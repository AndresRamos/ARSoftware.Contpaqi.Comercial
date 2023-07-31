using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class ConceptoDocumentoService : IConceptoDocumentoService
{
    private readonly IContpaqiSdk _sdk;

    public ConceptoDocumentoService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    public void Actualizar(int idConcepto, Dictionary<string, string> datosConcepto)
    {
        _sdk.fBuscaIdConceptoDocto(idConcepto).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosConcepto);
        _sdk.fGuardaConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Actualizar(string codigoConcepto, Dictionary<string, string> datosConcepto)
    {
        _sdk.fBuscaConceptoDocto(codigoConcepto).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosConcepto);
        _sdk.fGuardaConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoConceptoDocto(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}
