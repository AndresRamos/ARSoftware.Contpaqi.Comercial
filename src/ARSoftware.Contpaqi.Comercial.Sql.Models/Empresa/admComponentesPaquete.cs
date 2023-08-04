using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admComponentesPaquete
{
    public int CIDCOMPONENTE { get; set; }

    public int CIDPAQUETE { get; set; }

    public int CIDPRODUCTO { get; set; }

    public double CCANTIDADPRODUCTO { get; set; }

    public int CIDVALORCARACTERISTICA1 { get; set; }

    public int CIDVALORCARACTERISTICA2 { get; set; }

    public int CIDVALORCARACTERISTICA3 { get; set; }

    public int CTIPOPRODUCTO { get; set; }

    public int CIDUNIDADVENTA { get; set; }
}
