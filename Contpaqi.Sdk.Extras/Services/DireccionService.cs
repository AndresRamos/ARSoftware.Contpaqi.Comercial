﻿using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services
{
    public class DireccionService : IDireccionService
    {
        private readonly IContpaqiSdk _sdk;

        public DireccionService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public void Actualizar(tDireccion direccion)
        {
            _sdk.fActualizaDireccion(ref direccion).ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Actualizar(int idDireccion, Dictionary<string, string> datosDireccion)
        {
            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            string idDireccionDato = _sdk.LeeDatoDireccion(nameof(admDomicilios.CIDDIRECCION), 12);
            if (idDireccion == int.Parse(idDireccionDato))
            {
                _sdk.fEditaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                SetDatos(datosDireccion);
                _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();

                return;
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                idDireccionDato = _sdk.LeeDatoDireccion(nameof(admDomicilios.CIDDIRECCION), 12);
                if (idDireccion == int.Parse(idDireccionDato))
                {
                    _sdk.fEditaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                    SetDatos(datosDireccion);
                    _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    return;
                }
            }
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
            SetDatos(datosDireccion);
            _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            string idDireccionDato = _sdk.LeeDatoDireccion(nameof(admDomicilios.CIDDIRECCION), 12);
            return int.Parse(idDireccionDato);
        }

        public void SetDatos(Dictionary<string, string> datos)
        {
            foreach (KeyValuePair<string, string> dato in datos)
            {
                _sdk.fSetDatoDireccion(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }
        }
    }
}
