namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admCostosHistoricos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCOSTOH { get; set; }

        public int CIDPRODUCTO { get; set; }

        public int CIDALMACEN { get; set; }

        public DateTime CFECHACOSTOH { get; set; }

        public double CCOSTOH { get; set; }

        public double CULTIMOCOSTOH { get; set; }

        public int CIDMOVIMIENTO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}
