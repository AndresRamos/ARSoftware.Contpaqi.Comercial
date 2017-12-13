namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admAlmacenes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDALMACEN { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODIGOALMACEN { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREALMACEN { get; set; }

        public DateTime CFECHAALTAALMACEN { get; set; }

        public int CIDVALORCLASIFICACION1 { get; set; }

        public int CIDVALORCLASIFICACION2 { get; set; }

        public int CIDVALORCLASIFICACION3 { get; set; }

        public int CIDVALORCLASIFICACION4 { get; set; }

        public int CIDVALORCLASIFICACION5 { get; set; }

        public int CIDVALORCLASIFICACION6 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTALMACEN { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA3 { get; set; }

        public DateTime CFECHAEXTRA { get; set; }

        public double CIMPORTEEXTRA1 { get; set; }

        public double CIMPORTEEXTRA2 { get; set; }

        public double CIMPORTEEXTRA3 { get; set; }

        public double CIMPORTEEXTRA4 { get; set; }

        public int CBANDOMICILIO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCALMAC2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCALMAC3 { get; set; }

        public int CSISTORIG { get; set; }
    }
}
