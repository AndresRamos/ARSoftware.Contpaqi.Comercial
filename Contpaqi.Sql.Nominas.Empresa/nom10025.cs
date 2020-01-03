namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10025
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idperiodo { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime fecha { get; set; }
    }
}
