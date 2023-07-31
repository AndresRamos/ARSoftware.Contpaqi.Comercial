using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar movimientos.
/// </summary>
/// <typeparam name="T">
///     El tipo de movimiento utilizado por el repositorio.
/// </typeparam>
public class MovimientoSdkRepository<T> : IMovimientoRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public MovimientoSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idMovimiento)
    {
        return _sdk.fBuscarIdMovimiento(idMovimiento) == SdkResultConstants.Success ? LeerDatosMovimientoActual() : null;
    }

    /// <inheritdoc />
    public List<T> TraerPorDocumentoId(int idDocumento)
    {
        var lista = new List<T>();

        _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

        SdkResult resultadoSdk = _sdk.fSetFiltroMovimiento(idDocumento).ToResultadoSdk(_sdk);

        if (!resultadoSdk.IsSuccess)
        {
            _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

            if (resultadoSdk.Result ==
                2) // Si el resultado es "2" significa que no hay movimientos en el filtro pero no creo que se considere un error para tirar una excepcion
                return lista;

            resultadoSdk.ThrowIfError();
        }

        _sdk.fPosPrimerMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosMovimientoActual());

        while (_sdk.fPosSiguienteMovimiento() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosMovimientoActual());
            if (_sdk.fPosMovimientoEOF() == 1) break;
        }

        _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosMovimientoActual());
        while (_sdk.fPosSiguienteMovimiento() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosMovimientoActual());
            if (_sdk.fPosMovimientoEOF() == 1) break;
        }

        return lista;
    }

    private T LeerDatosMovimientoActual()
    {
        var movimiento = new T();

        //movimiento.Consecutivo = double.TryParse(consecutivo.ToString(), out var consecutivoReslt) ? Convert.ToInt32(consecutivoReslt) : 0; // Int.Parse falla por que regresa 1.00

        LeerYAsignarDatos(movimiento);

        return movimiento;
    }

    private void LeerYAsignarDatos(T movimiento)
    {
        Type sqlModelType = typeof(admMovimientos);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(movimiento,
                    _sdk.LeeDatoMovimiento(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
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
