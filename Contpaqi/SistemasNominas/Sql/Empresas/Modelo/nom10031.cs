namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class nom10031
    {
        [Column(TypeName = "text")]
        public string ayuda { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

        [Column(TypeName = "text")]
        public string expresion { get; set; }

        public int? idcategoria { get; set; }

        [Key]
        public int idformula { get; set; }

        public bool modificado { get; set; }

        [StringLength(40)]
        public string nombre { get; set; }

        public int? posicion { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public int? version { get; set; }
    }
}