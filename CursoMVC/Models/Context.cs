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
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        /*metodo responsavel por configurar o entityframework
          dentro dele vamos falar qual banco de dados vamos utilizar 
             */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SAMUEL-PC\SQLEXPRESS;Database=Cursomvc;Integrated Security=True");
        }

        /// <summary>
        /// Metodo recebe a entidade para modifica-la
        /// fiz isso para funcionar o teste unitário. Mock
        /// </summary>
        /// <param name="entity"></param>
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
