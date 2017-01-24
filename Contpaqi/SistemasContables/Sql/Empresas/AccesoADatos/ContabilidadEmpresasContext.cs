using Contpaqi.SistemasContables.Sql.Empresas.Modelo;

namespace Contpaqi.SistemasContables.Sql.Empresas.AccesoADatos
{
    using System.Data.Common;
    using System.Data.Entity;

    public partial class ContabilidadEmpresasContext : DbContext
    {
        static ContabilidadEmpresasContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<ContabilidadEmpresasContext>());
        }

        public ContabilidadEmpresasContext()
            : base("name=ContabilidadEmpresasContext")
        {
        }

        public ContabilidadEmpresasContext(DbConnection connection, bool ownsConnection)
            : base(connection, ownsConnection)
        {
        }

        public virtual DbSet<ActivosFijos> ActivosFijos { get; set; }

        public virtual DbSet<Afectaciones> Afectaciones { get; set; }

        public virtual DbSet<AfectacionesPresupuestos> AfectacionesPresupuestos { get; set; }

        public virtual DbSet<AfectacionesSaldos> AfectacionesSaldos { get; set; }

        public virtual DbSet<AgrupadoresSAT> AgrupadoresSAT { get; set; }

        public virtual DbSet<AsientosContablesCV> AsientosContablesCV { get; set; }

        public virtual DbSet<AsignacionesDigitos> AsignacionesDigitos { get; set; }

        public virtual DbSet<AsocCargosAbonos> AsocCargosAbonos { get; set; }

        public virtual DbSet<AsocCategorias> AsocCategorias { get; set; }

        public virtual DbSet<AsocCategoriasPlantillas> AsocCategoriasPlantillas { get; set; }

        public virtual DbSet<AsocCFDIs> AsocCFDIs { get; set; }

        public virtual DbSet<AsocComprasVentas> AsocComprasVentas { get; set; }

        public virtual DbSet<AsocCuentasGrupos> AsocCuentasGrupos { get; set; }

        public virtual DbSet<AsocDoctoCategorias> AsocDoctoCategorias { get; set; }

        public virtual DbSet<Asociaciones> Asociaciones { get; set; }

        public virtual DbSet<Bancos> Bancos { get; set; }

        public virtual DbSet<CatalogosPreinstalados> CatalogosPreinstalados { get; set; }

        public virtual DbSet<Categorias> Categorias { get; set; }

        public virtual DbSet<CausacionesIVA> CausacionesIVA { get; set; }

        public virtual DbSet<Cheques> Cheques { get; set; }

        public virtual DbSet<ClavesCV> ClavesCV { get; set; }

        public virtual DbSet<Clientes> Clientes { get; set; }

        public virtual DbSet<Conceptos> Conceptos { get; set; }

        public virtual DbSet<ConceptosIETU> ConceptosIETU { get; set; }

        public virtual DbSet<Counters> Counters { get; set; }

        public virtual DbSet<Cuentas> Cuentas { get; set; }

        public virtual DbSet<CuentasCheques> CuentasCheques { get; set; }

        public virtual DbSet<CuentasDeGastosYRetenciones> CuentasDeGastosYRetenciones { get; set; }

        public virtual DbSet<CuentasReexpresion> CuentasReexpresion { get; set; }

        public virtual DbSet<DatosExtra> DatosExtra { get; set; }

        public virtual DbSet<Depositos> Depositos { get; set; }

        public virtual DbSet<DevolucionesIVA> DevolucionesIVA { get; set; }

        public virtual DbSet<DiariosEspeciales> DiariosEspeciales { get; set; }

        public virtual DbSet<Digitos> Digitos { get; set; }

        public virtual DbSet<DocumentosBancarios> DocumentosBancarios { get; set; }

        public virtual DbSet<DocumentosDe> DocumentosDe { get; set; }

        public virtual DbSet<DocumentosGastos> DocumentosGastos { get; set; }

        public virtual DbSet<EdoCtaBancos> EdoCtaBancos { get; set; }

        public virtual DbSet<Egresos> Egresos { get; set; }

        public virtual DbSet<Ejercicios> Ejercicios { get; set; }

        public virtual DbSet<EmisionesSAT> EmisionesSAT { get; set; }

        public virtual DbSet<Folios> Folios { get; set; }

        public virtual DbSet<FoliosDigitales> FoliosDigitales { get; set; }

        public virtual DbSet<FoliosUsados> FoliosUsados { get; set; }

        public virtual DbSet<GruposCuentas> GruposCuentas { get; set; }

        public virtual DbSet<GruposEstadisticos> GruposEstadisticos { get; set; }

        public virtual DbSet<Ingresos> Ingresos { get; set; }

        public virtual DbSet<IngresosNoDepositados> IngresosNoDepositados { get; set; }

        public virtual DbSet<Listados> Listados { get; set; }

        public virtual DbSet<Modulos> Modulos { get; set; }

        public virtual DbSet<ModulosListados> ModulosListados { get; set; }

        public virtual DbSet<Monedas> Monedas { get; set; }

        public virtual DbSet<MovimientosCFD> MovimientosCFD { get; set; }

        public virtual DbSet<MovimientosPoliza> MovimientosPoliza { get; set; }

        public virtual DbSet<MovimientosPrepoliza> MovimientosPrepoliza { get; set; }

        public virtual DbSet<MovtosEdoCtaBancos> MovtosEdoCtaBancos { get; set; }

        public virtual DbSet<NombresValoresCV> NombresValoresCV { get; set; }

        public virtual DbSet<Parametros> Parametros { get; set; }

        public virtual DbSet<PeriodosCausacionIVA> PeriodosCausacionIVA { get; set; }

        public virtual DbSet<Personas> Personas { get; set; }

        public virtual DbSet<Plantillas> Plantillas { get; set; }

        public virtual DbSet<PlantillasEstadosCuentas> PlantillasEstadosCuentas { get; set; }

        public virtual DbSet<Polizas> Polizas { get; set; }

        public virtual DbSet<PolizasPagos> PolizasPagos { get; set; }

        public virtual DbSet<PorcentajesPresupuesto> PorcentajesPresupuesto { get; set; }

        public virtual DbSet<Prepolizas> Prepolizas { get; set; }

        public virtual DbSet<Presupuestos> Presupuestos { get; set; }

        public virtual DbSet<PresupuestosCategorias> PresupuestosCategorias { get; set; }

        public virtual DbSet<ProcesosReexpresion> ProcesosReexpresion { get; set; }

        public virtual DbSet<Proveedores> Proveedores { get; set; }

        public virtual DbSet<Recordatorios> Recordatorios { get; set; }

        public virtual DbSet<Reportes> Reportes { get; set; }

        public virtual DbSet<RubrosNIF> RubrosNIF { get; set; }

        public virtual DbSet<SaldosCategorias> SaldosCategorias { get; set; }

        public virtual DbSet<SaldosCtasCheques> SaldosCtasCheques { get; set; }

        public virtual DbSet<SaldosCuentas> SaldosCuentas { get; set; }

        public virtual DbSet<SaldosReexpresion> SaldosReexpresion { get; set; }

        public virtual DbSet<SaldosSegmentoNegocio> SaldosSegmentoNegocio { get; set; }

        public virtual DbSet<SegmentosNegocio> SegmentosNegocio { get; set; }

        public virtual DbSet<TiposCambio> TiposCambio { get; set; }

        public virtual DbSet<TiposDocumentos> TiposDocumentos { get; set; }

        public virtual DbSet<TiposPolizas> TiposPolizas { get; set; }

        public virtual DbSet<TiposPolizasSAT> TiposPolizasSAT { get; set; }

        public virtual DbSet<ValoresAuxiliaresCV> ValoresAuxiliaresCV { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}