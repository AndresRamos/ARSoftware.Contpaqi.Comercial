using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp.Direcciones;

public sealed class CrearDireccionCliente
{
    private readonly IDireccionService _direccionService;

    public CrearDireccionCliente(IDireccionService direccionService)
    {
        _direccionService = direccionService;
    }

    public int Crear()
    {
        var codigoCliente = "PRUEBA";

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
            Pais = "México"
        };

        return _direccionService.Crear(codigoCliente, direccion);
    }
}
