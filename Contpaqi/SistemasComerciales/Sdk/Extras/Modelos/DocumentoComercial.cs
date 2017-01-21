using System;
using System.Collections.Generic;
namespace Contpaqi.SistemasComerciales.Sdk.Extras.Modelos

{
    public class DocumentoComercial
    {
        public DocumentoComercial()
        {
            ClienteProveedor = new ClienteProveedorComercial();
            ConceptoDocumento = new ConceptoDocumentoComercial();
            Movimientos = new List<MovimientoComercial>();
        }
        // Propiedes de Tipo tDocumento
        public double Folio;
        public int NumeroMoneda;
        public double TipoDeCambio;
        public double Importe;
        public double DescuentoDoc1;
        public double DescuentoDoc2;
        public int SistemaDeOrigen;
        public string CodigoConcepto;
        public string Serie;
        public DateTime Fecha;
        public string CodigoClienteProveedor;
        public string CodigoAgente;
        public string Referencia;
        public int Afecta;
        public double Gasto1;
        public double Gasto2;
        public double Gasto3;
        // Propiedades Extra
        public int IdDocumento { get; set; }
        public int IdConceptoDocumento { get; set; }
        public int IdClienteProveedor { get; set; }
        public string Observaciones { get; set; }
        public int IdAgente { get; set; }
        public string TextoExtra1 { get; set; }
        public string TextoExtra2 { get; set; }
        public string TextoExtra3 { get; set; }
        public DateTime FechaExtra { get; set; }
        public ClienteProveedorComercial ClienteProveedor { get; set; }
        public ConceptoDocumentoComercial ConceptoDocumento { get; set; }
        public List<MovimientoComercial> Movimientos { get; set; }
    }
}
