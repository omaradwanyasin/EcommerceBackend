using Ecommerce_Backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Backend.Data.DBContext
{


    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
           : base(options)
        {
        }

        public DbSet<UserModel>? Users { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\InstanceName;Initial Catalog = EcommerceDB ;Integrated Security=True;");
        //}
    }

}

