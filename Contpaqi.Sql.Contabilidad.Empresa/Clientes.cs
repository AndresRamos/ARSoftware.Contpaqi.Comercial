namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(40)]
        public string Codigo { get; set; }

        [StringLength(40)]
        public string CodigoPersona { get; set; }

        [StringLength(30)]
        public string CodigoCuenta { get; set; }

        [StringLength(30)]
        public string CodigoCtaComplementaria { get; set; }

        [StringLength(20)]
        public string CodigoPrepoliza { get; set; }

        public int? IdSegNeg { get; set; }

        [StringLength(10)]
        public string BancoOrigen { get; set; }

        [StringLength(50)]
        public string CuentaOrigen { get; set; }

        [StringLength(30)]
        public string SegContCliente1 { get; set; }

        [StringLength(30)]
        public string SegContCliente2 { get; set; }

        [StringLength(30)]
        public string SegContCliente3 { get; set; }

        [StringLength(30)]
        public string SegContCliente4 { get; set; }

        [StringLength(30)]
        public string SegContCliente5 { get; set; }

        [StringLength(30)]
        public string SegContCliente6 { get; set; }

        [StringLength(30)]
        public string SegContCliente7 { get; set; }
    }
}
