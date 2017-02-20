namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class nom10019
    {
        public int? cidperiodo { get; set; }

        public int? cidtipoperiodo { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime fecha { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idempleado { get; set; }

        public double? sueldo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string tiposueldo { get; set; }
    }
}