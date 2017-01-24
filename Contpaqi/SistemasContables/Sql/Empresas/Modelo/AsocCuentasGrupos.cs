namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AsocCuentasGrupos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdGrupoCuenta { get; set; }

        public int IdCuentaCheque { get; set; }
    }
}