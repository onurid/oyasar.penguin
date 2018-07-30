namespace OYASAR.Penguin.Core.Base
{
    public interface IBaseWritableRepository : IBaseRepository
    {
        void Add<K, I>(K k) where K : class;
        void Edit<K, I>(K k) where K : class;
        void Delete<K, I>(K k) where K : class;
        void RowDelete<K>(object key) where K : class;
        void Save();
    }
}
