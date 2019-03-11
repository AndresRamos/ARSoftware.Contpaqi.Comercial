namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CuentasChequesAlias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroCuenta { get; set; }

        public int TipoCuenta { get; set; }

        [StringLength(60)]
        public string Descripcion { get; set; }

        public int IdCuentaCheques { get; set; }
    }
}
