namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CuentasReexpresion")]
    public partial class CuentasReexpresion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int TipoCta { get; set; }

        public int Renglon { get; set; }

        public int? IdCuenta { get; set; }

        public int? IdCuentaAct { get; set; }

        public int? TipoCalculo { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
