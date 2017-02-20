namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10018
    {
        [StringLength(1)]
        public string circunstancia { get; set; }

        [StringLength(1)]
        public string controlincapacidad { get; set; }

        public bool controlmaternidad { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public int? diasautorizados { get; set; }

        public DateTime? fechainicio { get; set; }

        public bool fincaso { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        public int? idempleado { get; set; }

        [Key]
        public int idtarjetaincapacidad { get; set; }

        public int? idtipoincidencia { get; set; }

        [StringLength(1)]
        public string incapacidadinicial { get; set; }

        [StringLength(40)]
        public string matriculamedico { get; set; }

        [StringLength(40)]
        public string nombremedico { get; set; }

        public int? numerocaso { get; set; }

        public double? porcentajeincapacidad { get; set; }

        [StringLength(1)]
        public string ramoseguro { get; set; }

        [StringLength(1)]
        public string secuelaconsecuencia { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tiporiesgo { get; set; }
    }
}