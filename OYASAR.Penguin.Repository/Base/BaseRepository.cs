using OYASAR.Framework.Core.Extension;
using OYASAR.Framework.Core.Interface;
using OYASAR.Framework.Core.Utils;
using OYASAR.Penguin.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OYASAR.Penguin.Repository.Base
{
    public abstract class BaseRepository<T> : IBaseRepository
    {
        protected readonly IRepository<T> repository;

        protected BaseRepository()
        {
            this.repository = Invoke<IRepository<T>>.Call();
        }

        public IQueryable<B> GetAll<D, B>(Expression<Func<D, bool>> expr) where D : class where B : class
        {
            var data = repository.GetAll<D>(expr);

            var result = (IQueryable<B>)data.MapTo<B>();

            return result;
        }

        public IQueryable<B> GetAll<D, B>() where D : class where B : class
        {
            var data = repository.GetAll<D>();

            var result = (IQueryable<B>)data.MapTo<B>();

            return result;
        }

        public void LazyLoad<T1, K>(T1 entity, Expression<Func<T1, ICollection<K>>> expr) where T1 : class where K : class
        {
            repository.LazyLoad(entity, expr);
        }

        public void LazyLoad<T1, K>(T1 entity)
            where T1 : class
            where K : class
        {
            repository.LazyLoad<T1, K>(entity);
        }
    }
}
