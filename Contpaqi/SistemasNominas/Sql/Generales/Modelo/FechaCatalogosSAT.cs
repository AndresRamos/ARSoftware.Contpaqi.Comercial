namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FechaCatalogosSAT")]
    public partial class FechaCatalogosSAT
    {
        [Key]
        public DateTime UltimaActualizacion { get; set; }
    }
}