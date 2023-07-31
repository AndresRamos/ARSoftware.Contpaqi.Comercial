using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

namespace Sdk.ConsoleApp.Catalogos;

/// <summary>
///     Tabla Empresas - Tabla de Empresas
/// </summary>
public sealed class EmpresaSdk
{
    /// <summary>
    ///     Campo CIDEMPRESA - Identificador de la empresa.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Campo CNOMBREEMPRESA - Nombre de la empresa.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    ///     Campo CRUTADATOS - Ruta de la empresa.
    /// </summary>
    public string Ruta { get; set; }

    /// <summary>
    ///     Busca la lista de empresas del sistema.
    /// </summary>
    /// <returns>Lista de empresas del sistema.</returns>
    public static List<EmpresaSdk> BuscarEmpresas()
    {
        var empresasList = new List<EmpresaSdk>();

        // Declarar variables a leer de la base de datos
        var idBd = 0;
        var nombreBd = new StringBuilder(SdkConstantes.kLongNombre);
        var rutaBd = new StringBuilder(SdkConstantes.kLongRuta);

        // Posicionar el SDK en el primer registro
        int sdkResult = ComercialSdk.fPosPrimerEmpresa(ref idBd, nombreBd, rutaBd);
        if (sdkResult != SdkConstantes.CodigoExito) return empresasList;

        // Instanciar una empresa y asignar los datos de la base de datos
        empresasList.Add(new EmpresaSdk { Id = idBd, Nombre = nombreBd.ToString(), Ruta = rutaBd.ToString() });

        // Crear un loop y posicionar el SDK en el siguiente registro
        while (ComercialSdk.fPosSiguienteEmpresa(ref idBd, nombreBd, rutaBd) == SdkConstantes.CodigoExito)
            // Instanciar una empresa y asignar los datos de la base de datos       
            empresasList.Add(new EmpresaSdk { Id = idBd, Nombre = nombreBd.ToString(), Ruta = rutaBd.ToString() });

        return empresasList;
    }
}
