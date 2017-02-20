namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class nom10004
    {
        public bool articulo86 { get; set; }

        public bool automaticoglobal { get; set; }

        public bool automaticoliquidacion { get; set; }

        [StringLength(20)]
        public string ClaveAgrupadoraSAT { get; set; }

        [StringLength(1)]
        public string contabcontracuentacw { get; set; }

        [StringLength(1)]
        public string contabcuentacw { get; set; }

        [StringLength(31)]
        public string contracuentacw { get; set; }

        [StringLength(31)]
        public string cuentacw { get; set; }

        [StringLength(31)]
        public string CuentaExentoDeduc { get; set; }

        [StringLength(31)]
        public string CuentaExentoNoDeduc { get; set; }

        [StringLength(31)]
        public string CuentaGravado { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public bool especie { get; set; }

        [Column(TypeName = "text")]
        public string formulaimporte1 { get; set; }

        [Column(TypeName = "text")]
        public string formulaimporte2 { get; set; }

        [Column(TypeName = "text")]
        public string formulaimporte3 { get; set; }

        [Column(TypeName = "text")]
        public string formulaimporte4 { get; set; }

        [Column(TypeName = "text")]
        public string formulaimportetotal { get; set; }

        [Column(TypeName = "text")]
        public string FormulaValor { get; set; }

        [Key]
        public int idconcepto { get; set; }

        public bool imprimir { get; set; }

        [StringLength(40)]
        public string leyendaimporte1 { get; set; }

        [StringLength(40)]
        public string leyendaimporte2 { get; set; }

        [StringLength(40)]
        public string leyendaimporte3 { get; set; }

        [StringLength(40)]
        public string leyendaimporte4 { get; set; }

        [StringLength(40)]
        public string leyendavalor { get; set; }

        public int? numeroconcepto { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tipoconcepto { get; set; }

        [StringLength(1)]
        public string tipomovtocw { get; set; }
    }
}