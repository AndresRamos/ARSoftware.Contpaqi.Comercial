using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarProducto
{
    private readonly IMapper _mapper;
    private readonly IProductoRepository<ProductoDto> _productoRepository;
    private readonly IProductoService _productoService;

    public EditarProducto(IProductoService productoService, IProductoRepository<ProductoDto> productoRepository, IMapper mapper)
    {
        _productoService = productoService;
        _mapper = mapper;
        _productoRepository = productoRepository;
    }

    public void Editar()
    {
        var codigoProducto = "PRUEBA";

        ProductoDto? productoDto = _productoRepository.BuscarPorCodigo(codigoProducto);

        var producto = _mapper.Map<Producto>(productoDto);

        producto.Nombre = "PRODUCTO DE PRUEBAS MODIFICADO";
        producto.ClaveSat = "43231500";
        producto.DatosExtra.Add(nameof(admProductos.CTEXTOEXTRA1), "Texto Extra 1");

        _productoService.Actualizar(producto);
    }

    public void EditarConDiccionario()
    {
        var codigoProducto = "PRUEBA";

        var datosProducto = new Dictionary<string, string>
        {
            { nameof(admProductos.CTEXTOEXTRA1), "Texto Extra 1" },
            { nameof(admProductos.CTEXTOEXTRA2), "Texto Extra 2" },
            { nameof(admProductos.CTEXTOEXTRA3), "Texto Extra 3" }
        };

        _productoService.Actualizar(codigoProducto, datosProducto);
    }
}
