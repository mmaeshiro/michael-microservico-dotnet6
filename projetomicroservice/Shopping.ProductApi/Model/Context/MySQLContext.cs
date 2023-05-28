using Microsoft.EntityFrameworkCore;

namespace Shopping.ProductApi.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}

        public MySQLContext(DbContextOptions<MySQLContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 2,
                        Name = "Name 2",
                        Price =  new decimal(79.9),
                        Description = "description 2",
                        ImageUrl = "https://img.freepik.com/vetores-gratis/laptop-com-icone-de-codigo-isometrico-de-programa-desenvolvimento-de-software-e-aplicacoes-de-programacao-neon-escuro_39422-971.jpg?w=900&t=st=1685310716~exp=1685311316~hmac=3cd629e566448fc8a3763222d3d91716ce22747d805a80c51c4c403bd1f1980e",
                        CategoryName= "Category 2"
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 3,
                        Name = "Name 3",
                        Price = new decimal(79.9),
                        Description = "description 3",
                        ImageUrl = "https://img.freepik.com/vetores-gratis/ilustracao-do-conceito-de-digitacao-de-codigo_114360-3581.jpg?w=740&t=st=1685310825~exp=1685311425~hmac=973fd53fa3054f2deee21284d6197659915e0cb63215cbf7125daa2689ee1ac7",
                        CategoryName = "Category 3"
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 4,
                        Name = "Name 4",
                        Price = new decimal(79.9),
                        Description = "description 4",
                        ImageUrl = "https://img.freepik.com/psd-premium/psd-de-maquete-de-sacola-de-compras-em-um-apartamento-moderno_53876-137778.jpg?w=996",
                        CategoryName = "Category 4"
                    }
                );
        }
    }
}
