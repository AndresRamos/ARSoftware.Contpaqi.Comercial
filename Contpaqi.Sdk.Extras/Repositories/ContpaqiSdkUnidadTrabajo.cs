using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ContpaqiSdkUnidadTrabajo
    {
        public ContpaqiSdkUnidadTrabajo(IContpaqiSdk sdk)
        {
            ContpaqiSdk = sdk;
            AgenteRepository = new AgenteRepository(sdk);
            AlmacenRepository = new AlmacenRepository(sdk);
            ClasificacionRepository = new ClasificacionRepository(sdk);
            ClienteProveedorRepository = new ClienteProveedorRepository(sdk);
            ConceptoDocumentoRepository = new ConceptoDocumentoRepository(sdk);
            DireccionRepository = new DireccionRepository(sdk);
            DocumentoRepository = new DocumentoRepository(sdk);
            EmpresaRepository = new EmpresaRepository(sdk);
            SdkErrorRepository = new SdkErrorRepository(sdk);
            MovimientoRepository = new MovimientoRepository(sdk);
            ProductoRepository = new ProductoRepository(sdk);
            UnidadMedidaRepository = new UnidadMedidaRepository(sdk);
            ValorClasificacionRepository = new ValorClasificacionRepository(sdk);
        }

        public AgenteRepository AgenteRepository { get; }

        public AlmacenRepository AlmacenRepository { get; }

        public ClasificacionRepository ClasificacionRepository { get; }

        public ClienteProveedorRepository ClienteProveedorRepository { get; }

        public ConceptoDocumentoRepository ConceptoDocumentoRepository { get; }

        public DireccionRepository DireccionRepository { get; }

        public DocumentoRepository DocumentoRepository { get; }

        public EmpresaRepository EmpresaRepository { get; }

        public SdkErrorRepository SdkErrorRepository { get; }

        public MovimientoRepository MovimientoRepository { get; }

        public ProductoRepository ProductoRepository { get; }

        public UnidadMedidaRepository UnidadMedidaRepository { get; }

        public ValorClasificacionRepository ValorClasificacionRepository { get; }

        public IContpaqiSdk ContpaqiSdk { get; }
    }
}