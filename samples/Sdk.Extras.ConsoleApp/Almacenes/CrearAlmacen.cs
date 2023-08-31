using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
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

        almacen.DatosExtra.Add(nameof(admAlmacenes.CTEXTOEXTRA1), "Texto extra 2");
        almacen.DatosExtra.Add(nameof(admAlmacenes.CTEXTOEXTRA2), "Texto extra 2");

        int nuevoAlmacenId = _almacenService.Crear(almacen);

        return nuevoAlmacenId;
    }
}
