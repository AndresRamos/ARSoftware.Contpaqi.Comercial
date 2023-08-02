using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IUnidadMedidaService
{
    void Actualizar(string nombreUnidad, tUnidad unidad);
    void Actualizar(int idUnidad, Dictionary<string, string> datosUnidad);
    int Crear(tUnidad unidad);
    int Crear(Dictionary<string, string> datosUnidad);
    public int Crear(UnidadMedida unidad);
    void Eliminar(int idUnidad);
    void Eliminar(string codigoUnidad);
}
