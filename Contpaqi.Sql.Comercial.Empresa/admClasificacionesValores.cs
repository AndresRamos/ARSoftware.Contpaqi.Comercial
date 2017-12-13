namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admClasificacionesValores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDVALORCLASIFICACION { get; set; }

        [Required]
        [StringLength(60)]
        public string CVALORCLASIFICACION { get; set; }

        public int CIDCLASIFICACION { get; set; }

        [Required]
        [StringLength(3)]
        public string CCODIGOVALORCLASIFICACION { get; set; }
    }
}
