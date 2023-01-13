using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Catalogos;

public sealed class EmpresaSdk
{
    private readonly IEmpresaRepository<Empresa> _empresaRepository;
    private readonly ILogger<EmpresaSdk> _logger;

    public EmpresaSdk(IEmpresaRepository<Empresa> empresaRepository, ILogger<EmpresaSdk> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    public List<Empresa> BuscarEmpresas()
    {
        return _empresaRepository.TraerTodo().ToList();
    }

    public void LogEmpresas(IEnumerable<Empresa> empresas)
    {
        foreach (Empresa empresa in empresas)
            _logger.LogInformation("{@Empresa}", empresa);
    }
}
