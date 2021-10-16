using Microsoft.EntityFrameworkCore;

namespace DesafioKinvo.Models
{

    public class Contexto : DbContext
    {

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            //tambem funciona assim
            //DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer("Data Source=TONYPC\\SQLEXPRESS;Initial Catalog=Cursomvc;Integrated Security=true");
            optionsBuilder.UseSqlServer("Data Source=TONYPC\\SQLEXPRESS;Initial Catalog=Cursomvc;Integrated Security=true");
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

    }
}
