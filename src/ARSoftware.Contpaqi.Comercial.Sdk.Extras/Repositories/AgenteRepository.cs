using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para buscar agentes.
/// </summary>
/// <typeparam name="T"> El tipo de agente utilizado por el repositorio.</typeparam>
public class AgenteRepository<T> : IAgenteRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public AgenteRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T BuscarPorCodigo(string codigoAgente)
    {
        return _sdk.fBuscaAgente(codigoAgente) == SdkResultConstants.Success ? LeerDatosAgenteActual() : null;
    }

    /// <inheritdoc />
    public T BuscarPorId(int idAgente)
    {
        return _sdk.fBuscaIdAgente(idAgente) == SdkResultConstants.Success ? LeerDatosAgenteActual() : null;
    }

    /// <inheritdoc />
    public IEnumerable<T> TraerTodo()
    {
        _sdk.fPosPrimerAgente().ToResultadoSdk(_sdk).ThrowIfError();
        yield return LeerDatosAgenteActual();

        while (_sdk.fPosSiguienteAgente() == SdkResultConstants.Success)
        {
            yield return LeerDatosAgenteActual();
            if (_sdk.fPosEOFAgente() == 1) break;
        }
    }

    private T LeerDatosAgenteActual()
    {
        var agente = new T();

        LeerYAsignarDatos(agente);

        return agente;
    }

    private void LeerYAsignarDatos(T agente)
    {
        Type sqlModelType = typeof(admAgentes);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(agente,
                    _sdk.LeeDatoAgente(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
            }
            catch (ContpaqiSdkException e)
            {
                throw new ContpaqiSdkInvalidOperationException(
                    $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                    e);
            }
        }
    }
}