namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10045
    {
        [StringLength(40)]
        public string GUIDRef { get; set; }

        public int ID { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(60)]
        public string UUID { get; set; }
    }
}