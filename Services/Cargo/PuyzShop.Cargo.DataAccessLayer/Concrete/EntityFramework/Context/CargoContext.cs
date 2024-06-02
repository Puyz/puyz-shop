using Microsoft.EntityFrameworkCore;
using PuyzShop.Cargo.EntityLayer.Concrete;

namespace PuyzShop.Cargo.DataAccessLayer.Concrete.EntityFramework.Context
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1435;initial Catalog=PuyzShopCargoDb;User=sa;Password=123123123Aa.");
        }

        public DbSet<CargoCompany> CargoCompanies { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoCustomer> CargoCustomers { get; set; }
        public DbSet<CargoOperation> CargoOperations { get; set; }
    }
}
