namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAC30000
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IdSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Perfil { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
