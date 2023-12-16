using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp.Direcciones;

public sealed class ActualizarDireccionCliente
{
    private readonly IDireccionService _direccionService;

    public ActualizarDireccionCliente(IDireccionService direccionService)
    {
        _direccionService = direccionService;
    }

    public void ActualizarFiscal()
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

        tDireccion direccionSdk = direccion.ToSdkDireccion();
        direccionSdk.cCodCteProv = codigoCliente;

        _direccionService.Actualizar(direccionSdk);
    }
}
