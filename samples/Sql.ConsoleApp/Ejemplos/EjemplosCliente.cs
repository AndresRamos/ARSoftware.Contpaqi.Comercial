using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common.Models.Dtos;

namespace Sql.ConsoleApp.Ejemplos;

internal class EjemplosCliente
{
    private readonly ContpaqiComercialEmpresaDbContext _empresaDbContext;
    private readonly ILogger<EjemplosProducto> _logger;

    public EjemplosCliente(ContpaqiComercialEmpresaDbContext empresaDbContext, ILogger<EjemplosProducto> logger)
    {
        _empresaDbContext = empresaDbContext;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de clientes.");

        BuscarTodosLosClientes();

        BuscarTodosLosClientesUtilizandoDto();
    }

    private void BuscarTodosLosClientes()
    {
        _logger.LogInformation("Buscando todos los clientes.");
        long startTime = Stopwatch.GetTimestamp();
        List<admClientes> clientes = _empresaDbContext.admClientes.OrderBy(c => c.CRAZONSOCIAL).ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} clientes.", clientes.Count);
        foreach (admClientes cliente in clientes)
            LogCliente(cliente);
    }

    private void BuscarTodosLosClientesUtilizandoDto()
    {
        _logger.LogInformation("Buscando todos los clientes utilizando un DTO.");
        long startTime = Stopwatch.GetTimestamp();
        List<ClienteDto> clientes = _empresaDbContext.admClientes.OrderBy(c => c.CRAZONSOCIAL)
            .Select(c => new ClienteDto
            {
                CIDCLIENTEPROVEEDOR = c.CIDCLIENTEPROVEEDOR,
                CCODIGOCLIENTE = c.CCODIGOCLIENTE,
                CRAZONSOCIAL = c.CRAZONSOCIAL,
                CRFC = c.CRFC,
                CTIPOCLIENTE = c.CTIPOCLIENTE,
                CUSOCFDI = c.CUSOCFDI,
                CREGIMFISC = c.CREGIMFISC
            })
            .ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} clientes.", clientes.Count);
        foreach (ClienteDto cliente in clientes)
            LogCliente(cliente);
    }

    private void LogCliente(admClientes clienteProveedor)
    {
        _logger.LogInformation(
            "Id: {Id}, Codigo: {Codigo}, Razon Social: {RazonSocial}, RFC: {Rfc}, Tipo: {Tipo}, Uso CFDI: {UsoCfdi}, Regimen Fiscal: {RegimenFiscal}",
            clienteProveedor.CIDCLIENTEPROVEEDOR,
            clienteProveedor.CCODIGOCLIENTE,
            clienteProveedor.CRAZONSOCIAL,
            clienteProveedor.CRFC,
            clienteProveedor.CTIPOCLIENTE,
            clienteProveedor.CUSOCFDI,
            clienteProveedor.CREGIMFISC);
    }

    private void LogCliente(ClienteDto clienteProveedor)
    {
        _logger.LogInformation(
            "Id: {Id}, Codigo: {Codigo}, Razon Social: {RazonSocial}, RFC: {Rfc}, Tipo: {Tipo}, Uso CFDI: {UsoCfdi}, Regimen Fiscal: {RegimenFiscal}",
            clienteProveedor.CIDCLIENTEPROVEEDOR,
            clienteProveedor.CCODIGOCLIENTE,
            clienteProveedor.CRAZONSOCIAL,
            clienteProveedor.CRFC,
            clienteProveedor.CTIPOCLIENTE,
            clienteProveedor.CUSOCFDI,
            clienteProveedor.CREGIMFISC);
    }
}
