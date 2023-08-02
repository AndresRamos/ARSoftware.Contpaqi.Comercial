using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarEmpresasDtoConRepositorio : IBuscarEmpresas
{
    private readonly IEmpresaRepository<EmpresaDto> _empresaRepository;
    private readonly ILogger<BuscarEmpresasDtoConRepositorio> _logger;

    public BuscarEmpresasDtoConRepositorio(IEmpresaRepository<EmpresaDto> empresaRepository,
        ILogger<BuscarEmpresasDtoConRepositorio> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorNombre()
    {
        var nombreEmpresa = "EMPRESA PRUEBA";

        EmpresaDto? empresa = _empresaRepository.BuscarPorNombre(nombreEmpresa);

        _logger.LogInformation("{@Empresa}", empresa);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<EmpresaDto> empresas = _empresaRepository.TraerTodo().ToList();

        _logger.LogInformation("{@Empresas}", empresas);
    }
}
