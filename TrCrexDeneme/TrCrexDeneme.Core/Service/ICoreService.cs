using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.Core.Service
{
   public interface ICoreService<T> where T:CoreEntity
    {
        void Add(T item);
        void Add(IEnumerable<T> item);
        void Update(T item);
        void Remove(T item); 
        void RemoveAll(Expression<Func<T, bool>> expression); 
        T GetById(int id);
        T GetByDefault(Expression<Func<T, bool>> expression); 
        List<T> GetAll();
        List<T> GetDefault(Expression<Func<T, bool>> expression);
        List<T> GetActive();
        int Save();
        bool Any(Expression<Func<T, bool>> expression);
    }
}
