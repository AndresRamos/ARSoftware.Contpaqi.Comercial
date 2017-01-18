namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admAsocCargosAbonos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDOCUMENTOABONO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDOCUMENTOCARGO { get; set; }

        public double CIMPORTEABONO { get; set; }

        public double CIMPORTECARGO { get; set; }

        public DateTime CFECHAABONOCARGO { get; set; }

        public int CIDDESCUENTOPRONTOPAGO { get; set; }

        public int CIDUTILIDADPERDIDACAMB { get; set; }

        public int CIDAJUSIVA { get; set; }
    }
}
