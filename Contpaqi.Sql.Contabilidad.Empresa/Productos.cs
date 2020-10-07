namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
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

        [StringLength(8)]
        public string ClaveProdServ { get; set; }

        public int? IdTipoOperacion { get; set; }

        [StringLength(30)]
        public string SegContProducto1 { get; set; }

        [StringLength(30)]
        public string SegContProducto2 { get; set; }

        [StringLength(30)]
        public string SegContProducto3 { get; set; }

        [StringLength(30)]
        public string SegContProducto4 { get; set; }

        [StringLength(30)]
        public string SegContProducto5 { get; set; }

        [StringLength(30)]
        public string SegContProducto6 { get; set; }

        [StringLength(30)]
        public string SegContProducto7 { get; set; }

        public int? SistOrig { get; set; }
    }
}
