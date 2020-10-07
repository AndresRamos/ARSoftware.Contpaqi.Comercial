using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.Nominas.Empresa
{
    using System.Data.Entity;

    public partial class NominasEmpresaDbContext : DbContext
    {
        static NominasEmpresaDbContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<NominasEmpresaDbContext>());
        }

        public NominasEmpresaDbContext()
            : base("name=NominasEmpresaDbContext")
        {
        }

        protected NominasEmpresaDbContext(DbCompiledModel model) : base(model)
        {
        }

        public NominasEmpresaDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public NominasEmpresaDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public NominasEmpresaDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public NominasEmpresaDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public NominasEmpresaDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<nom10001> nom10001 { get; set; }
        public virtual DbSet<nom10002> nom10002 { get; set; }
        public virtual DbSet<nom10003> nom10003 { get; set; }
        public virtual DbSet<nom10004> nom10004 { get; set; }
        public virtual DbSet<nom10005> nom10005 { get; set; }
        public virtual DbSet<nom10006> nom10006 { get; set; }
        public virtual DbSet<nom10007> nom10007 { get; set; }
        public virtual DbSet<nom10008> nom10008 { get; set; }
        public virtual DbSet<nom10009> nom10009 { get; set; }
        public virtual DbSet<nom10010> nom10010 { get; set; }
        public virtual DbSet<nom10011> nom10011 { get; set; }
        public virtual DbSet<nom10012> nom10012 { get; set; }
        public virtual DbSet<nom10013> nom10013 { get; set; }
        public virtual DbSet<nom10014> nom10014 { get; set; }
        public virtual DbSet<nom10015> nom10015 { get; set; }
        public virtual DbSet<nom10016> nom10016 { get; set; }
        public virtual DbSet<nom10017> nom10017 { get; set; }
        public virtual DbSet<nom10018> nom10018 { get; set; }
        public virtual DbSet<nom10019> nom10019 { get; set; }
        public virtual DbSet<nom10020> nom10020 { get; set; }
        public virtual DbSet<nom10021> nom10021 { get; set; }
        public virtual DbSet<nom10022> nom10022 { get; set; }
        public virtual DbSet<nom10023> nom10023 { get; set; }
        public virtual DbSet<nom10024> nom10024 { get; set; }
        public virtual DbSet<nom10025> nom10025 { get; set; }
        public virtual DbSet<nom10026> nom10026 { get; set; }
        public virtual DbSet<nom10027> nom10027 { get; set; }
        public virtual DbSet<nom10028> nom10028 { get; set; }
        public virtual DbSet<nom10029> nom10029 { get; set; }
        public virtual DbSet<nom10030> nom10030 { get; set; }
        public virtual DbSet<nom10031> nom10031 { get; set; }
        public virtual DbSet<nom10032> nom10032 { get; set; }
        public virtual DbSet<nom10033> nom10033 { get; set; }
        public virtual DbSet<nom10034> nom10034 { get; set; }
        public virtual DbSet<nom10035> nom10035 { get; set; }
        public virtual DbSet<nom10036> nom10036 { get; set; }
        public virtual DbSet<nom10037> nom10037 { get; set; }
        public virtual DbSet<nom10038> nom10038 { get; set; }
        public virtual DbSet<nom10039> nom10039 { get; set; }
        public virtual DbSet<nom10040> nom10040 { get; set; }
        public virtual DbSet<nom10041> nom10041 { get; set; }
        public virtual DbSet<nom10042> nom10042 { get; set; }
        public virtual DbSet<nom10043> nom10043 { get; set; }
        public virtual DbSet<nom10044> nom10044 { get; set; }
        public virtual DbSet<nom10045> nom10045 { get; set; }
        public virtual DbSet<Nom10046> Nom10046 { get; set; }
        public virtual DbSet<nom10048> nom10048 { get; set; }
        public virtual DbSet<nom10049> nom10049 { get; set; }
        public virtual DbSet<nom10050> nom10050 { get; set; }
        public virtual DbSet<nom10051> nom10051 { get; set; }
        public virtual DbSet<nom10000> nom10000 { get; set; }
        public virtual DbSet<Nom1000x> Nom1000x { get; set; }
        public virtual DbSet<nom10047> nom10047 { get; set; }
        public virtual DbSet<nom100xx> nom100xx { get; set; }
        public virtual DbSet<nomsimul> nomsimul { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<nom10001>()
                .Property(e => e.codigoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.apellidopaterno)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.apellidomaterno)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.nombrelargo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.lugarnacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.estadocivil)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.curpi)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.curpf)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.numerosegurosocial)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.homoclave)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.cuentapagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.sucursalpagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.bancopagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.estadoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.cuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.tipocontrato)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.basecotizacionimss)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.tipoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.basepago)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.formapago)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.zonasalario)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.expediente)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.nombrepadre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.nombremadre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.numeroafore)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.causabaja)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.campoextra1)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.campoextra2)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.campoextra3)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.cestadoempleadoperiodo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.NumeroFonacot)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.TipoRegimen)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.ClabeInterbancaria)
                .IsUnicode(false);

            modelBuilder.Entity<nom10001>()
                .Property(e => e.EntidadFederativa)
                .IsUnicode(false);

            modelBuilder.Entity<nom10003>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10003>()
                .Property(e => e.beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<nom10003>()
                .Property(e => e.cuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10003>()
                .Property(e => e.csegmentonegocio)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.tipoconcepto)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.leyendaimporte1)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.leyendaimporte2)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.leyendaimporte3)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.leyendaimporte4)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.cuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.tipomovtocw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.contracuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.contabcuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.contabcontracuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.leyendavalor)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.formulaimportetotal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.formulaimporte1)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.formulaimporte2)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.formulaimporte3)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.formulaimporte4)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.FormulaValor)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.CuentaGravado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.CuentaExentoDeduc)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.CuentaExentoNoDeduc)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.ClaveAgrupadoraSAT)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.MetodoDePago)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.TipoClaveSAT)
                .IsUnicode(false);

            modelBuilder.Entity<nom10004>()
                .Property(e => e.TipoHoras)
                .IsUnicode(false);

            modelBuilder.Entity<nom10006>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10006>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<nom10012>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10014>()
                .Property(e => e.diasdescanso)
                .IsUnicode(false);

            modelBuilder.Entity<nom10015>()
                .Property(e => e.estadocontab)
                .IsUnicode(false);

            modelBuilder.Entity<nom10015>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<nom10015>()
                .Property(e => e.diario)
                .IsUnicode(false);

            modelBuilder.Entity<nom10015>()
                .Property(e => e.GUIDPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.cuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.tipomovto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.diario)
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.csegmentonegocio)
                .IsUnicode(false);

            modelBuilder.Entity<nom10016>()
                .Property(e => e.GUIDMovtoPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<nom10017>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10017>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nom10017>()
                .Property(e => e.numerocontrol)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.incapacidadinicial)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.ramoseguro)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.tiporiesgo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.nombremedico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.matriculamedico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.circunstancia)
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.controlincapacidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nom10018>()
                .Property(e => e.secuelaconsecuencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nom10019>()
                .Property(e => e.tiposueldo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nom10020>()
                .Property(e => e.clavebajareingreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nom10021>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10021>()
                .Property(e => e.tipomovtoacumulado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10022>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10022>()
                .Property(e => e.mnemonico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10022>()
                .Property(e => e.tipoimss)
                .IsUnicode(false);

            modelBuilder.Entity<nom10022>()
                .Property(e => e.tipoincidencia)
                .IsUnicode(false);

            modelBuilder.Entity<nom10023>()
                .Property(e => e.nombretipoperiodo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10023>()
                .Property(e => e.posicionseptimos)
                .IsUnicode(false);

            modelBuilder.Entity<nom10023>()
                .Property(e => e.PeriodicidadPago)
                .IsUnicode(false);

            modelBuilder.Entity<nom10024>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10024>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10024>()
                .Property(e => e.ruta)
                .IsUnicode(false);

            modelBuilder.Entity<nom10024>()
                .Property(e => e.fechainicio)
                .IsUnicode(false);

            modelBuilder.Entity<nom10024>()
                .Property(e => e.frecuencia)
                .IsUnicode(false);

            modelBuilder.Entity<nom10026>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10027>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10028>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10028>()
                .Property(e => e.tipocolumna)
                .IsUnicode(false);

            modelBuilder.Entity<nom10030>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10030>()
                .Property(e => e.grupo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10030>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10031>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10031>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10031>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10031>()
                .Property(e => e.ayuda)
                .IsUnicode(false);

            modelBuilder.Entity<nom10031>()
                .Property(e => e.expresion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10032>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10032>()
                .Property(e => e.TipoJornada)
                .IsUnicode(false);

            modelBuilder.Entity<nom10033>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10033>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.estadocivil)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.cuentapagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.sucursalpagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.bancopagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.estadoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.cuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.tipocontrato)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.basecotizacionimss)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.tipoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.basepago)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.formapago)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.zonasalario)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.numeroafore)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.causabaja)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.campoextra1)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.campoextra2)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.campoextra3)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.cestadoempleadoperiodo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom10034>()
                .Property(e => e.ClabeInterbancaria)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.crfc)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.chomoclave)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.crfccompleto)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.cregistroimss)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.GUIDFirmaDSL)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.ClaseRiesgoTrabajo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.FraccionRiesgoTrabajo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.LocalidadRegPatronal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10035>()
                .Property(e => e.EntidadFederativa)
                .IsUnicode(false);

            modelBuilder.Entity<nom10036>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10036>()
                .Property(e => e.sentenciaSQL)
                .IsUnicode(false);

            modelBuilder.Entity<nom10039>()
                .Property(e => e.ClaveABR)
                .IsUnicode(false);

            modelBuilder.Entity<nom10040>()
                .Property(e => e.NumeroControl)
                .IsUnicode(false);

            modelBuilder.Entity<nom10040>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10040>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10040>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.GUIDDocumentoDSL)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.GUIDDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.Confirmacion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.URLCaptcha)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.vComplemento)
                .IsUnicode(false);

            modelBuilder.Entity<nom10043>()
                .Property(e => e.vComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<nom10045>()
                .Property(e => e.GUIDRef)
                .IsUnicode(false);

            modelBuilder.Entity<nom10045>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<nom10045>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Nom10046>()
                .Property(e => e.ParametrosGenerales)
                .IsUnicode(false);

            modelBuilder.Entity<Nom10046>()
                .Property(e => e.ConceptosCalculo)
                .IsUnicode(false);

            modelBuilder.Entity<Nom10046>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10048>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<nom10048>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<nom10050>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.nombrecorto)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.rutarespaldo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.rutacontpaqw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.rutacheqpaqw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.telefono3)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.registroimss)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.registrocamara)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.homoclave)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.registroinfonavit)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.registrofonacot)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.registrocomisionmixta)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.registrossa)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.zonasalariogeneral)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.cuentacwglobal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.estructuracuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.formatosobrerecibo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.localidad)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.nombrerepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.appaternorepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.apmaternorepresentante)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.codigopostal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.apartadopostal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.mascarillacodigo)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.tipocodigoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.GUIDEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.GUIDDSL)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.RegimenFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.FormatoSobreReciboCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.vConfigComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.vUltTimbreComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.vConfigComplemento)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.vUltTimbreComplemento)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.OrigenRecursos)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.RelacionarCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<nom10000>()
                .Property(e => e.GUIDEmpresaOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.estadocivil)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.cuentapagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.sucursalpagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.bancopagoelectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.estadoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.cuentacw)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.tipocontrato)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.basecotizacionimss)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.tipoempleado)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.basepago)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.formapago)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.zonasalario)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.numeroafore)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.causabaja)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.campoextra1)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.campoextra2)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.campoextra3)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.cestadoempleadoperiodo)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<nom100xx>()
                .Property(e => e.ClabeInterbancaria)
                .IsUnicode(false);

            modelBuilder.Entity<nomsimul>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nomsimul>()
                .Property(e => e.ids)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nomsimul>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nomsimul>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nomsimul>()
                .Property(e => e.expresion)
                .IsUnicode(false);
        }
    }
}