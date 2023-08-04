using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Extensiones;

namespace Sdk.ConsoleApp.Catalogos;

public sealed class ConceptoSdk
{
    /// <summary>
    ///     Campo CCODIGOCONCEPTO - Código del concepto.
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    ///     Campo CIDCONCEPTODOCUMENTO - Identificador del concepto de documento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Campo CNOMBRECONCEPTO - Nombre del concepto.
    /// </summary>
    public string Nombre { get; set; }

    public static ConceptoSdk BuscarConceptoPorCodigo(string conceptoCodigo)
    {
        ComercialSdk.fBuscaConceptoDocto(conceptoCodigo).TirarSiEsError();

        return LeerDatosConcepto();
    }

    public static ConceptoSdk BuscarConceptoPorId(int conceptoId)
    {
        ComercialSdk.fBuscaIdConceptoDocto(conceptoId).TirarSiEsError();

        return LeerDatosConcepto();
    }

    private static ConceptoSdk LeerDatosConcepto()
    {
        var idBd = new StringBuilder(3000);
        var codigoBd = new StringBuilder(3000);
        var nombreBd = new StringBuilder(3000);

        ComercialSdk.fLeeDatoConceptoDocto("CIDCONCEPTODOCUMENTO", idBd, 3000);
        ComercialSdk.fLeeDatoConceptoDocto("CCODIGOCONCEPTO", codigoBd, 3000);
        ComercialSdk.fLeeDatoConceptoDocto("CNOMBRECONCEPTO", nombreBd, 3000);

        return new ConceptoSdk { Id = int.Parse(idBd.ToString()), Codigo = codigoBd.ToString(), Nombre = nombreBd.ToString() };
    }
}
