using System.Collections.Generic;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.DatosAbstractos;
using Contpaqi.Sdk.Extras.Extensions;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Services
{
    public class MovimientoService : IMovimientoService
    {
        private readonly IContpaqiSdk _sdk;

        public MovimientoService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public void Actualizar(int idMovimiento, Dictionary<string, string> datosMovimiento)
        {
            _sdk.fBuscarIdMovimiento(idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditarMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosMovimiento);
            _sdk.fGuardaMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public int Crear(int idDocumento, tMovimiento movimiento)
        {
            var movimientoId = 0;
            _sdk.fAltaMovimiento(idDocumento, ref movimientoId, ref movimiento).ToResultadoSdk(_sdk).ThrowIfError();
            return movimientoId;
        }

        public int Crear(Dictionary<string, string> datosMovimiento)
        {
            _sdk.fInsertarMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosMovimiento);
            _sdk.fGuardaMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            string idMovimientoDato = _sdk.LeeDatoMovimiento(nameof(admMovimientos.CIDMOVIMIENTO), 12);
            return int.Parse(idMovimientoDato);
        }

        public void Eliminar(int idDocumento, int idMovimiento)
        {
            _sdk.fBuscarIdMovimiento(idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fBorraMovimiento(idDocumento, idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void SetDatos(Dictionary<string, string> datos)
        {
            foreach (KeyValuePair<string, string> dato in datos)
            {
                _sdk.fSetDatoMovimiento(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }
        }
    }
}
