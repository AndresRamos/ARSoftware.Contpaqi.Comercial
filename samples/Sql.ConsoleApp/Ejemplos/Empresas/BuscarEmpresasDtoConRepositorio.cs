using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarEmpresasDtoConRepositorio : IBuscarEmpresas
{
    private readonly EmpresaSqlRepository<EmpresaDto> _empresaRepository;
    private readonly ILogger<BuscarEmpresasDtoConRepositorio> _logger;

    public BuscarEmpresasDtoConRepositorio(EmpresaSqlRepository<EmpresaDto> empresaRepository,
        ILogger<BuscarEmpresasDtoConRepositorio> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    public void TraerTodo()
    {
        List<EmpresaDto> empresas = _empresaRepository.TraerTodo().ToList();

        _logger.LogInformation("{@Empresas}", empresas);
    }

    public void CorrerEjemplos()
    {
        TraerTodo();
    }
}