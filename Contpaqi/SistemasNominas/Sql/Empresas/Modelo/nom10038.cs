namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class nom10038
    {
        public int IdConcepto { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDEmpleado { get; set; }

        public double Importe { get; set; }
    }
}