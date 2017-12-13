namespace Contpaqi.Sql.Comercial.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATMonedas
    {
        [Key]
        [StringLength(3)]
        public string CCODIGO { get; set; }

        [Required]
        [StringLength(100)]
        public string CNOMBRE { get; set; }

        public int CDECIMALES { get; set; }
    }
}
