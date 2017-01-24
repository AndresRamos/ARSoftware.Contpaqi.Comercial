namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ModulosListados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Consec { get; set; }

        public int? Modulo { get; set; }

        [StringLength(100)]
        public string ColumnaOrigen { get; set; }

        [StringLength(50)]
        public string ColumnaDesplegar { get; set; }

        [StringLength(50)]
        public string ColumnaDesIdiom { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public int? TipoDato { get; set; }

        public int? PorOmision { get; set; }

        [StringLength(30)]
        public string Tabla { get; set; }
    }
}