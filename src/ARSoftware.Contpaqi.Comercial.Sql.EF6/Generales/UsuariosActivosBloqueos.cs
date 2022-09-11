namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsuariosActivosBloqueos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDUSUARIO { get; set; }

        [Required]
        [StringLength(30)]
        public string CUSUARIO { get; set; }

        [Required]
        [StringLength(150)]
        public string CEMPRESA { get; set; }
    }
}
