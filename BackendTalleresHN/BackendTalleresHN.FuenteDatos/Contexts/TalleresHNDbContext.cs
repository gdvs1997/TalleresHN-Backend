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
        public DbSet<Empresa> Empresa { get; set; }
        public TalleresHNDbContext(DbContextOptions<TalleresHNDbContext> options) : base(options)
        {

        }
    }
}
