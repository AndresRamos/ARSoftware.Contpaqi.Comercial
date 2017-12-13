namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admAgentes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDAGENTE { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODIGOAGENTE { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREAGENTE { get; set; }

        public DateTime CFECHAALTAAGENTE { get; set; }

        public int CTIPOAGENTE { get; set; }

        public double CCOMISIONVENTAAGENTE { get; set; }

        public double CCOMISIONCOBROAGENTE { get; set; }

        public int CIDCLIENTE { get; set; }

        public int CIDPROVEEDOR { get; set; }

        public int CIDVALORCLASIFICACION1 { get; set; }

        public int CIDVALORCLASIFICACION2 { get; set; }

        public int CIDVALORCLASIFICACION3 { get; set; }

        public int CIDVALORCLASIFICACION4 { get; set; }

        public int CIDVALORCLASIFICACION5 { get; set; }

        public int CIDVALORCLASIFICACION6 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTAGENTE { get; set; }

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

        [Required]
        [StringLength(50)]
        public string CSCAGENTE2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCAGENTE3 { get; set; }
    }
}
