using OOP_lab1.Shapes;
using System.Collections;
using System.Collections.Generic;

namespace OOP_lab1.Collections
{
    public class ShapesList : IList<BaseShape>
    {
        private readonly List<BaseShape> _collection;

        public ShapesList(params BaseShape[] shapes)
        {
            _collection = new(shapes);
        }

        public ShapesList() { _collection = new(); }

        public BaseShape this[int index] { get => _collection[index]; set => _collection[index] = value; }

        public int Count => _collection.Count;

        public bool IsReadOnly => false;

        public void Add(BaseShape item)
        {
            _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(BaseShape item)
        {
            return _collection.Contains(item);
        }

        public void CopyTo(BaseShape[] array, int arrayIndex)
        {
            _collection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<BaseShape> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        public int IndexOf(BaseShape item)
        {
            return _collection.IndexOf(item);
        }

        public void Insert(int index, BaseShape item)
        {
            _collection.Insert(index, item);
        }

        public bool Remove(BaseShape item)
        {
            return _collection.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _collection.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
