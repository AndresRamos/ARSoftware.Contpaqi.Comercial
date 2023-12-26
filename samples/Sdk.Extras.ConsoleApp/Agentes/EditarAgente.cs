using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarAgente
{
    private readonly IAgenteRepository<AgenteDto> _agenteRepository;
    private readonly IAgenteService _agenteService;
    private readonly IMapper _mapper;

    public EditarAgente(IAgenteService agenteService, IAgenteRepository<AgenteDto> agenteRepository, IMapper mapper)
    {
        _agenteService = agenteService;
        _agenteRepository = agenteRepository;
        _mapper = mapper;
    }

    public void Editar()
    {
        var codigoAgente = "PRUEBA";

        AgenteDto? agenteDto = _agenteRepository.BuscarPorCodigo(codigoAgente);

        var agente = _mapper.Map<Agente>(agenteDto);

        agente.Nombre = "AGENTE DE PRUEBAS MODIFICADO";
        agente.Tipo = TipoAgente.VentasCobro;
        agente.DatosExtra.Add(nameof(admAgentes.CCOMISIONVENTAAGENTE), "10");

        _agenteService.Actualizar(agente);
    }

    public void EditarConDiccionario()
    {
        var codigoAgente = "PRUEBA";

        var datosAgente = new Dictionary<string, string>
        {
            { nameof(admAgentes.CNOMBREAGENTE), "AGENTE DE PRUEBAS MODIFICADO" }, // Nombre del agente.
            { nameof(admAgentes.CCOMISIONVENTAAGENTE), "10" }, // Comisión de venta del agente.
            { nameof(admAgentes.CCOMISIONCOBROAGENTE), "5" }, // Comisión de cobro del agente.
            { nameof(admAgentes.CTEXTOEXTRA1), "Texto extra 1" }, // Texto extra 1.
            { nameof(admAgentes.CTEXTOEXTRA2), "Texto extra 2" }, // Texto extra 2.
            { nameof(admAgentes.CTEXTOEXTRA3), "Texto extra 3" } // Texto extra 3.
        };

        _agenteService.Actualizar(codigoAgente, datosAgente);
    }
}
