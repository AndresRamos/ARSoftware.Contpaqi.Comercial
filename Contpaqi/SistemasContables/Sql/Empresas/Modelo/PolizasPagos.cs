namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PolizasPagos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public int Banco { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(200)]
        public string BeneficiarioPagador { get; set; }

        [StringLength(60)]
        public string Cuenta { get; set; }

        [StringLength(60)]
        public string CuentaDestino { get; set; }

        public int? BancoDestino { get; set; }

        public int PolizaOrigen { get; set; }
    }
}
