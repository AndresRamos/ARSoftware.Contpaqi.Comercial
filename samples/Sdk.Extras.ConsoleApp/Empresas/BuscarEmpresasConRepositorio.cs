using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarEmpresasConRepositorio : IBuscarEmpresas
{
    private readonly IEmpresaRepository<Empresas> _empresaRepository;
    private readonly ILogger<BuscarEmpresasConRepositorio> _logger;

    public BuscarEmpresasConRepositorio(IEmpresaRepository<Empresas> empresaRepository, ILogger<BuscarEmpresasConRepositorio> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorNombre()
    {
        var nombreEmpresa = "EMPRESA PRUEBA";

        Empresas? empresa = _empresaRepository.BuscarPorNombre(nombreEmpresa);

        _logger.LogInformation("{@Empresa}", empresa);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<Empresas> empresas = _empresaRepository.TraerTodo().ToList();

        _logger.LogInformation("{@Empresas}", empresas);
    }
}
