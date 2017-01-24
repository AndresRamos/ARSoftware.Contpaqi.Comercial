namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DocumentosBancarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdCheque { get; set; }

        public int IdEgreso { get; set; }

        public int IdIngreso { get; set; }

        public int IdIngresoNoDepositado { get; set; }

        public int IdDeposito { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? FechaAplicacion { get; set; }

        public bool? EsConciliado { get; set; }

        public bool? EsProyectado { get; set; }

        public int IdCuentaCheques { get; set; }
    }
}