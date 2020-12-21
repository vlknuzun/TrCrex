using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using TrCrexDeneme.Core.Entity;
using TrCrexDeneme.Core.Service;
using TrCrexDeneme.Model.Context;
using TrCrexDeneme.Service.Tools;

namespace TrCrexDeneme.Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        protected ProjectContext _projectContext;
        public BaseService()
        {
            //_projectContext = projectContext;
            IServiceCollection services = new ServiceCollection();
            services.AddDbContextService();
            ServiceProvider provider = services.BuildServiceProvider();
            _projectContext = provider.GetService<ProjectContext>();
        }

        public void Add(T item)
        {
            _projectContext.Set<T>().Add(item);
            Save();
        }

        public void Add(IEnumerable<T> item)
        {
            _projectContext.Set<T>().AddRange(item);
            Save();
        }
        //Sor***********************
        public bool Any(Expression<Func<T, bool>> expression) => _projectContext.Set<T>().Any(expression);


        public List<T> GetActive()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _projectContext.Set<T>().ToList();
        }

        public T GetByDefault(Expression<Func<T, bool>> expression)
        {
            return _projectContext.Set<T>().Where(expression).FirstOrDefault();
        }

        public T GetById(int id)
        {
            return _projectContext.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return _projectContext.Set<T>().Where(expression).ToList();
        }

        public void Remove(T item)
        {
            _projectContext.Set<T>().Remove(item);
            Save();
        }

        public void RemoveAll(Expression<Func<T, bool>> expression)
        {
            foreach (var item in GetDefault(expression))
            {
                _projectContext.Set<T>().Remove(item);
                Save();
            }
        }

        public int Save()
        {
            return _projectContext.SaveChanges();
        }

        public void Update(T item)
        {
            //T updated = GetById(item.Id);
            //DbEntityEntry entry = _projectContext.Entry(updated);
            //entry.CurrentValues.SetValues(item);
            //Save();
           

            //T updated = GetById(item.Id);
            //var tumPropertyler = typeof(T).GetProperties();
            //foreach (var property in tumPropertyler)
            //    if (property.Name != "Id")
            //        property.SetValue(updated, property.GetValue(item));
            //Save();
        }
    }
}
