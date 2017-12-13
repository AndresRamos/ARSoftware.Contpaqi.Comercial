namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admPromociones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPROMOCION { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODIGOPROMOCION { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREPROMOCION { get; set; }

        public DateTime CFECHAINICIO { get; set; }

        public DateTime CFECHAFIN { get; set; }

        public double CVOLUMENMINIMO { get; set; }

        public double CVOLUMENMAXIMO { get; set; }

        public double CPORCENTAJEDESCUENTO { get; set; }

        public int CIDVALORCLASIFCLIENTE1 { get; set; }

        public int CIDVALORCLASIFCLIENTE2 { get; set; }

        public int CIDVALORCLASIFCLIENTE3 { get; set; }

        public int CIDVALORCLASIFCLIENTE4 { get; set; }

        public int CIDVALORCLASIFCLIENTE5 { get; set; }

        public int CIDVALORCLASIFCLIENTE6 { get; set; }

        public int CIDVALORCLASIFPRODUCTO1 { get; set; }

        public int CIDVALORCLASIFPRODUCTO2 { get; set; }

        public int CIDVALORCLASIFPRODUCTO3 { get; set; }

        public int CIDVALORCLASIFPRODUCTO4 { get; set; }

        public int CIDVALORCLASIFPRODUCTO5 { get; set; }

        public int CIDVALORCLASIFPRODUCTO6 { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CTIPOPROMO { get; set; }

        public int CIDCPTODOC { get; set; }

        public int CSUBTIPO { get; set; }

        [Required]
        [StringLength(4)]
        public string CHORAINI { get; set; }

        [Required]
        [StringLength(4)]
        public string CHORAFIN { get; set; }

        public int CTIPOPRO { get; set; }

        public int CVALA { get; set; }

        public int CVALB { get; set; }

        public int CDIAS { get; set; }

        public DateTime CFECHAALTA { get; set; }

        public int CSTATUS { get; set; }
    }
}
