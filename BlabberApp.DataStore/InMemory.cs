using System;
using System.Collections;
using BlabberApp.Domain.Entities;
using BlabberApp.Domain.Interfaces;

namespace BlabberApp.DataStore
{
    public class InMemory : IDataStore
    {
        private ArrayList _items = new ArrayList();

        public InMemory()
        {
        }
        
        public bool Create(IDatum datum)
        {
            int idx = this._items.Add(datum);
            if (idx < 0)
            {
                throw new ArgumentOutOfRangeException("OH No!");
            }
            return true;
        }
        public IDatum Read(int idx)
        {
            return (IDatum)this._items[idx];
        }
        public bool Update(IDatum datum)
        {
            return true;
        }
        public bool Delete(int idx)
        {
            try
            {
                this._items.RemoveAt(idx);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw e;
            }
            return true;
        }
        

        // T Add<T>(T item) where T : BaseDatum
        // {
        //     return item;
        // }
        // void Delete<T>(T item) where T : BaseDatum
        // {

        // }
        // List<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseDatum
        // {
        //     return;
        // }
        // T GetById<T>(string sysId) where T : BaseDatum
        // {
        //     return BaseDatum;
        //     void Update<T>(T item) where T : BaseDatum { }
        // }
    }
}
