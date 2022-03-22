namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admProyectos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPROYECTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODIGOPROYECTO { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREPROYECTO { get; set; }

        public DateTime CFECHAALTA { get; set; }

        public DateTime CFECHABAJA { get; set; }

        public int CESTATUS { get; set; }

        public int CIDVALORCLASIFICACION1 { get; set; }

        public int CIDVALORCLASIFICACION2 { get; set; }

        public int CIDVALORCLASIFICACION3 { get; set; }

        public int CIDVALORCLASIFICACION4 { get; set; }

        public int CIDVALORCLASIFICACION5 { get; set; }

        public int CIDVALORCLASIFICACION6 { get; set; }

        public double CIMPORTE1 { get; set; }

        public double CIMPORTE2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT3 { get; set; }

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

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CTIPOCATALOGO { get; set; }

        public int CIDCATALOGO { get; set; }
    }
}
