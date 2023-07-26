using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarEmpresasConRepositorio : IBuscarEmpresas
{
    private readonly EmpresaSqlRepository _empresaRepository;
    private readonly ILogger<BuscarEmpresasConRepositorio> _logger;

    public BuscarEmpresasConRepositorio(EmpresaSqlRepository empresaRepository, ILogger<BuscarEmpresasConRepositorio> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    public void TraerTodo()
    {
        List<Empresas> empresas = _empresaRepository.TraerTodo().ToList();

        _logger.LogInformation("{@Empresas}", empresas);
    }

    public void CorrerEjemplos()
    {
        TraerTodo();
    }
}