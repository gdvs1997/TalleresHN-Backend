using BackendTalleresHN.Dominio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendTalleresHN.FuenteDatos.Contexts
{
    public class TalleresHNDbContext: IdentityDbContext<ApplicationUser>
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Taller> Taller { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<TallerRelacionTipoTaller> TallerRelacionTipoTaller { get; set; }
        public DbSet<TipoTaller> TipoTaller { get; set; }
        public TalleresHNDbContext(DbContextOptions<TalleresHNDbContext> options) : base(options)
        {

        }
    }
}
