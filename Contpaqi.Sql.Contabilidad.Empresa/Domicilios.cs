namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Domicilios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdReferencia { get; set; }

        [Required]
        [StringLength(1000)]
        public string TablaReferencia { get; set; }

        [StringLength(200)]
        public string Calle { get; set; }

        [StringLength(55)]
        public string NoExt { get; set; }

        [StringLength(30)]
        public string NoInt { get; set; }

        [StringLength(50)]
        public string Colonia { get; set; }

        [StringLength(50)]
        public string Localidad { get; set; }

        [StringLength(5)]
        public string Municipio { get; set; }

        [StringLength(2)]
        public string Estado { get; set; }

        [StringLength(3)]
        public string Pais { get; set; }

        [StringLength(10)]
        public string CodigoPostal { get; set; }

        [StringLength(1000)]
        public string Referencia { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }
    }
}
