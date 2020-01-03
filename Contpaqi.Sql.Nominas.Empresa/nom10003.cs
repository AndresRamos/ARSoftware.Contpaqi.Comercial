namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10003
    {
        [Key]
        public int iddepartamento { get; set; }

        public int? numerodepartamento { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(60)]
        public string beneficiario { get; set; }

        [StringLength(31)]
        public string cuentacw { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(20)]
        public string csegmentonegocio { get; set; }
    }
}
