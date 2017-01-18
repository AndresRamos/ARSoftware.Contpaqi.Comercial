using Contpaqi.SistemasContables.Sql.Generales.Modelo;
using System.Data.Entity;

namespace Contpaqi.SistemasContables.Sql.Generales.AccesoADatos
{
    public partial class ContabilidadGeneralesContext : DbContext
    {
        static ContabilidadGeneralesContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<ContabilidadGeneralesContext>());
        }

        public ContabilidadGeneralesContext()
            : base("name=ContabilidadGeneralesContext")
        {
        }

        public virtual DbSet<Counters> Counters { get; set; }
        public virtual DbSet<EmpresasUsuario> EmpresasUsuario { get; set; }
        public virtual DbSet<INPCs> INPCs { get; set; }
        public virtual DbSet<ListaEmpresas> ListaEmpresas { get; set; }
        public virtual DbSet<ModelosFinancieros> ModelosFinancieros { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<PermisosPerfil> PermisosPerfil { get; set; }
        public virtual DbSet<PermisosUsuario> PermisosUsuario { get; set; }
        public virtual DbSet<Procesos> Procesos { get; set; }
        public virtual DbSet<Temps> Temps { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
