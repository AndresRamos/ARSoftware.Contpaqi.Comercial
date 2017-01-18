namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Polizas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Ejercicio { get; set; }

        public int Periodo { get; set; }

        public int TipoPol { get; set; }

        public int Folio { get; set; }

        public int? Clase { get; set; }

        public bool? Impresa { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        public DateTime? Fecha { get; set; }

        public double? Cargos { get; set; }

        public double? Abonos { get; set; }

        public int? IdDiario { get; set; }

        public int? SistOrig { get; set; }

        public bool? Ajuste { get; set; }

        public int IdUsuario { get; set; }

        public bool? ConFlujo { get; set; }

        public bool? ConCuadre { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [StringLength(254)]
        public string RutaAnexo { get; set; }

        [StringLength(254)]
        public string ArchivoAnexo { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }

        public bool? tieneDoctoBancario { get; set; }
    }
}
