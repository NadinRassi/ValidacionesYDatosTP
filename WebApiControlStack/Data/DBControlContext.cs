using Microsoft.EntityFrameworkCore;
using WebApiControlStack.Models;

namespace WebApiControlStack.Data
{
    public class DBControlContext: DbContext
    {
        public DBControlContext(DbContextOptions<DBControlContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }
    }
}
