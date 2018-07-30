using Microsoft.EntityFrameworkCore;
using OYASAR.Penguin.Repository.Core.DbContext;

namespace OYASAR.Penguin.Repository.Data.DbContext
{
    public class DbEntitiesWrite : AbstractDbEntities<DbEntitiesWrite>, IDbEntitiesWritable
    {
        public DbEntitiesWrite(DbContextOptions<DbEntitiesWrite> options)
            : base(options)
        {
        }
    }
}
