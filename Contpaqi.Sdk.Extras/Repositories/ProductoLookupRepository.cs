using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ProductoLookupRepository : IProductoRepository<ProductoLookup>
    {
        private readonly IContpaqiSdk _sdk;

        public ProductoLookupRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public ProductoLookup BuscarPorId(int idProducto)
        {
            return _sdk.fBuscaIdProducto(idProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
        }

        public ProductoLookup BuscarPorCodigo(string codigoProducto)
        {
            return _sdk.fBuscaProducto(codigoProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
        }

        public IEnumerable<ProductoLookup> TraerTodo()
        {
            _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosProductoActual();
            while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
            {
                yield return LeerDatosProductoActual();
                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<ProductoLookup> TraerPorTipo(TipoProductoEnum tipoProducto)
        {
            _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();

            var tipoProductoDato = new StringBuilder(7);
            _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoProducto == TipoProductoHelper.ConvertoToTipoProductoEnum(tipoProductoDato.ToString()))
            {
                yield return LeerDatosProductoActual();
            }

            while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();

                if (tipoProducto == TipoProductoHelper.ConvertoToTipoProductoEnum(tipoProductoDato.ToString()))
                {
                    yield return LeerDatosProductoActual();
                }

                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
        }

        private ProductoLookup LeerDatosProductoActual()
        {
            var codigoProducto = new StringBuilder(Constantes.kLongCodigo);
            var nombreProducto = new StringBuilder(Constantes.kLongNombre);
            var tipoProducto = new StringBuilder(7);
            var id = new StringBuilder(12);

            _sdk.fLeeDatoProducto("CCODIGOPRODUCTO", codigoProducto, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CNOMBREPRODUCTO", nombreProducto, Constantes.kLongNombre).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProducto, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDPRODUCTO", id, 12).ToResultadoSdk(_sdk).ThrowIfError();

            var productoComercial = new ProductoLookup();
            productoComercial.Codigo = codigoProducto.ToString();
            productoComercial.Nombre = nombreProducto.ToString();
            productoComercial.Tipo = int.Parse(tipoProducto.ToString());
            productoComercial.Id = int.Parse(id.ToString());

            return productoComercial;
        }
    }
}