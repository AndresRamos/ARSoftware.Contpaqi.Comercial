namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admClientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCLIENTEPROVEEDOR { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODIGOCLIENTE { get; set; }

        [Required]
        [StringLength(60)]
        public string CRAZONSOCIAL { get; set; }

        public DateTime CFECHAALTA { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        [Required]
        [StringLength(20)]
        public string CCURP { get; set; }

        [Required]
        [StringLength(50)]
        public string CDENCOMERCIAL { get; set; }

        [Required]
        [StringLength(50)]
        public string CREPLEGAL { get; set; }

        public int CIDMONEDA { get; set; }

        public int CLISTAPRECIOCLIENTE { get; set; }

        public double CDESCUENTODOCTO { get; set; }

        public double CDESCUENTOMOVTO { get; set; }

        public int CBANVENTACREDITO { get; set; }

        public int CIDVALORCLASIFCLIENTE1 { get; set; }

        public int CIDVALORCLASIFCLIENTE2 { get; set; }

        public int CIDVALORCLASIFCLIENTE3 { get; set; }

        public int CIDVALORCLASIFCLIENTE4 { get; set; }

        public int CIDVALORCLASIFCLIENTE5 { get; set; }

        public int CIDVALORCLASIFCLIENTE6 { get; set; }

        public int CTIPOCLIENTE { get; set; }

        public int CESTATUS { get; set; }

        public DateTime CFECHABAJA { get; set; }

        public DateTime CFECHAULTIMAREVISION { get; set; }

        public double CLIMITECREDITOCLIENTE { get; set; }

        public int CDIASCREDITOCLIENTE { get; set; }

        public int CBANEXCEDERCREDITO { get; set; }

        public double CDESCUENTOPRONTOPAGO { get; set; }

        public int CDIASPRONTOPAGO { get; set; }

        public double CINTERESMORATORIO { get; set; }

        public int CDIAPAGO { get; set; }

        public int CDIASREVISION { get; set; }

        [Required]
        [StringLength(20)]
        public string CMENSAJERIA { get; set; }

        [Required]
        [StringLength(60)]
        public string CCUENTAMENSAJERIA { get; set; }

        public int CDIASEMBARQUECLIENTE { get; set; }

        public int CIDALMACEN { get; set; }

        public int CIDAGENTEVENTA { get; set; }

        public int CIDAGENTECOBRO { get; set; }

        public int CRESTRICCIONAGENTE { get; set; }

        public double CIMPUESTO1 { get; set; }

        public double CIMPUESTO2 { get; set; }

        public double CIMPUESTO3 { get; set; }

        public double CRETENCIONCLIENTE1 { get; set; }

        public double CRETENCIONCLIENTE2 { get; set; }

        public int CIDVALORCLASIFPROVEEDOR1 { get; set; }

        public int CIDVALORCLASIFPROVEEDOR2 { get; set; }

        public int CIDVALORCLASIFPROVEEDOR3 { get; set; }

        public int CIDVALORCLASIFPROVEEDOR4 { get; set; }

        public int CIDVALORCLASIFPROVEEDOR5 { get; set; }

        public int CIDVALORCLASIFPROVEEDOR6 { get; set; }

        public double CLIMITECREDITOPROVEEDOR { get; set; }

        public int CDIASCREDITOPROVEEDOR { get; set; }

        public int CTIEMPOENTREGA { get; set; }

        public int CDIASEMBARQUEPROVEEDOR { get; set; }

        public double CIMPUESTOPROVEEDOR1 { get; set; }

        public double CIMPUESTOPROVEEDOR2 { get; set; }

        public double CIMPUESTOPROVEEDOR3 { get; set; }

        public double CRETENCIONPROVEEDOR1 { get; set; }

        public double CRETENCIONPROVEEDOR2 { get; set; }

        public int CBANINTERESMORATORIO { get; set; }

        public double CCOMVENTAEXCEPCLIENTE { get; set; }

        public double CCOMCOBROEXCEPCLIENTE { get; set; }

        public int CBANPRODUCTOCONSIGNACION { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE3 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE4 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE5 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE6 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCLIENTE7 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR3 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR4 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR5 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR6 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTPROVEEDOR7 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA3 { get; set; }

        public DateTime CFECHAEXTRA { get; set; }

        public double CIMPORTEEXTRA1 { get; set; }

        public double CIMPORTEEXTRA2 { get; set; }

        public double CIMPORTEEXTRA3 { get; set; }

        public double CIMPORTEEXTRA4 { get; set; }

        public int CBANDOMICILIO { get; set; }

        public int CBANCREDITOYCOBRANZA { get; set; }

        public int CBANENVIO { get; set; }

        public int CBANAGENTE { get; set; }

        public int CBANIMPUESTO { get; set; }

        public int CBANPRECIO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CFACTERC01 { get; set; }

        public double CCOMVENTA { get; set; }

        public double CCOMCOBRO { get; set; }

        public int CIDMONEDA2 { get; set; }

        [Required]
        [StringLength(60)]
        public string CEMAIL1 { get; set; }

        [Required]
        [StringLength(60)]
        public string CEMAIL2 { get; set; }

        [Required]
        [StringLength(60)]
        public string CEMAIL3 { get; set; }

        public int CTIPOENTRE { get; set; }

        public int CCONCTEEMA { get; set; }

        public int CFTOADDEND { get; set; }

        public int CIDCERTCTE { get; set; }

        public int CENCRIPENT { get; set; }

        public int CBANCFD { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA4 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA5 { get; set; }

        public double CIMPORTEEXTRA5 { get; set; }

        public int CIDADDENDA { get; set; }

        public int CCODPROVCO { get; set; }

        public int CENVACUSE { get; set; }

        [Required]
        [StringLength(60)]
        public string CCON1NOM { get; set; }

        [Required]
        [StringLength(15)]
        public string CCON1TEL { get; set; }

        public int CQUITABLAN { get; set; }

        public int CFMTOENTRE { get; set; }

        public int CIDCOMPLEM { get; set; }

        public int CDESGLOSAI2 { get; set; }

        public int CLIMDOCTOS { get; set; }

        [Required]
        [StringLength(60)]
        public string CSITIOFTP { get; set; }

        [Required]
        [StringLength(60)]
        public string CUSRFTP { get; set; }

        [Required]
        [StringLength(100)]
        public string CMETODOPAG { get; set; }

        [Required]
        [StringLength(100)]
        public string CNUMCTAPAG { get; set; }
    }
}