namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admDomicilios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDIRECCION { get; set; }

        public int CIDCATALOGO { get; set; }

        public int CTIPOCATALOGO { get; set; }

        public int CTIPODIRECCION { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CNOMBRECALLE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(30)]
        public string CNUMEROEXTERIOR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(30)]
        public string CNUMEROINTERIOR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CCOLONIA { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(6)]
        public string CCODIGOPOSTAL { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(15)]
        public string CTELEFONO1 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(15)]
        public string CTELEFONO2 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(15)]
        public string CTELEFONO3 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(15)]
        public string CTELEFONO4 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string CEMAIL { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string CDIRECCIONWEB { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CPAIS { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CESTADO { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CCIUDAD { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CTEXTOEXTRA { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CMUNICIPIO { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(60)]
        public string CSUCURSAL { get; set; }
    }
}