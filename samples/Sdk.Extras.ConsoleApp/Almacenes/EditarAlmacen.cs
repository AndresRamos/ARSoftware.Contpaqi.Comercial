using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarAlmacen
{
    private readonly IAlmacenRepository<AlmacenDto> _almacenRepository;
    private readonly IAlmacenService _almacenService;
    private readonly IMapper _mapper;

    public EditarAlmacen(IAlmacenService almacenService, IAlmacenRepository<AlmacenDto> almacenRepository, IMapper mapper)
    {
        _almacenService = almacenService;
        _almacenRepository = almacenRepository;
        _mapper = mapper;
    }

    public void Editar()
    {
        var codigoAlmacen = "PRUEBA";

        AlmacenDto? almacenDto = _almacenRepository.BuscarPorCodigo(codigoAlmacen);

        var almacen = _mapper.Map<Almacen>(almacenDto);

        almacen.Nombre = "ALMACEN DE PRUEBAS MODIFICADO";
        almacen.DatosExtra.Add(nameof(admAlmacenes.CTEXTOEXTRA1), "Texto extra 1");

        _almacenService.Actualizar(almacen);
    }

    public void EditarConDiccionario()
    {
        var codigoAlmacen = "PRUEBA";

        var datosAlmacen = new Dictionary<string, string>
        {
            { nameof(admAlmacenes.CNOMBREALMACEN), "ALMACEN DE PRUEBAS MODIFICADO" },
            { nameof(admAlmacenes.CTEXTOEXTRA1), "Texto extra 1" },
            { nameof(admAlmacenes.CTEXTOEXTRA2), "Texto extra 2" },
            { nameof(admAlmacenes.CTEXTOEXTRA3), "Texto extra 3" }
        };

        _almacenService.Actualizar(codigoAlmacen, datosAlmacen);
    }
}
