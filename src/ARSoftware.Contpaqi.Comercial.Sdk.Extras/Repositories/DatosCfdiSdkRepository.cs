using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

public class DatosCfdiSdkRepository : IDatosCfdiRepository
{
    private readonly IContpaqiSdk _sdk;

    public DatosCfdiSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    public DatosCfdi BuscarPorDocumentoId(int idDocumento)
    {
        _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();

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

        if (_sdk is ComercialSdkExtended)
        {
            _sdk.fGetDatosCFDI(serieCertificadoEmisor, folioFiscalUUid, serieCertificadoSat, fecha, selloDigital, selloSat,
                    cadenaOriginalComplementoSat, regimen, lugarExpedicion, moneda, folioFiscalOriginal, serieFolioFiscal, fechaFolioFiscal,
                    montoFolioFiscal)
                .ToResultadoSdk(_sdk)
                .ThrowIfError();
        }
        else
        {
            _sdk.fObtieneDatosCFDI("").ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(serieCertificadoEmisor, 1).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(folioFiscalUUid, 2).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(serieCertificadoSat, 3).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(fecha, 4).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(selloDigital, 5).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(selloSat, 6).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(cadenaOriginalComplementoSat, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(moneda, 8).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(lugarExpedicion, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(regimen, 10).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(folioFiscalOriginal, 11).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(serieFolioFiscal, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(fechaFolioFiscal, 13).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCFDI(montoFolioFiscal, 14).ToResultadoSdk(_sdk).ThrowIfError();
        }

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
