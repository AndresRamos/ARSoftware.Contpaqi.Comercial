namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParametrosInicialesMto")]
    public partial class ParametrosInicialesMto
    {
        [Key]
        [StringLength(50)]
        public string cDBTemplate { get; set; }

        public int? cLogSize { get; set; }

        public int? cLogLevel1 { get; set; }

        public int? cLogLevel2 { get; set; }

        public int? cLogLevel3 { get; set; }

        public int? cIdxLevel1 { get; set; }

        public int? cIdxLevel2 { get; set; }

        public int? cIdxLevel3 { get; set; }
    }
}
