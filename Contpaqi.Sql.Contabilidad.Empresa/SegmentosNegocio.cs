namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SegmentosNegocio")]
    public partial class SegmentosNegocio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [StringLength(30)]
        public string SegContSegmento1 { get; set; }

        [StringLength(30)]
        public string SegContSegmento2 { get; set; }

        [StringLength(30)]
        public string SegContSegmento3 { get; set; }

        [StringLength(30)]
        public string SegContSegmento4 { get; set; }

        [StringLength(30)]
        public string SegContSegmento5 { get; set; }

        [StringLength(30)]
        public string SegContSegmento6 { get; set; }

        [StringLength(30)]
        public string SegContSegmento7 { get; set; }
    }
}
