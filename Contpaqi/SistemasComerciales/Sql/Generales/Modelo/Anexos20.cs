namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Anexos20
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDESQUEMA { get; set; }

        public int CTIPODOCTO { get; set; }

        [Required]
        [StringLength(6)]
        public string CVERSION { get; set; }

        public DateTime CFECHAFIN { get; set; }
    }
}