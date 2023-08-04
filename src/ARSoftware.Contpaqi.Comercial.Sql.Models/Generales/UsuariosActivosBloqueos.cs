using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class UsuariosActivosBloqueos
{
    public int CIDUSUARIO { get; set; }

    public string CUSUARIO { get; set; } = null!;

    public string CEMPRESA { get; set; } = null!;
}
