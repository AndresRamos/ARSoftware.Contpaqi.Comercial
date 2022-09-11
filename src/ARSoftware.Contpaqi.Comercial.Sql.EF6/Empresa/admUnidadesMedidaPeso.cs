namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admUnidadesMedidaPeso")]
    public partial class admUnidadesMedidaPeso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDUNIDAD { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREUNIDAD { get; set; }

        [Required]
        [StringLength(3)]
        public string CABREVIATURA { get; set; }

        [Required]
        [StringLength(3)]
        public string CDESPLIEGUE { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVEINT { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVESAT { get; set; }
    }
}
