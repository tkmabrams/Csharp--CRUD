using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
        public DbSet<Dish> Dishes {  get; set; }
    }
}