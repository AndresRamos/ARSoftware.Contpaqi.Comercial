namespace Contpaqi.SistemasContables.Sql.Generales.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Temps
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public DateTime? TStamp { get; set; }

        public int Local { get; set; }

        public int? Definition { get; set; }

        [StringLength(100)]
        public string Replace { get; set; }

        [StringLength(50)]
        public string Async { get; set; }

        public int? Sys { get; set; }

        public int? Func { get; set; }

        [StringLength(20)]
        public string Stream { get; set; }

        public int? Repeat { get; set; }

        [StringLength(200)]
        public string Fix { get; set; }

        [StringLength(200)]
        public string Demo { get; set; }

        [StringLength(30)]
        public string Reference { get; set; }

        public int? Count1 { get; set; }

        public int? Count2 { get; set; }

        public int? Count3 { get; set; }

        public int? Count4 { get; set; }

        [StringLength(30)]
        public string End1 { get; set; }

        [StringLength(30)]
        public string End2 { get; set; }

        [StringLength(20)]
        public string End3 { get; set; }

        [StringLength(5)]
        public string End4 { get; set; }
    }
}