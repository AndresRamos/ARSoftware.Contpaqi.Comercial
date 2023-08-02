using System;
using System.Collections.Generic;
using System.Globalization;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class Documento : admDocumentos
{
    public Documento()
    {
        CFECHA = DateTime.Today;
        Moneda = MonedaEnum.PesoMexicano.ToMoneda();
        MetodoPago = MetodoPagoEnum.PUE;
        CTIPOCAMBIO = 1;
    }

    public Agente Agente { get; set; } = new();
    public ClienteProveedor ClienteProveedor { get; set; } = new();
    public ConceptoDocumento ConceptoDocumento { get; set; } = new();
    public Direccion DireccionEnvio { get; set; } = new();
    public Direccion DireccionFiscal { get; set; } = new();

    public FormaPagoEnum FormaPago
    {
        get => FormaPagoEnum.FromValue(CMETODOPAG);
        set => CMETODOPAG = value.Value;
    }

    public MetodoPagoEnum MetodoPago
    {
        get => MetodoPagoHelper.ConvertFromSdkValue(CCANTPARCI);
        set => CCANTPARCI = MetodoPagoHelper.ConvertToSdkValue(value);
    }

    public Moneda Moneda
    {
        get => MonedaEnum.FromValue(CIDMONEDA).ToMoneda();
        set => CIDMONEDA = value.Id;
    }

    public List<Movimiento> Movimientos { get; set; } = new();

    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CIDDOCUMENTO.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               ConceptoDocumento.CCODIGOCONCEPTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               ConceptoDocumento.CNOMBRECONCEPTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CSERIEDOCUMENTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CFOLIO.ToString(CultureInfo.InvariantCulture).IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public tDocumento ToTDocumento()
    {
        var tdocumento = new tDocumento
        {
            aFolio = CFOLIO,
            aNumMoneda = CIDMONEDA,
            aTipoCambio = CTIPOCAMBIO,
            aImporte = CNETO,
            aDescuentoDoc1 = CDESCUENTODOC1,
            aDescuentoDoc2 = CDESCUENTODOC2,
            aSistemaOrigen = CSISTORIG,
            aCodConcepto = ConceptoDocumento.CCODIGOCONCEPTO,
            aSerie = CSERIEDOCUMENTO,
            aFecha = CFECHA.ToSdkFecha(),
            aCodigoCteProv = ClienteProveedor.CCODIGOCLIENTE,
            aCodigoAgente = Agente.CCODIGOAGENTE,
            aReferencia = CREFERENCIA,
            aAfecta = CAFECTADO,
            aGasto1 = CGASTO1,
            aGasto2 = CGASTO2,
            aGasto3 = CGASTO3
        };
        return tdocumento;
    }

    public tLlaveDoc ToTLlaveDoc()
    {
        return new tLlaveDoc { aCodConcepto = ConceptoDocumento.CCODIGOCONCEPTO, aSerie = CSERIEDOCUMENTO, aFolio = CFOLIO };
    }
}
