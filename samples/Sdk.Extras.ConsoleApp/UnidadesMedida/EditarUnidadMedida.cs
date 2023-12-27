using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarUnidadMedida
{
    private readonly IMapper _mapper;
    private readonly IUnidadMedidaRepository<UnidadMedidaDto> _unidadMedidaRepository;
    private readonly IUnidadMedidaService _unidadMedidaService;

    public EditarUnidadMedida(IUnidadMedidaService unidadMedidaService, IUnidadMedidaRepository<UnidadMedidaDto> unidadMedidaRepository,
        IMapper mapper)
    {
        _unidadMedidaService = unidadMedidaService;
        _unidadMedidaRepository = unidadMedidaRepository;
        _mapper = mapper;
    }

    public void Editar()
    {
        var nombreUnidad = "SERVICIO";

        UnidadMedidaDto? unidadMedidaDto = _unidadMedidaRepository.BuscarPorNombre(nombreUnidad);

        var unidadMedida = _mapper.Map<UnidadMedida>(unidadMedidaDto);

        unidadMedida.Abreviatura = "SER";
        unidadMedida.ClaveSat = "E48";

        _unidadMedidaService.Actualizar(unidadMedida);
    }

    public void EditarCondiccionario()
    {
        var nombreUnidad = "PRUEBA";

        var datosUnidad = new Dictionary<string, string>
        {
            { nameof(admUnidadesMedidaPeso.CABREVIATURA), "KG" },
            { nameof(admUnidadesMedidaPeso.CCLAVEINT), "KGM" }, // CCLAVEINT es la clave SAT
            { nameof(admUnidadesMedidaPeso.CCLAVESAT), "01" } // CCLAVESAT es la clave SAT del complemente de comercio exterior
        };

        _unidadMedidaService.Actualizar(nombreUnidad, datosUnidad);
    }
}
