﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admVistasConsultas
    {
        public int CIDCONSULTA { get; set; }
        public int CIDSISTEMA { get; set; }
        public int CIDIDIOMA { get; set; }
        public int CIDMODULO { get; set; }
        public int CTIPO { get; set; }
        public int CCOLUMNASOCULTAR { get; set; }
        public string CNOMBRECONSULTA { get; set; }
        public string CSENTENCIASQL { get; set; }
        public int CIDEMPRESA { get; set; }
        public string CINDICE { get; set; }
        public int CESDESIS01 { get; set; }
        public string CFILTROS { get; set; }
        public int CINICIOARG { get; set; }
        public int CLIMITEARG { get; set; }
        public int CORDEN { get; set; }
    }
}