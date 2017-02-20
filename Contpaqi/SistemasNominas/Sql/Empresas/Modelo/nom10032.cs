namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10032
    {
        [StringLength(40)]
        public string descripcion { get; set; }

        [Key]
        public int idturno { get; set; }

        public double? numerohoras { get; set; }

        public int? numeroturno { get; set; }

        public DateTime? timestamp { get; set; }
    }
}