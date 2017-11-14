using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class ContpaqiSdkUnidadTrabajo
    {
        public ContpaqiSdkUnidadTrabajo(IContpaqiSdk sdk)
        {
            ContpaqiSdk = sdk;
            AgenteRepositorio = new AgenteRepositorio(sdk);
            AlmacenRepositorio = new AlmacenRepositorio(sdk);
            ClasificacionRepositorio = new ClasificacionRepositorio(sdk);
            ClienteProveedorRepositorio = new ClienteProveedorRepositorio(sdk);
            ConceptoDocumentoRepositorio = new ConceptoDocumentoRepositorio(sdk);
            DireccionRepositorio = new DireccionRepositorio(sdk);
            DocumentoRepositorio = new DocumentoRepositorio(sdk);
            EmpresaRepositorio = new EmpresaRepositorio(sdk);
            ErrorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
            MovimientoRepositorio = new MovimientoRepositorio(sdk);
            ProductoRepositorio = new ProductoRepositorio(sdk);
            UnidadMedidaRepositorio = new UnidadMedidaRepositorio(sdk);
            ValorClasificacionRepositorio = new ValorClasificacionRepositorio(sdk);
        }

        public AgenteRepositorio AgenteRepositorio { get; }

        public AlmacenRepositorio AlmacenRepositorio { get; }

        public ClasificacionRepositorio ClasificacionRepositorio { get; }

        public ClienteProveedorRepositorio ClienteProveedorRepositorio { get; }

        public ConceptoDocumentoRepositorio ConceptoDocumentoRepositorio { get; }

        public DireccionRepositorio DireccionRepositorio { get; }

        public DocumentoRepositorio DocumentoRepositorio { get; }

        public EmpresaRepositorio EmpresaRepositorio { get; }

        public ErrorContpaqiSdkRepositorio ErrorContpaqiSdkRepositorio { get; }

        public MovimientoRepositorio MovimientoRepositorio { get; }

        public ProductoRepositorio ProductoRepositorio { get; }

        public UnidadMedidaRepositorio UnidadMedidaRepositorio { get; }

        public ValorClasificacionRepositorio ValorClasificacionRepositorio { get; }

        public IContpaqiSdk ContpaqiSdk { get; }
    }
}