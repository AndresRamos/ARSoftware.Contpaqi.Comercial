namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RELACION")]
    public partial class RELACION
    {
        [StringLength(30)]
        public string BaseDatos { get; set; }

        [StringLength(40)]
        public string CampoOrigen { get; set; }

        [StringLength(40)]
        public string CampoVer { get; set; }

        [StringLength(40)]
        public string Despliegue { get; set; }

        [StringLength(20)]
        public string TablaOrigen { get; set; }

        [StringLength(20)]
        public string TablaVer { get; set; }

        [Key]
        [StringLength(3)]
        public string ValorVer { get; set; }
    }
}