namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10003
    {
        [StringLength(60)]
        public string beneficiario { get; set; }

        [StringLength(20)]
        public string csegmentonegocio { get; set; }

        [StringLength(31)]
        public string cuentacw { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [Key]
        public int iddepartamento { get; set; }

        public int? numerodepartamento { get; set; }

        public DateTime? timestamp { get; set; }
    }
}