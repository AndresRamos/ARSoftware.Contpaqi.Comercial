namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nom20000
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDUsuario { get; set; }

        [StringLength(15)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(10)]
        public string Clave { get; set; }

        [StringLength(10)]
        public string TipoUsuario { get; set; }

        [StringLength(50)]
        public string Acceso { get; set; }
    }
}
