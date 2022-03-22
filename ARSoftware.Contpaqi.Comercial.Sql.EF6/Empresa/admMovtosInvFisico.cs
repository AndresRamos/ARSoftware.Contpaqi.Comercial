namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admMovtosInvFisico")]
    public partial class admMovtosInvFisico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVIMIENTO { get; set; }

        public int CIDPRODUCTO { get; set; }

        public int CIDALMACEN { get; set; }

        public int CIDUNIDAD { get; set; }

        public double CUNIDADES { get; set; }

        public double CUNIDADESNC { get; set; }

        public double CUNIDADESCAPTURADAS { get; set; }

        public int CMOVTOOCULTO { get; set; }

        public int CIDMOVTOOWNER { get; set; }
    }
}
