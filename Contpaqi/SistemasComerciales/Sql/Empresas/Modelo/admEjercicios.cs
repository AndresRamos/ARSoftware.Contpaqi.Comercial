namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admEjercicios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDEJERCICIO { get; set; }

        public int CNUMEROEJERCICIO { get; set; }

        public DateTime CFECINIPERIODO1 { get; set; }

        public DateTime CFECINIPERIODO2 { get; set; }

        public DateTime CFECINIPERIODO3 { get; set; }

        public DateTime CFECINIPERIODO4 { get; set; }

        public DateTime CFECINIPERIODO5 { get; set; }

        public DateTime CFECINIPERIODO6 { get; set; }

        public DateTime CFECINIPERIODO7 { get; set; }

        public DateTime CFECINIPERIODO8 { get; set; }

        public DateTime CFECINIPERIODO9 { get; set; }

        public DateTime CFECINIPERIODO10 { get; set; }

        public DateTime CFECINIPERIODO11 { get; set; }

        public DateTime CFECINIPERIODO12 { get; set; }

        public DateTime CFECHAFINAL { get; set; }

        public int CEJERCICIO { get; set; }
    }
}
