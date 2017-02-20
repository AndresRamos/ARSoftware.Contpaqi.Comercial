namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10027
    {
        [StringLength(40)]
        public string descripcion { get; set; }

        [Key]
        public int numerotabla { get; set; }

        public DateTime? timestamp { get; set; }
    }
}