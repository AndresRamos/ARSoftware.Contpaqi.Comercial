using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Services
{
    public class ClienteProveedorService : IClienteProveedorService
    {
        private readonly IContpaqiSdk _sdk;

        public ClienteProveedorService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public int Crear(tCteProv clienteProveedor)
        {
            var idClienteProveedor = 0;
            _sdk.fAltaCteProv(ref idClienteProveedor, ref clienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
            return idClienteProveedor;
        }

        public void Actualizar(int idClienteProveedor, Dictionary<string, string> datosClienteProveedor)
        {
            _sdk.fBuscaIdCteProv(idClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaCteProv().ToResultadoSdk(_sdk).ThrowIfError();

            foreach (var dato in datosClienteProveedor)
            {
                _sdk.fSetDatoCteProv(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }

            _sdk.fGuardaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Actualizar(tCteProv clienteProveedor)
        {
            _sdk.fActualizaCteProv(clienteProveedor.cCodigoCliente, ref clienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Eliminar(int idClienteProveedor)
        {
            _sdk.fBuscaIdCteProv(idClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fBorraCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        }
    }
}