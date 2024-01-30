using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public string ConnectionString { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        
    }
}