
namespace Sales_Local.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales_Local.Common.Models.Product> Products { get; set; }
    }
}