namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10020
    {
        public int? cidperiodo { get; set; }

        public int? cidtipoperiodo { get; set; }

        [StringLength(1)]
        public string clavebajareingreso { get; set; }

        public DateTime? fecha { get; set; }

        [Key]
        public int idbajareingreso { get; set; }

        public int? idempleado { get; set; }
    }
}