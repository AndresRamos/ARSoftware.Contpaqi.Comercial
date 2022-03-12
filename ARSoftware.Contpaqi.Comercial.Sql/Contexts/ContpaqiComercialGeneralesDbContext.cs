using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Contpaqi.Comercial.Sql.Models.Generales
{
    public partial class ContpaqiComercialGeneralesDbContext : DbContext
    {
        public ContpaqiComercialGeneralesDbContext()
        {
        }

        public ContpaqiComercialGeneralesDbContext(DbContextOptions<ContpaqiComercialGeneralesDbContext> options)
            : base(options)
        {
        }

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
        public virtual DbSet<MantenimientoBDDIndexTmps> MantenimientoBDDIndexTmps { get; set; }
        public virtual DbSet<MantenimientoBDDProcesos> MantenimientoBDDProcesos { get; set; }
        public virtual DbSet<ModelosFinancieros> ModelosFinancieros { get; set; }
        public virtual DbSet<ParametrosInicialesMto> ParametrosInicialesMto { get; set; }
        public virtual DbSet<SATBancos> SATBancos { get; set; }
        public virtual DbSet<SATClaveProdServ> SATClaveProdServ { get; set; }
        public virtual DbSet<SATEstaciones> SATEstaciones { get; set; }
        public virtual DbSet<SATFracciones> SATFracciones { get; set; }
        public virtual DbSet<SATMonedas> SATMonedas { get; set; }
        public virtual DbSet<SATUnidades> SATUnidades { get; set; }
        public virtual DbSet<UsuariosActivos> UsuariosActivos { get; set; }
        public virtual DbSet<UsuariosActivosBloqueos> UsuariosActivosBloqueos { get; set; }
        public virtual DbSet<admVistasCampos> admVistasCampos { get; set; }
        public virtual DbSet<admVistasConsultas> admVistasConsultas { get; set; }
        public virtual DbSet<admVistasPorModulo> admVistasPorModulo { get; set; }
        public virtual DbSet<admVistasRelaciones> admVistasRelaciones { get; set; }
        public virtual DbSet<admVistasTablas> admVistasTablas { get; set; }
        public virtual DbSet<nubeEmpresas> nubeEmpresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Anexos20>(entity =>
            {
                entity.HasKey(e => e.CIDESQUEMA);

                entity.HasIndex(e => new { e.CTIPODOCTO, e.CIDESQUEMA }, "ITIPODOCTO");

                entity.HasIndex(e => new { e.CTIPODOCTO, e.CVERSION, e.CIDESQUEMA }, "ITIPOVER");

                entity.Property(e => e.CIDESQUEMA).ValueGeneratedNever();

                entity.Property(e => e.CFECHAFIN)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('18991230')");

                entity.Property(e => e.CVERSION)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CAC00003>(entity =>
            {
                entity.HasKey(e => e.CIDBITACORA);

                entity.Property(e => e.CIDBITACORA).ValueGeneratedNever();

                entity.Property(e => e.CMENSAJE).HasColumnType("text");
            });

            modelBuilder.Entity<CAC0000C>(entity =>
            {
                entity.HasKey(e => new { e.TABLA, e.CORTO });

                entity.HasIndex(e => new { e.TABLA, e.LARGO }, "ICAMPOL");

                entity.Property(e => e.TABLA)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CORTO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.LARGO)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CAC0000I>(entity =>
            {
                entity.HasKey(e => new { e.TABLA, e.CORTO });

                entity.HasIndex(e => new { e.TABLA, e.LARGO }, "IINDICEL");

                entity.Property(e => e.TABLA)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CORTO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.LARGO)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CACIdiom>(entity =>
            {
                entity.HasKey(e => new { e.NUMEROSISTEMA, e.NUMEROIDIOMA });

                entity.Property(e => e.ARCHAYUDA)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ARCHBDD)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.NOMBREDLLAPP)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NOMBREDLLERR)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NOMBREIDIOMA)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ControlProcesos>(entity =>
            {
                entity.HasKey(e => e.cGuidControl);

                entity.Property(e => e.cGuidControl)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.cEstatusProceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.cFechaFinal).HasColumnType("datetime");

                entity.Property(e => e.cFechaInicial).HasColumnType("datetime");

                entity.Property(e => e.cNombreLog)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.cProcesoDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.CIDEMPRESA);

                entity.HasIndex(e => new { e.CNOMBREEMPRESA, e.CIDEMPRESA }, "CNOMBREEMPRESA");

                entity.Property(e => e.CIDEMPRESA).ValueGeneratedNever();

                entity.Property(e => e.CNOMBREEMPRESA)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRUTADATOS)
                    .IsRequired()
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRUTARESPALDOS)
                    .IsRequired()
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmpresasModelo>(entity =>
            {
                entity.HasKey(e => e.CIDEMPRESA);

                entity.HasIndex(e => new { e.CNOMBREEMPRESA, e.CIDEMPRESA }, "CNOMBREEMPRESA");

                entity.Property(e => e.CIDEMPRESA).ValueGeneratedNever();

                entity.Property(e => e.CNOMBREEMPRESA)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRUTAARCHIVOS)
                    .IsRequired()
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Etiquetas>(entity =>
            {
                entity.HasKey(e => e.CIDETIQUETA);

                entity.HasIndex(e => new { e.CNOMBREETIQUETA, e.CIDETIQUETA }, "ICNOMBREETIQUETA");

                entity.HasIndex(e => new { e.CIDTIPOHOJA, e.CIDETIQUETA }, "IIDTIPOHOJA");

                entity.Property(e => e.CIDETIQUETA).ValueGeneratedNever();

                entity.Property(e => e.CFUENTEADUANA)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTECARACTERISTICA1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTECARACTERISTICA2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTECARACTERISTICA3)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTEFECHACADUCIDAD)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTEFECHAFABRICACION)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTEFECHAPEDIMENTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTEIMPUESTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTENOMBREPRODUCTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTENUMEROLOTE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTEPEDIMENTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTEPRECIOPRODUCTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTESERIE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFUENTETIPOCAMBIO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNOMBREETIQUETA)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CSUPLEMENTO)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOADUANA)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOCARACTERISTICA1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOCARACTERISTICA2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOCARACTERISTICA3)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOFECHACADUCIDAD)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOFECHAFABRICACION)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOFECHAPEDIMENTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOIMPUESTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTONOMBREPRODUCTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTONUMEROLOTE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOPEDIMENTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOPRECIOPRODUCTO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOSERIE)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTEXTOTIPOCAMBIO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FormatosEtiquetas>(entity =>
            {
                entity.HasKey(e => e.CIDTIPOHOJA);

                entity.HasIndex(e => new { e.CNOMBREHOJA, e.CIDTIPOHOJA }, "INOMBREHOJA");

                entity.Property(e => e.CIDTIPOHOJA).ValueGeneratedNever();

                entity.Property(e => e.CANCHOPAPEL).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CLARGOPAPEL).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CMARGENDERECHO).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CMARGENINFERIOR).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CMARGENIZQUIERDO).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CMARGENSUPERIOR).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CNOMBREHOJA)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Formulas>(entity =>
            {
                entity.HasKey(e => e.CIDFORMULA);

                entity.HasIndex(e => new { e.CAGRUPADOR, e.CIDFORMULA }, "CAGRUPADOR");

                entity.Property(e => e.CIDFORMULA).ValueGeneratedNever();

                entity.Property(e => e.CDESCRIPCION)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDESCRIPCIONEJEMPLO).HasColumnType("text");

                entity.Property(e => e.CNOMBRE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<IdxAdminPAQ>(entity =>
            {
                entity.HasKey(e => new { e.TABLA, e.NOMBRE, e.TIPO, e.GRUPO });

                entity.Property(e => e.TABLA)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NOMBRE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TIPO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GRUPO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.DESCRIPCIO)
                    .IsRequired()
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MantenimientoBDDErrores>(entity =>
            {
                entity.HasKey(e => e.cGuidProceso);

                entity.Property(e => e.cGuidProceso)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.cAliasBDD)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.cDescripcionError)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MantenimientoBDDIndexTmps>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.cNombreIndex)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.cNombreTabla)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MantenimientoBDDProcesos>(entity =>
            {
                entity.HasKey(e => e.cGuidProceso);

                entity.Property(e => e.cGuidProceso)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.cFechaFinal).HasColumnType("datetime");

                entity.Property(e => e.cFechaInicial).HasColumnType("datetime");
            });

            modelBuilder.Entity<ModelosFinancieros>(entity =>
            {
                entity.HasKey(e => e.CIDMODELO);

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CDESCRIPCION, e.CRUTA, e.CIDMODELO }, "IIDSISTEMADESCRIPCIONRUTA");

                entity.Property(e => e.CIDMODELO).ValueGeneratedNever();

                entity.Property(e => e.CDESCRIPCION)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRUTA)
                    .IsRequired()
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ParametrosInicialesMto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.cDBTemplate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SATBancos>(entity =>
            {
                entity.HasKey(e => e.CCLAVE);

                entity.HasIndex(e => new { e.CNOMBRE, e.CCLAVE }, "CNOMBRE");

                entity.Property(e => e.CCLAVE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDESCRIPCION)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNOMBRE)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CPAGINAWEB)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRFC)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SATClaveProdServ>(entity =>
            {
                entity.HasKey(e => e.CCLAVE);

                entity.Property(e => e.CCLAVE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDESCRIPCION)
                    .IsRequired()
                    .HasMaxLength(152)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CESTATUS).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SATEstaciones>(entity =>
            {
                entity.HasKey(e => new { e.CTIPO, e.CCLAVE });

                entity.HasIndex(e => new { e.CTIPO, e.CDESCRIPCION }, "CDESCRIPCION");

                entity.Property(e => e.CTIPO)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CCLAVE)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDESCRIPCION)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CEXTRA)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNACIONALIDAD)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SATFracciones>(entity =>
            {
                entity.HasKey(e => e.CCLAVE);

                entity.Property(e => e.CCLAVE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CUNIDAD)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SATMonedas>(entity =>
            {
                entity.HasKey(e => e.CCODIGO);

                entity.Property(e => e.CCODIGO)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDECIMALES).HasDefaultValueSql("((2))");

                entity.Property(e => e.CNOMBRE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SATUnidades>(entity =>
            {
                entity.HasKey(e => e.CCLAVE);

                entity.Property(e => e.CCLAVE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDESCRIPCION)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNOMBRE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<UsuariosActivos>(entity =>
            {
                entity.HasKey(e => e.CIDUSUARIO);

                entity.Property(e => e.CIDUSUARIO).ValueGeneratedNever();

                entity.Property(e => e.CEMPRESA)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CUSUARIO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<UsuariosActivosBloqueos>(entity =>
            {
                entity.HasKey(e => e.CIDUSUARIO);

                entity.Property(e => e.CIDUSUARIO).ValueGeneratedNever();

                entity.Property(e => e.CEMPRESA)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CUSUARIO)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<admVistasCampos>(entity =>
            {
                entity.HasKey(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CNOMBRENATIVOCAMPO });

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CNOMBREAMIGABLECAMPO }, "INOMBREAMIGABLECAMPO");

                entity.Property(e => e.CNOMBRENATIVOTABLA)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNOMBRENATIVOCAMPO)
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.CNOMBREAMIGABLECAMPO)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<admVistasConsultas>(entity =>
            {
                entity.HasKey(e => e.CIDCONSULTA);

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CTIPO }, "ISISTEMAIDIOMAMODULOTIPO");

                entity.Property(e => e.CIDCONSULTA).ValueGeneratedNever();

                entity.Property(e => e.CNOMBRECONSULTA)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CSENTENCIASQL).HasColumnType("text");
            });

            modelBuilder.Entity<admVistasPorModulo>(entity =>
            {
                entity.HasKey(e => new { e.CIDMODULO, e.CIDSISTEMA, e.CIDIDIOMA });

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.CNOMBREMODULO)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<admVistasRelaciones>(entity =>
            {
                entity.HasKey(e => e.CIDRELACION);

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CINDICEIDIOMA, e.CNOMBRENATIVOTABLA1, e.CNOMBRENATIVOTABLA2, e.CIDRELACION }, "IRELACIONTABLAS");

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CINDICEIDIOMA, e.CNOMBRENATIVOTABLA1, e.CIDRELACION }, "ISISTEMAIDIOMARELDIRECTA");

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CINDICEIDIOMA, e.CNOMBRENATIVOTABLA2, e.CIDRELACION }, "ISISTEMAIDIOMARELINVERSA");

                entity.Property(e => e.CIDRELACION).ValueGeneratedNever();

                entity.Property(e => e.CNOMBRENATIVOTABLA1)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNOMBRENATIVOTABLA2)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNOMBRERELACION)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CSENTENCIAENLACE)
                    .IsRequired()
                    .HasMaxLength(201)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<admVistasTablas>(entity =>
            {
                entity.HasKey(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA });

                entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBREAMIGABLETABLA }, "INOMBREAMIGABLETABLA");

                entity.Property(e => e.CNOMBRENATIVOTABLA)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();

                entity.Property(e => e.CNOMBREAMIGABLETABLA)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<nubeEmpresas>(entity =>
            {
                entity.HasKey(e => e.CIDEMPRESA);

                entity.HasIndex(e => new { e.CEMPRESA, e.CRFC }, "CEMPRESA");

                entity.Property(e => e.CIDEMPRESA)
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CEMPRESA)
                    .IsRequired()
                    .HasMaxLength(253)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CPROPIETARIO)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRFC)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTIPO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
