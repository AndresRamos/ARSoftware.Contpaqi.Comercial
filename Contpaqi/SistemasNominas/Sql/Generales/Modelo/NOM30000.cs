namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class NOM30000
    {
        [Column(TypeName = "text")]
        public string CamposAgrupar { get; set; }

        [Column(TypeName = "text")]
        public string FiltroModificable { get; set; }

        [Column(TypeName = "text")]
        public string FiltroReal { get; set; }

        [Column(TypeName = "text")]
        public string FiltroUsuario { get; set; }

        public int? IdEmpresa { get; set; }

        [Column(TypeName = "text")]
        public string ListaCampos { get; set; }

        [Key]
        [StringLength(255)]
        public string NombreFiltro { get; set; }

        public int? NumeroFiltro { get; set; }

        [StringLength(1)]
        public string Origen { get; set; }
    }
}