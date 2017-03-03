using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace KSB_ScriptLib.Structure
{
    /// <summary>
    /// Dynamic object that will act as the base for each script; supports storage of instance fields onto self.
    /// Supports traditional syntax (this.MyVariable = 5;), random access via integer (var item = this[0];) and look-up access via string (var item = this["MyVariable"];).
    /// Note: To best check whether a variable has been declared, use look-up (if (this["MyVariable"] != null)).
    /// Todo: Consider a type-based implementation for performance gains (eg: CSScriptObject<T>) where objects are expected to be a single type.
    /// </summary>
    public class CSScriptObject : DynamicObject, IEnumerable
    {
        // todo: change to a custom implementation of array in order to control memory-mapping and improve performance
        private readonly List<object> __list = new List<object>();
        private readonly ConcurrentDictionary<string, object> __collection = new ConcurrentDictionary<string, object>();

        public CSScriptObject()
        {

        }

        /// <summary>
        /// Create a new instance using key/values from a dictionary.
        /// </summary>
        /// <param name="collection"></param>
        public CSScriptObject(Dictionary<string, object> collection)
        {
            foreach (var item in collection)
            {
                __list.Add(item.Value);
                __collection.TryAdd(item.Key, item.Value);
            }
        }

        /// <summary>
        /// Create a new instance using various items.
        /// Note: There must be an even number of objects (key and value pairs).
        /// </summary>
        /// <param name="items"></param>
        public CSScriptObject(params object[] items)
        {
            if (items.Length%2 != 0) return;
            for (var i = 0; i < items.Length; i += 2)
            {
                __list.Add(items[i + 1]);
                __collection.TryAdd(items[i].ToString(), items[i + 1]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return __collection.GetEnumerator();
        }

        /// <summary>
        /// The number of variables/fields this object currently holds.
        /// </summary>
        public int Count => __list.Count;

        private object __get(string propertyName)
        {
            object value;
            __collection.TryGetValue(propertyName, out value);
            return value;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            try
            {
                return (result = this.__get(binder.Name)) != null || base.TryGetMember(binder, out result);
            }
            catch (Exception)
            {
                // for now, lets just catch and return null
                // todo: add some logging for improved bug-hunting
                result = null;
                return false;
            }
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            try
            {
                return base.TryInvokeMember(binder, args, out result);
            }
            catch (Exception)
            {
                // for now, lets just catch and return null
                // todo: add some logging for improved bug-hunting
                result = null;
                return false;
            }
        }

        private void __set(string propertyName, object value)
        {
            if (value != null)
            {
                object get;

                // attempt to get an existing object
                if (__collection.TryGetValue(propertyName, out get))
                {
                    // we seek the same object in the list
                    // and update reference to the new object
                    for (var i = 0; i < __list.Count; i++)
                    {
                        if (__list[i].Equals(get))
                        {
                            __list[i] = value;
                        }
                    }

                    // we let the garbage collector determine
                    // whether the older object is to be disposed

                    __collection[propertyName] = value;
                }
                else
                {
                    if (__collection.TryAdd(propertyName, value))
                    {
                        __list.Add(value);
                    }
                }
            }
            else
            {
                // if we're replacing with a null-object
                // lets simply clear this object
                if (__collection.TryRemove(propertyName, out value))
                {
                    __list.Remove(value);
                }
            }
        }

        public override bool TryDeleteMember(DeleteMemberBinder binder)
        {
            __set(binder.Name, null);
            return base.TryDeleteMember(binder);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            this.__set(binder.Name, value);
            return true;
        }

        /// <summary>
        /// Access the element with a given variable name.
        /// </summary>
        /// <param name="propertyName">Name of the variable/property/field etc.</param>
        /// <returns></returns>
        public virtual object this[string propertyName]
        {
            get { return __get(propertyName); }
            set { __set(propertyName, value); }
        }

        /// <summary>
        /// Access the element with a given index.
        /// Note: The element MUST exist prior to any set operation (eg: this[0] = 5;).
        /// </summary>
        /// <param name="index">Index of the variable/property/field etc.</param>
        /// <returns></returns>
        public virtual object this[int index]
        {
            get
            {
                return index >= __list.Count ? null : __list[index];
            }
            set
            {
                if (index < __list.Count)
                {
                    __list[index] = value;
                }
            }
        }
    }
}
