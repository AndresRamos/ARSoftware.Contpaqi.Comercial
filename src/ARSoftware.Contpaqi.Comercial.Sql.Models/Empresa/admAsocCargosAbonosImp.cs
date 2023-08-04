using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAsocCargosAbonosImp
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDDOCUMENTOABONO { get; set; }

    public int CIDDOCUMENTOCARGO { get; set; }

    public string CTEXTOTASA { get; set; } = null!;

    public double CNETO { get; set; }

    public double CTASA { get; set; }

    public int CESDETALLE { get; set; }

    public int CTIPOIMP01 { get; set; }

    public int CTIPOFAC01 { get; set; }

    public double CTASACUOTA { get; set; }

    public int CESRETEN01 { get; set; }

    public double CPROPORC01 { get; set; }

    public string CMETODOPAG { get; set; } = null!;
}
