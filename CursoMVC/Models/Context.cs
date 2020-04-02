using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        //estamos dizendo que temos uma tabela categoria
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        /*metodo responsavel por configurar o entityframework
          dentro dele vamos falar qual banco de dados vamos utilizar 
             */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SAMUEL-PC\SQLEXPRESS;Database=Cursomvc;Integrated Security=True");
        }
    }
}
