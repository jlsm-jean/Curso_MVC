using Curso_MVC.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias {get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

    }
}
