namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AsocCategoriasPlantillas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string CodigoPlantilla { get; set; }

        public int IdCategoria { get; set; }

        public int IdSubCategoria { get; set; }

        public double? Porcentaje { get; set; }

        public double? Total { get; set; }
    }
}
