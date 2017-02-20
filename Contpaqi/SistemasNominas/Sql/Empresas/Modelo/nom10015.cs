namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10015
    {
        [StringLength(100)]
        public string concepto { get; set; }

        [StringLength(20)]
        public string diario { get; set; }

        [StringLength(1)]
        public string estadocontab { get; set; }

        public DateTime? fechapoliza { get; set; }

        [StringLength(40)]
        public string GUIDPoliza { get; set; }

        public int? idperiodo { get; set; }

        [Key]
        public int idpoliza { get; set; }

        public int? numeropoliza { get; set; }

        public int? tipopoliza { get; set; }
    }
}