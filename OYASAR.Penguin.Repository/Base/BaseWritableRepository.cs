using OYASAR.Penguin.Core.Base;

namespace OYASAR.Penguin.Repository.Base
{
    public abstract class BaseWritableRepository<T> : BaseRepository<T>, IBaseWritableRepository
    {
        public void Add<K, I>(K k) where K : class
        {
            new BaseAuditHelper<K, I>(k, BaseAuditHelper<K, I>.BaseAuditType.Create, true);

            repository.Add(k);
        }

        public void Edit<K, I>(K k) where K : class
        {
            new BaseAuditHelper<K, I>(k, BaseAuditHelper<K, I>.BaseAuditType.Modify);

            repository.Edit(k);
        }

        public void Delete<K, I>(K k) where K : class
        {
            new BaseAuditHelper<K, I>(k, BaseAuditHelper<K, I>.BaseAuditType.Delete);

            repository.Edit(k);
        }

        public void RowDelete<K>(object key) where K : class
        {
            repository.DeleteByKey<K>(key);
        }

        public void Save()
        {
            repository.Save();
        }
    }
}
