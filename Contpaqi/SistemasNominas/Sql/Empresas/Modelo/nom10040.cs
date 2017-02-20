namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10040
    {
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public DateTime? FechaInicio { get; set; }

        public int IdConcepto { get; set; }

        public int IdEmpleado { get; set; }

        [Key]
        public int IdTarjetaCredito { get; set; }

        public double? MontoAcumulado { get; set; }

        public double? MontoLimite { get; set; }

        [StringLength(40)]
        public string NumeroControl { get; set; }

        [StringLength(100)]
        public string Observaciones { get; set; }

        public double? OtrosPagos { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public double? Valor { get; set; }

        public int? VecesAplicado { get; set; }

        public int? VecesAplicar { get; set; }
    }
}