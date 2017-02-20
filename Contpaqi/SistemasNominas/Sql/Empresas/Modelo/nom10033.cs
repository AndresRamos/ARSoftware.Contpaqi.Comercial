namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;

    public partial class nom10033
    {
        [StringLength(255)]
        public string archivo { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [Key]
        public int idmodelo { get; set; }
    }
}