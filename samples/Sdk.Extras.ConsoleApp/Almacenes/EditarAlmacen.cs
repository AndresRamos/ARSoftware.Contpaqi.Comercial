using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class EditarAlmacen
{
    private readonly IAlmacenService _almacenService;

    public EditarAlmacen(IAlmacenService almacenService)
    {
        _almacenService = almacenService;
    }

    public void Editar()
    {
        var almacen = new Almacen { Codigo = "PRUEBA", Nombre = "ALMACEN DE PRUEBAS MODIFICADO" };

        almacen.DatosExtra.Add(nameof(admAlmacenes.CTEXTOEXTRA1), "Texto extra 1");

        _almacenService.Actualizar(almacen);
    }

    public void EditarConDiccionario()
    {
        var codigoAlmacen = "PRUEBA";

        var datosAlmacen = new Dictionary<string, string>
        {
            { nameof(admAlmacenes.CNOMBREALMACEN), "ALMACEN DE PRUEBAS MODIFICADO" },
            { nameof(admAlmacenes.CTEXTOEXTRA1), "Texto extra 1" },
            { nameof(admAlmacenes.CTEXTOEXTRA2), "Texto extra 2" },
            { nameof(admAlmacenes.CTEXTOEXTRA3), "Texto extra 3" }
        };

        _almacenService.Actualizar(codigoAlmacen, datosAlmacen);
    }
}
