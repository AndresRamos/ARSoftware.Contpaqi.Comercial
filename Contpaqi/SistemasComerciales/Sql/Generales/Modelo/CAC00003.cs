namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CAC00003
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDBITACORA { get; set; }

        [Column(TypeName = "text")]
        public string CMENSAJE { get; set; }
    }
}
