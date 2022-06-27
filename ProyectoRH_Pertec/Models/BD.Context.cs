
namespace ProyectoRH_Pertec.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RHEntities : DbContext
    {
        public RHEntities()
            : base("name=RHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Templeado> Templeadoes { get; set; }
        public virtual DbSet<Tempresafecha> Tempresafechas { get; set; }
        public virtual DbSet<Tpuesto> Tpuestoes { get; set; }
        public virtual DbSet<Tpuestofecha> Tpuestofechas { get; set; }
    }
}
