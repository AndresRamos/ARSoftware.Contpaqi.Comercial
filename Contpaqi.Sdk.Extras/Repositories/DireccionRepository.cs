using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class DireccionRepository : IDireccionRepository<Direccion>
    {
        private readonly IContpaqiSdk _sdk;

        public DireccionRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public Direccion BuscarPorId(int idDireccion)
        {
            var idDireccionDato = new StringBuilder(12);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
            if (idDireccion == int.Parse(idDireccionDato.ToString()))
            {
                return LeerDatosDireccionActual();
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
                if (idDireccion == int.Parse(idDireccionDato.ToString()))
                {
                    return LeerDatosDireccionActual();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }

            return null;
        }

        public Direccion BuscarPorCliente(string codigoClienteProveedor, byte tipoDireccion)
        {
            return _sdk.fBuscaDireccionCteProv(codigoClienteProveedor, tipoDireccion) == SdkResultConstants.Success ? LeerDatosDireccionActual() : null;
        }

        public Direccion BuscarPorDocumento(int idDocumento, byte tipoDireccion)
        {
            return _sdk.fBuscaDireccionDocumento(idDocumento, tipoDireccion) == SdkResultConstants.Success ? LeerDatosDireccionActual() : null;
        }

        public IEnumerable<Direccion> TraerTodo()
        {
            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosDireccionActual();

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                yield return LeerDatosDireccionActual();

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<Direccion> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion)
        {
            var tipoCatalogo = new StringBuilder(7);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertToTipoCatalogoDireccion(tipoCatalogo.ToString()))
            {
                yield return LeerDatosDireccionActual();
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertToTipoCatalogoDireccion(tipoCatalogo.ToString()))
                {
                    yield return LeerDatosDireccionActual();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<Direccion> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
        {
            var tipoCatalogo = new StringBuilder(7);
            var idCatalogoDato = new StringBuilder(12);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogoDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertToTipoCatalogoDireccion(tipoCatalogo.ToString()) &&
                idCatalogo == int.Parse(idCatalogoDato.ToString()))
            {
                yield return LeerDatosDireccionActual();
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
                _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogoDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertToTipoCatalogoDireccion(tipoCatalogo.ToString()) &&
                    idCatalogo == int.Parse(idCatalogoDato.ToString()))
                {
                    yield return LeerDatosDireccionActual();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }
        }

        private Direccion LeerDatosDireccionActual()
        {
            var tipoCatalogo = new StringBuilder(7);
            var tipoDireccion = new StringBuilder(7);
            var nombreCalle = new StringBuilder(61);
            var numeroExterior = new StringBuilder(31);
            var numeroInterior = new StringBuilder(31);
            var colonia = new StringBuilder(61);
            var codigoPostal = new StringBuilder(7);
            var telefono1 = new StringBuilder(16);
            var telefono2 = new StringBuilder(16);
            var telefono3 = new StringBuilder(16);
            var telefono4 = new StringBuilder(16);
            var email = new StringBuilder(51);
            var direccionWeb = new StringBuilder(51);
            var ciudad = new StringBuilder(61);
            var estado = new StringBuilder(61);
            var pais = new StringBuilder(61);
            var textoExtra = new StringBuilder(61);
            var idDireccion = new StringBuilder(12);
            var idCatalogo = new StringBuilder(12);

            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTIPODIRECCION", tipoDireccion, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CNOMBRECALLE", nombreCalle, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CNUMEROEXTERIOR", numeroExterior, 31).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CNUMEROINTERIOR", numeroInterior, 31).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CCOLONIA", colonia, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CCODIGOPOSTAL", codigoPostal, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTELEFONO1", telefono1, 16).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTELEFONO2", telefono2, 16).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTELEFONO3", telefono3, 16).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTELEFONO4", telefono4, 16).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CEMAIL", email, 51).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CDIRECCIONWEB", direccionWeb, 51).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CCIUDAD", ciudad, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CESTADO", estado, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CPAIS", pais, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTEXTOEXTRA", textoExtra, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccion, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogo, 12).ToResultadoSdk(_sdk).ThrowIfError();

            var direccion = new Direccion();
            direccion.TipoCatalogo = TipoCatalogoDireccionHelper.ConvertToTipoCatalogoDireccion(tipoCatalogo.ToString());
            direccion.TipoDireccion = TipoDireccionHelper.ToTipoDireccion(tipoDireccion.ToString());
            direccion.NombreCalle = nombreCalle.ToString();
            direccion.NumeroExterior = numeroExterior.ToString();
            direccion.NumeroInterior = numeroInterior.ToString();
            direccion.Colonia = colonia.ToString();
            direccion.CodigoPostal = codigoPostal.ToString();
            direccion.Telefono1 = telefono1.ToString();
            direccion.Telefono2 = telefono2.ToString();
            direccion.Telefono3 = telefono3.ToString();
            direccion.Telefono4 = telefono4.ToString();
            direccion.Email = email.ToString();
            direccion.DireccionWeb = direccionWeb.ToString();
            direccion.Ciudad = ciudad.ToString();
            direccion.Estado = estado.ToString();
            direccion.Pais = pais.ToString();
            direccion.TextoExtra = textoExtra.ToString();
            direccion.Id = int.Parse(idDireccion.ToString());
            direccion.IdCatalogo = int.Parse(idCatalogo.ToString());
            if ((direccion.TipoCatalogo == TipoCatalogoDireccion.Clientes || direccion.TipoCatalogo == TipoCatalogoDireccion.Proveedores) && _sdk.fBuscaIdCteProv(direccion.IdCatalogo) == SdkResultConstants.Success)
            {
                var codigoCliente = new StringBuilder(Constantes.kLongCodigo);
                _sdk.fLeeDatoCteProv("CCODIGOCLIENTE", codigoCliente, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
                direccion.CodigoClienteProveedor = codigoCliente.ToString();
            }

            return direccion;
        }
    }
}