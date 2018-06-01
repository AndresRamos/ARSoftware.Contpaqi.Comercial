namespace Contpaqi.Sql.Contabilidad.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresasUsuario")]
    public partial class EmpresasUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdUsuario { get; set; }

        public int IdEmpresa { get; set; }
    }
}
