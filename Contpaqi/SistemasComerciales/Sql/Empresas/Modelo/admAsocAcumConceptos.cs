namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admAsocAcumConceptos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCONCEPTOTIPOACUMULADO { get; set; }

        public int CIDCONCEPTODOCUMENTO { get; set; }

        public int CIDTIPOACUMULADO { get; set; }

        public int CIMPORTEMODELO { get; set; }

        public int CSUMARESTA { get; set; }
    }
}
