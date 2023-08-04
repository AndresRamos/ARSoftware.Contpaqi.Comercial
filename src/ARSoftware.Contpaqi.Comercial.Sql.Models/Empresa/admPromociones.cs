using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admPromociones
{
    public int CIDPROMOCION { get; set; }

    public string CCODIGOPROMOCION { get; set; } = null!;

    public string CNOMBREPROMOCION { get; set; } = null!;

    public DateTime CFECHAINICIO { get; set; }

    public DateTime CFECHAFIN { get; set; }

    public double CVOLUMENMINIMO { get; set; }

    public double CVOLUMENMAXIMO { get; set; }

    public double CPORCENTAJEDESCUENTO { get; set; }

    public int CIDVALORCLASIFCLIENTE1 { get; set; }

    public int CIDVALORCLASIFCLIENTE2 { get; set; }

    public int CIDVALORCLASIFCLIENTE3 { get; set; }

    public int CIDVALORCLASIFCLIENTE4 { get; set; }

    public int CIDVALORCLASIFCLIENTE5 { get; set; }

    public int CIDVALORCLASIFCLIENTE6 { get; set; }

    public int CIDVALORCLASIFPRODUCTO1 { get; set; }

    public int CIDVALORCLASIFPRODUCTO2 { get; set; }

    public int CIDVALORCLASIFPRODUCTO3 { get; set; }

    public int CIDVALORCLASIFPRODUCTO4 { get; set; }

    public int CIDVALORCLASIFPRODUCTO5 { get; set; }

    public int CIDVALORCLASIFPRODUCTO6 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public int CTIPOPROMO { get; set; }

    public int CIDCPTODOC { get; set; }

    public int CSUBTIPO { get; set; }

    public string CHORAINI { get; set; } = null!;

    public string CHORAFIN { get; set; } = null!;

    public int CTIPOPRO { get; set; }

    public int CVALA { get; set; }

    public int CVALB { get; set; }

    public int CDIAS { get; set; }

    public DateTime CFECHAALTA { get; set; }

    public int CSTATUS { get; set; }
}
