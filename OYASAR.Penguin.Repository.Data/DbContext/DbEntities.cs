using Microsoft.EntityFrameworkCore;
using OYASAR.Penguin.Repository.Core.DbContext;

namespace OYASAR.Penguin.Repository.Data
{
    public class DbEntities : AbstractDbEntities<DbEntities>, IDbEntities
    {
        public DbEntities(DbContextOptions<DbEntities> options)
            : base(options)
        {
        }
    }
}
