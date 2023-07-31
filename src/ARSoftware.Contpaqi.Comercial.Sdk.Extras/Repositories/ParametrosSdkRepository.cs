using System;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar parametros.
/// </summary>
/// <typeparam name="T">
///     El tipo de parametros utilizado por el repositorio.
/// </typeparam>
public class ParametrosSdkRepository<T> : IParametrosRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public ParametrosSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T Buscar()
    {
        var parametros = new T();

        LeerYAsignarDatos(parametros);

        return parametros;
    }

    private void LeerYAsignarDatos(T parametros)
    {
        Type sqlModelType = typeof(admParametros);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(parametros,
                    _sdk.LeeDatoParametros(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
            }
            catch (ContpaqiSdkException e)
            {
                // Hay propiedades en Comercial que no estan en el esquema de la base de datos de Factura Electronica
                if (e.CodigoErrorSdk == SdkErrorConstants.NombreCampoInvalido) continue;

                throw new ContpaqiSdkInvalidOperationException(
                    $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                    e);
            }
        }
    }
}
