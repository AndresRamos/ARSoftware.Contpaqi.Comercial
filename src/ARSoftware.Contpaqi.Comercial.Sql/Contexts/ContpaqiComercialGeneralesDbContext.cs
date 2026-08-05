using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Contexts;

public partial class ContpaqiComercialGeneralesDbContext : DbContext
{
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

    public virtual DbSet<ProveedoresNube> ProveedoresNube { get; set; }

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

            entity.Property(e => e.CFECHAFIN)
                .HasDefaultValueSql("('18991230')", "DF_MGW00009_CFECHAFIN")
                .HasColumnType("datetime");
            entity.Property(e => e.CVERSION)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00009_CVERSION");
        });

        modelBuilder.Entity<CAC00003>(entity =>
        {
            entity.HasKey(e => e.CIDBITACORA);

            entity.Property(e => e.CMENSAJE).HasColumnType("text");
        });

        modelBuilder.Entity<CAC0000C>(entity =>
        {
            entity.HasKey(e => new { e.TABLA, e.CORTO });

            entity.HasIndex(e => new { e.TABLA, e.LARGO }, "ICAMPOL");

            entity.Property(e => e.TABLA)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC0000C_TABLA");
            entity.Property(e => e.CORTO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC0000C_CORTO");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.LARGO)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC0000C_LARGO");
        });

        modelBuilder.Entity<CAC0000I>(entity =>
        {
            entity.HasKey(e => new { e.TABLA, e.CORTO });

            entity.HasIndex(e => new { e.TABLA, e.LARGO }, "IINDICEL");

            entity.Property(e => e.TABLA)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC0000I_TABLA");
            entity.Property(e => e.CORTO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC0000I_CORTO");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.LARGO)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC0000I_LARGO");
        });

        modelBuilder.Entity<CACIdiom>(entity =>
        {
            entity.HasKey(e => new { e.NUMEROSISTEMA, e.NUMEROIDIOMA });

            entity.Property(e => e.ARCHAYUDA)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CACIdiom_ARCHAYUDA");
            entity.Property(e => e.ARCHBDD)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CACIdiom_ARCHBDD");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.NOMBREDLLAPP)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CACIdiom_NOMBREDL01");
            entity.Property(e => e.NOMBREDLLERR)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CACIdiom_NOMBREDL02");
            entity.Property(e => e.NOMBREIDIOMA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CACIdiom_NOMBREID01");
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

            entity.Property(e => e.CNOMBREEMPRESA)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00001_CNOMBREE01");
            entity.Property(e => e.CRUTADATOS)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00001_CRUTADATOS");
            entity.Property(e => e.CRUTARESPALDOS)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00001_CRUTARES01");
        });

        modelBuilder.Entity<EmpresasModelo>(entity =>
        {
            entity.HasKey(e => e.CIDEMPRESA);

            entity.HasIndex(e => new { e.CNOMBREEMPRESA, e.CIDEMPRESA }, "CNOMBREEMPRESA");

            entity.Property(e => e.CNOMBREEMPRESA)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00001_CNOMBREE01");
            entity.Property(e => e.CRUTAARCHIVOS)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00001_CRUTAARC01");
        });

        modelBuilder.Entity<Etiquetas>(entity =>
        {
            entity.HasKey(e => e.CIDETIQUETA);

            entity.HasIndex(e => new { e.CNOMBREETIQUETA, e.CIDETIQUETA }, "ICNOMBREETIQUETA");

            entity.HasIndex(e => new { e.CIDTIPOHOJA, e.CIDETIQUETA }, "IIDTIPOHOJA");

            entity.Property(e => e.CFUENTEADUANA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEA01");
            entity.Property(e => e.CFUENTECARACTERISTICA1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEC01");
            entity.Property(e => e.CFUENTECARACTERISTICA2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEC02");
            entity.Property(e => e.CFUENTECARACTERISTICA3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEC03");
            entity.Property(e => e.CFUENTEFECHACADUCIDAD)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEF01");
            entity.Property(e => e.CFUENTEFECHAFABRICACION)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEF02");
            entity.Property(e => e.CFUENTEFECHAPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEF03");
            entity.Property(e => e.CFUENTEIMPUESTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEI01");
            entity.Property(e => e.CFUENTENOMBREPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEN01");
            entity.Property(e => e.CFUENTENUMEROLOTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEN02");
            entity.Property(e => e.CFUENTEPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEP02");
            entity.Property(e => e.CFUENTEPRECIOPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTEP01");
            entity.Property(e => e.CFUENTESERIE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTES01");
            entity.Property(e => e.CFUENTETIPOCAMBIO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CFUENTET01");
            entity.Property(e => e.CNOMBREETIQUETA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CNOMBREE01");
            entity.Property(e => e.CSUPLEMENTO)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CSUPLEME01");
            entity.Property(e => e.CTEXTOADUANA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOAD01");
            entity.Property(e => e.CTEXTOCARACTERISTICA1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOCA01");
            entity.Property(e => e.CTEXTOCARACTERISTICA2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOCA02");
            entity.Property(e => e.CTEXTOCARACTERISTICA3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOCA03");
            entity.Property(e => e.CTEXTOFECHACADUCIDAD)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOFE01");
            entity.Property(e => e.CTEXTOFECHAFABRICACION)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOFE02");
            entity.Property(e => e.CTEXTOFECHAPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOFE03");
            entity.Property(e => e.CTEXTOIMPUESTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOIM01");
            entity.Property(e => e.CTEXTONOMBREPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTONO01");
            entity.Property(e => e.CTEXTONUMEROLOTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTONU01");
            entity.Property(e => e.CTEXTOPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOPE01");
            entity.Property(e => e.CTEXTOPRECIOPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOPR01");
            entity.Property(e => e.CTEXTOSERIE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOSE01");
            entity.Property(e => e.CTEXTOTIPOCAMBIO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00005_CTEXTOTI01");
        });

        modelBuilder.Entity<FormatosEtiquetas>(entity =>
        {
            entity.HasKey(e => e.CIDTIPOHOJA);

            entity.HasIndex(e => new { e.CNOMBREHOJA, e.CIDTIPOHOJA }, "INOMBREHOJA");

            entity.Property(e => e.CNOMBREHOJA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00006_CNOMBREH01");
        });

        modelBuilder.Entity<Formulas>(entity =>
        {
            entity.HasKey(e => e.CIDFORMULA);

            entity.HasIndex(e => new { e.CAGRUPADOR, e.CIDFORMULA }, "CAGRUPADOR");

            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00002_CDESCRIP01");
            entity.Property(e => e.CDESCRIPCIONEJEMPLO).HasColumnType("text");
            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00002_CNOMBRE");
        });

        modelBuilder.Entity<IdxAdminPAQ>(entity =>
        {
            entity.HasKey(e => new { e.TABLA, e.NOMBRE, e.TIPO, e.GRUPO });

            entity.Property(e => e.TABLA)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IdxAdminPAQ_TABLA");
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IdxAdminPAQ_NOMBRE");
            entity.Property(e => e.TIPO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IdxAdminPAQ_TIPO");
            entity.Property(e => e.GRUPO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IdxAdminPAQ_GRUPO");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.DESCRIPCIO)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IdxAdminPAQ_DESCRIPCIO");
        });

        modelBuilder.Entity<MantenimientoBDDErrores>(entity =>
        {
            entity.HasKey(e => e.cGuidProceso);

            entity.Property(e => e.cGuidProceso)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.cAliasBDD)
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
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.cNombreTabla)
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

            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00010_CDESCRIP01");
            entity.Property(e => e.CRUTA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00010_CRUTA");
        });

        modelBuilder.Entity<ParametrosInicialesMto>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.cDBTemplate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProveedoresNube>(entity =>
        {
            entity.HasKey(e => e.CIDPROVEEDORSERVICIO);

            entity.Property(e => e.CNOMBREPROVEEDOR)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_ProveedoresNube_CNOMBREPROVEEDOR");
            entity.Property(e => e.CURLBASE)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_ProveedoresNube_CURLBASE");
        });

        modelBuilder.Entity<SATBancos>(entity =>
        {
            entity.HasKey(e => e.CCLAVE);

            entity.HasIndex(e => new { e.CNOMBRE, e.CCLAVE }, "CNOMBRE");

            entity.Property(e => e.CCLAVE)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATBancos_CCLAVE");
            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATBancos_CDESCRIPCION");
            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATBancos_CNOMBRE");
            entity.Property(e => e.CPAGINAWEB)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATBancos_CPAGINAWEB");
            entity.Property(e => e.CRFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATBancos_CRFC");
        });

        modelBuilder.Entity<SATClaveProdServ>(entity =>
        {
            entity.HasKey(e => e.CCLAVE);

            entity.Property(e => e.CCLAVE)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATClaveProdServ_CCLAVE");
            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(152)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATClaveProdServ_CDESCRIPCION");
            entity.Property(e => e.CESTATUS).HasDefaultValue(1, "DF_SATClaveProdServ_CESTATUS");
        });

        modelBuilder.Entity<SATEstaciones>(entity =>
        {
            entity.HasKey(e => new { e.CTIPO, e.CCLAVE });

            entity.HasIndex(e => new { e.CTIPO, e.CDESCRIPCION }, "CDESCRIPCION");

            entity.Property(e => e.CTIPO)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATEstaciones_CTIPO");
            entity.Property(e => e.CCLAVE)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATEstaciones_CCLAVE");
            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATEstaciones_CDESCRIPCION");
            entity.Property(e => e.CEXTRA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATEstaciones_CEXTRA");
            entity.Property(e => e.CNACIONALIDAD)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATEstaciones_CNACIONALIDAD");
        });

        modelBuilder.Entity<SATFracciones>(entity =>
        {
            entity.HasKey(e => e.CCLAVE);

            entity.Property(e => e.CCLAVE)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CUNIDAD)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATMonedas>(entity =>
        {
            entity.HasKey(e => e.CCODIGO);

            entity.Property(e => e.CCODIGO)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATMonedas_CCODIGO");
            entity.Property(e => e.CDECIMALES).HasDefaultValue(2, "DF_SATMonedas_CDECIMALES");
            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATMonedas_CNOMBRE");
        });

        modelBuilder.Entity<SATUnidades>(entity =>
        {
            entity.HasKey(e => e.CCLAVE);

            entity.Property(e => e.CCLAVE)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATUnidades_CCLAVE");
            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATUnidades_CDESCRIPCION");
            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_SATUnidades_CNOMBRE");
        });

        modelBuilder.Entity<UsuariosActivos>(entity =>
        {
            entity.HasKey(e => e.CIDUSUARIO);

            entity.Property(e => e.CEMPRESA)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00007_CEMPRESA");
            entity.Property(e => e.CUSUARIO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00007_CUSUARIO");
        });

        modelBuilder.Entity<UsuariosActivosBloqueos>(entity =>
        {
            entity.HasKey(e => e.CIDUSUARIO);

            entity.Property(e => e.CEMPRESA)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00007B_CEMPRESA");
            entity.Property(e => e.CUSUARIO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW00007B_CUSUARIO");
        });

        modelBuilder.Entity<admVistasCampos>(entity =>
        {
            entity.HasKey(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CNOMBRENATIVOCAMPO });

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CNOMBREAMIGABLECAMPO }, "INOMBREAMIGABLECAMPO");

            entity.Property(e => e.CNOMBRENATIVOTABLA)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00007_CNOMBREN01");
            entity.Property(e => e.CNOMBRENATIVOCAMPO)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00007_CNOMBREN02");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CNOMBREAMIGABLECAMPO)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00007_CNOMBREA01");
        });

        modelBuilder.Entity<admVistasConsultas>(entity =>
        {
            entity.HasKey(e => e.CIDCONSULTA);

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CTIPO }, "ISISTEMAIDIOMAMODULOTIPO");

            entity.Property(e => e.CNOMBRECONSULTA)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00005_CNOMBREC01");
            entity.Property(e => e.CSENTENCIASQL).HasColumnType("text");
        });

        modelBuilder.Entity<admVistasPorModulo>(entity =>
        {
            entity.HasKey(e => new { e.CIDMODULO, e.CIDSISTEMA, e.CIDIDIOMA });

            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CNOMBREMODULO)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00008_CNOMBREM01");
        });

        modelBuilder.Entity<admVistasRelaciones>(entity =>
        {
            entity.HasKey(e => e.CIDRELACION);

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CINDICEIDIOMA, e.CNOMBRENATIVOTABLA1, e.CNOMBRENATIVOTABLA2, e.CIDRELACION }, "IRELACIONTABLAS");

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CINDICEIDIOMA, e.CNOMBRENATIVOTABLA1, e.CIDRELACION }, "ISISTEMAIDIOMARELDIRECTA");

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CINDICEIDIOMA, e.CNOMBRENATIVOTABLA2, e.CIDRELACION }, "ISISTEMAIDIOMARELINVERSA");

            entity.Property(e => e.CNOMBRENATIVOTABLA1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CNOMBREN01");
            entity.Property(e => e.CNOMBRENATIVOTABLA2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CNOMBREN02");
            entity.Property(e => e.CNOMBRERELACION)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CNOMBRER01");
            entity.Property(e => e.CSENTENCIAENLACE)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CSENTENC01");
        });

        modelBuilder.Entity<admVistasTablas>(entity =>
        {
            entity.HasKey(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA });

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBREAMIGABLETABLA }, "INOMBREAMIGABLETABLA");

            entity.Property(e => e.CNOMBRENATIVOTABLA)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00006_CNOMBREN01");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CNOMBREAMIGABLETABLA)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00006_CNOMBREA01");
        });

        modelBuilder.Entity<nubeEmpresas>(entity =>
        {
            entity.HasKey(e => e.CIDEMPRESA);

            entity.HasIndex(e => new { e.CEMPRESA, e.CRFC }, "CEMPRESA");

            entity.Property(e => e.CIDEMPRESA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeEmpresas_CIDEMPRESA");
            entity.Property(e => e.CEMPRESA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeEmpresas_CEMPRESA");
            entity.Property(e => e.CPROPIETARIO)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeEmpresas_CPROPIETARIO");
            entity.Property(e => e.CRFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeEmpresas_CRFC");
            entity.Property(e => e.CTIPO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeEmpresas_CTIPO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
