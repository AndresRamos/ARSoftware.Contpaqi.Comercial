namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admCertificadosProveeedor")]
    public partial class admCertificadosProveeedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCSD { get; set; }

        public int CIDFIRMAR { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        [Required]
        [StringLength(30)]
        public string CNOSERIE { get; set; }

        public DateTime CFECHAINI { get; set; }

        public DateTime CFECHAFIN { get; set; }

        public int CTIPOCERT { get; set; }
    }
}