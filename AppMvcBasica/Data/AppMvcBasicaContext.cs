#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMvcBasica.Models;

namespace AppMvcBasica.Data
{
    public class AppMvcBasicaContext : DbContext
    {
        public AppMvcBasicaContext (DbContextOptions<AppMvcBasicaContext> options)
            : base(options)
        {
        }

        public DbSet<AppMvcBasica.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<AppMvcBasica.Models.Endereco> Endereco { get; set; }
    }
}
