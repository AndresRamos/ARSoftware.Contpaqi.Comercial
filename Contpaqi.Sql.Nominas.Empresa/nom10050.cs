namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10050
    {
        [Key]
        public int IDTabla { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
