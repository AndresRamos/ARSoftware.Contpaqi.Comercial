namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10030
    {
        public bool cpropia { get; set; }

        [StringLength(1)]
        public string grupo { get; set; }

        [Key]
        public int idcategoria { get; set; }

        [StringLength(40)]
        public string nombre { get; set; }

        public int? posicion { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }
    }
}