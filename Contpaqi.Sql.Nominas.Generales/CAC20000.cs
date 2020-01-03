namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAC20000
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IdSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Nivel { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Proceso { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Adicional { get; set; }
    }
}
