using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSB_ScriptLib.Structure
{
    public class CSScriptCollection<T> : ConcurrentDictionary<string, T>
    {
        private Random _random = new Random(DateTime.UtcNow.Millisecond);
        private List<T> _list = new List<T>();
        private int _count;

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

        public CSScriptCollection()
            : base()
        {
            Count = 0;
        }

        public IOrderedEnumerable<T> Sort()
        {
            return this.Values.OrderBy(x => x);
        }

        public IOrderedEnumerable<T> Shuffle()
        {
            return this.Values.OrderBy(x => _random.Next());
        }

        public void Add(T item)
        {
            _list.Add(item);
            Count++;
        }

        public new bool TryAdd(string key, T value)
        {
            bool add = base.TryAdd(key, value);
            if (add)
            {
                _list.Add(value);
                Count++;
            }
            return add;
        }

        public new bool TryGetValue(string key, out T value)
        {
            return base.TryGetValue(key, out value);
        }

        public bool Remove(T item)
        {
            bool remove = _list.Remove(item);
            if (remove)
            {
                Count--;
            }
            return remove;
        }

        public new bool TryRemove(string key, out T value)
        {
            bool remove = false;

            if (base.TryRemove(key, out value))
            {
                remove = Remove(value);
            }

            return remove;
        }

        public new T this[string index]
        {
            get
            {
                T value;
                TryGetValue(index, out value);
                return value;
            }
            set
            {
                if (!TryAdd(index, value))
                {
                    base[index] = value;
                    for (int i = 0; i < _count; i++)
                    {
                        if (_list[i].Equals(value))
                        {
                            _list[i] = value;
                        }
                    }
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= _count)
                {
                    return default(T);
                }
                return _list[index];
            }
            set
            {
                if (index < _count)
                {
                    T old = _list[index];
                    _list[index] = value;
                    foreach (KeyValuePair<string, T> item in this)
                    {
                        base.AddOrUpdate(item.Key, value, (key, update) => update.Equals(old) ? value : old);
                    }
                }
            }
        }

        public string Dump(string joinWith = "")
        {
            if (joinWith == null)
                throw new ArgumentNullException("joinWith");

            var stringBuilder = new StringBuilder();
            var enumerator = this.GetEnumerator();

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
