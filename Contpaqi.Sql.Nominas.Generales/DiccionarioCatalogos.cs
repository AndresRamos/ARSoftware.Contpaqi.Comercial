namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DiccionarioCatalogos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCampo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string Catalogo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Alias { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string CampoBD { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CampoImportacion { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Obligatorio { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrdenExportacion { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Actualizable { get; set; }
    }
}
