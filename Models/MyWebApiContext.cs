using Microsoft.EntityFrameworkCore;

namespace Ef6CoreForPosgreSQL.Models
{
    public class MyWebApiContext : DbContext 
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        // este ultimo é somente para fazer teste com o banco de dados. 
    }
}