namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admExistenciaCosto")]
    public partial class admExistenciaCosto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDEXISTENCIA { get; set; }

        public int CIDALMACEN { get; set; }

        public int CIDPRODUCTO { get; set; }

        public int CIDEJERCICIO { get; set; }

        public int CTIPOEXISTENCIA { get; set; }

        public double CENTRADASINICIALES { get; set; }

        public double CSALIDASINICIALES { get; set; }

        public double CCOSTOINICIALENTRADAS { get; set; }

        public double CCOSTOINICIALSALIDAS { get; set; }

        public double CENTRADASPERIODO1 { get; set; }

        public double CENTRADASPERIODO2 { get; set; }

        public double CENTRADASPERIODO3 { get; set; }

        public double CENTRADASPERIODO4 { get; set; }

        public double CENTRADASPERIODO5 { get; set; }

        public double CENTRADASPERIODO6 { get; set; }

        public double CENTRADASPERIODO7 { get; set; }

        public double CENTRADASPERIODO8 { get; set; }

        public double CENTRADASPERIODO9 { get; set; }

        public double CENTRADASPERIODO10 { get; set; }

        public double CENTRADASPERIODO11 { get; set; }

        public double CENTRADASPERIODO12 { get; set; }

        public double CSALIDASPERIODO1 { get; set; }

        public double CSALIDASPERIODO2 { get; set; }

        public double CSALIDASPERIODO3 { get; set; }

        public double CSALIDASPERIODO4 { get; set; }

        public double CSALIDASPERIODO5 { get; set; }

        public double CSALIDASPERIODO6 { get; set; }

        public double CSALIDASPERIODO7 { get; set; }

        public double CSALIDASPERIODO8 { get; set; }

        public double CSALIDASPERIODO9 { get; set; }

        public double CSALIDASPERIODO10 { get; set; }

        public double CSALIDASPERIODO11 { get; set; }

        public double CSALIDASPERIODO12 { get; set; }

        public double CCOSTOENTRADASPERIODO1 { get; set; }

        public double CCOSTOENTRADASPERIODO2 { get; set; }

        public double CCOSTOENTRADASPERIODO3 { get; set; }

        public double CCOSTOENTRADASPERIODO4 { get; set; }

        public double CCOSTOENTRADASPERIODO5 { get; set; }

        public double CCOSTOENTRADASPERIODO6 { get; set; }

        public double CCOSTOENTRADASPERIODO7 { get; set; }

        public double CCOSTOENTRADASPERIODO8 { get; set; }

        public double CCOSTOENTRADASPERIODO9 { get; set; }

        public double CCOSTOENTRADASPERIODO10 { get; set; }

        public double CCOSTOENTRADASPERIODO11 { get; set; }

        public double CCOSTOENTRADASPERIODO12 { get; set; }

        public double CCOSTOSALIDASPERIODO1 { get; set; }

        public double CCOSTOSALIDASPERIODO2 { get; set; }

        public double CCOSTOSALIDASPERIODO3 { get; set; }

        public double CCOSTOSALIDASPERIODO4 { get; set; }

        public double CCOSTOSALIDASPERIODO5 { get; set; }

        public double CCOSTOSALIDASPERIODO6 { get; set; }

        public double CCOSTOSALIDASPERIODO7 { get; set; }

        public double CCOSTOSALIDASPERIODO8 { get; set; }

        public double CCOSTOSALIDASPERIODO9 { get; set; }

        public double CCOSTOSALIDASPERIODO10 { get; set; }

        public double CCOSTOSALIDASPERIODO11 { get; set; }

        public double CCOSTOSALIDASPERIODO12 { get; set; }

        public int CBANCONGELADO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}