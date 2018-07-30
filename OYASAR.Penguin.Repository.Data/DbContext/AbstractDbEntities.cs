using Microsoft.EntityFrameworkCore;

namespace OYASAR.Penguin.Repository.Data
{
    public class AbstractDbEntities<T> : Microsoft.EntityFrameworkCore.DbContext where T : Microsoft.EntityFrameworkCore.DbContext
    {
        public AbstractDbEntities(DbContextOptions<T> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AccountNumberConf());
            //modelBuilder.ApplyConfiguration(new CompanyConf());
            //modelBuilder.ApplyConfiguration(new CompanyCurrencyConf());
            //modelBuilder.ApplyConfiguration(new CompanyVoucherTypeConf());
            //modelBuilder.ApplyConfiguration(new DocumentSettingConf());
            //modelBuilder.ApplyConfiguration(new EventConf());
            //modelBuilder.ApplyConfiguration(new EventOverrideConf());
            //modelBuilder.ApplyConfiguration(new GiftCardConf());
            //modelBuilder.ApplyConfiguration(new GuestConf());
            //modelBuilder.ApplyConfiguration(new GuestDiscountConf());
            //modelBuilder.ApplyConfiguration(new GuestDiscountLineConf());
            //modelBuilder.ApplyConfiguration(new HotelConf());
            //modelBuilder.ApplyConfiguration(new HouseKeepingMaintenanceConf());
            //modelBuilder.ApplyConfiguration(new OrderConf());
            //modelBuilder.ApplyConfiguration(new ProductTabItemConf());
            //modelBuilder.ApplyConfiguration(new CashStatementConf());
            //modelBuilder.ApplyConfiguration(new CashStatementExpenseConf());
            //modelBuilder.ApplyConfiguration(new ProductConf());
            //modelBuilder.ApplyConfiguration(new ProductGroupConf());
            //modelBuilder.ApplyConfiguration(new ProductResourceConf());
            ////modelBuilder.ApplyConfiguration(new ProductTabConf());            
            ////modelBuilder.ApplyConfiguration(new ProductTabItemConf());            
            //modelBuilder.ApplyConfiguration(new RegisterConf());
            ////modelBuilder.ApplyConfiguration(new RegisterLayoutConf());
            //modelBuilder.ApplyConfiguration(new ReservationConf());
            //modelBuilder.ApplyConfiguration(new RestaurantConf());
            //modelBuilder.ApplyConfiguration(new RoomConf());
            //modelBuilder.ApplyConfiguration(new RoomGroupConf());
            //modelBuilder.ApplyConfiguration(new RoomGroupRatePlanCalendarConf());
            //modelBuilder.ApplyConfiguration(new RoomGroupSubTypeConf());
            //modelBuilder.ApplyConfiguration(new RoomGroupTypeConf());
            //modelBuilder.ApplyConfiguration(new RoomPackageConf());
            //modelBuilder.ApplyConfiguration(new TableGroupConf());
            //modelBuilder.ApplyConfiguration(new TableGroupSetupConf());
            //modelBuilder.ApplyConfiguration(new TableReservationConf());
            //modelBuilder.ApplyConfiguration(new OfferConf());
            //modelBuilder.ApplyConfiguration(new OfferLocationConf());
            //modelBuilder.ApplyConfiguration(new OfferLocationEquipmentConf());
            //modelBuilder.ApplyConfiguration(new OfferLocationLinkedLocationConf());
            //modelBuilder.ApplyConfiguration(new OfferLocationProductConf());
            //modelBuilder.ApplyConfiguration(new OfferTemplateConf());
            //modelBuilder.ApplyConfiguration(new PackageConf());
            ////modelBuilder.ApplyConfiguration(new PackageEquipmentConf());
            ////modelBuilder.ApplyConfiguration(new PackageProductConf());
            ////modelBuilder.ApplyConfiguration(new PackageRoomConf());
            //// modelBuilder.ApplyConfiguration(new OfferRoomGroupConf());
            //modelBuilder.ApplyConfiguration(new OfferRoomConf());
            //modelBuilder.ApplyConfiguration(new TodoListViewConf());
            //modelBuilder.ApplyConfiguration(new OrderLineViewConf());

            //modelBuilder.ApplyConfiguration(new AllotmentConf());
            //modelBuilder.ApplyConfiguration(new AllotmentRoomGroupConf());
            //modelBuilder.ApplyConfiguration(new AllotmentRoomGroupDetailConf());

            //modelBuilder.ApplyConfiguration(new ModifierGroupConf());
            //modelBuilder.ApplyConfiguration(new ModifierGroupTypeConf());
            //modelBuilder.ApplyConfiguration(new ModifierGroupTypeItemConf());
            //modelBuilder.ApplyConfiguration(new OfferLocationProductModifierConf());


            base.OnModelCreating(modelBuilder);
        }
    }
}
