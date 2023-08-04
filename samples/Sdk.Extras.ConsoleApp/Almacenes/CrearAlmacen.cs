using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class CrearAlmacen
{
    private readonly IAlmacenService _almacenService;

    public CrearAlmacen(IAlmacenService almacenService)
    {
        _almacenService = almacenService;
    }

    public int Crear()
    {
        var almacen = new Almacen { Codigo = "PRUEBA", Nombre = "ALMACEN DE PRUEBAS" };

        almacen.DatosExtra.Add(nameof(admAlmacenes.CFECHAALTAALMACEN), DateTime.Today.ToSdkFecha());
        almacen.DatosExtra.Add(nameof(admAlmacenes.CTEXTOEXTRA1), "Texto Extra 1");

        return _almacenService.Crear(almacen);
    }
}
