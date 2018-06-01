namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmisionesSAT")]
    public partial class EmisionesSAT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public DateTime Fecha { get; set; }

        public int Ano { get; set; }

        public int Mes { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }
    }
}
