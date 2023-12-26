using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarCliente
{
    private readonly IClienteProveedorRepository<ClienteProveedorDto> _clienteProveedorRepository;
    private readonly IClienteProveedorService _clienteProveedorService;
    private readonly IMapper _mapper;

    public EditarCliente(IClienteProveedorService clienteProveedorService,
        IClienteProveedorRepository<ClienteProveedorDto> clienteProveedorRepository, IMapper mapper)
    {
        _clienteProveedorService = clienteProveedorService;
        _clienteProveedorRepository = clienteProveedorRepository;
        _mapper = mapper;
    }

    public void Editar()
    {
        var codigoCliente = "PRUEBA";

        ClienteProveedorDto? clienteProveedorDto = _clienteProveedorRepository.BuscarPorCodigo(codigoCliente);

        var cliente = _mapper.Map<ClienteProveedor>(clienteProveedorDto);

        cliente.RazonSocial = "CLIENTE DE PRUEBAS MODIFICADO";
        cliente.UsoCfdi = UsoCfdiEnum.S01;
        cliente.DatosExtra.Add(nameof(admClientes.CTEXTOEXTRA1), "Texto Extra 1");

        _clienteProveedorService.Actualizar(cliente);
    }

    public void EditarConDiccionario()
    {
        var codigoCliente = "PRUEBA";

        var datosCliente = new Dictionary<string, string>
        {
            { nameof(admClientes.CRAZONSOCIAL), "CLIENTE DE PRUEBAS MODIFICADO" },
            { nameof(admClientes.CTEXTOEXTRA1), "Texto Modificado" },
            { nameof(admClientes.CTEXTOEXTRA2), "Texto Extra 2" }
        };

        _clienteProveedorService.Actualizar(codigoCliente, datosCliente);
    }
}
