using Contpaqi.SistemasComerciales.Sql.Generales.Modelo;

namespace Contpaqi.SistemasComerciales.Sql.Generales.AccesoADatos
{
    using System.Data.Entity;

    public partial class ComercialGeneralesContext : DbContext
    {
        static ComercialGeneralesContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<ComercialGeneralesContext>());
        }

        public ComercialGeneralesContext()
            : base("name=ComercialGeneralesContext")
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

        public virtual DbSet<Modelo.Empresas> Empresas { get; set; }

        public virtual DbSet<EmpresasModelo> EmpresasModelo { get; set; }

        public virtual DbSet<EstructuraAddendas> EstructuraAddendas { get; set; }

        public virtual DbSet<Etiquetas> Etiquetas { get; set; }

        public virtual DbSet<FormatosEtiquetas> FormatosEtiquetas { get; set; }

        public virtual DbSet<Formulas> Formulas { get; set; }

        public virtual DbSet<IdxAdminPAQ> IdxAdminPAQ { get; set; }

        public virtual DbSet<ModelosFinancieros> ModelosFinancieros { get; set; }

        public virtual DbSet<SATBancos> SATBancos { get; set; }

        public virtual DbSet<SATMonedas> SATMonedas { get; set; }

        public virtual DbSet<UsuariosActivos> UsuariosActivos { get; set; }

        public virtual DbSet<UsuariosActivosBloqueos> UsuariosActivosBloqueos { get; set; }

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

            modelBuilder.Entity<Modelo.Empresas>()
                .Property(e => e.CNOMBREEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo.Empresas>()
                .Property(e => e.CRUTADATOS)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo.Empresas>()
                .Property(e => e.CRUTARESPALDOS)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasModelo>()
                .Property(e => e.CNOMBREEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasModelo>()
                .Property(e => e.CRUTAARCHIVOS)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.STRINICIO)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.STRFIN)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.ORIGENDATO)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.FORMATO)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.DATO)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.MAPVALUES)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.DESCRIPCIO)
                .IsUnicode(false);

            modelBuilder.Entity<EstructuraAddendas>()
                .Property(e => e.DEPFUNC)
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

            modelBuilder.Entity<ModelosFinancieros>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ModelosFinancieros>()
                .Property(e => e.CRUTA)
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

            modelBuilder.Entity<SATMonedas>()
                .Property(e => e.CCODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<SATMonedas>()
                .Property(e => e.CNOMBRE)
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
        }
    }
}