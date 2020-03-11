using System.Collections.Generic;
using BlabberApp.Domain.Entities;

namespace BlabberApp.Domain.Interfaces {
    public interface IRepository<T> where T : BaseEntity 
    {
    //    T Add<T>(T item) where T : BaseDatum;
    //    void Remove<T>(T item) where T : BaseDatum;
    //    List<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseEntity;
    //    T GetById<T>(string sysId) where T : BaseEntity;
    //    void Update<T>(T item) where T : BaseEntity; 

        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        IEnumerable<T>GetAll();
        T GetBySysId(string sysId);
        //T GetByUserId(string userId);
    }
}