namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10035
    {
        [Key]
        public int cidregistropatronal { get; set; }

        [StringLength(4)]
        public string crfc { get; set; }

        public DateTime? cfechaconstitucion { get; set; }

        [StringLength(3)]
        public string chomoclave { get; set; }

        public DateTime? ctimestamp { get; set; }

        [StringLength(19)]
        public string crfccompleto { get; set; }

        [StringLength(20)]
        public string cregistroimss { get; set; }

        [StringLength(40)]
        public string GUIDFirmaDSL { get; set; }

        [StringLength(20)]
        public string ClaseRiesgoTrabajo { get; set; }

        [StringLength(20)]
        public string FraccionRiesgoTrabajo { get; set; }

        [StringLength(40)]
        public string LocalidadRegPatronal { get; set; }

        [Required]
        [StringLength(5)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(3)]
        public string EntidadFederativa { get; set; }
    }
}
