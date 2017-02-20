namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10042
    {
        public int IdConcepto { get; set; }

        public int IdEmpleado { get; set; }

        [Key]
        public int IdMovtoCredito { get; set; }

        public int IdPeriodo { get; set; }

        public int IdTarjetaCredito { get; set; }

        public double? Importe { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}