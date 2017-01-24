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
            Agente = new AgenteComercial();
            Movimientos = new List<MovimientoComercial>();
        }

        // Propiedes de Tipo tDocumento
        public double Folio { get; set; }

        public int NumeroMoneda { get; set; }

        public double TipoDeCambio { get; set; }

        public double Importe { get; set; }

        public double DescuentoDoc1 { get; set; }

        public double DescuentoDoc2 { get; set; }

        public int SistemaDeOrigen { get; set; }

        public string CodigoConcepto { get; set; }

        public string Serie { get; set; }

        public DateTime Fecha { get; set; }

        public string CodigoClienteProveedor { get; set; }

        public string CodigoAgente { get; set; }

        public string Referencia { get; set; }

        public int Afecta { get; set; }

        public double Gasto1 { get; set; }

        public double Gasto2 { get; set; }

        public double Gasto3 { get; set; }

        // Propiedades Extra
        public int IdDocumento { get; set; }

        public int IdConceptoDocumento { get; set; }

        public int IdClienteProveedor { get; set; }

        public int IdAgente { get; set; }

        public string Observaciones { get; set; }

        public string TextoExtra1 { get; set; }

        public string TextoExtra2 { get; set; }

        public string TextoExtra3 { get; set; }

        public DateTime FechaExtra { get; set; }

        public ConceptoDocumentoComercial ConceptoDocumento { get; set; }

        public ClienteProveedorComercial ClienteProveedor { get; set; }

        public AgenteComercial Agente { get; set; }

        public List<MovimientoComercial> Movimientos { get; set; }
    }
}