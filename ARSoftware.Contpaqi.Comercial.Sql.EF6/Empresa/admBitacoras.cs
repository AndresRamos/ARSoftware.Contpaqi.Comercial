namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admBitacoras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBITACORA { get; set; }

        public DateTime FECHA { get; set; }

        [Required]
        [StringLength(4)]
        public string HORA { get; set; }

        [Required]
        [StringLength(15)]
        public string USUARIO { get; set; }

        [Required]
        [StringLength(30)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(15)]
        public string USUARIO2 { get; set; }

        [Required]
        [StringLength(30)]
        public string NOMBRE2 { get; set; }

        [Required]
        [StringLength(100)]
        public string PROCESO { get; set; }

        [Required]
        [StringLength(100)]
        public string DATOS { get; set; }

        public int IDSISTEMA { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOEX01 { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOEX02 { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOEX03 { get; set; }

        public DateTime CFECHAEX01 { get; set; }

        public double CIMPORTE01 { get; set; }

        public double CIMPORTE02 { get; set; }

        public double CIMPORTE03 { get; set; }
    }
}
