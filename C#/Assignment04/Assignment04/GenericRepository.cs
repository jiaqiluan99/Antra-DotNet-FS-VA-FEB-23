using System;

namespace Assignment04
{
	public class GenericRepository<T> : IRepository<T>
        where T : class
	{
        private Dictionary<int, T> savedValues;
        private Dictionary<int, T> values;
        private int nextID;

        public GenericRepository()
		{
            savedValues = new Dictionary<int, T>();
            values = new Dictionary<int, T>();
            nextID = 1;
		}

        public void Add(T item)
        {
            values[nextID] = item;
            nextID++;
        }

        public IEnumerable<T> GetAll()
        {
            return values.Values.ToList();
        }

        public T GetById(int id)
        {
            return values[id];
        }

        public void Remove(T item)
        {
            for (int i = 1; i < nextID; i++) {
                if (values[i] == item) {
                    values.Remove(i);
                }
            }
        }

        public void Save()
        {
            savedValues = values;
        }
    }
}

