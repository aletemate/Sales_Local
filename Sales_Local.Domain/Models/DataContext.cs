
namespace Sales_Local.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Sales_Local.Common.Models.Product> Products { get; set; }
    }
}
