using Contpaqi.SistemasNominas.Sql.Generales.Modelo;

namespace Contpaqi.SistemasNominas.Sql.Generales.AccesoADatos
{
    using System.Data.Entity;

    public partial class NominasGeneralesContext : DbContext
    {
        public NominasGeneralesContext()
            : base("name=NominasGeneralesContext")
        {
        }

        public virtual DbSet<Asc10001> Asc10001 { get; set; }

        public virtual DbSet<Asc10002> Asc10002 { get; set; }

        public virtual DbSet<Asc10003> Asc10003 { get; set; }

        public virtual DbSet<Asc10004> Asc10004 { get; set; }

        public virtual DbSet<CAC10000> CAC10000 { get; set; }

        public virtual DbSet<CAC20000> CAC20000 { get; set; }

        public virtual DbSet<CAC30000> CAC30000 { get; set; }

        public virtual DbSet<CAC40000> CAC40000 { get; set; }

        public virtual DbSet<CAC50000> CAC50000 { get; set; }

        public virtual DbSet<CACIdiom> CACIdiom { get; set; }

        public virtual DbSet<DDFIELD> DDFIELD { get; set; }

        public virtual DbSet<DDTABLE> DDTABLE { get; set; }

        public virtual DbSet<FechaCatalogosSAT> FechaCatalogosSAT { get; set; }

        public virtual DbSet<NOM10000> NOM10000 { get; set; }

        public virtual DbSet<Nom20000> Nom20000 { get; set; }

        public virtual DbSet<NOM30000> NOM30000 { get; set; }

        public virtual DbSet<Nom40000> Nom40000 { get; set; }

        public virtual DbSet<Nom50000> Nom50000 { get; set; }

        public virtual DbSet<Nom60000> Nom60000 { get; set; }

        public virtual DbSet<NomIdiom> NomIdiom { get; set; }

        public virtual DbSet<NomIDX> NomIDX { get; set; }

        public virtual DbSet<RELACION> RELACION { get; set; }

        public virtual DbSet<REPORTS> REPORTS { get; set; }

        public virtual DbSet<SATCatFormasPago> SATCatFormasPago { get; set; }

        public virtual DbSet<VistaRelacion> VistaRelacion { get; set; }

        public virtual DbSet<VistaTabla> VistaTabla { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asc10001>()
                .Property(e => e.DatabaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10001>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10001>()
                .Property(e => e.TableAlias)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10001>()
                .Property(e => e.ItemAlias)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10001>()
                .Property(e => e.MainFields)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10002>()
                .Property(e => e.DatabaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10002>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10002>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10002>()
                .Property(e => e.FieldAlias)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10002>()
                .Property(e => e.Index)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10003>()
                .Property(e => e.DatabaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10003>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10003>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10003>()
                .Property(e => e.FieldValue)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10003>()
                .Property(e => e.UserValue)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10004>()
                .Property(e => e.DatabaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10004>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10004>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10004>()
                .Property(e => e.LookupTable)
                .IsUnicode(false);

            modelBuilder.Entity<Asc10004>()
                .Property(e => e.LookupField)
                .IsUnicode(false);

            modelBuilder.Entity<CAC10000>()
                .Property(e => e.IdSistema)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC10000>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<CAC10000>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CAC10000>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<CAC20000>()
                .Property(e => e.IdSistema)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC20000>()
                .Property(e => e.Proceso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC20000>()
                .Property(e => e.Adicional)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC30000>()
                .Property(e => e.IdSistema)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC30000>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAC40000>()
                .Property(e => e.IdSistema)
                .IsUnicode(false);

            modelBuilder.Entity<CAC40000>()
                .Property(e => e.IdProceso)
                .IsUnicode(false);

            modelBuilder.Entity<CAC40000>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CAC40000>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAC40000>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CAC50000>()
                .Property(e => e.IdSistema)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC50000>()
                .Property(e => e.Grupo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAC50000>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NombreIdioma)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NombreDLLApp)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NombreDLLErr)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NombreArchivoAyuda)
                .IsUnicode(false);

            modelBuilder.Entity<CACIdiom>()
                .Property(e => e.NombreArchivoBDD)
                .IsUnicode(false);

            modelBuilder.Entity<DDFIELD>()
                .Property(e => e.databasename)
                .IsUnicode(false);

            modelBuilder.Entity<DDFIELD>()
                .Property(e => e.tablename)
                .IsUnicode(false);

            modelBuilder.Entity<DDFIELD>()
                .Property(e => e.fieldname)
                .IsUnicode(false);

            modelBuilder.Entity<DDFIELD>()
                .Property(e => e.fieldalias)
                .IsUnicode(false);

            modelBuilder.Entity<DDFIELD>()
                .Property(e => e.displayformat)
                .IsUnicode(false);

            modelBuilder.Entity<DDTABLE>()
                .Property(e => e.databasename)
                .IsUnicode(false);

            modelBuilder.Entity<DDTABLE>()
                .Property(e => e.tablename)
                .IsUnicode(false);

            modelBuilder.Entity<DDTABLE>()
                .Property(e => e.tablealias)
                .IsUnicode(false);

            modelBuilder.Entity<DDTABLE>()
                .Property(e => e.group)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.NombreEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.NombreCorto)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RutaEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RutaRespaldo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RutaContpaqW)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RutaCheqpaqW)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Telefono3)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegistroIMSS)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegistroCamara)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Homoclave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegistroInfonavit)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegistroFonacot)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegistroComisionMixta)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegistroSSA)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.ZonaSalarioGeneral)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.CuentaCWGlobal)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.EstructuraCuentaCW)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.FormatoSobreRecibo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.NombreRepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.ApPaternoRepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.ApMaternoRepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.ApartadoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.MascarillaCodigo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.TipoCodigoEmpleado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.GUIDEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.GUIDDSL)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.RegimenFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.FormatoSobreReciboCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.vConfigComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.vUltTimbreComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.vConfigComplemento)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.vUltTimbreComplemento)
                .IsUnicode(false);

            modelBuilder.Entity<NOM10000>()
                .Property(e => e.OrigenRecursos)
                .IsUnicode(false);

            modelBuilder.Entity<Nom20000>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Nom20000>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Nom20000>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Nom20000>()
                .Property(e => e.TipoUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nom20000>()
                .Property(e => e.Acceso)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.NombreFiltro)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.FiltroReal)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.FiltroUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.FiltroModificable)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.ListaCampos)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.CamposAgrupar)
                .IsUnicode(false);

            modelBuilder.Entity<NOM30000>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nom40000>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Nom50000>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Nom50000>()
                .Property(e => e.TipoColumna)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NomIdiom>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTS>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTS>()
                .Property(e => e.DataViewName)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTS>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<VistaRelacion>()
                .Property(e => e.campo)
                .IsUnicode(false);

            modelBuilder.Entity<VistaRelacion>()
                .Property(e => e.campodestino)
                .IsUnicode(false);

            modelBuilder.Entity<VistaTabla>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<VistaTabla>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<NomIDX>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<NomIDX>()
                .Property(e => e.Indice)
                .IsUnicode(false);

            modelBuilder.Entity<NomIDX>()
                .Property(e => e.Columnas)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.TablaOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.CampoOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.TablaVer)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.CampoVer)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.Despliegue)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.ValorVer)
                .IsUnicode(false);

            modelBuilder.Entity<RELACION>()
                .Property(e => e.BaseDatos)
                .IsUnicode(false);

            modelBuilder.Entity<SATCatFormasPago>()
                .Property(e => e.ClaveFormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SATCatFormasPago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}