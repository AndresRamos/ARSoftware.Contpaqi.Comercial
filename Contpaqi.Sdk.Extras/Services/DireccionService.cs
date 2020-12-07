using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Services
{
    public class DireccionService : IDireccionService
    {
        private readonly IContpaqiSdk _sdk;

        public DireccionService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public int Crear(tDireccion direccion)
        {
            var idDireccion = 0;
            _sdk.fAltaDireccion(ref idDireccion, ref direccion).ToResultadoSdk(_sdk).ThrowIfError();
            return idDireccion;
        }

        public int Crear(Dictionary<string, string> datosDireccion)
        {
            _sdk.fInsertaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosDireccion(datosDireccion);
            _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();

            var idDireccionDato = new StringBuilder(12);
            _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
            return int.Parse(idDireccionDato.ToString());
        }

        public void Actualizar(tDireccion direccion)
        {
            _sdk.fActualizaDireccion(ref direccion).ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Actualizar(int idDireccion, Dictionary<string, string> datosDireccion)
        {
            var idDireccionDato = new StringBuilder(12);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
            if (idDireccion == int.Parse(idDireccionDato.ToString()))
            {
                _sdk.fEditaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                SetDatosDireccion(datosDireccion);
                _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();

                return;
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
                if (idDireccion == int.Parse(idDireccionDato.ToString()))
                {
                    _sdk.fEditaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                    SetDatosDireccion(datosDireccion);
                    _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    return;
                }
            }
        }

        private void SetDatosDireccion(Dictionary<string, string> datosDireccion)
        {
            foreach (var dato in datosDireccion)
            {
                _sdk.fSetDatoDireccion(dato.Key, dato.Value);
            }
        }
    }
}