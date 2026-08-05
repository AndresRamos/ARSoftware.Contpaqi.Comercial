using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Contexts;

public partial class ContpaqiComercialEmpresaDbContext : DbContext
{
    public ContpaqiComercialEmpresaDbContext(DbContextOptions<ContpaqiComercialEmpresaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<admAcumulados> admAcumulados { get; set; }

    public virtual DbSet<admAcumuladosTipos> admAcumuladosTipos { get; set; }

    public virtual DbSet<admAgentes> admAgentes { get; set; }

    public virtual DbSet<admAlmacenes> admAlmacenes { get; set; }

    public virtual DbSet<admAperturas> admAperturas { get; set; }

    public virtual DbSet<admAsientosContables> admAsientosContables { get; set; }

    public virtual DbSet<admAsocAcumConceptos> admAsocAcumConceptos { get; set; }

    public virtual DbSet<admAsocBuzones> admAsocBuzones { get; set; }

    public virtual DbSet<admAsocCargosAbonos> admAsocCargosAbonos { get; set; }

    public virtual DbSet<admAsocCargosAbonosImp> admAsocCargosAbonosImp { get; set; }

    public virtual DbSet<admAsocLigasPagos> admAsocLigasPagos { get; set; }

    public virtual DbSet<admBanderas> admBanderas { get; set; }

    public virtual DbSet<admBitacoras> admBitacoras { get; set; }

    public virtual DbSet<admBuzones> admBuzones { get; set; }

    public virtual DbSet<admCajas> admCajas { get; set; }

    public virtual DbSet<admCapasProducto> admCapasProducto { get; set; }

    public virtual DbSet<admCaracteristicas> admCaracteristicas { get; set; }

    public virtual DbSet<admCaracteristicasValores> admCaracteristicasValores { get; set; }

    public virtual DbSet<admClasificaciones> admClasificaciones { get; set; }

    public virtual DbSet<admClasificacionesValores> admClasificacionesValores { get; set; }

    public virtual DbSet<admClientes> admClientes { get; set; }

    public virtual DbSet<admComponentesPaquete> admComponentesPaquete { get; set; }

    public virtual DbSet<admConceptos> admConceptos { get; set; }

    public virtual DbSet<admConceptosBack> admConceptosBack { get; set; }

    public virtual DbSet<admConfigProveedoresNube> admConfigProveedoresNube { get; set; }

    public virtual DbSet<admConversionesUnidad> admConversionesUnidad { get; set; }

    public virtual DbSet<admCostosHistoricos> admCostosHistoricos { get; set; }

    public virtual DbSet<admCuentasBancarias> admCuentasBancarias { get; set; }

    public virtual DbSet<admDatosAddenda> admDatosAddenda { get; set; }

    public virtual DbSet<admDocumentos> admDocumentos { get; set; }

    public virtual DbSet<admDocumentosModelo> admDocumentosModelo { get; set; }

    public virtual DbSet<admDocumentosModelosBack> admDocumentosModelosBack { get; set; }

    public virtual DbSet<admDocumentosOrigen> admDocumentosOrigen { get; set; }

    public virtual DbSet<admDomicilios> admDomicilios { get; set; }

    public virtual DbSet<admEjercicios> admEjercicios { get; set; }

    public virtual DbSet<admExistenciaCosto> admExistenciaCosto { get; set; }

    public virtual DbSet<admFoliosDigitales> admFoliosDigitales { get; set; }

    public virtual DbSet<admFormasPago> admFormasPago { get; set; }

    public virtual DbSet<admLigasPago> admLigasPago { get; set; }

    public virtual DbSet<admMaximosMinimos> admMaximosMinimos { get; set; }

    public virtual DbSet<admMensajes> admMensajes { get; set; }

    public virtual DbSet<admMonedas> admMonedas { get; set; }

    public virtual DbSet<admMovimientos> admMovimientos { get; set; }

    public virtual DbSet<admMovimientosCapas> admMovimientosCapas { get; set; }

    public virtual DbSet<admMovimientosContables> admMovimientosContables { get; set; }

    public virtual DbSet<admMovimientosPrepoliza> admMovimientosPrepoliza { get; set; }

    public virtual DbSet<admMovimientosSerie> admMovimientosSerie { get; set; }

    public virtual DbSet<admMovtosBancarios> admMovtosBancarios { get; set; }

    public virtual DbSet<admMovtosCEPs> admMovtosCEPs { get; set; }

    public virtual DbSet<admMovtosInvFisico> admMovtosInvFisico { get; set; }

    public virtual DbSet<admMovtosInvFisicoSerieCa> admMovtosInvFisicoSerieCa { get; set; }

    public virtual DbSet<admNumerosSerie> admNumerosSerie { get; set; }

    public virtual DbSet<admPagoNotas> admPagoNotas { get; set; }

    public virtual DbSet<admParametros> admParametros { get; set; }

    public virtual DbSet<admParametrosBack> admParametrosBack { get; set; }

    public virtual DbSet<admPreciosCompra> admPreciosCompra { get; set; }

    public virtual DbSet<admPrepolizas> admPrepolizas { get; set; }

    public virtual DbSet<admProductos> admProductos { get; set; }

    public virtual DbSet<admProductosDetalles> admProductosDetalles { get; set; }

    public virtual DbSet<admProductosFotos> admProductosFotos { get; set; }

    public virtual DbSet<admPromociones> admPromociones { get; set; }

    public virtual DbSet<admProyectos> admProyectos { get; set; }

    public virtual DbSet<admSATSegmentos> admSATSegmentos { get; set; }

    public virtual DbSet<admSegmentosImpuestos> admSegmentosImpuestos { get; set; }

    public virtual DbSet<admTiposCambio> admTiposCambio { get; set; }

    public virtual DbSet<admUnidadesMedidaPeso> admUnidadesMedidaPeso { get; set; }

    public virtual DbSet<admVistasCampos> admVistasCampos { get; set; }

    public virtual DbSet<admVistasConsultas> admVistasConsultas { get; set; }

    public virtual DbSet<admVistasPorModulo> admVistasPorModulo { get; set; }

    public virtual DbSet<admVistasRecursos> admVistasRecursos { get; set; }

    public virtual DbSet<admVistasRelaciones> admVistasRelaciones { get; set; }

    public virtual DbSet<admVistasTablas> admVistasTablas { get; set; }

    public virtual DbSet<nubeCuentas> nubeCuentas { get; set; }

    public virtual DbSet<nubeDiarios> nubeDiarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<admAcumulados>(entity =>
        {
            entity.HasKey(e => e.CIDACUMULADO);

            entity.HasIndex(e => new { e.CIDMONEDA, e.CIDACUMULADO }, "CIDMONEDA");

            entity.HasIndex(e => new { e.CIDTIPOACUMULADO, e.CIMPORTEMODELO, e.CIDOWNER1, e.CIDOWNER2, e.CIDEJERCICIO, e.CIDMONEDA }, "IACUMIMPTEOWNEREJERMONEDA");

            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10018_CTIMESTAMP");
        });

        modelBuilder.Entity<admAcumuladosTipos>(entity =>
        {
            entity.HasKey(e => e.CIDTIPOACUMULADO);

            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10012_CNOMBRE");
        });

        modelBuilder.Entity<admAgentes>(entity =>
        {
            entity.HasKey(e => e.CIDAGENTE);

            entity.HasIndex(e => e.CCODIGOAGENTE, "CCODIGOAGENTE").IsUnique();

            entity.HasIndex(e => new { e.CFECHAALTAAGENTE, e.CIDAGENTE }, "CFECHAALTAAGENTE");

            entity.HasIndex(e => new { e.CIDCLIENTE, e.CIDAGENTE }, "CIDCLIENTE");

            entity.HasIndex(e => new { e.CIDPROVEEDOR, e.CIDAGENTE }, "CIDPROVEEDOR");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION1, e.CIDAGENTE }, "CIDVALORCLASIFICACION1");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION2, e.CIDAGENTE }, "CIDVALORCLASIFICACION2");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION3, e.CIDAGENTE }, "CIDVALORCLASIFICACION3");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION4, e.CIDAGENTE }, "CIDVALORCLASIFICACION4");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION5, e.CIDAGENTE }, "CIDVALORCLASIFICACION5");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION6, e.CIDAGENTE }, "CIDVALORCLASIFICACION6");

            entity.HasIndex(e => new { e.CCODIGOAGENTE, e.CTIPOAGENTE }, "ICODIGOTIPO");

            entity.HasIndex(e => new { e.CNOMBREAGENTE, e.CTIPOAGENTE, e.CIDAGENTE }, "INOMBRETIPO");

            entity.Property(e => e.CCODIGOAGENTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CCODIGOA01");
            entity.Property(e => e.CFECHAALTAAGENTE)
                .HasDefaultValueSql("('18991230')", "DF_MGW10001_CFECHAAL01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10001_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNOMBREAGENTE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CNOMBREA01");
            entity.Property(e => e.CSCAGENTE2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CSCAGENTE2");
            entity.Property(e => e.CSCAGENTE3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CSCAGENTE3");
            entity.Property(e => e.CSEGCONTAGENTE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CSEGCONT01");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10001_CTIMESTAMP");
        });

        modelBuilder.Entity<admAlmacenes>(entity =>
        {
            entity.HasKey(e => e.CIDALMACEN);

            entity.HasIndex(e => e.CCODIGOALMACEN, "CCODIGOALMACEN").IsUnique();

            entity.HasIndex(e => new { e.CFECHAALTAALMACEN, e.CIDALMACEN }, "CFECHAALTAALMACEN");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION1, e.CIDALMACEN }, "CIDVALORCLASIFICACION1");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION2, e.CIDALMACEN }, "CIDVALORCLASIFICACION2");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION3, e.CIDALMACEN }, "CIDVALORCLASIFICACION3");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION4, e.CIDALMACEN }, "CIDVALORCLASIFICACION4");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION5, e.CIDALMACEN }, "CIDVALORCLASIFICACION5");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION6, e.CIDALMACEN }, "CIDVALORCLASIFICACION6");

            entity.HasIndex(e => new { e.CNOMBREALMACEN, e.CIDALMACEN }, "CNOMBREALMACEN");

            entity.Property(e => e.CCODIGOALMACEN)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CCODIGOA01");
            entity.Property(e => e.CFECHAALTAALMACEN)
                .HasDefaultValueSql("('18991230')", "DF_MGW10003_CFECHAAL01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10003_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNOMBREALMACEN)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CNOMBREA01");
            entity.Property(e => e.CSCALMAC2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CSCALMAC2");
            entity.Property(e => e.CSCALMAC3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CSCALMAC3");
            entity.Property(e => e.CSEGCONTALMACEN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CSEGCONT01");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10003_CTIMESTAMP");
        });

        modelBuilder.Entity<admAperturas>(entity =>
        {
            entity.HasKey(e => e.CIDAPERTURA);

            entity.HasIndex(e => new { e.CFECHAAPERTURA, e.CIDAPERTURA }, "CFECHAAPERTURA");

            entity.HasIndex(e => new { e.CIDCAJA, e.CIDAPERTURA }, "CIDCAJA");

            entity.Property(e => e.CFECHAAPERTURA)
                .HasDefaultValueSql("('18991230')", "DF_admAperturas_CFECHAAPERTURA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACORTE)
                .HasDefaultValueSql("('18991230')", "DF_admAperturas_CFECHACORTE")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAFACTURA)
                .HasDefaultValueSql("('18991230')", "DF_admAperturas_CFECHAFACTURA")
                .HasColumnType("datetime");
            entity.Property(e => e.CHORAAPERTURA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("000000", "DF_admAperturas_CHORAAPERTURA");
            entity.Property(e => e.CHORACORTE)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("000000", "DF_admAperturas_CHORACORTE");
            entity.Property(e => e.CTERMINAL)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admAperturas_CTERMINAL");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admAperturas_CTIMESTAMP");
            entity.Property(e => e.CUSUARIO)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admAperturas_CUSUARIO");
        });

        modelBuilder.Entity<admAsientosContables>(entity =>
        {
            entity.HasKey(e => e.CIDASIENTOCONTABLE);

            entity.HasIndex(e => new { e.CNOMBREASIENTOCONTABLE, e.CIDASIENTOCONTABLE }, "CNOMBREASIENTOCONTABLE");

            entity.HasIndex(e => new { e.CNUMEROASIENTOCONTABLE, e.CIDASIENTOCONTABLE }, "CNUMEROASIENTOCONTABLE");

            entity.Property(e => e.CCONCEPTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10023_CCONCEPTO");
            entity.Property(e => e.CDIARIO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10023_CDIARIO");
            entity.Property(e => e.CNOMBREASIENTOCONTABLE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10023_CNOMBREA01");
            entity.Property(e => e.CNUMEROASIENTOCONTABLE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10023_CNUMEROA01");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10023_CTIMESTAMP");
        });

        modelBuilder.Entity<admAsocAcumConceptos>(entity =>
        {
            entity.HasKey(e => e.CIDCONCEPTOTIPOACUMULADO);

            entity.HasIndex(e => new { e.CIDCONCEPTODOCUMENTO, e.CIMPORTEMODELO, e.CIDTIPOACUMULADO, e.CIDCONCEPTOTIPOACUMULADO }, "ICONCEPTOIMPORTETIPO");
        });

        modelBuilder.Entity<admAsocBuzones>(entity =>
        {
            entity.HasKey(e => new { e.CTIPOCATALOGO, e.CIDCATALOGO });

            entity.Property(e => e.CINBOXID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admAsocBuzones_CINBOXID");
            entity.Property(e => e.CPASSWORD)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admBuzones_CPASSWORD");
            entity.Property(e => e.CPRIVATEPEMKEY).IsUnicode(false);
            entity.Property(e => e.CPUBLICPEMKEY).IsUnicode(false);
        });

        modelBuilder.Entity<admAsocCargosAbonos>(entity =>
        {
            entity.HasKey(e => new { e.CIDDOCUMENTOABONO, e.CIDDOCUMENTOCARGO });

            entity.HasIndex(e => new { e.CIDDOCUMENTOCARGO, e.CIDDOCUMENTOABONO }, "IDOCTOCARGOABONO");

            entity.HasIndex(e => new { e.CFECHAABONOCARGO, e.CIDAUTOINCSQL }, "PORFECHAABONOCARGO");

            entity.Property(e => e.CFECHAABONOCARGO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10009_CFECHAAB01")
                .HasColumnType("datetime");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<admAsocCargosAbonosImp>(entity =>
        {
            entity.HasKey(e => new { e.CIDDOCUMENTOABONO, e.CIDDOCUMENTOCARGO, e.CTEXTOTASA });

            entity.HasIndex(e => new { e.CIDDOCUMENTOABONO, e.CESDETALLE }, "IABONODET");

            entity.HasIndex(e => new { e.CIDDOCUMENTOCARGO, e.CESDETALLE }, "ICARGODET");

            entity.HasIndex(e => new { e.CIDDOCUMENTOCARGO, e.CIDDOCUMENTOABONO, e.CTEXTOTASA }, "IDOCTOCARGOABONO").IsUnique();

            entity.Property(e => e.CTEXTOTASA)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CMETODOPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10059_CMETODOPAG");
            entity.Property(e => e.CNOMIMPLOC)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10059_CNOMIMPLOC");
            entity.Property(e => e.COBJIMPU01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10059_COBJIMPU01");
        });

        modelBuilder.Entity<admAsocLigasPagos>(entity =>
        {
            entity.HasKey(e => new { e.CIDLIGA, e.CIDDOCTO });
        });

        modelBuilder.Entity<admBanderas>(entity =>
        {
            entity.HasKey(e => e.CIDBANDERA);

            entity.HasIndex(e => e.CNOMBREBANDERA, "CNOMBREBANDERA");

            entity.Property(e => e.CBANDERA).HasColumnType("text");
            entity.Property(e => e.CCLAVEISO)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IMG10002_CCLAVEISO");
            entity.Property(e => e.CNOMBREBANDERA)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IMG10002_CNOMBREB01");
        });

        modelBuilder.Entity<admBitacoras>(entity =>
        {
            entity.HasKey(e => e.IDBITACORA);

            entity.HasIndex(e => new { e.FECHA, e.HORA }, "FECHAHORA");

            entity.HasIndex(e => new { e.PROCESO, e.IDBITACORA }, "PROCESO");

            entity.HasIndex(e => new { e.IDSISTEMA, e.IDBITACORA }, "SISTEMA");

            entity.HasIndex(e => new { e.USUARIO, e.IDBITACORA }, "USUARIO");

            entity.Property(e => e.CFECHAEX01)
                .HasDefaultValueSql("('18991230')", "DF_CAC60000_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CTEXTOEX01)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEX02)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEX03)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_CTEXTOEX03");
            entity.Property(e => e.DATOS)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_DATOS");
            entity.Property(e => e.EQUIPO)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_EQUIPO");
            entity.Property(e => e.FECHA)
                .HasDefaultValueSql("('18991230')", "DF_CAC60000_FECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.HORA)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_HORA");
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_NOMBRE");
            entity.Property(e => e.NOMBRE2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_NOMBRE2");
            entity.Property(e => e.PROCESO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_PROCESO");
            entity.Property(e => e.USUARIO)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_USUARIO");
            entity.Property(e => e.USUARIO2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC60000_USUARIO2");
        });

        modelBuilder.Entity<admBuzones>(entity =>
        {
            entity.HasKey(e => new { e.CINBOXID, e.CSUBSCRIPTIONID });

            entity.HasIndex(e => new { e.CINBOXID, e.CTIPO }, "ITIPO").IsUnique();

            entity.Property(e => e.CINBOXID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admBuzones_CINBOXID");
            entity.Property(e => e.CSUBSCRIPTIONID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admBuzones_CSUBSCRIPTIONID");
            entity.Property(e => e.CALIAS)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admBuzones_CALIAS");
            entity.Property(e => e.CCREATEDAT)
                .HasDefaultValueSql("('18991230')", "DF_admBuzones_CCREATEDAT")
                .HasColumnType("datetime");
            entity.Property(e => e.CENCRYPTIONKEYID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admBuzones_CENCRYPTIONKEYID");
            entity.Property(e => e.CSUBSCRIPTIONKEY).IsUnicode(false);
            entity.Property(e => e.CUPDATEDAT)
                .HasDefaultValueSql("('18991230')", "DF_admBuzones_CUPDATEDAT")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<admCajas>(entity =>
        {
            entity.HasKey(e => e.CIDCAJA);

            entity.HasIndex(e => e.CCODIGOCAJA, "CCODIGOCAJA").IsUnique();

            entity.HasIndex(e => new { e.CFECHAALTA, e.CIDCAJA }, "CFECHAALTA");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION1, e.CIDCAJA }, "CIDVALORCLASIFICACION1");

            entity.HasIndex(e => e.CNOMBRECAJA, "CNOMBRECAJA").IsUnique();

            entity.Property(e => e.CCODIGOCAJA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CCODIGOCAJA");
            entity.Property(e => e.CFECHAALTA)
                .HasDefaultValueSql("('18991230')", "DF_admCajas_CFECHAALTA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHABAJA)
                .HasDefaultValueSql("('18991230')", "DF_admCajas_CFECHABAJA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_admCajas_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNOMBRECAJA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CNOMBRECAJA");
            entity.Property(e => e.CSERIEDEVN)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CSERIEDEVN");
            entity.Property(e => e.CSERIENOTA)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CSERIENOTA");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_CTIMESTAMP");
            entity.Property(e => e.cReporteApertura)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_cReporteApertura");
            entity.Property(e => e.cReporteCorte)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_cReporteCorte");
            entity.Property(e => e.cReporteNota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCajas_cReporteNota");
        });

        modelBuilder.Entity<admCapasProducto>(entity =>
        {
            entity.HasKey(e => e.CIDCAPA);

            entity.HasIndex(e => new { e.CFECHA, e.CIDCAPA }, "CFECHA");

            entity.HasIndex(e => new { e.CFECHACADUCIDAD, e.CIDCAPA }, "CFECHACADUCIDAD");

            entity.HasIndex(e => new { e.CIDCAPAORIGEN, e.CIDCAPA }, "CIDCAPAORIGEN");

            entity.HasIndex(e => new { e.CNUMEROLOTE, e.CIDCAPA }, "CNUMEROLOTE");

            entity.HasIndex(e => new { e.CPEDIMENTO, e.CIDCAPA }, "CPEDIMENTO");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDCAPAORIGEN, e.CIDCAPA }, "IALMACENCAPAORIGEN");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CIDCAPA }, "IALMACENPRODUCTO");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CFECHA, e.CIDCAPA }, "IALMPROFEC");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CPEDIMENTO, e.CNUMEROLOTE, e.CIDCAPA }, "IPRODALMACENPEDIMENTOLOTE");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CFECHA, e.CIDCAPA }, "IPRODFECHA");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CNUMEROLOTE, e.CIDCAPA }, "IPRODUCTOALMACENLOTE");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CFECHACADUCIDAD, e.CIDCAPA }, "IPRODUCTOFECHACADUCIDAD");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CFECHAPEDIMENTO, e.CIDCAPA }, "IPRODUCTOFECHAPEDIMENTO");

            entity.Property(e => e.CADUANA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10025_CADUANA");
            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10025_CCLAVESAT");
            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10025_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACADUCIDAD)
                .HasDefaultValueSql("('18991230')", "DF_MGW10025_CFECHACA01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAFABRICACION)
                .HasDefaultValueSql("('18991230')", "DF_MGW10025_CFECHAFA01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAPEDIMENTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10025_CFECHAPE01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNUMEROLOTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10025_CNUMEROL01");
            entity.Property(e => e.CPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10025_CPEDIMENTO");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10025_CTIMESTAMP");
        });

        modelBuilder.Entity<admCaracteristicas>(entity =>
        {
            entity.HasKey(e => e.CIDPADRECARACTERISTICA);

            entity.HasIndex(e => e.CNOMBRECARACTERISTICA, "CNOMBRECARACTERISTICA");

            entity.Property(e => e.CNOMBRECARACTERISTICA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10021_CNOMBREC01");
        });

        modelBuilder.Entity<admCaracteristicasValores>(entity =>
        {
            entity.HasKey(e => e.CIDVALORCARACTERISTICA);

            entity.HasIndex(e => e.CNEMOCARACTERISTICA, "CNEMOCARACTERISTICA");

            entity.HasIndex(e => new { e.CVALORCARACTERISTICA, e.CIDVALORCARACTERISTICA }, "CVALORCARACTERISTICA");

            entity.HasIndex(e => new { e.CIDPADRECARACTERISTICA, e.CNEMOCARACTERISTICA, e.CIDVALORCARACTERISTICA }, "IPADRENEMO");

            entity.HasIndex(e => new { e.CIDPADRECARACTERISTICA, e.CVALORCARACTERISTICA, e.CIDVALORCARACTERISTICA }, "IPADREVA02");

            entity.HasIndex(e => new { e.CIDPADRECARACTERISTICA, e.CIDVALORCARACTERISTICA }, "IPADREVALOR");

            entity.Property(e => e.CNEMOCARACTERISTICA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10022_CNEMOCAR01");
            entity.Property(e => e.CVALORCARACTERISTICA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10022_CVALORCA01");
        });

        modelBuilder.Entity<admClasificaciones>(entity =>
        {
            entity.HasKey(e => e.CIDCLASIFICACION);

            entity.HasIndex(e => new { e.CNOMBRECLASIFICACION, e.CIDCLASIFICACION }, "CNOMBRECLASIFICACION");

            entity.Property(e => e.CNOMBRECLASIFICACION)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10019_CNOMBREC01");
        });

        modelBuilder.Entity<admClasificacionesValores>(entity =>
        {
            entity.HasKey(e => e.CIDVALORCLASIFICACION);

            entity.HasIndex(e => new { e.CVALORCLASIFICACION, e.CIDVALORCLASIFICACION }, "CVALORCL01");

            entity.HasIndex(e => new { e.CCODIGOVALORCLASIFICACION, e.CIDCLASIFICACION }, "ICCODIGOCLASIFICACION");

            entity.HasIndex(e => new { e.CIDCLASIFICACION, e.CVALORCLASIFICACION, e.CIDVALORCLASIFICACION }, "ICLASIFICACIONVALOR");

            entity.HasIndex(e => new { e.CIDCLASIFICACION, e.CIDVALORCLASIFICACION }, "ICLASIFVALORCLASIF");

            entity.Property(e => e.CCODIGOVALORCLASIFICACION)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10020_CCODIGOV01");
            entity.Property(e => e.CSEGCONT1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10020_CSEGCONT1");
            entity.Property(e => e.CSEGCONT2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10020_CSEGCONT2");
            entity.Property(e => e.CSEGCONT3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10020_CSEGCONT3");
            entity.Property(e => e.CVALORCLASIFICACION)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10020_CVALORCL01");
        });

        modelBuilder.Entity<admClientes>(entity =>
        {
            entity.HasKey(e => e.CIDCLIENTEPROVEEDOR);

            entity.HasIndex(e => new { e.CCODIGOALTERNO, e.CIDCLIENTEPROVEEDOR }, "CCODIGOALTERNO");

            entity.HasIndex(e => e.CCODIGOCLIENTE, "CCODIGOCLIENTE").IsUnique();

            entity.HasIndex(e => new { e.CFECHAALTA, e.CIDCLIENTEPROVEEDOR }, "CFECHAALTA");

            entity.HasIndex(e => new { e.CIDAGENTECOBRO, e.CIDCLIENTEPROVEEDOR }, "CIDAGENTECOBRO");

            entity.HasIndex(e => new { e.CIDAGENTEVENTA, e.CIDCLIENTEPROVEEDOR }, "CIDAGENTEVENTA");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDCLIENTEPROVEEDOR }, "CIDALMACEN");

            entity.HasIndex(e => new { e.CIDCUENTA, e.CIDCLIENTEPROVEEDOR }, "CIDCUENTA");

            entity.HasIndex(e => new { e.CIDMONEDA, e.CIDCLIENTEPROVEEDOR }, "CIDMONEDA");

            entity.HasIndex(e => new { e.CIDVALORCLASIFCLIENTE1, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFCLIENTE1");

            entity.HasIndex(e => new { e.CIDVALORCLASIFCLIENTE2, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFCLIENTE2");

            entity.HasIndex(e => new { e.CIDVALORCLASIFCLIENTE3, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFCLIENTE3");

            entity.HasIndex(e => new { e.CIDVALORCLASIFCLIENTE4, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFCLIENTE4");

            entity.HasIndex(e => new { e.CIDVALORCLASIFCLIENTE5, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFCLIENTE5");

            entity.HasIndex(e => new { e.CIDVALORCLASIFCLIENTE6, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFCLIENTE6");

            entity.HasIndex(e => new { e.CIDVALORCLASIFPROVEEDOR1, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFPROVEEDOR1");

            entity.HasIndex(e => new { e.CIDVALORCLASIFPROVEEDOR2, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFPROVEEDOR2");

            entity.HasIndex(e => new { e.CIDVALORCLASIFPROVEEDOR3, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFPROVEEDOR3");

            entity.HasIndex(e => new { e.CIDVALORCLASIFPROVEEDOR4, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFPROVEEDOR4");

            entity.HasIndex(e => new { e.CIDVALORCLASIFPROVEEDOR5, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFPROVEEDOR5");

            entity.HasIndex(e => new { e.CIDVALORCLASIFPROVEEDOR6, e.CIDCLIENTEPROVEEDOR }, "CIDVALORCLASIFPROVEEDOR6");

            entity.HasIndex(e => new { e.CCODIGOCLIENTE, e.CTIPOCLIENTE }, "ICODIGOTIPO");

            entity.HasIndex(e => new { e.CESTATUS, e.CTIPOCLIENTE, e.CIDCLIENTEPROVEEDOR }, "IESTATUSTIPOCTEPROV");

            entity.HasIndex(e => new { e.CRAZONSOCIAL, e.CTIPOCLIENTE, e.CIDCLIENTEPROVEEDOR }, "IRAZONTIPO");

            entity.HasIndex(e => new { e.CRFC, e.CTIPOCLIENTE, e.CIDCLIENTEPROVEEDOR }, "IRFCTIPO");

            entity.Property(e => e.CCODIGOALTERNO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCODIGOALTERNO");
            entity.Property(e => e.CCODIGOCLIENTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCODIGOC01");
            entity.Property(e => e.CCODPROVCO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCODPROVCO");
            entity.Property(e => e.CCON1NOM)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCON1NOM");
            entity.Property(e => e.CCON1TEL)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCON1TEL");
            entity.Property(e => e.CCUENTAMENSAJERIA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCUENTAM01");
            entity.Property(e => e.CCURP)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CCURP");
            entity.Property(e => e.CDENCOMERCIAL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CDENCOME01");
            entity.Property(e => e.CEMAIL1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CEMAIL1");
            entity.Property(e => e.CEMAIL2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CEMAIL2");
            entity.Property(e => e.CEMAIL3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CEMAIL3");
            entity.Property(e => e.CFECHAALTA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10002_CFECHAALTA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHABAJA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10002_CFECHABAJA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10002_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAULTIMAREVISION)
                .HasDefaultValueSql("('18991230')", "DF_MGW10002_CFECHAUL01")
                .HasColumnType("datetime");
            entity.Property(e => e.CMENSAJERIA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CMENSAJE01");
            entity.Property(e => e.CMETODOPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CMETODOPAG");
            entity.Property(e => e.CNUMCTAPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CNUMCTAPAG");
            entity.Property(e => e.CRAZONSOCIAL)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CRAZONSO01");
            entity.Property(e => e.CREGIMFISC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CREGIMFISC");
            entity.Property(e => e.CREPLEGAL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CREPLEGAL");
            entity.Property(e => e.CRFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CRFC");
            entity.Property(e => e.CSEGCONTCLIENTE1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT01");
            entity.Property(e => e.CSEGCONTCLIENTE2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT02");
            entity.Property(e => e.CSEGCONTCLIENTE3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT03");
            entity.Property(e => e.CSEGCONTCLIENTE4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT04");
            entity.Property(e => e.CSEGCONTCLIENTE5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT05");
            entity.Property(e => e.CSEGCONTCLIENTE6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT06");
            entity.Property(e => e.CSEGCONTCLIENTE7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT07");
            entity.Property(e => e.CSEGCONTPROVEEDOR1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT08");
            entity.Property(e => e.CSEGCONTPROVEEDOR2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT09");
            entity.Property(e => e.CSEGCONTPROVEEDOR3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT10");
            entity.Property(e => e.CSEGCONTPROVEEDOR4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT11");
            entity.Property(e => e.CSEGCONTPROVEEDOR5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT12");
            entity.Property(e => e.CSEGCONTPROVEEDOR6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT13");
            entity.Property(e => e.CSEGCONTPROVEEDOR7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSEGCONT14");
            entity.Property(e => e.CSITIOFTP)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CSITIOFTP");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CTEXTOEX03");
            entity.Property(e => e.CTEXTOEXTRA4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CTEXTOEX04");
            entity.Property(e => e.CTEXTOEXTRA5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CTEXTOEX05");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CTIMESTAMP");
            entity.Property(e => e.CUSOCFDI)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("P01", "DF_MGW10002_CUSOCFDI");
            entity.Property(e => e.CUSRFTP)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CUSRFTP");
            entity.Property(e => e.CWHATSAPP)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10002_CWHATSAPP");
        });

        modelBuilder.Entity<admComponentesPaquete>(entity =>
        {
            entity.HasKey(e => e.CIDCOMPONENTE);

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA1, e.CIDCOMPONENTE }, "CIDVALORCARACTERISTICA1");

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA2, e.CIDCOMPONENTE }, "CIDVALORCARACTERISTICA2");

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA3, e.CIDCOMPONENTE }, "CIDVALORCARACTERISTICA3");

            entity.HasIndex(e => new { e.CIDPAQUETE, e.CIDPRODUCTO, e.CIDVALORCARACTERISTICA1, e.CIDVALORCARACTERISTICA2, e.CIDVALORCARACTERISTICA3, e.CIDCOMPONENTE }, "IPAQPRODVALORESCARAC");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CTIPOPRODUCTO, e.CIDCOMPONENTE }, "IPRODUCTOTIPO");
        });

        modelBuilder.Entity<admConceptos>(entity =>
        {
            entity.HasKey(e => e.CIDCONCEPTODOCUMENTO);

            entity.HasIndex(e => e.CCODIGOCONCEPTO, "CCODIGOCONCEPTO");

            entity.HasIndex(e => new { e.CIDCUENTA, e.CIDCONCEPTODOCUMENTO }, "CIDCUENTA");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CIDCONCEPTODOCUMENTO }, "CIDDOCUMENTODE");

            entity.HasIndex(e => e.CIDCONCEPTODOCUMENTO, "DCIDCONCEPTODOCUMENTO");

            entity.HasIndex(e => new { e.CNOMBRECONCEPTO, e.CNATURALEZA, e.CIDCONCEPTODOCUMENTO }, "INOMBRENATURALEZA");

            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CCLAVESAT");
            entity.Property(e => e.CCODIGOCONCEPTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CCODIGOC01");
            entity.Property(e => e.CESTATUS).HasDefaultValue(1, "DF_MGW10006_CESTATUS");
            entity.Property(e => e.CFORMAPREIMPRESA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CFORMAPR01");
            entity.Property(e => e.CIDFIRMADSL)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CIDFIRMDSL");
            entity.Property(e => e.CMETODOPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CMETODOPAG");
            entity.Property(e => e.CNOMBRECONCEPTO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CNOMBREC01");
            entity.Property(e => e.CORDENCAPTURA)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CIDORDENCAPTURA");
            entity.Property(e => e.CPLAMIGCFD)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CPLAMIGCFD");
            entity.Property(e => e.CPREFIJOCONCEPTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CPREFICON");
            entity.Property(e => e.CREGIMFISC)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CREGIMFISC");
            entity.Property(e => e.CREPIMPCFD)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CREPIMPCFD");
            entity.Property(e => e.CRUTAENTREGA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CRUTAENT01");
            entity.Property(e => e.CSCCPTO2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CSCCPTO2");
            entity.Property(e => e.CSCCPTO3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CSCCPTO3");
            entity.Property(e => e.CSCMOVTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CSCMOVTO");
            entity.Property(e => e.CSEGCONTCONCEPTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CSEGCONT01");
            entity.Property(e => e.CSERIEPOROMISION)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CSERIEPO01");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CTIMESTAMP");
            entity.Property(e => e.CVERESQUE)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10006_CVERESQUE");
        });

        modelBuilder.Entity<admConceptosBack>(entity =>
        {
            entity.HasKey(e => e.CIDCONCEPTODOCUMENTO);

            entity.HasIndex(e => e.CCODIGOCONCEPTO, "CCODIGOCONCEPTO");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CIDCONCEPTODOCUMENTO }, "CIDDOCUMENTODE");

            entity.HasIndex(e => new { e.CNOMBRECONCEPTO, e.CNATURALEZA, e.CIDCONCEPTODOCUMENTO }, "INOMBRENATURALEZA");

            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CCLAVESAT");
            entity.Property(e => e.CCODIGOCONCEPTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CCODIGOC01");
            entity.Property(e => e.CFORMAPREIMPRESA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CFORMAPR01");
            entity.Property(e => e.CIDFIRMADSL)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CIDFIRMDSL");
            entity.Property(e => e.CMETODOPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CMETODOPAG");
            entity.Property(e => e.CNOMBRECONCEPTO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CNOMBREC01");
            entity.Property(e => e.CORDENCAPTURA)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CORDENCAPTURA");
            entity.Property(e => e.CPLAMIGCFD)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CPLAMIGCFD");
            entity.Property(e => e.CPREFIJOCONCEPTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CPREFICON");
            entity.Property(e => e.CREGIMFISC)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CREGIMFISC");
            entity.Property(e => e.CREPIMPCFD)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CREPIMPCFD");
            entity.Property(e => e.CRUTAENTREGA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CRUTAENT01");
            entity.Property(e => e.CSCCPTO2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CSCCPTO2");
            entity.Property(e => e.CSCCPTO3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CSCCPTO3");
            entity.Property(e => e.CSCMOVTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CSCMOVTO");
            entity.Property(e => e.CSEGCONTCONCEPTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CSEGCONT01");
            entity.Property(e => e.CSERIEPOROMISION)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CSERIEPO01");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CTIMESTAMP");
            entity.Property(e => e.CVERESQUE)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10006_CVERESQUE");
        });

        modelBuilder.Entity<admConfigProveedoresNube>(entity =>
        {
            entity.HasKey(e => e.CIDPROVEEDORSERVICIO);
        });

        modelBuilder.Entity<admConversionesUnidad>(entity =>
        {
            entity.HasKey(e => new { e.CIDUNIDAD1, e.CIDUNIDAD2 });

            entity.HasIndex(e => new { e.CIDUNIDAD2, e.CIDAUTOINCSQL }, "CIDUNIDAD2");

            entity.Property(e => e.CEXPRESIONFACTOR)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10027_CEXPRESIONFACTOR");
            entity.Property(e => e.CFACTORCONVERSION).HasDefaultValueSql("('')", "DF_MGW10027_CFACTORC01");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<admCostosHistoricos>(entity =>
        {
            entity.HasKey(e => e.CIDCOSTOH);

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CFECHACOSTOH }, "IPRODALMACENFECHA");

            entity.Property(e => e.CFECHACOSTOH)
                .HasDefaultValueSql("('18991230')", "DF_MGW10017_CFECHACO01")
                .HasColumnType("datetime");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10017_CTIMESTAMP");
        });

        modelBuilder.Entity<admCuentasBancarias>(entity =>
        {
            entity.HasKey(e => e.CIDCUENTA);

            entity.HasIndex(e => new { e.CNOMBRECUENTA, e.CESTATUS, e.CIDCUENTA }, "CNOMBRECUENTA");

            entity.HasIndex(e => new { e.CNUMEROCUENTA, e.CESTATUS, e.CIDCUENTA }, "CNUMEROCUENTA");

            entity.HasIndex(e => new { e.CIDCATALOGO, e.CTIPOCATALOGO, e.CIDCUENTA }, "IIDCATTIPO");

            entity.Property(e => e.CACCOUNTID)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CACCOUNTID");
            entity.Property(e => e.CCLABE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CCLABE");
            entity.Property(e => e.CCLAVE)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CCLAVE");
            entity.Property(e => e.CFECHAALTA)
                .HasDefaultValueSql("('18991230')", "DF_admCuentasBancarias_CFECHAALTA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHABAJA)
                .HasDefaultValueSql("('18991230')", "DF_admCuentasBancarias_CFECHABAJA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_admCuentasBancarias_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNOMBANEXT)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CNOMBANEXT");
            entity.Property(e => e.CNOMBRECUENTA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CNOMBRECUENTA");
            entity.Property(e => e.CNUMEROCUENTA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CNUMEROCUENTA");
            entity.Property(e => e.CRFCBANCO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CRFCBANCO");
            entity.Property(e => e.CSEGCONT01)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CSEGCONT01");
            entity.Property(e => e.CSEGCONT02)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CSEGCONT02");
            entity.Property(e => e.CSEGCONT03)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CSEGCONT03");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admCuentasBancarias_CTIMESTAMP");
        });

        modelBuilder.Entity<admDatosAddenda>(entity =>
        {
            entity.HasKey(e => new { e.IDADDENDA, e.TIPOCAT, e.IDCAT, e.NUMCAMPO });

            entity.HasIndex(e => new { e.TIPOCAT, e.IDCAT, e.CIDAUTOINCSQL }, "ITIPOCATCA");

            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.VALOR)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10046_VALOR");
        });

        modelBuilder.Entity<admDocumentos>(entity =>
        {
            entity.HasKey(e => e.CIDDOCUMENTO);

            entity.HasIndex(e => new { e.CFECHA, e.CIDDOCUMENTO }, "CFECHA");

            entity.HasIndex(e => new { e.CFECHAVENCIMIENTO, e.CIDDOCUMENTO }, "CFECHAVENCIMIENTO");

            entity.HasIndex(e => new { e.CIDAPERTURA, e.CIDDOCUMENTO }, "CIDAPERTURA");

            entity.HasIndex(e => new { e.CIDCOPIADE, e.CFECHA, e.CIDDOCUMENTO }, "CIDCOPIADE");

            entity.HasIndex(e => new { e.CIDCUENTA, e.CFECHA, e.CIDDOCUMENTO }, "CIDCUENTA");

            entity.HasIndex(e => new { e.CIDDOCUMENTOORIGEN, e.CIDDOCUMENTO }, "CIDDOCUMENTOORIGEN");

            entity.HasIndex(e => new { e.CIDMONEDA, e.CIDDOCUMENTO }, "CIDMONEDA");

            entity.HasIndex(e => new { e.CIDPREPOLIZA, e.CIDDOCUMENTO }, "CIDPREPOLIZA");

            entity.HasIndex(e => new { e.CIDPROYECTO, e.CFECHA, e.CIDDOCUMENTO }, "CIDPROYECTO");

            entity.HasIndex(e => new { e.CSISTORIG, e.CIDDOCUMENTO }, "CSISTORIG");

            entity.HasIndex(e => new { e.CIDAGENTE, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO, e.CIDDOCUMENTO }, "IAGENTEFECHASERIEFOLIO");

            entity.HasIndex(e => new { e.CNUMEROGUIA, e.CDESTINATARIO, e.CIDDOCUMENTO }, "IBANCOS");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CAFECTADO, e.CNATURALEZA, e.CFECHAVENCIMIENTO, e.CIDDOCUMENTO }, "ICLIENTEPROVAFECTANATVENC");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CIDCONCEPTODOCUMENTO, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO }, "ICLIENTEPROVCPTOFECHA");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO, e.CIDDOCUMENTO }, "ICLIENTEPROVEEDORFECHA");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CPENDIENTE, e.CAFECTADO, e.CNATURALEZA, e.CFECHAVENCIMIENTO, e.CIDDOCUMENTO }, "ICLIPENFEC");

            entity.HasIndex(e => new { e.CIDCONCEPTODOCUMENTO, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO }, "ICONCEPTOFECHA");

            entity.HasIndex(e => new { e.CIDCONCEPTODOCUMENTO, e.CFOLIO, e.CIDDOCUMENTO }, "ICONCEPTOFOLIO");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CIDDOCUMENTODE, e.CFECHAVENCIMIENTO, e.CIDDOCUMENTO }, "ICTEDOCTODEFECVENCCHQW");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CNATURALEZA, e.CPENDIENTE, e.CIDDOCUMENTO }, "ICTEPROVNATPEN");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CIDDOCUMENTOORIGEN, e.CIDDOCUMENTO }, "IDOCTODEDOCTOORIGEN");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CSERIEDOCUMENTO, e.CFOLIO, e.CIDDOCUMENTO }, "IDOCTODESERIEFOLIO");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CIDAGENTE, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO }, "IDOCUMENTODEAGENTEFECHA");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CIDCLIENTEPROVEEDOR, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO }, "IDOCUMENTODECLIENTEFECHA");

            entity.HasIndex(e => new { e.CIDDOCUMENTODE, e.CFECHA, e.CSERIEDOCUMENTO, e.CFOLIO }, "IDOCUMENTODEFECHASERIEFOL");

            entity.HasIndex(e => e.CCANCELADO, "RCCANCELADO");

            entity.HasIndex(e => new { e.CIDCLIENTEPROVEEDOR, e.CNATURALEZA, e.CAFECTADO, e.CFECHAVENCIMIENTO, e.CPENDIENTE }, "RIDCLINATAFEC");

            entity.Property(e => e.CCODIGOFACTURACION)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CCODIGOFACTURACION");
            entity.Property(e => e.CCONDIPAGO)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CCONDIPAGO");
            entity.Property(e => e.CCUENTAMENSAJERIA)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CCUENTAM01");
            entity.Property(e => e.CDATOSADICIONALES).IsUnicode(false);
            entity.Property(e => e.CDESTINATARIO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CDESTINA01");
            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAENTREGARECEPCION)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHAEN01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAFACTURACION)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHAFACTURACION")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAPRONTOPAGO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHAPR01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAULTIMOINTERES)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHAUL01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAVENCIMIENTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10008_CFECHAVE01")
                .HasColumnType("datetime");
            entity.Property(e => e.CGUIDDOCUMENTO)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CGUIDDOCUMENTO");
            entity.Property(e => e.CLUGAREXPE)
                .HasMaxLength(380)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CLUGAREXPE");
            entity.Property(e => e.CMENSAJERIA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CMENSAJE01");
            entity.Property(e => e.CMETODOPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CMETODOPAG");
            entity.Property(e => e.CNUMCTAPAG)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CNUMCTAPAG");
            entity.Property(e => e.CNUMEROGUIA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CNUMEROG01");
            entity.Property(e => e.COBSERVACIONES).HasColumnType("text");
            entity.Property(e => e.CRAZONSOCIAL)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CRAZONSO01");
            entity.Property(e => e.CREFERENCIA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CREFEREN01");
            entity.Property(e => e.CRFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CRFC");
            entity.Property(e => e.CSERIEDOCUMENTO)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CSERIEDO01");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CTEXTOEX03");
            entity.Property(e => e.CTICKETID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CTICKETID");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CTIMESTAMP");
            entity.Property(e => e.CTRANSACTIONID)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CTRANSACTIONID");
            entity.Property(e => e.CUSUARIO)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CUSUARIO");
            entity.Property(e => e.CVERESQUE)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10008_CVERESQUE");
        });

        modelBuilder.Entity<admDocumentosModelo>(entity =>
        {
            entity.HasKey(e => e.CIDDOCUMENTODE);

            entity.HasIndex(e => new { e.CDESCRIPCION, e.CIDDOCUMENTODE }, "CDESCRIPCION");

            entity.HasIndex(e => new { e.CIDASIENTOCONTABLE, e.CIDDOCUMENTODE }, "CIDASIENTOCONTABLE");

            entity.HasIndex(e => new { e.CIDCONCEPTODOCTOASUMIDO, e.CIDDOCUMENTODE }, "CIDCONCEPTODOCTOASUMIDO");

            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10007_CDESCRIP01");
        });

        modelBuilder.Entity<admDocumentosModelosBack>(entity =>
        {
            entity.HasKey(e => e.CIDDOCUMENTODE);

            entity.HasIndex(e => new { e.CDESCRIPCION, e.CIDDOCUMENTODE }, "CDESCRIPCION");

            entity.HasIndex(e => new { e.CIDASIENTOCONTABLE, e.CIDDOCUMENTODE }, "CIDASIENTOCONTABLE");

            entity.HasIndex(e => new { e.CIDCONCEPTODOCTOASUMIDO, e.CIDDOCUMENTODE }, "CIDCONCEPTODOCTOASUMIDO");

            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10007_CDESCRIP01");
        });

        modelBuilder.Entity<admDocumentosOrigen>(entity =>
        {
            entity.HasKey(e => e.CIDDOCUMENTO);

            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_admDocumentosOrigen_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CSERIE)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admDocumentosOrigen_CSERIE");
        });

        modelBuilder.Entity<admDomicilios>(entity =>
        {
            entity.HasKey(e => e.CIDDIRECCION);

            entity.HasIndex(e => new { e.CNOMBRECALLE, e.CIDDIRECCION }, "CNOMBRECALLE");

            entity.HasIndex(e => new { e.CTIPOCATALOGO, e.CIDDIRECCION }, "CTIPOCATALOGO");

            entity.HasIndex(e => new { e.CIDCATALOGO, e.CTIPOCATALOGO, e.CTIPODIRECCION, e.CIDDIRECCION }, "ICATTIPOCATTIPODIR");

            entity.HasIndex(e => new { e.CTIPOCATALOGO, e.CSUCURSAL, e.CIDDIRECCION }, "ITICATSUCU");

            entity.Property(e => e.CCIUDAD)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CCIUDAD");
            entity.Property(e => e.CCODIGOPOSTAL)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CCODIGOP01");
            entity.Property(e => e.CCOLONIA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CCOLONIA");
            entity.Property(e => e.CDIRECCIONWEB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CDIRECCI01");
            entity.Property(e => e.CEMAIL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CEMAIL");
            entity.Property(e => e.CESTADO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CESTADO");
            entity.Property(e => e.CMUNICIPIO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CMUNICIPIO");
            entity.Property(e => e.CNOMBRECALLE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CNOMBREC01");
            entity.Property(e => e.CNUMEROEXTERIOR)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CNUMEROE01");
            entity.Property(e => e.CNUMEROINTERIOR)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CNUMEROI01");
            entity.Property(e => e.CPAIS)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CPAIS");
            entity.Property(e => e.CSUCURSAL)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CSUCURSAL");
            entity.Property(e => e.CTELEFONO1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CTELEFONO1");
            entity.Property(e => e.CTELEFONO2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CTELEFONO2");
            entity.Property(e => e.CTELEFONO3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CTELEFONO3");
            entity.Property(e => e.CTELEFONO4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CTELEFONO4");
            entity.Property(e => e.CTEXTOEXTRA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CTEXTOEX01");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10011_CTIMESTAMP");
        });

        modelBuilder.Entity<admEjercicios>(entity =>
        {
            entity.HasKey(e => e.CIDEJERCICIO);

            entity.HasIndex(e => e.CNUMEROEJERCICIO, "CNUMEROEJERCICIO");

            entity.Property(e => e.CFECHAFINAL)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECHAFI01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO1)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO10)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP10")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO11)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP11")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO12)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP12")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO2)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP02")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO3)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP03")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO4)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP04")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO5)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP05")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO6)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP06")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO7)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP07")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO8)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP08")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECINIPERIODO9)
                .HasDefaultValueSql("('18991230')", "DF_MGW10031_CFECINIP09")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<admExistenciaCosto>(entity =>
        {
            entity.HasKey(e => e.CIDEXISTENCIA);

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDEJERCICIO, e.CBANCONGELADO, e.CIDEXISTENCIA }, "IALMACENEJERCONGELADO");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CTIPOEXISTENCIA, e.CIDEJERCICIO, e.CIDEXISTENCIA }, "IPRODALMACEN");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDEJERCICIO, e.CIDALMACEN, e.CTIPOEXISTENCIA }, "IPRODEJERALMACENTIPO");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDEJERCICIO, e.CTIPOEXISTENCIA, e.CIDEXISTENCIA }, "IPRODEJERTIPO");

            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10030_CTIMESTAMP");
        });

        modelBuilder.Entity<admFoliosDigitales>(entity =>
        {
            entity.HasKey(e => e.CIDFOLDIG);

            entity.HasIndex(e => new { e.CFECHACANC, e.CIDFOLDIG }, "CFECHACANC");

            entity.HasIndex(e => new { e.CIDDOCTO, e.CIDFOLDIG }, "CIDDOCTO");

            entity.HasIndex(e => new { e.CUUID, e.CIDFOLDIG }, "CUUID");

            entity.HasIndex(e => e.CIDDOCTO, "DCIDDOCTO");

            entity.HasIndex(e => new { e.CALIASBDCT, e.CIDFOLDIG }, "IALIASBDCT");

            entity.HasIndex(e => new { e.CIDDOCALDI, e.CIDFOLDIG }, "IDDOCALDI");

            entity.HasIndex(e => new { e.CIDDOCTODE, e.CSERIE, e.CFOLIO, e.CIDFOLDIG }, "IDOCDESEFO");

            entity.HasIndex(e => new { e.CCODCONCBA, e.CNUMCTABAN, e.CFOLIOBAN, e.CIDFOLDIG }, "IDOCTOBAN");

            entity.HasIndex(e => new { e.CESTADO, e.CIDDOCTODE, e.CIDCPTODOC, e.CFECHAEMI, e.CIDFOLDIG }, "IEDDECONFE");

            entity.HasIndex(e => new { e.CESTADO, e.CIDDOCTODE, e.CIDCPTODOC, e.CSERIE, e.CFOLIO }, "IEDODDECON");

            entity.HasIndex(e => new { e.CEJERPOL, e.CPERPOL, e.CTIPOPOL, e.CNUMPOL, e.CIDFOLDIG }, "IEJPETINOP");

            entity.HasIndex(e => new { e.CESTADO, e.CIDCPTODOC, e.CFECHAEMI, e.CIDFOLDIG }, "IESTCONFEC");

            entity.HasIndex(e => new { e.CESTADO, e.CIDDOCTODE, e.CFECHAEMI, e.CIDFOLDIG }, "IESTDOCFEC");

            entity.HasIndex(e => new { e.CESTADO, e.CENTREGADO, e.CFECHAEMI, e.CIDFOLDIG }, "IESTENTFEC");

            entity.HasIndex(e => new { e.CESTADO, e.CFECHAEMI, e.CIDFOLDIG }, "IESTFECHA");

            entity.HasIndex(e => new { e.CESTADO, e.CRFC, e.CFECHAEMI, e.CIDFOLDIG }, "IESTRFCFEC");

            entity.HasIndex(e => new { e.CESTADO, e.CSERIE, e.CFOLIO }, "IESTSERFO1");

            entity.HasIndex(e => new { e.CESTADO, e.CSERIEREC, e.CFOLIOREC }, "IESTSERFO2");

            entity.HasIndex(e => new { e.CESTADO, e.CTIPO, e.CENTREGADO, e.CFECHAEMI, e.CIDFOLDIG }, "IESTTENFEC");

            entity.HasIndex(e => new { e.CESTADO, e.CTIPO, e.CFECHAEMI, e.CIDFOLDIG }, "IESTTIPFEC");

            entity.HasIndex(e => new { e.CESTADO, e.CTIPO, e.CRFC, e.CFECHAEMI, e.CIDFOLDIG }, "IESTTIPRFC");

            entity.HasIndex(e => new { e.CNOAPROB, e.CIDDOCTODE, e.CIDCPTODOC, e.CESTADO, e.CIDFOLDIG }, "INAPDDCONE");

            entity.HasIndex(e => new { e.CNOAPROB, e.CIDDOCTODE, e.CIDCPTODOC, e.CSERIE, e.CFOLIO }, "INAPDDECON");

            entity.HasIndex(e => new { e.CNOAPROB, e.CSERIE, e.CFOLIO }, "INAPRSERFO");

            entity.HasIndex(e => new { e.CNOORDEN, e.CIDDOCTODE, e.CIDCPTODOC, e.CESTADO, e.CIDFOLDIG }, "IORDDDCONE");

            entity.HasIndex(e => new { e.CNOORDEN, e.CIDDOCTODE, e.CIDCPTODOC, e.CSERIE, e.CFOLIO }, "IORDDDECON");

            entity.HasIndex(e => new { e.CTIPO, e.CSERIEREC, e.CFOLIOREC, e.CRFC }, "ITISEFORFC");

            entity.HasIndex(e => new { e.CESTRAD, e.CIDDOCTODE, e.CIDCPTODOC, e.CSERIE, e.CFOLIO, e.CESTADO }, "ITRDDECON");

            entity.HasIndex(e => new { e.CESTRAD, e.CIDDOCTODE, e.CIDCPTODOC, e.CFECHAEMI, e.CESTADO, e.CIDFOLDIG }, "ITRDECONFE");

            entity.Property(e => e.CACUSECAN)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CACUSECAN");
            entity.Property(e => e.CALIASBDCT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CALIASBDCT");
            entity.Property(e => e.CARCHCBB)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CARCHCBB");
            entity.Property(e => e.CARCHDIDIS)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CARCHDIDIS");
            entity.Property(e => e.CCADPEDI).HasColumnType("text");
            entity.Property(e => e.CCODCONCBA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CCODCONCBA");
            entity.Property(e => e.CDESCAUT01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CDESCAUT01");
            entity.Property(e => e.CDESCAUT02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CDESCAUT02");
            entity.Property(e => e.CDESCAUT03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CDESCAUT03");
            entity.Property(e => e.CDESCONCBA)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CDESCONCBA");
            entity.Property(e => e.CDESESTADO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CDESESTADO");
            entity.Property(e => e.CDESPAGBAN)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CDESPAGBAN");
            entity.Property(e => e.CEMAIL)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CEMAIL");
            entity.Property(e => e.CFECAPROB)
                .HasDefaultValueSql("('18991230')", "DF_MGW10045_CFECAPROB")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACANC)
                .HasDefaultValueSql("('18991230')", "DF_MGW10045_CFECHACANC")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEMI)
                .HasDefaultValueSql("('18991230')", "DF_MGW10045_CFECHAEMI")
                .HasColumnType("datetime");
            entity.Property(e => e.CFINVIG)
                .HasDefaultValueSql("('18991230')", "DF_MGW10045_CFINVIG")
                .HasColumnType("datetime");
            entity.Property(e => e.CFOLIOBAN)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CFOLIOBAN");
            entity.Property(e => e.CFOLIOREC).HasDefaultValue(0.0, "DF_MGW10045_CFOLIOREC");
            entity.Property(e => e.CHORACANC)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CHORACANC");
            entity.Property(e => e.CHORAEMI)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CHORAEMI");
            entity.Property(e => e.CIDDOCTODSL)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CIDDOCDSL");
            entity.Property(e => e.CINIVIG)
                .HasDefaultValueSql("('18991230')", "DF_MGW10045_CINIVIG")
                .HasColumnType("datetime");
            entity.Property(e => e.CNUMCTABAN)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CNUMCTABAN");
            entity.Property(e => e.COBSERVA01)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_COBSERVA01");
            entity.Property(e => e.CRAZON)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CRAZON");
            entity.Property(e => e.CREFEREN01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CREFEREN01");
            entity.Property(e => e.CRFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CRFC");
            entity.Property(e => e.CSERIE)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CSERIE");
            entity.Property(e => e.CSERIEREC)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CSERIEREC");
            entity.Property(e => e.CTIPO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CTIPO");
            entity.Property(e => e.CTIPOLDESC)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CTIPOLDESC");
            entity.Property(e => e.CUSUAUTBAN)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CUSUAUTBAN");
            entity.Property(e => e.CUSUBAN01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CUSUBAN01");
            entity.Property(e => e.CUSUBAN02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CUSUBAN02");
            entity.Property(e => e.CUSUBAN03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CUSUBAN03");
            entity.Property(e => e.CUUID)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10045_CUUID");
        });

        modelBuilder.Entity<admFormasPago>(entity =>
        {
            entity.HasKey(e => e.CIDFORMAPAGO);

            entity.HasIndex(e => e.CCODIGOFORMAPAGO, "CCODIGOFORMA").IsUnique();

            entity.HasIndex(e => new { e.CFECHAALTA, e.CIDFORMAPAGO }, "CFECHAALTA");

            entity.HasIndex(e => e.CNOMBREFORMAPAGO, "CNOMBREFORMAPAGO").IsUnique();

            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CCLAVESAT");
            entity.Property(e => e.CCODIGOFORMAPAGO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CCODIGOFORMA");
            entity.Property(e => e.CFECHAALTA)
                .HasDefaultValueSql("('18991230')", "DF_admFormasPago_CFECHAALTA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHABAJA)
                .HasDefaultValueSql("('18991230')", "DF_admFormasPago_CFECHABAJA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_admFormasPago_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CIDMONEDA).HasDefaultValue(1, "DF_admFormasPago_CIDMONEDA");
            entity.Property(e => e.CNOMBREFORMAPAGO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CNOMBREFORMA");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admFormasPago_CTIMESTAMP");
        });

        modelBuilder.Entity<admLigasPago>(entity =>
        {
            entity.HasKey(e => e.CIDLIGA);

            entity.HasIndex(e => e.CIDCLIENTEPROVEEDOR, "CIDCLIENTEPROVEEDOR");

            entity.HasIndex(e => e.CIDDOCTOABONO, "CIDDOCTOABONO");

            entity.Property(e => e.CFECHAFINVIG)
                .HasDefaultValueSql("('18991230')", "DF_admLigasPago_CFECHAFINVIG")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAINIVIG)
                .HasDefaultValueSql("('18991230')", "DF_admLigasPago_CFECHAINIVIG")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAPAGO)
                .HasDefaultValueSql("('18991230')", "DF_admLigasPago_CFECHAPAGO")
                .HasColumnType("datetime");
            entity.Property(e => e.CGUIDEXTERNALREF)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admLigasPago_CGUIDEXTERNALREF");
            entity.Property(e => e.CGUIDLIGA)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admLigasPago_CGUIDLIGA");
            entity.Property(e => e.CLIGA).IsUnicode(false);
        });

        modelBuilder.Entity<admMaximosMinimos>(entity =>
        {
            entity.HasKey(e => new { e.CIDALMACEN, e.CIDPRODUCTO });

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDAUTOINCSQL }, "CIDPRODUCTO");

            entity.HasIndex(e => new { e.CIDPRODUCTOPADRE, e.CIDAUTOINCSQL }, "CIDPRODUCTOPADRE");

            entity.Property(e => e.CANAQUEL)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10016_CANAQUEL");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CPASILLO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10016_CPASILLO");
            entity.Property(e => e.CREPISA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10016_CREPISA");
            entity.Property(e => e.CZONA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10016_CZONA");
        });

        modelBuilder.Entity<admMensajes>(entity =>
        {
            entity.HasKey(e => e.CMESSAGEID);

            entity.HasIndex(e => new { e.CINBOXID, e.CMESSAGEID }, "IINBOXID").IsUnique();

            entity.HasIndex(e => new { e.CINBOXID, e.CSTATUS, e.CQUEUEDAT, e.CMESSAGEID }, "IINBOXSTATUSDATE");

            entity.HasIndex(e => new { e.CSTATUS, e.CQUEUEDAT }, "ISTATUSDATE");

            entity.Property(e => e.CMESSAGEID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CMESSAGEID");
            entity.Property(e => e.CALIAS)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CALIAS");
            entity.Property(e => e.CBODY).IsUnicode(false);
            entity.Property(e => e.CCONTENTENCODING)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CCONTENTENCODING");
            entity.Property(e => e.CCONTENTTYPE)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CCONTENTTYPE");
            entity.Property(e => e.CDATOS)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CDATOS");
            entity.Property(e => e.CDUEDATE)
                .HasDefaultValueSql("('18991230')", "DF_admMensajes_CDUEDATE")
                .HasColumnType("datetime");
            entity.Property(e => e.CERROR)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CERROR");
            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_admMensajes_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CHORA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("000000", "DF_admMensajes_CHORA");
            entity.Property(e => e.CINBOXID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CINBOXID");
            entity.Property(e => e.CPRIORITY)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CPRIORITY");
            entity.Property(e => e.CPROCESO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CPROCESO");
            entity.Property(e => e.CQUEUEDAT)
                .HasDefaultValueSql("('18991230')", "DF_admMensajes_CQUEUEDAT")
                .HasColumnType("datetime");
            entity.Property(e => e.CTAGS).IsUnicode(false);
            entity.Property(e => e.CUSUARIO)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMensajes_CUSUARIO");
        });

        modelBuilder.Entity<admMonedas>(entity =>
        {
            entity.HasKey(e => e.CIDMONEDA);

            entity.HasIndex(e => e.CNOMBREMONEDA, "CNOMBREMONEDA");

            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CCLAVESAT");
            entity.Property(e => e.CDESCRIPCIONPROTEGIDA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CDESCRIP01");
            entity.Property(e => e.CNOMBREMONEDA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CNOMBREM01");
            entity.Property(e => e.CPLURAL)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CPLURAL");
            entity.Property(e => e.CSIMBOLOMONEDA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CSIMBOLO01");
            entity.Property(e => e.CSINGULAR)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CSINGULAR");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10034_CTIMESTAMP");
        });

        modelBuilder.Entity<admMovimientos>(entity =>
        {
            entity.HasKey(e => e.CIDMOVIMIENTO);

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDMOVIMIENTO }, "CIDALMACEN");

            entity.HasIndex(e => new { e.CIDMOVTODESTINO, e.CIDMOVIMIENTO }, "CIDMOVTODESTINO");

            entity.HasIndex(e => new { e.CIDMOVTOORIGEN, e.CIDMOVIMIENTO }, "CIDMOVTOORIGEN");

            entity.HasIndex(e => e.CIDMOVIMIENTO, "DCIDMOVIMIENTO");

            entity.HasIndex(e => new { e.CAFECTADOSALDOS, e.CIDMOVIMIENTO }, "IAFECTASALDOS");

            entity.HasIndex(e => new { e.CIDDOCUMENTO, e.CNUMEROMOVIMIENTO }, "IDOCTONUMEROMOVTO");

            entity.HasIndex(e => new { e.CIDDOCUMENTO, e.CIDPRODUCTO, e.CIDMOVIMIENTO }, "IDOCTOPROD");

            entity.HasIndex(e => new { e.CAFECTAEXISTENCIA, e.CAFECTADOINVENTARIO, e.CIDMOVIMIENTO }, "IEXISTENCIAAFECTADO");

            entity.HasIndex(e => new { e.CMOVTOOCULTO, e.CIDMOVTOOWNER, e.CAFECTAEXISTENCIA, e.CIDMOVIMIENTO }, "IMOVTOOCULTOOWNER");

            entity.HasIndex(e => new { e.CIDMOVTOOWNER, e.CAFECTAEXISTENCIA, e.CIDMOVIMIENTO }, "IMOVTOOWNERAFECTAEXIST");

            entity.HasIndex(e => new { e.CIDMOVTOOWNER, e.CIDMOVIMIENTO }, "IMOVTOOWNERMOVTO");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CIDDOCUMENTODE, e.CFECHA, e.CIDMOVIMIENTO }, "IPROALMD02");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CIDMOVTOOWNER, e.CTIPOTRASPASO, e.CIDMOVIMIENTO }, "IPRODALMACENOWNERTRASP");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CAFECTADOINVENTARIO, e.CFECHA, e.CIDMOVIMIENTO }, "IPRODUCTOALMACENAFECFECHA");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CFECHA, e.CAFECTAEXISTENCIA, e.CIDMOVIMIENTO }, "IPRODUCTOALMACENFECHAAFEC");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDDOCUMENTODE, e.CAFECTADOINVENTARIO, e.CFECHA, e.CIDMOVIMIENTO }, "IPRODUCTODOCTODEAFECFECHA");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CFECHA, e.CAFECTAEXISTENCIA, e.CIDMOVIMIENTO }, "IPRODUCTOFECHAAFECTA");

            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10010_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10010_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.COBJIMPU01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_COBJIMPU01");
            entity.Property(e => e.COBSERVAMOV).HasColumnType("text");
            entity.Property(e => e.CREFERENCIA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_CREFEREN01");
            entity.Property(e => e.CSCMOVTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_CSCMOVTO");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10010_CTIMESTAMP");
        });

        modelBuilder.Entity<admMovimientosCapas>(entity =>
        {
            entity.HasKey(e => new { e.CIDMOVIMIENTO, e.CIDCAPA });

            entity.HasIndex(e => new { e.CFECHA, e.CIDAUTOINCSQL }, "CFECHA");

            entity.HasIndex(e => new { e.CIDCAPA, e.CFECHA, e.CIDAUTOINCSQL }, "ICAPAFECHA");

            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10028_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<admMovimientosContables>(entity =>
        {
            entity.HasKey(e => e.CIDMOVIMIENTOCONTABLE);

            entity.HasIndex(e => new { e.CIDASIENTOCONTABLE, e.CIDMOVIMIENTOCONTABLE }, "IASIENTOMOVTOCONTABLE");

            entity.Property(e => e.CCONCEPTO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10024_CCONCEPTO");
            entity.Property(e => e.CCUENTA)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10024_CCUENTA");
            entity.Property(e => e.CDIARIO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10024_CDIARIO");
            entity.Property(e => e.CREFERENCIA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10024_CREFEREN01");
            entity.Property(e => e.CSEGNEG)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10024_CSEGNEG");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10024_CTIMESTAMP");
        });

        modelBuilder.Entity<admMovimientosPrepoliza>(entity =>
        {
            entity.HasKey(e => e.CIDMOVIMIENTOPREPOLIZA);

            entity.HasIndex(e => new { e.CIDPREPOLIZA, e.CUENTA, e.TIPOPOL, e.CIDMOVIMIENTOPREPOLIZA }, "IPREPOLIZACUENTATIPO");

            entity.HasIndex(e => new { e.CIDPREPOLIZA, e.MOVTO }, "IPREPOLIZAMOVTO");

            entity.Property(e => e.CONCEPTO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10039_CONCEPTO");
            entity.Property(e => e.CUENTA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10039_CUENTA");
            entity.Property(e => e.DIARIO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10039_DIARIO");
            entity.Property(e => e.FECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10039_FECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.REFERENCIA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10039_REFERENCIA");
            entity.Property(e => e.SEGNEG)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10039_SEGNEG");
        });

        modelBuilder.Entity<admMovimientosSerie>(entity =>
        {
            entity.HasKey(e => new { e.CIDMOVIMIENTO, e.CIDSERIE });

            entity.HasIndex(e => new { e.CIDSERIE, e.CIDAUTOINCSQL }, "CIDSERIE");

            entity.HasIndex(e => new { e.CIDSERIE, e.CFECHA, e.CIDAUTOINCSQL }, "ISERIEFECHA");

            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10036_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<admMovtosBancarios>(entity =>
        {
            entity.HasKey(e => e.CTRANSACTIONID);

            entity.HasIndex(e => e.CTRANSACTIONID, "CTRANSACTIONID").IsUnique();

            entity.HasIndex(e => new { e.CIDCUENTA, e.CFECHA }, "ICUENTAFECHA");

            entity.HasIndex(e => new { e.CIDDOCUMENTO, e.CFECHA }, "IDOCUMENTOFECHA");

            entity.Property(e => e.CTRANSACTIONID)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CTRANSACTIONID");
            entity.Property(e => e.CACCOUNTID)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CACCOUNTID");
            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CDESCRIPCION");
            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_admMovtosBancarios_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_admMovtosBancarios_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CREFERENCIA)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CREFERENCIA");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosBancarios_CTIMESTAMP");
        });

        modelBuilder.Entity<admMovtosCEPs>(entity =>
        {
            entity.HasKey(e => e.CIDMOVTOCEP);

            entity.HasIndex(e => e.CIDDOCUMENTO, "CIDDOCUMENTO");

            entity.HasIndex(e => new { e.CESTADO, e.CFECHA, e.CHORA }, "IEDOFECHA");

            entity.Property(e => e.CARCHIVO)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CARCHIVO");
            entity.Property(e => e.CCADENA).HasColumnType("text");
            entity.Property(e => e.CCERTIFICADO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CCERTIFICADO");
            entity.Property(e => e.CCLAVE)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CCLAVE");
            entity.Property(e => e.CCONCEPTO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CCONCEPTO");
            entity.Property(e => e.CEBANCO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CEBANCO");
            entity.Property(e => e.CECUENTA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CECUENTA");
            entity.Property(e => e.CENOMBRE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CENOMBRE");
            entity.Property(e => e.CERFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CERFC");
            entity.Property(e => e.CETIPOCTA)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CETIPOCTA");
            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_admMovtosCEPs_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_admMovtosCEPs_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CHORA)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("00000000", "DF_admMovtosCEPs_CHORA");
            entity.Property(e => e.CRBANCO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CRBANCO");
            entity.Property(e => e.CRCUENTA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CRCUENTA");
            entity.Property(e => e.CRNOMBRE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CRNOMBRE");
            entity.Property(e => e.CRRFC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CRRFC");
            entity.Property(e => e.CRTIPOCTA)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CRTIPOCTA");
            entity.Property(e => e.CSELLO)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CSELLO");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admMovtosCEPs_CTIMESTAMP");
        });

        modelBuilder.Entity<admMovtosInvFisico>(entity =>
        {
            entity.HasKey(e => e.CIDMOVIMIENTO);

            entity.HasIndex(e => new { e.CIDALMACEN, e.CMOVTOOCULTO, e.CIDPRODUCTO, e.CIDMOVIMIENTO }, "IALMACENMOVTOOCULTO");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CMOVTOOCULTO, e.CIDMOVIMIENTO }, "IALMACENOCULTOMOVTO");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CIDMOVIMIENTO }, "IALMACENPRODUCTO");

            entity.HasIndex(e => new { e.CMOVTOOCULTO, e.CIDMOVTOOWNER, e.CIDMOVIMIENTO }, "IMOVTOOCULTOOWNER");

            entity.HasIndex(e => new { e.CIDMOVTOOWNER, e.CIDPRODUCTO, e.CIDMOVIMIENTO }, "IMOVTOOWNERPRODUCTO");
        });

        modelBuilder.Entity<admMovtosInvFisicoSerieCa>(entity =>
        {
            entity.HasKey(e => e.CIDSERIECAPA);

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CPEDIMENTO, e.CNUMEROLOTE, e.CIDSERIECAPA }, "IALMACEN04");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CPEDIMENTO, e.CIDCAPA, e.CIDSERIECAPA }, "IALMACEN05");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CNUMEROLOTE, e.CIDCAPA, e.CIDSERIECAPA }, "IALMACEN06");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CPEDIMENTO, e.CNUMEROLOTE, e.CIDCAPA, e.CIDSERIECAPA }, "IALMACEN07");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CNUMEROLOTE, e.CIDSERIECAPA }, "IALMACENPRODUCTOLOTE");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CPEDIMENTO, e.CIDSERIECAPA }, "IALMACENPRODUCTOPEDIMENTO");

            entity.HasIndex(e => new { e.CIDALMACEN, e.CIDPRODUCTO, e.CNUMEROSERIE }, "IALMACENPRODUCTOSERIE");

            entity.HasIndex(e => new { e.CIDMOVTOINVENTARIOFISICO, e.CNUMEROSERIE }, "IMOVTOINVENTARIOSERIE");

            entity.HasIndex(e => new { e.CIDMOVTOINVENTARIOFISICO, e.CNUMEROLOTE, e.CIDSERIECAPA }, "IMOVTONUMEROLOTE");

            entity.HasIndex(e => new { e.CIDMOVTOINVENTARIOFISICO, e.CPEDIMENTO, e.CIDSERIECAPA }, "IMOVTOPEDIMENTO");

            entity.HasIndex(e => new { e.CTIPO, e.CIDMOVTOINVENTARIOFISICO, e.CIDSERIECAPA }, "ITIPOMOVIMIENTO");

            entity.Property(e => e.CADUANA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10040_CADUANA");
            entity.Property(e => e.CFECHACADUCIDAD)
                .HasDefaultValueSql("('18991230')", "DF_MGW10040_CFECHACA01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAFABRICACION)
                .HasDefaultValueSql("('18991230')", "DF_MGW10040_CFECHAFA01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAPEDIMENTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10040_CFECHAPE01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNUMEROLOTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10040_CNUMEROL01");
            entity.Property(e => e.CNUMEROSERIE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10040_CNUMEROS01");
            entity.Property(e => e.CPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10040_CPEDIMENTO");
        });

        modelBuilder.Entity<admNumerosSerie>(entity =>
        {
            entity.HasKey(e => e.CIDSERIE);

            entity.HasIndex(e => new { e.CNUMEROSERIE, e.CIDPRODUCTO }, "INUMEROSERIEPRODUCTO");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CESTADO, e.CNUMEROSERIE }, "IPRODALMACENESTADOSERIE");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDALMACEN, e.CNUMEROSERIE }, "IPRODALMACENSERIE");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CNUMEROSERIE }, "IPRODNOSER");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CFECHACADUCIDAD, e.CIDSERIE }, "IPRODUCTOFECHACADUCIDAD");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CFECHAPEDIMENTO, e.CIDSERIE }, "IPRODUCTOFECHAPEDIMENTO");

            entity.HasIndex(e => new { e.CIDPRODUCTO, e.CIDSERIE }, "IPRODUCTOSERIE");

            entity.Property(e => e.CADUANA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10032_CADUANA");
            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10032_CCLAVESAT");
            entity.Property(e => e.CFECHACADUCIDAD)
                .HasDefaultValueSql("('18991230')", "DF_MGW10032_CFECHACA01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAFABRICACION)
                .HasDefaultValueSql("('18991230')", "DF_MGW10032_CFECHAFA01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAPEDIMENTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10032_CFECHAPE01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNUMEROLOTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10032_CNUMEROL01");
            entity.Property(e => e.CNUMEROSERIE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10032_CNUMEROS01");
            entity.Property(e => e.CPEDIMENTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10032_CPEDIMENTO");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10032_CTIMESTAMP");
        });

        modelBuilder.Entity<admPagoNotas>(entity =>
        {
            entity.HasKey(e => e.CIDPAGO);

            entity.HasIndex(e => new { e.CTIPO, e.CIDDOCUMENTO, e.CIDFORMAPAGO, e.CIDPAGO }, "ITIPODOCTOFORMA");

            entity.Property(e => e.CIDMONEDA).HasDefaultValue(1, "DF_admPagoNotas_CIDMONEDA");
            entity.Property(e => e.CREFERENCIA)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admPagoNotas_CREFERENCIA");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admPagoNotas_CTIMESTAMP");
            entity.Property(e => e.CTIPOCAMBIO).HasDefaultValue(1.0, "DF_admPagoNotas_CTIPOCAMBIO");
        });

        modelBuilder.Entity<admParametros>(entity =>
        {
            entity.HasKey(e => e.CIDEMPRESA);

            entity.HasIndex(e => new { e.CVALIDACFD, e.CIDEMPRESA }, "CVALIDACFD");

            entity.Property(e => e.CADJUNTO1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CADJUNTO1");
            entity.Property(e => e.CADJUNTO2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CADJUNTO2");
            entity.Property(e => e.CASUNTO)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CASUNTO");
            entity.Property(e => e.CAUTRVOE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CAUTRVOE");
            entity.Property(e => e.CCORREOPRU)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CCORREOPRU");
            entity.Property(e => e.CCUENTAESTATAL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CCUENTAE01");
            entity.Property(e => e.CCUERPO).HasColumnType("text");
            entity.Property(e => e.CCURPEMPRESA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CCURPEMP01");
            entity.Property(e => e.CFECAJ2010)
                .HasDefaultValueSql("('18991230')", "DF_MGW10000_CFECAJ2010")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECDONAT)
                .HasDefaultValueSql("('18991230')", "DF_MGW10000_CFECDONAT")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACIERRE)
                .HasDefaultValueSql("('18991230')", "DF_MGW10000_CFECHACI01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACONGELAMIENTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10000_CFECHACO01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFIRMA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CFIRMA");
            entity.Property(e => e.CGUIDDSL)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CGUIDDSL");
            entity.Property(e => e.CGUIDEMPRESA)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CGUIDEMPRESA");
            entity.Property(e => e.CHOST)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CHOST");
            entity.Property(e => e.CHOSTPROXY)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CHOSTPROXY");
            entity.Property(e => e.CHOSTSMTP)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CHOSTSMTP");
            entity.Property(e => e.CIDPORTALFACT)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CIDPORTALFACT");
            entity.Property(e => e.CINBOXID)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CINBOXID");
            entity.Property(e => e.CLEYENDON)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CLEYENDON");
            entity.Property(e => e.CLEYENDON1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CLEYENDON1");
            entity.Property(e => e.CLEYENDON2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CLEYENDON2");
            entity.Property(e => e.CMASCARILLAAGENTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMASCARI04");
            entity.Property(e => e.CMASCARILLAALMACEN)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMASCARI03");
            entity.Property(e => e.CMASCARILLACLIENTES)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMASCARI01");
            entity.Property(e => e.CMASCARILLACURP)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMASCARI06");
            entity.Property(e => e.CMASCARILLAPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMASCARI02");
            entity.Property(e => e.CMASCARILLARFC)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMASCARI05");
            entity.Property(e => e.CMOVFECEX1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVFECEX1");
            entity.Property(e => e.CMOVIMPEX1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVIMPEX1");
            entity.Property(e => e.CMOVIMPEX2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVIMPEX2");
            entity.Property(e => e.CMOVIMPEX3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVIMPEX3");
            entity.Property(e => e.CMOVIMPEX4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVIMPEX4");
            entity.Property(e => e.CMOVTEXEX1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVTEXEX1");
            entity.Property(e => e.CMOVTEXEX2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVTEXEX2");
            entity.Property(e => e.CMOVTEXEX3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CMOVTEXEX3");
            entity.Property(e => e.CNOMBRECORTO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREC01");
            entity.Property(e => e.CNOMBREDESCUENTODOC1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED06");
            entity.Property(e => e.CNOMBREDESCUENTODOC2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED07");
            entity.Property(e => e.CNOMBREDESCUENTOMOV1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED01");
            entity.Property(e => e.CNOMBREDESCUENTOMOV2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED02");
            entity.Property(e => e.CNOMBREDESCUENTOMOV3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED03");
            entity.Property(e => e.CNOMBREDESCUENTOMOV4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED04");
            entity.Property(e => e.CNOMBREDESCUENTOMOV5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRED05");
            entity.Property(e => e.CNOMBREEMPRESA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREE01");
            entity.Property(e => e.CNOMBREGASTO1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREG01");
            entity.Property(e => e.CNOMBREGASTO2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREG02");
            entity.Property(e => e.CNOMBREGASTO3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREG03");
            entity.Property(e => e.CNOMBREIMPUESTO1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREI01");
            entity.Property(e => e.CNOMBREIMPUESTO2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREI02");
            entity.Property(e => e.CNOMBREIMPUESTO3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREI03");
            entity.Property(e => e.CNOMBRELISTA1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL01");
            entity.Property(e => e.CNOMBRELISTA10)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL10");
            entity.Property(e => e.CNOMBRELISTA2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL02");
            entity.Property(e => e.CNOMBRELISTA3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL03");
            entity.Property(e => e.CNOMBRELISTA4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL04");
            entity.Property(e => e.CNOMBRELISTA5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL05");
            entity.Property(e => e.CNOMBRELISTA6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL06");
            entity.Property(e => e.CNOMBRELISTA7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL07");
            entity.Property(e => e.CNOMBRELISTA8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL08");
            entity.Property(e => e.CNOMBRELISTA9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBREL09");
            entity.Property(e => e.CNOMBRERETENCION1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRER01");
            entity.Property(e => e.CNOMBRERETENCION2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNOMBRER02");
            entity.Property(e => e.CNUMDONAT)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CNUMDONAT");
            entity.Property(e => e.CPORTALDIASFACT).HasDefaultValue(1, "DF_MGW10000_CPORTALDIASF");
            entity.Property(e => e.CPORTALTIPOFACT).HasDefaultValue(1, "DF_MGW10000_CPORTALTIPOFACT");
            entity.Property(e => e.CPROVEEDOROAUTH)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CPROVEEDOROAUTH");
            entity.Property(e => e.CREFRESHTOKENCN)
                .HasDefaultValueSql("(NULL)", "DF_admParametros_CREFRESHTOKENCN")
                .HasColumnType("text");
            entity.Property(e => e.CREGIMFISC)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CREGIMFISC");
            entity.Property(e => e.CREGISTROCAMARA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CREGISTR01");
            entity.Property(e => e.CREPRESENTANTELEGAL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CREPRESE01");
            entity.Property(e => e.CRFCEMPRESA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CRFCEMPR01");
            entity.Property(e => e.CRUTACONTPAQ)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CRUTACON01");
            entity.Property(e => e.CRUTAEMPRESAPRED)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CRUTAEMP01");
            entity.Property(e => e.CRUTAENTREGA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CRUTAENT01");
            entity.Property(e => e.CRUTAPLA01)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CRUTAPLA01");
            entity.Property(e => e.CRUTAPLA02)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CRUTAPLA02");
            entity.Property(e => e.CSEGCIVA10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCIVA10");
            entity.Property(e => e.CSEGCIVA11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCIVA11");
            entity.Property(e => e.CSEGCIVA15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCIVA15");
            entity.Property(e => e.CSEGCIVA16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCIVA16");
            entity.Property(e => e.CSEGCIVA8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCIVA8");
            entity.Property(e => e.CSEGCIVAOT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCIVAOT");
            entity.Property(e => e.CSEGCONTGENERAL1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT01");
            entity.Property(e => e.CSEGCONTGENERAL10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT10");
            entity.Property(e => e.CSEGCONTGENERAL11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT11");
            entity.Property(e => e.CSEGCONTGENERAL2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT02");
            entity.Property(e => e.CSEGCONTGENERAL3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT03");
            entity.Property(e => e.CSEGCONTGENERAL4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT04");
            entity.Property(e => e.CSEGCONTGENERAL5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT05");
            entity.Property(e => e.CSEGCONTGENERAL6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT06");
            entity.Property(e => e.CSEGCONTGENERAL7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT07");
            entity.Property(e => e.CSEGCONTGENERAL8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT08");
            entity.Property(e => e.CSEGCONTGENERAL9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGCONT09");
            entity.Property(e => e.CSEGPIVA10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGPIVA10");
            entity.Property(e => e.CSEGPIVA11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGPIVA11");
            entity.Property(e => e.CSEGPIVA15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGPIVA15");
            entity.Property(e => e.CSEGPIVA16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGPIVA16");
            entity.Property(e => e.CSEGPIVA8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGPIVA8");
            entity.Property(e => e.CSEGPIVAOT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CSEGPIVAOT");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CTIMESTAMP");
            entity.Property(e => e.CTOKENCN)
                .HasDefaultValueSql("(NULL)", "DF_admParametros_CTOKENCN")
                .HasColumnType("text");
            entity.Property(e => e.CURLWSTORE)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)", "DF_admParametros_CURLWSTORE");
            entity.Property(e => e.CUSRPROXY)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CUSRPROXY");
            entity.Property(e => e.CVALIDACFD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CVALIDACFD");
            entity.Property(e => e.CVERPOSI)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CVERPOSI");
            entity.Property(e => e.CVERSIONACTUAL)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10000_CVERSION01");
        });

        modelBuilder.Entity<admParametrosBack>(entity =>
        {
            entity.HasKey(e => e.CIDEMPRESA);

            entity.Property(e => e.CADJUNTO1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CADJUNTO1");
            entity.Property(e => e.CADJUNTO2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CADJUNTO2");
            entity.Property(e => e.CASUNTO)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CASUNTO");
            entity.Property(e => e.CAUTRVOE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CAUTRVOE");
            entity.Property(e => e.CCORREOPRU)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CCORREOPRU");
            entity.Property(e => e.CCUENTAESTATAL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CCUENTAE01");
            entity.Property(e => e.CCUERPO).HasColumnType("text");
            entity.Property(e => e.CCURPEMPRESA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CCURPEMP01");
            entity.Property(e => e.CFECAJ2010)
                .HasDefaultValueSql("('18991230')", "DF_BACK10000_CFECAJ2010")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECDONAT)
                .HasDefaultValueSql("('18991230')", "DF_BACK10000_CFECDONAT")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACIERRE)
                .HasDefaultValueSql("('18991230')", "DF_BACK10000_CFECHACI01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHACONGELAMIENTO)
                .HasDefaultValueSql("('18991230')", "DF_BACK10000_CFECHACO01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFIRMA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CFIRMA");
            entity.Property(e => e.CGUIDDSL)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CGUIDDSL");
            entity.Property(e => e.CGUIDEMPRESA)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CGUIDEMPRESA");
            entity.Property(e => e.CHOST)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CHOST");
            entity.Property(e => e.CHOSTPROXY)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CHOSTPROXY");
            entity.Property(e => e.CHOSTSMTP)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CHOSTSMTP");
            entity.Property(e => e.CLEYENDON1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CLEYENDON1");
            entity.Property(e => e.CLEYENDON2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CLEYENDON2");
            entity.Property(e => e.CMASCARILLAAGENTE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMASCARI04");
            entity.Property(e => e.CMASCARILLAALMACEN)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMASCARI03");
            entity.Property(e => e.CMASCARILLACLIENTES)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMASCARI01");
            entity.Property(e => e.CMASCARILLACURP)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMASCARI06");
            entity.Property(e => e.CMASCARILLAPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMASCARI02");
            entity.Property(e => e.CMASCARILLARFC)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMASCARI05");
            entity.Property(e => e.CMOVFECEX1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVFECEX1");
            entity.Property(e => e.CMOVIMPEX1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVIMPEX1");
            entity.Property(e => e.CMOVIMPEX2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVIMPEX2");
            entity.Property(e => e.CMOVIMPEX3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVIMPEX3");
            entity.Property(e => e.CMOVIMPEX4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVIMPEX4");
            entity.Property(e => e.CMOVTEXEX1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVTEXEX1");
            entity.Property(e => e.CMOVTEXEX2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVTEXEX2");
            entity.Property(e => e.CMOVTEXEX3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CMOVTEXEX3");
            entity.Property(e => e.CNOMBRECORTO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREC01");
            entity.Property(e => e.CNOMBREDESCUENTODOC1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED06");
            entity.Property(e => e.CNOMBREDESCUENTODOC2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED07");
            entity.Property(e => e.CNOMBREDESCUENTOMOV1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED01");
            entity.Property(e => e.CNOMBREDESCUENTOMOV2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED02");
            entity.Property(e => e.CNOMBREDESCUENTOMOV3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED03");
            entity.Property(e => e.CNOMBREDESCUENTOMOV4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED04");
            entity.Property(e => e.CNOMBREDESCUENTOMOV5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRED05");
            entity.Property(e => e.CNOMBREEMPRESA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREE01");
            entity.Property(e => e.CNOMBREGASTO1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREG01");
            entity.Property(e => e.CNOMBREGASTO2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREG02");
            entity.Property(e => e.CNOMBREGASTO3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREG03");
            entity.Property(e => e.CNOMBREIMPUESTO1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREI01");
            entity.Property(e => e.CNOMBREIMPUESTO2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREI02");
            entity.Property(e => e.CNOMBREIMPUESTO3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREI03");
            entity.Property(e => e.CNOMBRELISTA1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL01");
            entity.Property(e => e.CNOMBRELISTA10)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL10");
            entity.Property(e => e.CNOMBRELISTA2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL02");
            entity.Property(e => e.CNOMBRELISTA3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL03");
            entity.Property(e => e.CNOMBRELISTA4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL04");
            entity.Property(e => e.CNOMBRELISTA5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL05");
            entity.Property(e => e.CNOMBRELISTA6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL06");
            entity.Property(e => e.CNOMBRELISTA7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL07");
            entity.Property(e => e.CNOMBRELISTA8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL08");
            entity.Property(e => e.CNOMBRELISTA9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBREL09");
            entity.Property(e => e.CNOMBRERETENCION1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRER01");
            entity.Property(e => e.CNOMBRERETENCION2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNOMBRER02");
            entity.Property(e => e.CNUMDONAT)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CNUMDONAT");
            entity.Property(e => e.CREFRESHTOKENCN)
                .HasDefaultValueSql("(NULL)", "DF_admParametrosBack_CREFRESHTOKENCN")
                .HasColumnType("text");
            entity.Property(e => e.CREGIMFISC)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CREGIMFISC");
            entity.Property(e => e.CREGISTROCAMARA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CREGISTR01");
            entity.Property(e => e.CREPRESENTANTELEGAL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CREPRESE01");
            entity.Property(e => e.CRFCEMPRESA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CRFCEMPR01");
            entity.Property(e => e.CRUTACONTPAQ)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CRUTACON01");
            entity.Property(e => e.CRUTAEMPRESAPRED)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CRUTAEMP01");
            entity.Property(e => e.CRUTAENTREGA)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CRUTAENT01");
            entity.Property(e => e.CRUTAPLA01)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CRUTAPLA01");
            entity.Property(e => e.CRUTAPLA02)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CRUTAPLA02");
            entity.Property(e => e.CSEGCIVA10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCIVA10");
            entity.Property(e => e.CSEGCIVA11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCIVA11");
            entity.Property(e => e.CSEGCIVA15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCIVA15");
            entity.Property(e => e.CSEGCIVA16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCIVA16");
            entity.Property(e => e.CSEGCIVAOT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCIVAOT");
            entity.Property(e => e.CSEGCONTGENERAL1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT01");
            entity.Property(e => e.CSEGCONTGENERAL10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT10");
            entity.Property(e => e.CSEGCONTGENERAL11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT11");
            entity.Property(e => e.CSEGCONTGENERAL2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT02");
            entity.Property(e => e.CSEGCONTGENERAL3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT03");
            entity.Property(e => e.CSEGCONTGENERAL4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT04");
            entity.Property(e => e.CSEGCONTGENERAL5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT05");
            entity.Property(e => e.CSEGCONTGENERAL6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT06");
            entity.Property(e => e.CSEGCONTGENERAL7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT07");
            entity.Property(e => e.CSEGCONTGENERAL8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT08");
            entity.Property(e => e.CSEGCONTGENERAL9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGCONT09");
            entity.Property(e => e.CSEGPIVA10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGPIVA10");
            entity.Property(e => e.CSEGPIVA11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGPIVA11");
            entity.Property(e => e.CSEGPIVA15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGPIVA15");
            entity.Property(e => e.CSEGPIVA16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGPIVA16");
            entity.Property(e => e.CSEGPIVAOT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CSEGPIVAOT");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CTIMESTAMP");
            entity.Property(e => e.CTOKENCN)
                .HasDefaultValueSql("(NULL)", "DF_admParametrosBack_CTOKENCN")
                .HasColumnType("text");
            entity.Property(e => e.CURLWSTORE)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)", "DF_admParametrosBack_CURLWSTORE");
            entity.Property(e => e.CUSRPROXY)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CUSRPROXY");
            entity.Property(e => e.CVALIDACFD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CVALIDACFD");
            entity.Property(e => e.CVERPOSI)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CVERPOSI");
            entity.Property(e => e.CVERSIONACTUAL)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_BACK10000_CVERSION01");
        });

        modelBuilder.Entity<admPreciosCompra>(entity =>
        {
            entity.HasKey(e => new { e.CIDPRODUCTO, e.CIDPROVEEDOR });

            entity.HasIndex(e => new { e.CIDMONEDA, e.CIDAUTOINCSQL }, "CIDMONEDA");

            entity.HasIndex(e => new { e.CIDPROVEEDOR, e.CIDAUTOINCSQL }, "CIDPROVEEDOR");

            entity.HasIndex(e => new { e.CIDUNIDAD, e.CIDAUTOINCSQL }, "CIDUNIDAD");

            entity.Property(e => e.CCODIGOPRODUCTOPROVEEDOR)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10014_CCODIGOP01");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10014_CTIMESTAMP");
        });

        modelBuilder.Entity<admPrepolizas>(entity =>
        {
            entity.HasKey(e => e.CIDPREPOLIZA);

            entity.HasIndex(e => e.CIDTRANSACCION, "CIDTRANSACCION");

            entity.HasIndex(e => new { e.FECHA, e.CIDPREPOLIZA }, "FECHA");

            entity.HasIndex(e => new { e.EJE, e.PERIODO, e.TIPOPOL, e.NUMPOL }, "IEJEPERIODOTIPONUMPOL");

            entity.HasIndex(e => new { e.FECHA, e.TIPOPOL, e.NUMPOL }, "IFECHATIPONUM");

            entity.Property(e => e.CGUIDPOLIZA)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CHORA)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10038_CHORA");
            entity.Property(e => e.CIDTRANSACCION)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10038_CIDTRANSACCION");
            entity.Property(e => e.CONCEPTO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10038_CONCEPTO");
            entity.Property(e => e.DIARIO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10038_DIARIO");
            entity.Property(e => e.FECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10038_FECHA")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<admProductos>(entity =>
        {
            entity.HasKey(e => e.CIDPRODUCTO);

            entity.HasIndex(e => new { e.CCLAVESAT, e.CIDPRODUCTO }, "CCLAVESAT");

            entity.HasIndex(e => e.CCODIGOPRODUCTO, "CCODIGOPRODUCTO").IsUnique();

            entity.HasIndex(e => new { e.CERRORCOSTO, e.CIDPRODUCTO }, "CERRORCO01");

            entity.HasIndex(e => new { e.CFECHAALTAPRODUCTO, e.CIDPRODUCTO }, "CFECHAALTAPRODUCTO");

            entity.HasIndex(e => new { e.CIDPADRECARACTERISTICA1, e.CIDPRODUCTO }, "CIDPADRECARACTERISTICA1");

            entity.HasIndex(e => new { e.CIDPADRECARACTERISTICA2, e.CIDPRODUCTO }, "CIDPADRECARACTERISTICA2");

            entity.HasIndex(e => new { e.CIDPADRECARACTERISTICA3, e.CIDPRODUCTO }, "CIDPADRECARACTERISTICA3");

            entity.HasIndex(e => new { e.CIDUNIDADBASE, e.CIDPRODUCTO }, "CIDUNIDADBASE");

            entity.HasIndex(e => new { e.CIDUNIDADNOCONVERTIBLE, e.CIDPRODUCTO }, "CIDUNIDADNOCONVERTIBLE");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION1, e.CIDPRODUCTO }, "CIDVALORCLASIFICACION1");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION2, e.CIDPRODUCTO }, "CIDVALORCLASIFICACION2");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION3, e.CIDPRODUCTO }, "CIDVALORCLASIFICACION3");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION4, e.CIDPRODUCTO }, "CIDVALORCLASIFICACION4");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION5, e.CIDPRODUCTO }, "CIDVALORCLASIFICACION5");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION6, e.CIDPRODUCTO }, "CIDVALORCLASIFICACION6");

            entity.HasIndex(e => new { e.CCODALTERN, e.CTIPOPRODUCTO, e.CIDPRODUCTO }, "ICODALTTIP");

            entity.HasIndex(e => new { e.CCODIGOPRODUCTO, e.CTIPOPRODUCTO }, "ICODIGOTIPO");

            entity.HasIndex(e => new { e.CMETODOCOSTEO, e.CIDPRODUCTO }, "IMETODOCOSTEO");

            entity.HasIndex(e => new { e.CNOMALTERN, e.CTIPOPRODUCTO, e.CIDPRODUCTO }, "INOMALTTIP");

            entity.HasIndex(e => new { e.CNOMBREPRODUCTO, e.CTIPOPRODUCTO, e.CIDPRODUCTO }, "INOMBRETIPO");

            entity.HasIndex(e => new { e.CSTATUSPRODUCTO, e.CIDPRODUCTO }, "ISTATUSPRODUCTO");

            entity.HasIndex(e => new { e.CTIPOPRODUCTO, e.CSUBTIPO, e.CCODIGOPRODUCTO }, "ITIPCODIGO");

            entity.HasIndex(e => new { e.CTIPOPRODUCTO, e.CSUBTIPO, e.CNOMBREPRODUCTO, e.CIDPRODUCTO }, "ITIPNOMBRE");

            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CCLAVESAT");
            entity.Property(e => e.CCODALTERN)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CCODALTERN");
            entity.Property(e => e.CCODIGOPRODUCTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CCODIGOP01");
            entity.Property(e => e.CCTAPRED)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CCTAPRED");
            entity.Property(e => e.CDESCCORTA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CDESCCORTA");
            entity.Property(e => e.CDESCRIPCIONPRODUCTO).HasColumnType("text");
            entity.Property(e => e.CFECCOSEX1)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECCOSEX1")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECCOSEX2)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECCOSEX2")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECCOSEX3)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECCOSEX3")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECCOSEX4)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECCOSEX4")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECCOSEX5)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECCOSEX5")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAALTAPRODUCTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECHAAL01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHABAJA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECHABAJA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAERRORCOSTO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECHAER01")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10005_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNOMALTERN)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CNOMALTERN");
            entity.Property(e => e.CNOMBREPRODUCTO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CNOMBREP01");
            entity.Property(e => e.CSEGCONTPRODUCTO1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT01");
            entity.Property(e => e.CSEGCONTPRODUCTO2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT02");
            entity.Property(e => e.CSEGCONTPRODUCTO3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT03");
            entity.Property(e => e.CSEGCONTPRODUCTO4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT04");
            entity.Property(e => e.CSEGCONTPRODUCTO5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT05");
            entity.Property(e => e.CSEGCONTPRODUCTO6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT06");
            entity.Property(e => e.CSEGCONTPRODUCTO7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CSEGCONT07");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10005_CTIMESTAMP");
            entity.Property(e => e.CUNIDADDIMENSION).HasDefaultValue(-1, "DF_MGW10005_CUNIDADDIMENSION");
        });

        modelBuilder.Entity<admProductosDetalles>(entity =>
        {
            entity.HasKey(e => e.CIDPRODUCTO);

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA1, e.CIDPRODUCTO }, "CIDVALORCARACTERISTICA1");

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA2, e.CIDPRODUCTO }, "CIDVALORCARACTERISTICA2");

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA3, e.CIDPRODUCTO }, "CIDVALORCARACTERISTICA3");

            entity.HasIndex(e => new { e.CIDVALORCARACTERISTICA1, e.CIDVALORCARACTERISTICA2, e.CIDVALORCARACTERISTICA3, e.CIDPRODUCTO }, "ICARACT123");

            entity.HasIndex(e => new { e.CIDPRODUCTOPADRE, e.CIDVALORCARACTERISTICA1, e.CIDVALORCARACTERISTICA2, e.CIDVALORCARACTERISTICA3 }, "IPRODPADREVALORESCARAC");

            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10004_CTIMESTAMP");
        });

        modelBuilder.Entity<admProductosFotos>(entity =>
        {
            entity.HasKey(e => e.CIDFOTOPRODUCTO);

            entity.HasIndex(e => e.CNOMBREFOTOPRODUCTO, "CNOMBREFOTOPRODUCTO");

            entity.Property(e => e.CFOTOPRODUCTO).HasColumnType("text");
            entity.Property(e => e.CNOMBREFOTOPRODUCTO)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_IMG10001_CNOMBREF01");
        });

        modelBuilder.Entity<admPromociones>(entity =>
        {
            entity.HasKey(e => e.CIDPROMOCION);

            entity.HasIndex(e => e.CCODIGOPROMOCION, "CCODIGOPROMOCION").IsUnique();

            entity.HasIndex(e => new { e.CFECHAFIN, e.CIDPROMOCION }, "CFECHAFIN");

            entity.HasIndex(e => new { e.CNOMBREPROMOCION, e.CIDPROMOCION }, "CNOMBREPROMOCION");

            entity.HasIndex(e => new { e.CSUBTIPO, e.CSTATUS, e.CFECHAFIN, e.CIDPROMOCION }, "ISUBTSTAT");

            entity.HasIndex(e => new { e.CTIPOPROMO, e.CIDCPTODOC, e.CFECHAFIN, e.CIDPROMOCION }, "ITICPTOFEC");

            entity.Property(e => e.CCODIGOPROMOCION)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10029_CCODIGOP01");
            entity.Property(e => e.CFECHAALTA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10029_CFECHAALTA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAFIN)
                .HasDefaultValueSql("('18991230')", "DF_MGW10029_CFECHAFIN")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAINICIO)
                .HasDefaultValueSql("('18991230')", "DF_MGW10029_CFECHAIN01")
                .HasColumnType("datetime");
            entity.Property(e => e.CHORAFIN)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10029_CHORAFIN");
            entity.Property(e => e.CHORAINI)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10029_CHORAINI");
            entity.Property(e => e.CNOMBREPROMOCION)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10029_CNOMBREP01");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10029_CTIMESTAMP");
        });

        modelBuilder.Entity<admProyectos>(entity =>
        {
            entity.HasKey(e => e.CIDPROYECTO);

            entity.HasIndex(e => e.CCODIGOPROYECTO, "CCODIGOPROYECTO").IsUnique();

            entity.HasIndex(e => new { e.CFECHAALTA, e.CIDPROYECTO }, "CFECHAALTA");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION1, e.CIDPROYECTO }, "CIDVALORCLASIFICACION1");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION2, e.CIDPROYECTO }, "CIDVALORCLASIFICACION2");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION3, e.CIDPROYECTO }, "CIDVALORCLASIFICACION3");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION4, e.CIDPROYECTO }, "CIDVALORCLASIFICACION4");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION5, e.CIDPROYECTO }, "CIDVALORCLASIFICACION5");

            entity.HasIndex(e => new { e.CIDVALORCLASIFICACION6, e.CIDPROYECTO }, "CIDVALORCLASIFICACION6");

            entity.HasIndex(e => e.CNOMBREPROYECTO, "CNOMBREPROYECTO").IsUnique();

            entity.Property(e => e.CCODIGOPROYECTO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CCODIGOPROYECTO");
            entity.Property(e => e.CFECHAALTA)
                .HasDefaultValueSql("('18991230')", "DF_admProyectos_CFECHAALTA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHABAJA)
                .HasDefaultValueSql("('18991230')", "DF_admProyectos_CFECHABAJA")
                .HasColumnType("datetime");
            entity.Property(e => e.CFECHAEXTRA)
                .HasDefaultValueSql("('18991230')", "DF_admProyectos_CFECHAEX01")
                .HasColumnType("datetime");
            entity.Property(e => e.CNOMBREPROYECTO)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CNOMBREPROYECTO");
            entity.Property(e => e.CSEGCONT1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CSEGCONT1");
            entity.Property(e => e.CSEGCONT2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CSEGCONT2");
            entity.Property(e => e.CSEGCONT3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CSEGCONT3");
            entity.Property(e => e.CTEXTOEXTRA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CTEXTOEX01");
            entity.Property(e => e.CTEXTOEXTRA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CTEXTOEX02");
            entity.Property(e => e.CTEXTOEXTRA3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CTEXTOEX03");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admProyectos_CTIMESTAMP");
        });

        modelBuilder.Entity<admSATSegmentos>(entity =>
        {
            entity.HasKey(e => e.CCLAVE);

            entity.HasIndex(e => e.CCLAVE, "CCLAVE").IsUnique();

            entity.Property(e => e.CCLAVE)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSATSegmentos_CCLAVE");
            entity.Property(e => e.CDESCRIPCION)
                .HasMaxLength(152)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSATSegmentos_CDESCRIPCION");
            entity.Property(e => e.CSEGCONT1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSATSegmentos_CSEGCONT1");
            entity.Property(e => e.CSEGCONT2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSATSegmentos_CSEGCONT2");
            entity.Property(e => e.CSEGCONT3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSATSegmentos_CSEGCONT3");
        });

        modelBuilder.Entity<admSegmentosImpuestos>(entity =>
        {
            entity.HasKey(e => e.CIDSEGMENTO);

            entity.HasIndex(e => new { e.CTIPO, e.CCATALOGO, e.CIDSEGMENTO }, "ITIPOCATALOGO");

            entity.Property(e => e.CSEGMENTO1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSegmentosImpuestos_CSEGMENTO1");
            entity.Property(e => e.CSEGMENTO2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSegmentosImpuestos_CSEGMENTO2");
            entity.Property(e => e.CSEGMENTO3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSegmentosImpuestos_CSEGMENTO3");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_admSegmentosImpuestos_CTIMESTAMP");
        });

        modelBuilder.Entity<admTiposCambio>(entity =>
        {
            entity.HasKey(e => e.CIDTIPOCAMBIO);

            entity.HasIndex(e => new { e.CIDMONEDA, e.CFECHA }, "IMONEDAFECHA");

            entity.HasIndex(e => new { e.CIDMONEDA, e.CFECHA }, "IMONEDAFECHADESC");

            entity.Property(e => e.CFECHA)
                .HasDefaultValueSql("('18991230')", "DF_MGW10035_CFECHA")
                .HasColumnType("datetime");
            entity.Property(e => e.CTIMESTAMP)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10035_CTIMESTAMP");
        });

        modelBuilder.Entity<admUnidadesMedidaPeso>(entity =>
        {
            entity.HasKey(e => e.CIDUNIDAD);

            entity.HasIndex(e => e.CABREVIATURA, "CABREVIATURA");

            entity.HasIndex(e => e.CNOMBREUNIDAD, "CNOMBREUNIDAD");

            entity.Property(e => e.CABREVIATURA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10026_CABREVIA01");
            entity.Property(e => e.CCLAVEINT)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10026_CCLAVEINT");
            entity.Property(e => e.CCLAVESAT)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10026_CCLAVESAT");
            entity.Property(e => e.CDESPLIEGUE)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10026_CDESPLIE01");
            entity.Property(e => e.CNOMBREUNIDAD)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_MGW10026_CNOMBREU01");
        });

        modelBuilder.Entity<admVistasCampos>(entity =>
        {
            entity.HasKey(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CNOMBRENATIVOCAMPO });

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CNOMBREAMIGABLECAMPO }, "INOMBREAMIGABLECAMPO");

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDMODULO, e.CNOMBRENATIVOTABLA, e.CCAMPOOC01 }, "ISISTEMA01");

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

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CTIPO, e.CNOMBRECONSULTA }, "ISISTEMAIDIOMAMODULOTIPO");

            entity.Property(e => e.CFILTROS)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00005_CFILTROS");
            entity.Property(e => e.CINDICE)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00005_CINDICE");
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

        modelBuilder.Entity<admVistasRecursos>(entity =>
        {
            entity.HasKey(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CIDMODULO, e.CTABLABASE, e.CCAMPOBASE });

            entity.Property(e => e.CTABLABASE)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CTABLABASE");
            entity.Property(e => e.CCAMPOBASE)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CCAMPOBASE");
            entity.Property(e => e.CCAMPO0)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CCAMPO0");
            entity.Property(e => e.CCAMPO1)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CCAMPO1");
            entity.Property(e => e.CCAMPOID)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CCAMPOID");
            entity.Property(e => e.CIDAUTOINCSQL).ValueGeneratedOnAdd();
            entity.Property(e => e.CINDICE0)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CINDICE0");
            entity.Property(e => e.CINDICE1)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CINDICE1");
            entity.Property(e => e.CRANGO)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CRANGO");
            entity.Property(e => e.CTABLARELA)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CTABLARELA");
            entity.Property(e => e.CTITULO0)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CTITULO0");
            entity.Property(e => e.CTITULO1)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00004_CTITULO1");
        });

        modelBuilder.Entity<admVistasRelaciones>(entity =>
        {
            entity.HasKey(e => e.CIDRELACION);

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CNOMBRENATIVOTABLA1, e.CNOMBRENATIVOTABLA2, e.CIDRELACION }, "IRELACIONTABLAS");

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CNOMBRENATIVOTABLA1, e.CIDRELACION }, "ISISTEMAIDIOMARELDIRECTA");

            entity.HasIndex(e => new { e.CIDSISTEMA, e.CIDIDIOMA, e.CNOMBRENATIVOTABLA2, e.CIDRELACION }, "ISISTEMAIDIOMARELINVERSA");

            entity.Property(e => e.CCAMPONA01)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CCAMPONA01");
            entity.Property(e => e.CFILTRO)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CFILTRO");
            entity.Property(e => e.CFILTROAUX)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CFILTROAUX");
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
                .HasMaxLength(127)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CSENTENC01");
            entity.Property(e => e.CTABLAREL1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CTABLAREL1");
            entity.Property(e => e.CTABLAREL2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00009_CTABLAREL2");
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
            entity.Property(e => e.CINDICES)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00006_CINDICES");
            entity.Property(e => e.CNOMBREAMIGABLETABLA)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_CAC00006_CNOMBREA01");
        });

        modelBuilder.Entity<nubeCuentas>(entity =>
        {
            entity.HasKey(e => e.CCUENTA);

            entity.Property(e => e.CCUENTA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeCuentas_CCUENTA");
            entity.Property(e => e.CMONEDA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeCuentas_CMONEDA");
            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeCuentas_CNOMBRE");
            entity.Property(e => e.CSEGMENTO)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeCuentas_CSEGMENTO");
            entity.Property(e => e.CTIPO)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeCuentas_CTIPO");
        });

        modelBuilder.Entity<nubeDiarios>(entity =>
        {
            entity.HasKey(e => e.CCODIGO);

            entity.Property(e => e.CCODIGO)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeDiarios_CCUENTA");
            entity.Property(e => e.CNOMBRE)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_nubeDiarios_CNOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
