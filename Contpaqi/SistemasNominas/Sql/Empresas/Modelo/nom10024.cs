namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10024
    {
        public bool activada { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(5)]
        public string fechainicio { get; set; }

        [StringLength(1)]
        public string frecuencia { get; set; }

        [Key]
        public int iddispfiscal { get; set; }

        [StringLength(255)]
        public string ruta { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }
    }
}