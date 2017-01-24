namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Ejercicios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Ejercicio { get; set; }

        public int? TipoPer { get; set; }

        public int? Periodos { get; set; }

        public DateTime? FecIniEje { get; set; }

        public DateTime? FecFinEje { get; set; }

        public DateTime? FecIniPer1 { get; set; }

        public DateTime? FecIniPer2 { get; set; }

        public DateTime? FecIniPer3 { get; set; }

        public DateTime? FecIniPer4 { get; set; }

        public DateTime? FecIniPer5 { get; set; }

        public DateTime? FecIniPer6 { get; set; }

        public DateTime? FecIniPer7 { get; set; }

        public DateTime? FecIniPer8 { get; set; }

        public DateTime? FecIniPer9 { get; set; }

        public DateTime? FecIniPer10 { get; set; }

        public DateTime? FecIniPer11 { get; set; }

        public DateTime? FecIniPer12 { get; set; }

        public DateTime? FecIniPer13 { get; set; }

        public DateTime? FecIniPer14 { get; set; }

        public int? IdCtaCierre { get; set; }

        public int? IdPolCierre { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}