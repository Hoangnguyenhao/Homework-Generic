using System;
using System.Linq;
using System.Collections.Generic;

namespace Managers
{
    public class GenericManager<T> where T : class
    {
        protected List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }
    }
}
