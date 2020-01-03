namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CACIdiom")]
    public partial class CACIdiom
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroIdioma { get; set; }

        [StringLength(60)]
        public string NombreIdioma { get; set; }

        [StringLength(20)]
        public string NombreDLLApp { get; set; }

        [StringLength(20)]
        public string NombreDLLErr { get; set; }

        [StringLength(25)]
        public string NombreArchivoAyuda { get; set; }

        [StringLength(25)]
        public string NombreArchivoBDD { get; set; }

        public int? IdAyuda { get; set; }
    }
}
