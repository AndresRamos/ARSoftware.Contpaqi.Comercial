using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ClienteProveedorLookupRepository : IClienteProveedorRepository<ClienteProveedorLookup>
    {
        private readonly IContpaqiSdk _sdk;

        public ClienteProveedorLookupRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public ClienteProveedorLookup BuscarPorId(int idCliente)
        {
            return _sdk.fBuscaIdCteProv(idCliente) == SdkResultConstants.Success ? LeerDatosClienteProveedorActual() : null;
        }

        public ClienteProveedorLookup BuscarPorCodigo(string codigoCliente)
        {
            return _sdk.fBuscaCteProv(codigoCliente) == SdkResultConstants.Success ? LeerDatosClienteProveedorActual() : null;
        }

        public IEnumerable<ClienteProveedorLookup> TraerPorTipo(TipoClienteEnum tipoCliente)
        {
            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            var tipoDeCliente = new StringBuilder(7);
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCliente == TipoClienteHelper.ConvertToTipoClienteEnum(tipoDeCliente.ToString()))
            {
                yield return LeerDatosClienteProveedorActual();
            }

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCliente == TipoClienteHelper.ConvertToTipoClienteEnum(tipoDeCliente.ToString()))
                {
                    yield return LeerDatosClienteProveedorActual();
                }

                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<ClienteProveedorLookup> TraerTodo()
        {
            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosClienteProveedorActual();
            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                yield return LeerDatosClienteProveedorActual();
                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<ClienteProveedorLookup> TraerClientes()
        {
            var tipoDeCliente = new StringBuilder(7);

            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString()))
            {
                yield return LeerDatosClienteProveedorActual();
            }

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString()))
                {
                    yield return LeerDatosClienteProveedorActual();
                }

                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<ClienteProveedorLookup> TraerProveedores()
        {
            var tipoDeCliente = new StringBuilder(7);

            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString()))
            {
                yield return LeerDatosClienteProveedorActual();
            }

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString()))
                {
                    yield return LeerDatosClienteProveedorActual();
                }

                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            }
        }

        private ClienteProveedorLookup LeerDatosClienteProveedorActual()
        {
            var codigo = new StringBuilder(Constantes.kLongCodigo);
            var razonSocial = new StringBuilder(Constantes.kLongNombre);
            var rfc = new StringBuilder(Constantes.kLongRFC);
            var tipoCliente = new StringBuilder(7);
            var estatus = new StringBuilder(7);
            var id = new StringBuilder(12);

            _sdk.fLeeDatoCteProv("CCODIGOCLIENTE", codigo, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CRAZONSOCIAL", razonSocial, Constantes.kLongNombre).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CRFC", rfc, Constantes.kLongRFC).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CESTATUS", estatus, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CIDCLIENTEPROVEEDOR", id, 12).ToResultadoSdk(_sdk).ThrowIfError();

            var clienteProveedor = new ClienteProveedorLookup();
            clienteProveedor.Codigo = codigo.ToString();
            clienteProveedor.RazonSocial = razonSocial.ToString();
            clienteProveedor.Tipo = TipoClienteHelper.ConvertToTipoClienteEnum(tipoCliente.ToString());
            clienteProveedor.Estatus = int.Parse(estatus.ToString());

            clienteProveedor.Id = int.Parse(id.ToString());

            return clienteProveedor;
        }
    }
}