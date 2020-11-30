using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Helpers;
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

        public int Crear(int idDocumento, tMovimiento movimiento)
        {
            var movimientoId = 0;
            _sdk.fAltaMovimiento(idDocumento, ref movimientoId, ref movimiento).ToResultadoSdk(_sdk).ThrowIfError();
            return movimientoId;
        }

        public void Actualizar(int idMovimiento, Dictionary<string, string> datosMovimiento)
        {
            _sdk.fBuscarIdMovimiento(idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditarMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

            foreach (var dato in datosMovimiento)
            {
                _sdk.fSetDatoMovimiento(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }

            _sdk.fGuardaMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Eliminar(int idDocumento, int idMovimiento)
        {
            _sdk.fBuscarIdMovimiento(idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fBorraMovimiento(idDocumento, idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
        }
    }
}