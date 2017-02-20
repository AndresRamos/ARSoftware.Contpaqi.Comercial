namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10035
    {
        public DateTime? cfechaconstitucion { get; set; }

        [StringLength(3)]
        public string chomoclave { get; set; }

        [Key]
        public int cidregistropatronal { get; set; }

        [StringLength(20)]
        public string ClaseRiesgoTrabajo { get; set; }

        [StringLength(19)]
        public string cregistroimss { get; set; }

        [StringLength(4)]
        public string crfc { get; set; }

        [StringLength(19)]
        public string crfccompleto { get; set; }

        public DateTime? ctimestamp { get; set; }

        [StringLength(20)]
        public string FraccionRiesgoTrabajo { get; set; }

        [StringLength(40)]
        public string GUIDFirmaDSL { get; set; }

        [StringLength(40)]
        public string LocalidadRegPatronal { get; set; }
    }
}