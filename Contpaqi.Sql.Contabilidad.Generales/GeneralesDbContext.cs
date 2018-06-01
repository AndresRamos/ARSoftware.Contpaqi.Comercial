using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.Contabilidad.Generales
{
    public class GeneralesDbContext : DbContext
    {
        static GeneralesDbContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<GeneralesDbContext>());
        }

        public GeneralesDbContext()
            : base("name=GeneralesDbContext")
        {
        }

        public GeneralesDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public GeneralesDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public GeneralesDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public GeneralesDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public GeneralesDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected GeneralesDbContext(DbCompiledModel model) : base(model)
        {
        }

        public virtual DbSet<Counters> Counters { get; set; }

        public virtual DbSet<EmpresasUsuario> EmpresasUsuario { get; set; }

        public virtual DbSet<Estados> Estados { get; set; }

        public virtual DbSet<INPCs> INPCs { get; set; }

        public virtual DbSet<ListaEmpresas> ListaEmpresas { get; set; }

        public virtual DbSet<ModelosFinancieros> ModelosFinancieros { get; set; }

        public virtual DbSet<Municipios> Municipios { get; set; }

        public virtual DbSet<Notificaciones> Notificaciones { get; set; }

        public virtual DbSet<Paises> Paises { get; set; }

        public virtual DbSet<Perfiles> Perfiles { get; set; }

        public virtual DbSet<PeriodosSAT> PeriodosSAT { get; set; }

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