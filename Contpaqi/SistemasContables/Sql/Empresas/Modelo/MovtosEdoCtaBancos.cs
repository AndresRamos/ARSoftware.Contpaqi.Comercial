namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class MovtosEdoCtaBancos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdMovto { get; set; }

        [StringLength(20)]
        public string Numero { get; set; }

        public int IdEdoCtaBanco { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoMovto { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        public double? Total { get; set; }

        public bool? EsConciliado { get; set; }
    }
}
