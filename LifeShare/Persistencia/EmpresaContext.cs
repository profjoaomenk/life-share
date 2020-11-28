using LifeShare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeShare.Persistencia
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }

        public EmpresaContext(DbContextOptions options) : base(options)
        {

        }
    }
}
