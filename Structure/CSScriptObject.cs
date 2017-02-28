using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace KSB_ScriptLib.Structure
{
    public class CSScriptObject : DynamicObject, IEnumerable
    {
        private readonly List<object> __list = new List<object>();
        private readonly ConcurrentDictionary<string, object> __collection = new ConcurrentDictionary<string, object>();

        public CSScriptObject()
        {

        }

        public CSScriptObject(Dictionary<string, object> collection)
        {
            foreach (var item in collection)
            {
                __list.Add(item.Value);
                __collection.TryAdd(item.Key, item.Value);
            }
        }

        public CSScriptObject(params object[] items)
        {
            if (items.Length%2 == 0)
            {
                for (int i = 0; i < items.Length; i += 2)
                {
                    __list.Add(items[i + 1]);
                    __collection.TryAdd(items[i].ToString(), items[i + 1]);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return __collection.GetEnumerator();
        }

        /// <summary>
        /// Return the upperbound from collection (0 index-based)
        /// </summary>
        public int Count => __list.Count;

        public object __get(string propertyName)
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
                result = null;
                return false;
            }
        }

        public void __set(string propertyName, object value)
        {
            if (value != null)
            {
                object get;

                if (__collection.TryGetValue(propertyName, out get))
                {
                    for (int i = 0; i < __list.Count; i++)
                    {
                        if (__list[i].Equals(get))
                        {
                            __list[i] = value;
                        }
                    }

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

        public object this[string propertyName]
        {
            get { return __get(propertyName); }
            set { __set(propertyName, value); }
        }

        public object this[int index]
        {
            get
            {
                if (index >= __list.Count)
                {
                    return null;
                }
                return __list[index];
            }
            set
            {
                if (index < __list.Count)
                {
                    __list[index] = value;
                }
            }
        }

        //public static bool operator ==(CSScriptObject obj1, object obj2)
        //{
        //    return obj1.__get()
        //}

        //public static bool operator !=(CSScriptObject obj1, object obj2)
        //{
        //    return true;
        //}
    }
}
