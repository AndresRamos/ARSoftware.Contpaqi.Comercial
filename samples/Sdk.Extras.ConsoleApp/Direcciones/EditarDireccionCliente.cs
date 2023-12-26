using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp.Direcciones;

public sealed class EditarDireccionCliente
{
    private readonly IDireccionService _direccionService;

    public EditarDireccionCliente(IDireccionService direccionService)
    {
        _direccionService = direccionService;
    }

    public void EditarFiscal()
    {
        var codigoCliente = "CTE003";

        var direccion = new Direccion
        {
            TipoCatalogo = TipoCatalogoDireccion.Clientes,
            Tipo = TipoDireccion.Fiscal,
            Calle = "Calle",
            NumeroExterior = "1",
            NumeroInterior = "1",
            Colonia = "Colonia",
            Ciudad = "Ciudad",
            Estado = "Estado",
            CodigoPostal = "123456",
            Pais = "México",
            DatosExtra = new Dictionary<string, string>
            {
                { nameof(admDomicilios.CTELEFONO1), "1234567890" },
                { nameof(admDomicilios.CTELEFONO2), "1234567890" },
                { nameof(admDomicilios.CEMAIL), "sdk@contpaqi.com" },
                { nameof(admDomicilios.CDIRECCIONWEB), "https://www.contpaqi.com" }
            }
        };

        _direccionService.Actualizar(codigoCliente, direccion);
    }
}
