using Ecommerce_Backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Backend.Data.DBContext
{


    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
        {
        }


        public DbSet<UserModel>? Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\InstanceName;Initial Catalog = EcommerceDB ;Integrated Security=True;");
        }
    }

}

