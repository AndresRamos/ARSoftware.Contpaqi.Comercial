using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// ReSharper disable UnusedVariable

namespace Sdk.Extras.ConsoleApp;

public class EjemplosBasicos
{
    public void RegistrarServicios()
    {
        IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                // Agregar servicios del SDK
                services.AddContpaqiComercialSdkServices();
            })
            .Build();

        IServiceProvider services = host.Services;

        var sdkSesionService = services.GetRequiredService<IComercialSdkSesionService>();
    }

    public void CrearDocumento(IServiceProvider services)
    {
        // Iniciar sesion
        var sdkSesionService = services.GetRequiredService<IComercialSdkSesionService>();
        sdkSesionService.IniciarSesionSdk("SUPERVISOR", "");

        // Buscar empresa
        var empresaRepository = services.GetRequiredService<IEmpresaRepository<EmpresaDto>>();
        EmpresaDto empresa = empresaRepository.BuscarPorNombre("EMPRESA PRUEBA") ?? throw new Exception("No se encontro la empresa.");

        // Abrir empresa
        sdkSesionService.AbrirEmpresa(empresa.CRUTADATOS);

        // Buscar siguiente folio del concepto
        var documentoService = services.GetRequiredService<IDocumentoService>();
        tLlaveDoc llaveDocumento = documentoService.BuscarSiguienteSerieYFolio("PRUEBAFACTURA");

        // Crear estructura de una factura
        var documento = new Documento
        {
            Concepto = new ConceptoDocumento { Codigo = "PRUEBAFACTURA" },
            Serie = llaveDocumento.aSerie,
            Folio = (int)llaveDocumento.aFolio,
            Fecha = DateTime.Today,
            Cliente = new ClienteProveedor { Codigo = "PRUEBA" },
            Referencia = "Referencia",
            FormaPago = FormaPagoEnum._03,
            MetodoPago = MetodoPagoEnum.PPD,
            Observaciones = "Observaciones",
            Moneda = MonedaEnum.PesoMexicano.ToMoneda(),
            TipoCambio = 1,
            Agente = new Agente { Codigo = "PRUEBA" }
        };

        // Agregar datos extra
        documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA1), "Texto Extra 1");
        documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA2), "Texto Extra 2");

        // Crear estructura de un movimiento
        var movimiento = new Movimiento
        {
            Producto = new Producto { Codigo = "PRUEBA" },
            Almacen = new Almacen { Codigo = "1" },
            Unidades = 1,
            Precio = 100,
            Referencia = "Referencia",
            Observaciones = "Observaciones"
        };

        // Agregar datos extra del movimiento
        movimiento.DatosExtra.Add(nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1");

        // Agregar movimiento a la factura
        documento.Movimientos.Add(movimiento);

        // Crear factura
        int nuevoDocumentoId = documentoService.Crear(documento);

        // Crear movimientos
        var movimientoService = services.GetRequiredService<IMovimientoService>();
        foreach (Movimiento mov in documento.Movimientos) movimientoService.Crear(nuevoDocumentoId, mov);

        // Timbrar factura
        documentoService.Timbrar(llaveDocumento, "12345678a");

        // Generar XML de la factura
        documentoService.GenerarDocumentoDigital(llaveDocumento, TipoArchivoDigital.Xml);

        // Generar PDF de la factura
        documentoService.GenerarDocumentoDigital(llaveDocumento, TipoArchivoDigital.Pdf,
            @"\\AR-SERVER\Compac\Empresas\Reportes\Formatos Digitales\reportes_Servidor\COMERCIAL\Facturav40.rdl");

        // Cerrar empresa
        sdkSesionService.CerrarEmpresa();

        // Terminar sesion
        sdkSesionService.TerminarSesionSdk();
    }

    public void HacerConsultas(IServiceProvider provider)
    {
        // Buscar productos de tipo admProductos
        // admProductos es la estructura de la tabla de productos de Contpaqi Comercial y tiene todas las columnas de la tabla.
        var productoRepository = provider.GetRequiredService<IProductoRepository<admProductos>>();
        List<admProductos> productos = productoRepository.TraerTodo();

        foreach (admProductos admProductos in productos)
        {
            int prodcutoId = admProductos.CIDPRODUCTO;
            string productoCodigo = admProductos.CCODIGOPRODUCTO;
        }

        // Buscar productos de tipo ProductoDto
        // ProductoDto es una estructura simplificada de la tabla de productos de Contpaqi Comercial y solo tiene las columnas mas utilizadas.
        // Mientras las propiedades tengan el mismo nombre que la columna de la tabla, se pueden mapear automaticamente.
        var productoDtoRepository = provider.GetRequiredService<IProductoRepository<ProductoDto>>();
        List<ProductoDto> productosDto = productoDtoRepository.TraerTodo();

        foreach (ProductoDto productoDto in productosDto)
        {
            int prodcutoId = productoDto.CIDPRODUCTO;
            string productoCodigo = productoDto.CCODIGOPRODUCTO;
        }
    }
}
