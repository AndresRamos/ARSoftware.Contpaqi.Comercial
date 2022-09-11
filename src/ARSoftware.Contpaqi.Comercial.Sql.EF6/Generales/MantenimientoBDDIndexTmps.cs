namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MantenimientoBDDIndexTmps
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string cNombreTabla { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cNombreIndex { get; set; }

        public int? cPorcentajeFragmentacion { get; set; }
    }
}
