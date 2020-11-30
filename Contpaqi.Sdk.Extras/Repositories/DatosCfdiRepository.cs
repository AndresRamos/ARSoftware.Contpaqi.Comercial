using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class DatosCfdiRepository : IDatosCfdiRepository
    {
        private readonly IContpaqiSdk _sdk;

        public DatosCfdiRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public DatosCfdi BuscarPorDocumentoId(int documentoId)
        {
            _sdk.fBuscarIdDocumento(documentoId).ToResultadoSdk(_sdk).ThrowIfError();

            var serieCertificadoEmisor = new StringBuilder(3000);
            var folioFiscalUUid = new StringBuilder(3000);
            var serieCertificadoSat = new StringBuilder(3000);
            var fecha = new StringBuilder(3000);
            var selloDigital = new StringBuilder(3000);
            var selloSat = new StringBuilder(3000);
            var cadenaOriginalComplementoSat = new StringBuilder(3000);
            var regimen = new StringBuilder(3000);
            var lugarExpedicion = new StringBuilder(3000);
            var moneda = new StringBuilder(3000);
            var folioFiscalOriginal = new StringBuilder(3000);
            var serieFolioFiscal = new StringBuilder(3000);
            var fechaFolioFiscal = new StringBuilder(3000);
            var montoFolioFiscal = new StringBuilder(3000);

            _sdk.fGetDatosCFDI(serieCertificadoEmisor,
                    folioFiscalUUid,
                    serieCertificadoSat,
                    fecha,
                    selloDigital,
                    selloSat,
                    cadenaOriginalComplementoSat,
                    regimen,
                    lugarExpedicion,
                    moneda,
                    folioFiscalOriginal,
                    serieFolioFiscal,
                    fechaFolioFiscal,
                    montoFolioFiscal)
                .ToResultadoSdk(_sdk)
                .ThrowIfError();

            return new DatosCfdi
            {
                SerieCertificadoEmisor = serieCertificadoEmisor.ToString(),
                FolioFiscalUUid = folioFiscalUUid.ToString(),
                SerieCertificadoSat = serieCertificadoSat.ToString(),
                Fecha = fecha.ToString(),
                SelloDigital = selloDigital.ToString(),
                SelloSat = selloSat.ToString(),
                CadenaOriginalComplementoSat = cadenaOriginalComplementoSat.ToString(),
                Regimen = regimen.ToString(),
                LugarExpedicion = lugarExpedicion.ToString(),
                Moneda = moneda.ToString(),
                FolioFiscalOriginal = folioFiscalOriginal.ToString(),
                SerieFolioFiscal = serieFolioFiscal.ToString(),
                FechaFolioFiscal = fechaFolioFiscal.ToString(),
                MontoFolioFiscal = montoFolioFiscal.ToString()
            };
        }
    }
}