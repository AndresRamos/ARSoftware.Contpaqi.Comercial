namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10006
    {
        [StringLength(40)]
        public string descripcion { get; set; }

        [Key]
        public int idpuesto { get; set; }

        public int? numeropuesto { get; set; }

        public DateTime? timestamp { get; set; }
    }
}