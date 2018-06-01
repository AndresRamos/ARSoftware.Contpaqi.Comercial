namespace Contpaqi.Sql.Contabilidad.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? EsBaja { get; set; }

        [Required]
        [StringLength(30)]
        public string Clave { get; set; }

        public int? IdPerfil { get; set; }

        public bool? UsaTodasEmpresas { get; set; }

        public bool? UsuarioContPAQ { get; set; }

        public bool? UsuarioAdminPAQ { get; set; }

        public bool? UsuarioNomiPAQ { get; set; }

        public bool? UsuarioCheqPAQ { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }

        [StringLength(250)]
        public string eMail { get; set; }

        [StringLength(100)]
        public string eMailClave { get; set; }
    }
}
