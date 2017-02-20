namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10022
    {
        public bool derechoseptimodia { get; set; }

        public bool derechosueldo { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [Key]
        public int idtipoincidencia { get; set; }

        [StringLength(4)]
        public string mnemonico { get; set; }

        public double? porcentajesueldo { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tipoimss { get; set; }

        [StringLength(1)]
        public string tipoincidencia { get; set; }

        public double? valorunidad { get; set; }
    }
}