using System.Collections.Generic;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar empresas.
/// </summary>
public class EmpresaSdkRepository : IEmpresaRepository<Empresas>
{
    private readonly IContpaqiSdk _sdk;

    public EmpresaSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public Empresas? BuscarPorNombre(string nombreEmpresa)
    {
        var id = 0;
        var nombre = new StringBuilder(SdkConstantes.kLongNombre);
        var ruta = new StringBuilder(SdkConstantes.kLongRuta);

        _sdk.fPosPrimerEmpresa(ref id, nombre, ruta).ToResultadoSdk(_sdk).ThrowIfError();
        var empresa = new Empresas();
        empresa.CIDEMPRESA = id;
        empresa.CNOMBREEMPRESA = nombre.ToString();
        empresa.CRUTADATOS = ruta.ToString();
        empresa.CRUTARESPALDOS = ruta.ToString();

        if (empresa.CNOMBREEMPRESA == nombreEmpresa) return empresa;

        while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == SdkResultConstants.Success)
        {
            empresa = new Empresas();
            empresa.CIDEMPRESA = id;
            empresa.CNOMBREEMPRESA = nombre.ToString();
            empresa.CRUTADATOS = ruta.ToString();
            empresa.CRUTARESPALDOS = ruta.ToString();

            if (empresa.CNOMBREEMPRESA == nombreEmpresa) return empresa;
        }

        return null;
    }

    /// <inheritdoc />
    public List<Empresas> TraerTodo()
    {
        var lista = new List<Empresas>();
        var id = 0;
        var nombre = new StringBuilder(SdkConstantes.kLongNombre);
        var ruta = new StringBuilder(SdkConstantes.kLongRuta);

        _sdk.fPosPrimerEmpresa(ref id, nombre, ruta).ToResultadoSdk(_sdk).ThrowIfError();
        var empresa = new Empresas();
        empresa.CIDEMPRESA = id;
        empresa.CNOMBREEMPRESA = nombre.ToString();
        empresa.CRUTADATOS = ruta.ToString();
        empresa.CRUTARESPALDOS = ruta.ToString();
        lista.Add(empresa);

        while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == SdkResultConstants.Success)
        {
            empresa = new Empresas();
            empresa.CIDEMPRESA = id;
            empresa.CNOMBREEMPRESA = nombre.ToString();
            empresa.CRUTADATOS = ruta.ToString();
            empresa.CRUTARESPALDOS = ruta.ToString();
            lista.Add(empresa);
        }

        return lista;
    }
}
