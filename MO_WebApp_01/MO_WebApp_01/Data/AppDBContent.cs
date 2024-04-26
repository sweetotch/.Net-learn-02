using Microsoft.EntityFrameworkCore;
using MO_WebApp_01.Data.Models;

namespace MO_WebApp_01.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) 
        { 
        
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }


    }



}
