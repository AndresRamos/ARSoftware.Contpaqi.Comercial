namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;

    public partial class nom10016
    {
        public double? abono { get; set; }

        public double? abonomonedaext { get; set; }

        public double? cargo { get; set; }

        public double? cargomonedaext { get; set; }

        [StringLength(30)]
        public string concepto { get; set; }

        [StringLength(20)]
        public string csegmentonegocio { get; set; }

        [StringLength(31)]
        public string cuentacw { get; set; }

        [StringLength(20)]
        public string diario { get; set; }

        [StringLength(40)]
        public string GUIDMovtoPoliza { get; set; }

        [Key]
        public int idmovtopoliza { get; set; }

        public int? idpoliza { get; set; }

        public int? numeromovto { get; set; }

        [StringLength(30)]
        public string referencia { get; set; }

        [StringLength(1)]
        public string tipomovto { get; set; }
    }
}