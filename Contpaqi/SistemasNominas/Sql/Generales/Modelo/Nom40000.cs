namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Nom40000
    {
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Key]
        public int NumeroTabla { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}