using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Direcciones;

public sealed class BuscarDireccionCliente
{
    private readonly IDireccionRepository<DireccionDto> _direccionRepository;
    private readonly ILogger<BuscarDireccionCliente> _logger;

    public BuscarDireccionCliente(IDireccionRepository<DireccionDto> direccionRepository, ILogger<BuscarDireccionCliente> logger)
    {
        _direccionRepository = direccionRepository;
        _logger = logger;
    }

    public void Buscar()
    {
        var codigoCliente = "PRUEBA";
        var tipoDireccion = TipoDireccion.Fiscal;

        DireccionDto? direccion = _direccionRepository.BuscarPorCliente(codigoCliente, tipoDireccion);

        _logger.LogInformation("{@Direccion}", direccion);
    }
}
