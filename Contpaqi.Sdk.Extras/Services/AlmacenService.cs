using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services
{
    public class AlmacenService : IAlmacenService
    {
        private readonly IContpaqiSdk _sdk;

        public AlmacenService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public void Actualizar(int idAlmacen, Dictionary<string, string> datosAlmacen)
        {
            _sdk.fBuscaIdAlmacen(idAlmacen).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosAlmacen);
            _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Actualizar(string codigoAlmacen, Dictionary<string, string> datosAlmacen)
        {
            _sdk.fBuscaAlmacen(codigoAlmacen).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosAlmacen);
            _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public int Crear(Dictionary<string, string> datosAlmacen)
        {
            _sdk.fInsertaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosAlmacen);
            _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            string idAlmacenDato = _sdk.LeeDatoAlmacen(nameof(admAlmacenes.CIDALMACEN), 12);
            return int.Parse(idAlmacenDato);
        }

        public void SetDatos(Dictionary<string, string> datos)
        {
            foreach (KeyValuePair<string, string> dato in datos)
            {
                _sdk.fSetDatoAlmacen(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }
        }
    }
}
