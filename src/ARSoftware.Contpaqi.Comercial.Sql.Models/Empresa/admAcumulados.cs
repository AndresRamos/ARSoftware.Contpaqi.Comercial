using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAcumulados
{
    public int CIDACUMULADO { get; set; }

    public int CIDTIPOACUMULADO { get; set; }

    public int CIDOWNER1 { get; set; }

    public int CIDOWNER2 { get; set; }

    public int CIMPORTEMODELO { get; set; }

    public int CIDEJERCICIO { get; set; }

    public double CIMPORTEINICIAL { get; set; }

    public int CIDMONEDA { get; set; }

    public double CIMPORTEPERIODO1 { get; set; }

    public double CIMPORTEPERIODO2 { get; set; }

    public double CIMPORTEPERIODO3 { get; set; }

    public double CIMPORTEPERIODO4 { get; set; }

    public double CIMPORTEPERIODO5 { get; set; }

    public double CIMPORTEPERIODO6 { get; set; }

    public double CIMPORTEPERIODO7 { get; set; }

    public double CIMPORTEPERIODO8 { get; set; }

    public double CIMPORTEPERIODO9 { get; set; }

    public double CIMPORTEPERIODO10 { get; set; }

    public double CIMPORTEPERIODO11 { get; set; }

    public double CIMPORTEPERIODO12 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
