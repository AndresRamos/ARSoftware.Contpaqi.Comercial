using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComercialEmpresaDbContext : DbContext
    {
        static ComercialEmpresaDbContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<ComercialEmpresaDbContext>());
        }

        public ComercialEmpresaDbContext()
            : base("name=ComercialEmpresaDbContext")
        {
        }

        protected ComercialEmpresaDbContext(DbCompiledModel model) : base(model)
        {
        }

        public ComercialEmpresaDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public ComercialEmpresaDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public ComercialEmpresaDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public ComercialEmpresaDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public ComercialEmpresaDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<admAcumulados> admAcumulados { get; set; }
        public virtual DbSet<admAcumuladosTipos> admAcumuladosTipos { get; set; }
        public virtual DbSet<admAgentes> admAgentes { get; set; }
        public virtual DbSet<admAlmacenes> admAlmacenes { get; set; }
        public virtual DbSet<admAsientosContables> admAsientosContables { get; set; }
        public virtual DbSet<admAsocAcumConceptos> admAsocAcumConceptos { get; set; }
        public virtual DbSet<admAsocCargosAbonos> admAsocCargosAbonos { get; set; }
        public virtual DbSet<admBanderas> admBanderas { get; set; }
        public virtual DbSet<admBitacoras> admBitacoras { get; set; }
        public virtual DbSet<admCapasProducto> admCapasProducto { get; set; }
        public virtual DbSet<admCaracteristicas> admCaracteristicas { get; set; }
        public virtual DbSet<admCaracteristicasValores> admCaracteristicasValores { get; set; }
        public virtual DbSet<admClasificaciones> admClasificaciones { get; set; }
        public virtual DbSet<admClasificacionesValores> admClasificacionesValores { get; set; }
        public virtual DbSet<admClientes> admClientes { get; set; }
        public virtual DbSet<admComponentesPaquete> admComponentesPaquete { get; set; }
        public virtual DbSet<admConceptos> admConceptos { get; set; }
        public virtual DbSet<admConceptosBack> admConceptosBack { get; set; }
        public virtual DbSet<admConversionesUnidad> admConversionesUnidad { get; set; }
        public virtual DbSet<admCostosHistoricos> admCostosHistoricos { get; set; }
        public virtual DbSet<admCuentasBancarias> admCuentasBancarias { get; set; }
        public virtual DbSet<admDatosAddenda> admDatosAddenda { get; set; }
        public virtual DbSet<admDocumentos> admDocumentos { get; set; }
        public virtual DbSet<admDocumentosModelo> admDocumentosModelo { get; set; }
        public virtual DbSet<admDocumentosModelosBack> admDocumentosModelosBack { get; set; }
        public virtual DbSet<admDomicilios> admDomicilios { get; set; }
        public virtual DbSet<admEjercicios> admEjercicios { get; set; }
        public virtual DbSet<admExistenciaCosto> admExistenciaCosto { get; set; }
        public virtual DbSet<admFoliosDigitales> admFoliosDigitales { get; set; }
        public virtual DbSet<admMaximosMinimos> admMaximosMinimos { get; set; }
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
        public virtual DbSet<admTiposCambio> admTiposCambio { get; set; }
        public virtual DbSet<admUnidadesMedidaPeso> admUnidadesMedidaPeso { get; set; }
        public virtual DbSet<admVistasCampos> admVistasCampos { get; set; }
        public virtual DbSet<admVistasConsultas> admVistasConsultas { get; set; }
        public virtual DbSet<admVistasPorModulo> admVistasPorModulo { get; set; }
        public virtual DbSet<admVistasRecursos> admVistasRecursos { get; set; }
        public virtual DbSet<admVistasRelaciones> admVistasRelaciones { get; set; }
        public virtual DbSet<admVistasTablas> admVistasTablas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admAcumulados>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admAcumuladosTipos>()
                .Property(e => e.CNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CCODIGOAGENTE)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CNOMBREAGENTE)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CSEGCONTAGENTE)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CSCAGENTE2)
                .IsUnicode(false);

            modelBuilder.Entity<admAgentes>()
                .Property(e => e.CSCAGENTE3)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CCODIGOALMACEN)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CNOMBREALMACEN)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CSEGCONTALMACEN)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CSCALMAC2)
                .IsUnicode(false);

            modelBuilder.Entity<admAlmacenes>()
                .Property(e => e.CSCALMAC3)
                .IsUnicode(false);

            modelBuilder.Entity<admAsientosContables>()
                .Property(e => e.CNUMEROASIENTOCONTABLE)
                .IsUnicode(false);

            modelBuilder.Entity<admAsientosContables>()
                .Property(e => e.CNOMBREASIENTOCONTABLE)
                .IsUnicode(false);

            modelBuilder.Entity<admAsientosContables>()
                .Property(e => e.CCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admAsientosContables>()
                .Property(e => e.CDIARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admAsientosContables>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admBanderas>()
                .Property(e => e.CNOMBREBANDERA)
                .IsUnicode(false);

            modelBuilder.Entity<admBanderas>()
                .Property(e => e.CBANDERA)
                .IsUnicode(false);

            modelBuilder.Entity<admBanderas>()
                .Property(e => e.CCLAVEISO)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.HORA)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.USUARIO2)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.NOMBRE2)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.PROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.DATOS)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.CTEXTOEX01)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.CTEXTOEX02)
                .IsUnicode(false);

            modelBuilder.Entity<admBitacoras>()
                .Property(e => e.CTEXTOEX03)
                .IsUnicode(false);

            modelBuilder.Entity<admCapasProducto>()
                .Property(e => e.CNUMEROLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<admCapasProducto>()
                .Property(e => e.CPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<admCapasProducto>()
                .Property(e => e.CADUANA)
                .IsUnicode(false);

            modelBuilder.Entity<admCapasProducto>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admCapasProducto>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

            modelBuilder.Entity<admCaracteristicas>()
                .Property(e => e.CNOMBRECARACTERISTICA)
                .IsUnicode(false);

            modelBuilder.Entity<admCaracteristicasValores>()
                .Property(e => e.CVALORCARACTERISTICA)
                .IsUnicode(false);

            modelBuilder.Entity<admCaracteristicasValores>()
                .Property(e => e.CNEMOCARACTERISTICA)
                .IsUnicode(false);

            modelBuilder.Entity<admClasificaciones>()
                .Property(e => e.CNOMBRECLASIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<admClasificacionesValores>()
                .Property(e => e.CVALORCLASIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<admClasificacionesValores>()
                .Property(e => e.CCODIGOVALORCLASIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<admClasificacionesValores>()
                .Property(e => e.CSEGCONT1)
                .IsUnicode(false);

            modelBuilder.Entity<admClasificacionesValores>()
                .Property(e => e.CSEGCONT2)
                .IsUnicode(false);

            modelBuilder.Entity<admClasificacionesValores>()
                .Property(e => e.CSEGCONT3)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CCODIGOCLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CRAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CRFC)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CCURP)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CDENCOMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CREPLEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CMENSAJERIA)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CCUENTAMENSAJERIA)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE1)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE2)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE3)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE4)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE5)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE6)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTCLIENTE7)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR1)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR2)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR3)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR4)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR5)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR6)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSEGCONTPROVEEDOR7)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CEMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CEMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CEMAIL3)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CTEXTOEXTRA4)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CTEXTOEXTRA5)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CCON1NOM)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CCON1TEL)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CSITIOFTP)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CUSRFTP)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CMETODOPAG)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CNUMCTAPAG)
                .IsUnicode(false);

            modelBuilder.Entity<admClientes>()
                .Property(e => e.CUSOCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CCODIGOCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CNOMBRECONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CFORMAPREIMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CSERIEPOROMISION)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CSEGCONTCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CSCCPTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CSCCPTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CSCMOVTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CREPIMPCFD)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CPLAMIGCFD)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CRUTAENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CPREFIJOCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CREGIMFISC)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CMETODOPAG)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CVERESQUE)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CIDFIRMADSL)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CORDENCAPTURA)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptos>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CCODIGOCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CNOMBRECONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CFORMAPREIMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CSERIEPOROMISION)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CSEGCONTCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CSCCPTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CSCCPTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CSCMOVTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CREPIMPCFD)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CPLAMIGCFD)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CRUTAENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CPREFIJOCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CREGIMFISC)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CMETODOPAG)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CVERESQUE)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CIDFIRMADSL)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CORDENCAPTURA)
                .IsUnicode(false);

            modelBuilder.Entity<admConceptosBack>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

            modelBuilder.Entity<admCostosHistoricos>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CACCOUNTID)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CNUMEROCUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CNOMBRECUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CCLABE)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CSEGCONT01)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CSEGCONT02)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CSEGCONT03)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CNOMBANEXT)
                .IsUnicode(false);

            modelBuilder.Entity<admCuentasBancarias>()
                .Property(e => e.CRFCBANCO)
                .IsUnicode(false);

            modelBuilder.Entity<admDatosAddenda>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CSERIEDOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CRAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CRFC)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CREFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.COBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CDESTINATARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CNUMEROGUIA)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CMENSAJERIA)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CCUENTAMENSAJERIA)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CLUGAREXPE)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CMETODOPAG)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CCONDIPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CNUMCTAPAG)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CGUIDDOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CUSUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentos>()
                .Property(e => e.CTRANSACTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentosModelo>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<admDocumentosModelosBack>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CNOMBRECALLE)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CNUMEROEXTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CNUMEROINTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CCOLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CCODIGOPOSTAL)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CTELEFONO1)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CTELEFONO2)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CTELEFONO3)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CTELEFONO4)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CDIRECCIONWEB)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CPAIS)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CCIUDAD)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CTEXTOEXTRA)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CMUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<admDomicilios>()
                .Property(e => e.CSUCURSAL)
                .IsUnicode(false);

            modelBuilder.Entity<admExistenciaCosto>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CSERIE)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CHORAEMI)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CARCHDIDIS)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CHORACANC)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CCADPEDI)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CARCHCBB)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CSERIEREC)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CRFC)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CRAZON)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CTIPOLDESC)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CALIASBDCT)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CDESESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CDESPAGBAN)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CREFEREN01)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.COBSERVA01)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CCODCONCBA)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CDESCONCBA)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CNUMCTABAN)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CFOLIOBAN)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CUSUAUTBAN)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CUUID)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CUSUBAN01)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CUSUBAN02)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CUSUBAN03)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CDESCAUT01)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CDESCAUT02)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CDESCAUT03)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CACUSECAN)
                .IsUnicode(false);

            modelBuilder.Entity<admFoliosDigitales>()
                .Property(e => e.CIDDOCTODSL)
                .IsUnicode(false);

            modelBuilder.Entity<admMaximosMinimos>()
                .Property(e => e.CZONA)
                .IsUnicode(false);

            modelBuilder.Entity<admMaximosMinimos>()
                .Property(e => e.CPASILLO)
                .IsUnicode(false);

            modelBuilder.Entity<admMaximosMinimos>()
                .Property(e => e.CANAQUEL)
                .IsUnicode(false);

            modelBuilder.Entity<admMaximosMinimos>()
                .Property(e => e.CREPISA)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CNOMBREMONEDA)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CSIMBOLOMONEDA)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CPLURAL)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CSINGULAR)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CDESCRIPCIONPROTEGIDA)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admMonedas>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.CREFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.COBSERVAMOV)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientos>()
                .Property(e => e.CSCMOVTO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosContables>()
                .Property(e => e.CCUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosContables>()
                .Property(e => e.CREFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosContables>()
                .Property(e => e.CDIARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosContables>()
                .Property(e => e.CCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosContables>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosContables>()
                .Property(e => e.CSEGNEG)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosPrepoliza>()
                .Property(e => e.CUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosPrepoliza>()
                .Property(e => e.REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosPrepoliza>()
                .Property(e => e.DIARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosPrepoliza>()
                .Property(e => e.CONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovimientosPrepoliza>()
                .Property(e => e.SEGNEG)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CTRANSACTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CACCOUNTID)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CREFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosBancarios>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CHORA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CSELLO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CCERTIFICADO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CCADENA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CCONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CRBANCO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CRNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CRRFC)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CRCUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CRTIPOCTA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CEBANCO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CENOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CERFC)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CECUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CETIPOCTA)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosCEPs>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosInvFisicoSerieCa>()
                .Property(e => e.CNUMEROSERIE)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosInvFisicoSerieCa>()
                .Property(e => e.CNUMEROLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosInvFisicoSerieCa>()
                .Property(e => e.CPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<admMovtosInvFisicoSerieCa>()
                .Property(e => e.CADUANA)
                .IsUnicode(false);

            modelBuilder.Entity<admNumerosSerie>()
                .Property(e => e.CNUMEROSERIE)
                .IsUnicode(false);

            modelBuilder.Entity<admNumerosSerie>()
                .Property(e => e.CNUMEROLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<admNumerosSerie>()
                .Property(e => e.CPEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<admNumerosSerie>()
                .Property(e => e.CADUANA)
                .IsUnicode(false);

            modelBuilder.Entity<admNumerosSerie>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admNumerosSerie>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CRFCEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CCURPEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CREGISTROCAMARA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CCUENTAESTATAL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CREPRESENTANTELEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRECORTO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CRUTACONTPAQ)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMASCARILLACLIENTES)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMASCARILLAPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMASCARILLAALMACEN)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMASCARILLAAGENTE)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMASCARILLARFC)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMASCARILLACURP)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA5)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA6)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA7)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA8)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA9)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRELISTA10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREIMPUESTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREIMPUESTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREIMPUESTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRERETENCION1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBRERETENCION2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREGASTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREGASTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREGASTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTOMOV1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTOMOV2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTOMOV3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTOMOV4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTOMOV5)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTODOC1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNOMBREDESCUENTODOC2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL5)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL6)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL7)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL8)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL9)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCONTGENERAL11)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CRUTAEMPRESAPRED)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CVERSIONACTUAL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVTEXEX1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVTEXEX2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVTEXEX3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVIMPEX1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVIMPEX2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVIMPEX3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVIMPEX4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CMOVFECEX1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CVERPOSI)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCIVA15)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCIVA10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCIVAOT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCIVA16)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCIVA11)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGPIVA15)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGPIVA10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGPIVAOT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGPIVA16)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGPIVA11)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CHOST)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CRUTAPLA01)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CRUTAPLA02)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CNUMDONAT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CHOSTPROXY)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CUSRPROXY)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CHOSTSMTP)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CRUTAENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CVALIDACFD)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CREGIMFISC)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CAUTRVOE)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CLEYENDON1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CLEYENDON2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CASUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CCUERPO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CADJUNTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CADJUNTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CCORREOPRU)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CGUIDDSL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CGUIDEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGCIVA8)
                .IsUnicode(false);

            modelBuilder.Entity<admParametros>()
                .Property(e => e.CSEGPIVA8)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CRFCEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CCURPEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CREGISTROCAMARA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CCUENTAESTATAL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CREPRESENTANTELEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRECORTO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CRUTACONTPAQ)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMASCARILLACLIENTES)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMASCARILLAPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMASCARILLAALMACEN)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMASCARILLAAGENTE)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMASCARILLARFC)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMASCARILLACURP)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA5)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA6)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA7)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA8)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA9)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRELISTA10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREIMPUESTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREIMPUESTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREIMPUESTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRERETENCION1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBRERETENCION2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREGASTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREGASTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREGASTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTOMOV1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTOMOV2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTOMOV3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTOMOV4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTOMOV5)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTODOC1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNOMBREDESCUENTODOC2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL5)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL6)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL7)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL8)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL9)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCONTGENERAL11)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CRUTAEMPRESAPRED)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CVERSIONACTUAL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVTEXEX1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVTEXEX2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVTEXEX3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVIMPEX1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVIMPEX2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVIMPEX3)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVIMPEX4)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CMOVFECEX1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CVERPOSI)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCIVA15)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCIVA10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCIVAOT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCIVA16)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGCIVA11)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGPIVA15)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGPIVA10)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGPIVAOT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGPIVA16)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CSEGPIVA11)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CHOST)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CRUTAPLA01)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CRUTAPLA02)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CNUMDONAT)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CHOSTPROXY)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CUSRPROXY)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CHOSTSMTP)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CRUTAENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CVALIDACFD)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CREGIMFISC)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CAUTRVOE)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CLEYENDON1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CLEYENDON2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CASUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CCUERPO)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CADJUNTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CADJUNTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CCORREOPRU)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CGUIDDSL)
                .IsUnicode(false);

            modelBuilder.Entity<admParametrosBack>()
                .Property(e => e.CGUIDEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<admPreciosCompra>()
                .Property(e => e.CCODIGOPRODUCTOPROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<admPreciosCompra>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admPrepolizas>()
                .Property(e => e.CONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<admPrepolizas>()
                .Property(e => e.DIARIO)
                .IsUnicode(false);

            modelBuilder.Entity<admPrepolizas>()
                .Property(e => e.CHORA)
                .IsUnicode(false);

            modelBuilder.Entity<admPrepolizas>()
                .Property(e => e.CGUIDPOLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CCODIGOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CNOMBREPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CDESCRIPCIONPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO1)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO2)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO3)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CCODALTERN)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CNOMALTERN)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CDESCCORTA)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO4)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO5)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO6)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CSEGCONTPRODUCTO7)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CCTAPRED)
                .IsUnicode(false);

            modelBuilder.Entity<admProductos>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

            modelBuilder.Entity<admProductosDetalles>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admProductosFotos>()
                .Property(e => e.CNOMBREFOTOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admProductosFotos>()
                .Property(e => e.CFOTOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<admPromociones>()
                .Property(e => e.CCODIGOPROMOCION)
                .IsUnicode(false);

            modelBuilder.Entity<admPromociones>()
                .Property(e => e.CNOMBREPROMOCION)
                .IsUnicode(false);

            modelBuilder.Entity<admPromociones>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admPromociones>()
                .Property(e => e.CHORAINI)
                .IsUnicode(false);

            modelBuilder.Entity<admPromociones>()
                .Property(e => e.CHORAFIN)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CCODIGOPROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CNOMBREPROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CSEGCONT1)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CSEGCONT2)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CSEGCONT3)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CTEXTOEXTRA1)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CTEXTOEXTRA2)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CTEXTOEXTRA3)
                .IsUnicode(false);

            modelBuilder.Entity<admProyectos>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admSATSegmentos>()
                .Property(e => e.CCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<admSATSegmentos>()
                .Property(e => e.CDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<admSATSegmentos>()
                .Property(e => e.CSEGCONT1)
                .IsUnicode(false);

            modelBuilder.Entity<admSATSegmentos>()
                .Property(e => e.CSEGCONT2)
                .IsUnicode(false);

            modelBuilder.Entity<admSATSegmentos>()
                .Property(e => e.CSEGCONT3)
                .IsUnicode(false);

            modelBuilder.Entity<admTiposCambio>()
                .Property(e => e.CTIMESTAMP)
                .IsUnicode(false);

            modelBuilder.Entity<admUnidadesMedidaPeso>()
                .Property(e => e.CNOMBREUNIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<admUnidadesMedidaPeso>()
                .Property(e => e.CABREVIATURA)
                .IsUnicode(false);

            modelBuilder.Entity<admUnidadesMedidaPeso>()
                .Property(e => e.CDESPLIEGUE)
                .IsUnicode(false);

            modelBuilder.Entity<admUnidadesMedidaPeso>()
                .Property(e => e.CCLAVEINT)
                .IsUnicode(false);

            modelBuilder.Entity<admUnidadesMedidaPeso>()
                .Property(e => e.CCLAVESAT)
                .IsUnicode(false);

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

            modelBuilder.Entity<admVistasConsultas>()
                .Property(e => e.CINDICE)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasConsultas>()
                .Property(e => e.CFILTROS)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasPorModulo>()
                .Property(e => e.CNOMBREMODULO)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CTABLABASE)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CTABLARELA)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CCAMPOBASE)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CCAMPOID)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CTITULO0)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CCAMPO0)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CINDICE0)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CTITULO1)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CCAMPO1)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CINDICE1)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRecursos>()
                .Property(e => e.CRANGO)
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

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CCAMPONA01)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CFILTRO)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CTABLAREL1)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CTABLAREL2)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasRelaciones>()
                .Property(e => e.CFILTROAUX)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasTablas>()
                .Property(e => e.CNOMBRENATIVOTABLA)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasTablas>()
                .Property(e => e.CNOMBREAMIGABLETABLA)
                .IsUnicode(false);

            modelBuilder.Entity<admVistasTablas>()
                .Property(e => e.CINDICES)
                .IsUnicode(false);
        }
    }
}
