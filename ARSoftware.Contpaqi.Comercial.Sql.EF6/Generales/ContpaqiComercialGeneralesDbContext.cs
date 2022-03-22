using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    public partial class ContpaqiComercialGeneralesDbContext : DbContext
    {
        public ContpaqiComercialGeneralesDbContext()
            : base("name=ContpaqiComercialGeneralesDbContext")
        {
        }

        protected ContpaqiComercialGeneralesDbContext(DbCompiledModel model) : base(model)
        {
        }

        public ContpaqiComercialGeneralesDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public ContpaqiComercialGeneralesDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public ContpaqiComercialGeneralesDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public ContpaqiComercialGeneralesDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public ContpaqiComercialGeneralesDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<admVistasCampos> admVistasCampos { get; set; }
        public virtual DbSet<admVistasConsultas> admVistasConsultas { get; set; }
        public virtual DbSet<admVistasPorModulo> admVistasPorModulo { get; set; }
        public virtual DbSet<admVistasRelaciones> admVistasRelaciones { get; set; }
        public virtual DbSet<admVistasTablas> admVistasTablas { get; set; }
        public virtual DbSet<Anexos20> Anexos20 { get; set; }
        public virtual DbSet<CAC00003> CAC00003 { get; set; }
        public virtual DbSet<CAC0000C> CAC0000C { get; set; }
        public virtual DbSet<CAC0000I> CAC0000I { get; set; }
        public virtual DbSet<CACIdiom> CACIdiom { get; set; }
        public virtual DbSet<ControlProcesos> ControlProcesos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<EmpresasModelo> EmpresasModelo { get; set; }
        public virtual DbSet<Etiquetas> Etiquetas { get; set; }
        public virtual DbSet<FormatosEtiquetas> FormatosEtiquetas { get; set; }
        public virtual DbSet<Formulas> Formulas { get; set; }
        public virtual DbSet<IdxAdminPAQ> IdxAdminPAQ { get; set; }
        public virtual DbSet<MantenimientoBDDErrores> MantenimientoBDDErrores { get; set; }
        public virtual DbSet<MantenimientoBDDProcesos> MantenimientoBDDProcesos { get; set; }
        public virtual DbSet<ModelosFinancieros> ModelosFinancieros { get; set; }
        public virtual DbSet<nubeEmpresas> nubeEmpresas { get; set; }
        public virtual DbSet<SATBancos> SATBancos { get; set; }
        public virtual DbSet<SATClaveProdServ> SATClaveProdServ { get; set; }
        public virtual DbSet<SATEstaciones> SATEstaciones { get; set; }
        public virtual DbSet<SATFracciones> SATFracciones { get; set; }
        public virtual DbSet<SATMonedas> SATMonedas { get; set; }
        public virtual DbSet<SATUnidades> SATUnidades { get; set; }
        public virtual DbSet<UsuariosActivos> UsuariosActivos { get; set; }
        public virtual DbSet<UsuariosActivosBloqueos> UsuariosActivosBloqueos { get; set; }
        public virtual DbSet<MantenimientoBDDIndexTmps> MantenimientoBDDIndexTmps { get; set; }
        public virtual DbSet<ParametrosInicialesMto> ParametrosInicialesMto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admVistasCampos>()
                .Property(e => e.CNOMBRENATIVOTABLA)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasCampos>()
                .Property(e => e.CNOMBRENATIVOCAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasCampos>()
                .Property(e => e.CNOMBREAMIGABLECAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasConsultas>()
                .Property(e => e.CNOMBRECONSULTA)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasConsultas>()
                .Property(e => e.CSENTENCIASQL)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasPorModulo>()
                .Property(e => e.CNOMBREMODULO)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CNOMBRENATIVOTABLA1)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CNOMBRENATIVOTABLA2)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CNOMBRERELACION)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CSENTENCIAENLACE)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasTablas>()
                .Property(e => e.CNOMBRENATIVOTABLA)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasTablas>()
                .Property(e => e.CNOMBREAMIGABLETABLA)
                .IsUnicode(false);

            modelBuilder.Entity<Anexos20>()
                .Property(e => e.CVERSION)
                .IsUnicode(false);

            modelBuilder.Entity<CAC00003>()
                .Property(e => e.CMENSAJE)
                .IsUnicode(false);

            modelBuilder.Entity<CAC0000C>()
                .Property(e => e.TABLA)
                .IsUnicode(false);

            modelBuilder.Entity<CAC0000C>()
                .Property(e => e.LARGO)
                .IsUnicode(false);

            modelBuilder.Entity<CAC0000C>()
                .Property(e => e.CORTO)
                .IsUnicode(false);

            modelBuilder.Entity<CAC0000I>()
                .Property(e => e.TABLA)
                .IsUnicode(false);

            modelBuilder.Entity<CAC0000I>()
                .Property(e => e.LARGO)
                .IsUnicode(false);

            modelBuilder.Entity<CAC0000I>()
                .Property(e => e.CORTO)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NOMBREIDIOMA)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NOMBREDLLAPP)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NOMBREDLLERR)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.ARCHBDD)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.ARCHAYUDA)
                .IsUnicode(false);

            modelBuilder.Entity<ControlProcesos>()
                .Property(e => e.cGuidControl)
                .IsUnicode(false);

            modelBuilder.Entity<ControlProcesos>()
                .Property(e => e.cProcesoDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ControlProcesos>()
                .Property(e => e.cNombreLog)
                .IsUnicode(false);

            modelBuilder.Entity<ControlProcesos>()
                .Property(e => e.cEstatusProceso)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.CNOMBREEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.CRUTADATOS)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.CRUTARESPALDOS)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasModelo>()
                .Property(e => e.CNOMBREEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasModelo>()
                .Property(e => e.CRUTAARCHIVOS)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CNOMBREETIQUETA)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CSUPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTENOMBREPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTONOMBREPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEPRECIOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOPRECIOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTECARACTERISTICA1)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOCARACTERISTICA1)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTECARACTERISTICA2)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOCARACTERISTICA2)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTECARACTERISTICA3)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOCARACTERISTICA3)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEIMPUESTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOIMPUESTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTENUMEROLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTONUMEROLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEFECHACADUCIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOFECHACADUCIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEFECHAFABRICACION)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOFECHAFABRICACION)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEADUANA)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOADUANA)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTEFECHAPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOFECHAPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTETIPOCAMBIO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOTIPOCAMBIO)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CFUENTESERIE)
                .IsUnicode(false);

            modelBuilder.Entity<Etiquetas>()
                .Property(e => e.CTEXTOSERIE)
                .IsUnicode(false);

            modelBuilder.Entity<FormatosEtiquetas>()
                .Property(e => e.CNOMBREHOJA)
                .IsUnicode(false);

            modelBuilder.Entity<Formulas>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<Formulas>()
                .Property(e => e.CNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<Formulas>()
                .Property(e => e.CDESCRIPCIONEJEMPLO)
                .IsUnicode(false);

            modelBuilder.Entity<IdxAdminPAQ>()
                .Property(e => e.TABLA)
                .IsUnicode(false);

            modelBuilder.Entity<IdxAdminPAQ>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<IdxAdminPAQ>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<IdxAdminPAQ>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<IdxAdminPAQ>()
                .Property(e => e.DESCRIPCIO)
                .IsUnicode(false);

            modelBuilder.Entity<MantenimientoBDDErrores>()
                .Property(e => e.cGuidProceso)
                .IsUnicode(false);

            modelBuilder.Entity<MantenimientoBDDErrores>()
                .Property(e => e.cAliasBDD)
                .IsUnicode(false);

            modelBuilder.Entity<MantenimientoBDDErrores>()
                .Property(e => e.cDescripcionError)
                .IsUnicode(false);

            modelBuilder.Entity<MantenimientoBDDProcesos>()
                .Property(e => e.cGuidProceso)
                .IsUnicode(false);

            modelBuilder.Entity<ModelosFinancieros>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ModelosFinancieros>()
                .Property(e => e.CRUTA)
                .IsUnicode(false);

            modelBuilder.Entity<nubeEmpresas>()
                .Property(e => e.CIDEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<nubeEmpresas>()
                .Property(e => e.CEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<nubeEmpresas>()
                .Property(e => e.CRFC)
                .IsUnicode(false);

            modelBuilder.Entity<nubeEmpresas>()
                .Property(e => e.CTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<nubeEmpresas>()
                .Property(e => e.CPROPIETARIO)
                .IsUnicode(false);

            modelBuilder.Entity<SATBancos>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SATBancos>()
                .Property(e => e.CNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SATBancos>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SATBancos>()
                .Property(e => e.CRFC)
                .IsUnicode(false);

            modelBuilder.Entity<SATBancos>()
                .Property(e => e.CPAGINAWEB)
                .IsUnicode(false);

            modelBuilder.Entity<SATClaveProdServ>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SATClaveProdServ>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SATEstaciones>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SATEstaciones>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SATEstaciones>()
                .Property(e => e.CTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<SATEstaciones>()
                .Property(e => e.CNACIONALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<SATEstaciones>()
                .Property(e => e.CEXTRA)
                .IsUnicode(false);

            modelBuilder.Entity<SATFracciones>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SATFracciones>()
                .Property(e => e.CUNIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<SATMonedas>()
                .Property(e => e.CCODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<SATMonedas>()
                .Property(e => e.CNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SATUnidades>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SATUnidades>()
                .Property(e => e.CNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SATUnidades>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosActivos>()
                .Property(e => e.CUSUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosActivos>()
                .Property(e => e.CEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosActivosBloqueos>()
                .Property(e => e.CUSUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosActivosBloqueos>()
                .Property(e => e.CEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<MantenimientoBDDIndexTmps>()
                .Property(e => e.cNombreTabla)
                .IsUnicode(false);

            modelBuilder.Entity<MantenimientoBDDIndexTmps>()
                .Property(e => e.cNombreIndex)
                .IsUnicode(false);

            modelBuilder.Entity<ParametrosInicialesMto>()
                .Property(e => e.cDBTemplate)
                .IsUnicode(false);
        }
    }
}
