using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OYASAR.Penguin.Core.Base
{
    public interface IBaseRepository
    {
        IQueryable<B> GetAll<D, B>(Expression<Func<D, bool>> expr) where D : class where B : class;

        void LazyLoad<T, K>(T entity, Expression<Func<T, ICollection<K>>> expr) where T : class where K : class;
        void LazyLoad<T, K>(T entity) where T : class where K : class;
    }
}
