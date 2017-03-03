using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSB_ScriptLib.Structure
{
    /// <summary>
    /// Custom list to achieve desired functionality and improve performance (or at least be able to control performance).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CSScriptList<T> : List<T>
    {
        private Random _random = new Random(DateTime.UtcNow.Millisecond);
        private int _count;
        private bool _luanumbers;

        public CSScriptList(IList<T> collection, bool luanumbers = true)
            : base(collection)
        {
            _luanumbers = luanumbers;
            Count = base.Count;
        }

        public CSScriptList(ICollection<T> collection, bool luanumbers = true)
            : base(collection)
        {
            _luanumbers = luanumbers;
            Count = base.Count;
        }

        public CSScriptList(IOrderedEnumerable<T> collection, bool luanumbers = true)
            : base(collection)
        {
            _luanumbers = luanumbers;
            Count = base.Count;
        }

        public CSScriptList(IEnumerable<T> collection, bool luanumbers = true)
            : base(collection)
        {
            _luanumbers = luanumbers;
            Count = base.Count;
        }

        public CSScriptList(List<T> collection, bool luanumbers = true)
            : base(collection)
        {
            _luanumbers = luanumbers;
            Count = base.Count;
        }

        public CSScriptList(bool luanumbers = true)
            : base()
        {
            _luanumbers = luanumbers;
            Count = 0;
        }

        public new IOrderedEnumerable<T> Sort()
        {
            return this.OrderBy(x => x);
        }

        public IOrderedEnumerable<T> Shuffle()
        {
            return this.OrderBy(x => _random.Next());
        }

        public new int Count
        {
            get
            {
                return _count;
            }
            private set
            {
                _count = value;
            }
        }

        public new void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public new void Add(T item)
        {
            base.Add(item);
            Count++;
        }

        public new void CopyTo(T[] array, int index)
        {
            CopyTo(array, index, _count);
        }

        public void CopyTo(T[] array, int index, int count)
        {
            if (count > _count) count = _count;
            Array.Resize(ref array, array.Length + count);
            for (int i = 0; i < count; i++)
            {
                array[index + count] = base[index + count];
            }
        }

        public new CSScriptList<T> GetRange(int index, int count)
        {
            if (index >= _count) return new CSScriptList<T>();
            CSScriptList<T> list = new CSScriptList<T>();
            for (int i = index; i < count; i++)
            {
                if (i >= _count)
                {
                    return list;
                }
                list.Add(this[i]);
            }
            return list;
        }

        public new void Insert(int index, T item)
        {
            base.Insert(index, item);
            Count++;
        }

        public new bool Remove(T item)
        {
            if (base.Remove(item))
            {
                Count--;
                return true;
            }

            return false;
        }

        public new void RemoveAt(int index)
        {
            Count--;
            base.RemoveAt(index);
        }

        public T this[string index]
        {
            get
            {
                return this.FirstOrDefault(x => x.GetType().GetProperty(index) != null);
            }
            set
            {
                for (int i = 0; i < _count; i++)
                {
                    if (this[i]?.GetType().GetProperty(index) != null)
                    {
                        this[i] = value;
                    }
                }
            }
        }

        public new T this[int index]
        {
            get
            {
                //if (_luanumbers)
                //{
                //    --index;
                //}
                if (index >= _count)
                {
                    return default(T);
                }
                return base[index];
            }
            set
            {
                //if (_luanumbers)
                //{
                //    --index;
                //}
                if (index < _count)
                {
                    base[index] = value;
                }
            }
        }

        public static bool operator <(CSScriptList<T> obj1, int value)
        {
            return (obj1.Count < value);
        }

        public static bool operator >(CSScriptList<T> obj1, int value)
        {
            return (obj1.Count > value);
        }

        public string Dump(string joinWith = "")
        {
            if (joinWith == null)
                throw new ArgumentNullException("joinWith");

            var stringBuilder = new StringBuilder();
            var enumerator = GetEnumerator();

            if (!enumerator.MoveNext())
                return string.Empty;

            while (true)
            {
                stringBuilder.Append(enumerator.Current);
                if (!enumerator.MoveNext())
                    break;

                stringBuilder.Append(joinWith);
            }

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return Dump();
        }
    }
}
