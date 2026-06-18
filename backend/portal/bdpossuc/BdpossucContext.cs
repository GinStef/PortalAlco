using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace portal.bdpossuc;

public partial class BdpossucContext : DbContext
{
    public BdpossucContext(DbContextOptions<BdpossucContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AlmacenExt> AlmacenExts { get; set; }

    public virtual DbSet<ArqueoTerminal> ArqueoTerminals { get; set; }

    public virtual DbSet<ArqueoTerminalDetalle> ArqueoTerminalDetalles { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<ArticuloConsolidar> ArticuloConsolidars { get; set; }

    public virtual DbSet<ArticuloCostoHist> ArticuloCostoHists { get; set; }

    public virtual DbSet<ArticuloEmpaque> ArticuloEmpaques { get; set; }

    public virtual DbSet<ArticuloPrecio> ArticuloPrecios { get; set; }

    public virtual DbSet<ArticuloPrecioVoluman> ArticuloPrecioVolumen { get; set; }

    public virtual DbSet<ArticuloProveedor> ArticuloProveedors { get; set; }

    public virtual DbSet<ArticuloProveedorUo> ArticuloProveedorUos { get; set; }

    public virtual DbSet<ArticuloTransformado> ArticuloTransformados { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BusquedaCriterio> BusquedaCriterios { get; set; }

    public virtual DbSet<Busquedum> Busqueda { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<CambioCosto> CambioCostos { get; set; }

    public virtual DbSet<CambioCostoOrigen> CambioCostoOrigens { get; set; }

    public virtual DbSet<CambioPrecio> CambioPrecios { get; set; }

    public virtual DbSet<CambioPrecioDet> CambioPrecioDets { get; set; }

    public virtual DbSet<CambioPrecioDetPl> CambioPrecioDetPls { get; set; }

    public virtual DbSet<CampoCatalogo> CampoCatalogos { get; set; }

    public virtual DbSet<CfdTipoFactura> CfdTipoFacturas { get; set; }

    public virtual DbSet<CfdTipoFacturaOrigen> CfdTipoFacturaOrigens { get; set; }

    public virtual DbSet<CfdTipoFacturaUo> CfdTipoFacturaUos { get; set; }

    public virtual DbSet<CfdTipoFacturaUoFolio> CfdTipoFacturaUoFolios { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteFormaPago> ClienteFormaPagos { get; set; }

    public virtual DbSet<ClientePrecio> ClientePrecios { get; set; }

    public virtual DbSet<ClienteTarjetaCf> ClienteTarjetaCfs { get; set; }

    public virtual DbSet<CodigoArticulo> CodigoArticulos { get; set; }

    public virtual DbSet<CompaniaValore> CompaniaValores { get; set; }

    public virtual DbSet<ConfiguracionTeclado> ConfiguracionTeclados { get; set; }

    public virtual DbSet<CorreoMensaje> CorreoMensajes { get; set; }

    public virtual DbSet<CorreoUsuario> CorreoUsuarios { get; set; }

    public virtual DbSet<CorteCaja> CorteCajas { get; set; }

    public virtual DbSet<CorteParcial> CorteParcials { get; set; }

    public virtual DbSet<CorteParcialFormaPago> CorteParcialFormaPagos { get; set; }

    public virtual DbSet<CorteParcialFormaPagoTiendum> CorteParcialFormaPagoTienda { get; set; }

    public virtual DbSet<CorteTiendaFormaPago> CorteTiendaFormaPagos { get; set; }

    public virtual DbSet<CorteTiendaRelParcial> CorteTiendaRelParcials { get; set; }

    public virtual DbSet<CorteTiendum> CorteTienda { get; set; }

    public virtual DbSet<CveEstatus> CveEstatuses { get; set; }

    public virtual DbSet<CxcTipoDocumento> CxcTipoDocumentos { get; set; }

    public virtual DbSet<DescuentoSupervisor> DescuentoSupervisors { get; set; }

    public virtual DbSet<Devolucion> Devolucions { get; set; }

    public virtual DbSet<DevolucionDet> DevolucionDets { get; set; }

    public virtual DbSet<DevolucionDetSerie> DevolucionDetSeries { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EntregaValore> EntregaValores { get; set; }

    public virtual DbSet<EsMovimientoSocio> EsMovimientoSocios { get; set; }

    public virtual DbSet<EsVaria> EsVarias { get; set; }

    public virtual DbSet<EsVariasDet> EsVariasDets { get; set; }

    public virtual DbSet<EsVariasDetSerie> EsVariasDetSeries { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstatusArticulo> EstatusArticulos { get; set; }

    public virtual DbSet<ExistenciaHist> ExistenciaHists { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; }

    public virtual DbSet<FacturaDocumento> FacturaDocumentos { get; set; }

    public virtual DbSet<FacturaImpuesto> FacturaImpuestos { get; set; }

    public virtual DbSet<Familium> Familia { get; set; }

    public virtual DbSet<Folio> Folios { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<FormaPagoDenominacion> FormaPagoDenominacions { get; set; }

    public virtual DbSet<FormaPagoSat> FormaPagoSats { get; set; }

    public virtual DbSet<Funcion> Funcions { get; set; }

    public virtual DbSet<GrupoCliente> GrupoClientes { get; set; }

    public virtual DbSet<IfceCont> IfceConts { get; set; }

    public virtual DbSet<IfceContD> IfceContDs { get; set; }

    public virtual DbSet<IfceCx> IfceCxes { get; set; }

    public virtual DbSet<IfceInv> IfceInvs { get; set; }

    public virtual DbSet<IfceInvD> IfceInvDs { get; set; }

    public virtual DbSet<ImagenPo> ImagenPos { get; set; }

    public virtual DbSet<ImagenPosDet> ImagenPosDets { get; set; }

    public virtual DbSet<ImagenPosUo> ImagenPosUos { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<InventarioFisico> InventarioFisicos { get; set; }

    public virtual DbSet<InventarioFisicoDet> InventarioFisicoDets { get; set; }

    public virtual DbSet<InventarioFisicoDetSerie> InventarioFisicoDetSeries { get; set; }

    public virtual DbSet<InventarioSerie> InventarioSeries { get; set; }

    public virtual DbSet<ListaPrecio> ListaPrecios { get; set; }

    public virtual DbSet<LogTranCfc> LogTranCfcs { get; set; }

    public virtual DbSet<LogTranError> LogTranErrors { get; set; }

    public virtual DbSet<LogTranFolio> LogTranFolios { get; set; }

    public virtual DbSet<LogTranIncoming> LogTranIncomings { get; set; }

    public virtual DbSet<LogTranMnl1> LogTranMnls { get; set; }

    public virtual DbSet<LogTranMnlTmp> LogTranMnlTmps { get; set; }

    public virtual DbSet<LogTranPasoCte> LogTranPasoCtes { get; set; }

    public virtual DbSet<LogTranPasoCteCfc> LogTranPasoCteCfcs { get; set; }

    public virtual DbSet<LogTranPasoCteCfcIncoming> LogTranPasoCteCfcIncomings { get; set; }

    public virtual DbSet<LogTranPasoCteIncoming> LogTranPasoCteIncomings { get; set; }

    public virtual DbSet<LogTranPasoSrv> LogTranPasoSrvs { get; set; }

    public virtual DbSet<LogTranPasoSrvCfc> LogTranPasoSrvCfcs { get; set; }

    public virtual DbSet<LogTranSendLogToClient> LogTranSendLogToClients { get; set; }

    public virtual DbSet<LogTranSent> LogTranSents { get; set; }

    public virtual DbSet<LogVentaDesc> LogVentaDescs { get; set; }

    public virtual DbSet<LogVentaDetalle> LogVentaDetalles { get; set; }

    public virtual DbSet<LogVentaDetalleComp> LogVentaDetalleComps { get; set; }

    public virtual DbSet<LogVentaDetalleCon> LogVentaDetalleCons { get; set; }

    public virtual DbSet<LogVentaForma> LogVentaFormas { get; set; }

    public virtual DbSet<LogVentum> LogVenta { get; set; }

    public virtual DbSet<LogtranMnl> LogtranMnls { get; set; }

    public virtual DbSet<Logtranmnl2> Logtranmnl2s { get; set; }

    public virtual DbSet<MacPc> MacPcs { get; set; }

    public virtual DbSet<MaqPc> MaqPcs { get; set; }

    public virtual DbSet<MaqPcDet> MaqPcDets { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<MensajeUnidadOperativa> MensajeUnidadOperativas { get; set; }

    public virtual DbSet<Merma> Mermas { get; set; }

    public virtual DbSet<MermaDet> MermaDets { get; set; }

    public virtual DbSet<MermaDetSerie> MermaDetSeries { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<MonitorTerminal> MonitorTerminals { get; set; }

    public virtual DbSet<MotivoFaltanteRecibo> MotivoFaltanteRecibos { get; set; }

    public virtual DbSet<MovimientoCajaPo> MovimientoCajaPos { get; set; }

    public virtual DbSet<MovimientoCajaPosDet> MovimientoCajaPosDets { get; set; }

    public virtual DbSet<MovimientoCxc> MovimientoCxcs { get; set; }

    public virtual DbSet<MovimientoCxcDet> MovimientoCxcDets { get; set; }

    public virtual DbSet<MovimientoInventario> MovimientoInventarios { get; set; }

    public virtual DbSet<MovimientoInventarioDet> MovimientoInventarioDets { get; set; }

    public virtual DbSet<MovimientoInventarioDetSerie> MovimientoInventarioDetSeries { get; set; }

    public virtual DbSet<MovimientoSocio> MovimientoSocios { get; set; }

    public virtual DbSet<Nodo> Nodos { get; set; }

    public virtual DbSet<OfertaCliente> OfertaClientes { get; set; }

    public virtual DbSet<OfertaClienteDet> OfertaClienteDets { get; set; }

    public virtual DbSet<OfertaClienteDetFecha> OfertaClienteDetFechas { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Panel> Panels { get; set; }

    public virtual DbSet<PanelUsuario> PanelUsuarios { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Pbcatcol> Pbcatcols { get; set; }

    public virtual DbSet<Pbcatedt> Pbcatedts { get; set; }

    public virtual DbSet<Pbcatfmt> Pbcatfmts { get; set; }

    public virtual DbSet<Pbcattbl> Pbcattbls { get; set; }

    public virtual DbSet<Pbcatvld> Pbcatvlds { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoDet> PedidoDets { get; set; }

    public virtual DbSet<PedidoEntrega> PedidoEntregas { get; set; }

    public virtual DbSet<PedidoEntregaDet> PedidoEntregaDets { get; set; }

    public virtual DbSet<PedidoEntregaPago> PedidoEntregaPagos { get; set; }

    public virtual DbSet<PedidoEntregaPagoDet> PedidoEntregaPagoDets { get; set; }

    public virtual DbSet<PedidoRequisicion> PedidoRequisicions { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ProveedorCompra> ProveedorCompras { get; set; }

    public virtual DbSet<ProveedorContacto> ProveedorContactos { get; set; }

    public virtual DbSet<ProveedorCuentum> ProveedorCuenta { get; set; }

    public virtual DbSet<ProveedorPago> ProveedorPagos { get; set; }

    public virtual DbSet<ProveedorTipoproducto> ProveedorTipoproductos { get; set; }

    public virtual DbSet<Recibo> Recibos { get; set; }

    public virtual DbSet<ReciboDet> ReciboDets { get; set; }

    public virtual DbSet<ReciboDetSerie> ReciboDetSeries { get; set; }

    public virtual DbSet<RecoleccionValore> RecoleccionValores { get; set; }

    public virtual DbSet<Requisicion> Requisicions { get; set; }

    public virtual DbSet<RequisicionDet> RequisicionDets { get; set; }

    public virtual DbSet<RevisionSuc> RevisionSucs { get; set; }

    public virtual DbSet<SaldoCxc> SaldoCxcs { get; set; }

    public virtual DbSet<SaldoSocio> SaldoSocios { get; set; }

    public virtual DbSet<SaldoSocioHist> SaldoSocioHists { get; set; }

    public virtual DbSet<SatCodigoPostal> SatCodigoPostals { get; set; }

    public virtual DbSet<SatFormaPago> SatFormaPagos { get; set; }

    public virtual DbSet<SatImpuesto> SatImpuestos { get; set; }

    public virtual DbSet<SatMetodoPago> SatMetodoPagos { get; set; }

    public virtual DbSet<SatMonedum> SatMoneda { get; set; }

    public virtual DbSet<SatPai> SatPais { get; set; }

    public virtual DbSet<SatProductosServicio> SatProductosServicios { get; set; }

    public virtual DbSet<SatRegimenFiscal> SatRegimenFiscals { get; set; }

    public virtual DbSet<SatTipoRelEntreCfdi> SatTipoRelEntreCfdis { get; set; }

    public virtual DbSet<SatUnidadMedidum> SatUnidadMedida { get; set; }

    public virtual DbSet<SatUsoComprobantesCfdi> SatUsoComprobantesCfdis { get; set; }

    public virtual DbSet<Sesion> Sesions { get; set; }

    public virtual DbSet<SesionHist> SesionHists { get; set; }

    public virtual DbSet<SesionSuc> SesionSucs { get; set; }

    public virtual DbSet<SesionUnidadOperativa> SesionUnidadOperativas { get; set; }

    public virtual DbSet<Subdivision> Subdivisions { get; set; }

    public virtual DbSet<SuperGrupoCliente> SuperGrupoClientes { get; set; }

    public virtual DbSet<Superpago> Superpagos { get; set; }

    public virtual DbSet<SuperpagoDet> SuperpagoDets { get; set; }

    public virtual DbSet<TarjetaCf> TarjetaCfs { get; set; }

    public virtual DbSet<TarjetaCfDet> TarjetaCfDets { get; set; }

    public virtual DbSet<TarjetaCfFoliador> TarjetaCfFoliadors { get; set; }

    public virtual DbSet<TemporalLogtranmnl> TemporalLogtranmnls { get; set; }

    public virtual DbSet<TemporalLogtranmnl3> TemporalLogtranmnl3s { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    public virtual DbSet<TerminalPc> TerminalPcs { get; set; }

    public virtual DbSet<Tiempo> Tiempos { get; set; }

    public virtual DbSet<TipoArticulo> TipoArticulos { get; set; }

    public virtual DbSet<TipoCambio> TipoCambios { get; set; }

    public virtual DbSet<TipoCliente> TipoClientes { get; set; }

    public virtual DbSet<TipoComercializacion> TipoComercializacions { get; set; }

    public virtual DbSet<TipoFormaPago> TipoFormaPagos { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; }

    public virtual DbSet<TipoMovimientoCaja> TipoMovimientoCajas { get; set; }

    public virtual DbSet<TipoMovimientoCajaTipoPago> TipoMovimientoCajaTipoPagos { get; set; }

    public virtual DbSet<TipoMovimientoCxc> TipoMovimientoCxcs { get; set; }

    public virtual DbSet<TipoMovimientoGrupo> TipoMovimientoGrupos { get; set; }

    public virtual DbSet<TipoMovimientoSocio> TipoMovimientoSocios { get; set; }

    public virtual DbSet<TipoOfertaFecha> TipoOfertaFechas { get; set; }

    public virtual DbSet<TipoOfertum> TipoOferta { get; set; }

    public virtual DbSet<TipoPrecio> TipoPrecios { get; set; }

    public virtual DbSet<TipoProveedor> TipoProveedors { get; set; }

    public virtual DbSet<TipoTarjetaCf> TipoTarjetaCfs { get; set; }

    public virtual DbSet<TipoTicket> TipoTickets { get; set; }

    public virtual DbSet<TipoTicketDetalle> TipoTicketDetalles { get; set; }

    public virtual DbSet<TipoTicketUnidad> TipoTicketUnidads { get; set; }

    public virtual DbSet<TipoUnidadOperativa> TipoUnidadOperativas { get; set; }

    public virtual DbSet<TmpArticulo> TmpArticulos { get; set; }

    public virtual DbSet<TmpCambioPrecio> TmpCambioPrecios { get; set; }

    public virtual DbSet<TmpCfdCliente> TmpCfdClientes { get; set; }

    public virtual DbSet<TmpCfdEmisor> TmpCfdEmisors { get; set; }

    public virtual DbSet<TmpCfdFactura> TmpCfdFacturas { get; set; }

    public virtual DbSet<TmpCfdFacturaCadena> TmpCfdFacturaCadenas { get; set; }

    public virtual DbSet<TmpCfdFacturaDetalle> TmpCfdFacturaDetalles { get; set; }

    public virtual DbSet<TmpCfdFacturaFormapago> TmpCfdFacturaFormapagos { get; set; }

    public virtual DbSet<TmpCfdFacturaImpuesto> TmpCfdFacturaImpuestos { get; set; }

    public virtual DbSet<TmpCfdFacturaPosXml> TmpCfdFacturaPosXmls { get; set; }

    public virtual DbSet<TmpCfdFacturaSello> TmpCfdFacturaSellos { get; set; }

    public virtual DbSet<TmpCfdTicket> TmpCfdTickets { get; set; }

    public virtual DbSet<TmpListaPrecio> TmpListaPrecios { get; set; }

    public virtual DbSet<TmpOfertaClte> TmpOfertaCltes { get; set; }

    public virtual DbSet<TmpOfertaClteCorte> TmpOfertaClteCortes { get; set; }

    public virtual DbSet<TmpProveedor> TmpProveedors { get; set; }

    public virtual DbSet<TmpUnidadOperativa> TmpUnidadOperativas { get; set; }

    public virtual DbSet<Transformado> Transformados { get; set; }

    public virtual DbSet<TransformadoDet> TransformadoDets { get; set; }

    public virtual DbSet<TransformadoDetComp> TransformadoDetComps { get; set; }

    public virtual DbSet<TransformadoDetSerie> TransformadoDetSeries { get; set; }

    public virtual DbSet<Traslado> Traslados { get; set; }

    public virtual DbSet<TrasladoDet> TrasladoDets { get; set; }

    public virtual DbSet<TrasladoDetSerie> TrasladoDetSeries { get; set; }

    public virtual DbSet<TrasladoRecibo> TrasladoRecibos { get; set; }

    public virtual DbSet<TrasladoReciboDet> TrasladoReciboDets { get; set; }

    public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; }

    public virtual DbSet<UnidadOperativa> UnidadOperativas { get; set; }

    public virtual DbSet<UnidadOperativaClienteExt> UnidadOperativaClienteExts { get; set; }

    public virtual DbSet<UnidadOperativaListaPrecio> UnidadOperativaListaPrecios { get; set; }

    public virtual DbSet<UnidadOperativaZona> UnidadOperativaZonas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioDescuento> UsuarioDescuentos { get; set; }

    public virtual DbSet<UsuarioPermiso> UsuarioPermisos { get; set; }

    public virtual DbSet<UsuarioUnidadOperativa> UsuarioUnidadOperativas { get; set; }

    public virtual DbSet<VentaDetalle> VentaDetalles { get; set; }

    public virtual DbSet<VentaDetalleComp> VentaDetalleComps { get; set; }

    public virtual DbSet<VentaDetalleCon> VentaDetalleCons { get; set; }

    public virtual DbSet<VentaDevolucion> VentaDevolucions { get; set; }

    public virtual DbSet<VentaDevolucionDetalle> VentaDevolucionDetalles { get; set; }

    public virtual DbSet<VentaFormaPago> VentaFormaPagos { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlmacenExt>(entity =>
        {
            entity.HasKey(e => e.IdAlmacen).HasName("PK_ALMACEN_EXT");

            entity.ToTable("almacen_ext");

            entity.Property(e => e.IdAlmacen)
                .ValueGeneratedNever()
                .HasColumnName("id_almacen");
            entity.Property(e => e.AbrevAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_almacen");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomAlmacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_almacen");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<ArqueoTerminal>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCaja, e.IdArqueo }).HasName("PK_ARQUEO_TERMINAL");

            entity.ToTable("arqueo_terminal");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdArqueo).HasColumnName("id_arqueo");
            entity.Property(e => e.Comentario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUsuarioAudita).HasColumnName("id_usuario_audita");
            entity.Property(e => e.TotalCapturado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_capturado");
            entity.Property(e => e.TotalDiferencia)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_diferencia");
            entity.Property(e => e.TotalFondoEnt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_fondo_ent");
            entity.Property(e => e.TotalFondoSal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_fondo_sal");
            entity.Property(e => e.TotalVenta)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_venta");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ArqueoTerminalIdUsuarioNavigations)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARQUEO_T_REF_8329_USUARIO");

            entity.HasOne(d => d.IdUsuarioAuditaNavigation).WithMany(p => p.ArqueoTerminalIdUsuarioAuditaNavigations)
                .HasForeignKey(d => d.IdUsuarioAudita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARQUEO_T_REF_8332_USUARIO");
        });

        modelBuilder.Entity<ArqueoTerminalDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCaja, e.IdArqueo, e.IdFormaPago, e.ValorDenominacion }).HasName("PK_ARQUEO_TERMINAL_DETALLE");

            entity.ToTable("arqueo_terminal_detalle");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdArqueo).HasColumnName("id_arqueo");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.ValorDenominacion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valor_denominacion");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Diferencia)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("diferencia");
            entity.Property(e => e.DiferenciaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("diferencia_mn");
            entity.Property(e => e.ImporteDenominacion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe_denominacion");
            entity.Property(e => e.ImporteFormapago)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe_formapago");
            entity.Property(e => e.ImporteFormapagoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe_formapago_mn");
            entity.Property(e => e.IndDenominacion).HasColumnName("ind_denominacion");
            entity.Property(e => e.IndPrincipal).HasColumnName("ind_principal");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.SaldoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_mn");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("tipo_cambio");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.ArqueoTerminalDetalles)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARQUEO_T_REF_24868_FORMA_PA");

            entity.HasOne(d => d.ArqueoTerminal).WithMany(p => p.ArqueoTerminalDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.IdCaja, d.IdArqueo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARQUEO_T_REF_24868_ARQUEO");
        });

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.Sku).HasName("PK_ARTICULO");

            entity.ToTable("articulo", tb =>
                {
                    tb.HasTrigger("ti_articulo_costo_hist");
                    tb.HasTrigger("tu_articulo_costo_hist");
                });

            entity.HasIndex(e => e.SkuInterno, "AK_articulo").IsUnique();

            entity.HasIndex(e => e.IdEstatusArticulo, "IX_articulo_estatus");

            entity.HasIndex(e => e.IdFamilia, "IX_familia");

            entity.HasIndex(e => e.IdMarca, "IX_marca");

            entity.HasIndex(e => e.IdModelo, "IX_modelo");

            entity.Property(e => e.Sku)
                .ValueGeneratedNever()
                .HasColumnName("sku");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.CostoEstandar)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_estandar");
            entity.Property(e => e.CostoPromedio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_promedio");
            entity.Property(e => e.CostoTc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("costo_tc");
            entity.Property(e => e.CostoUltimo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_ultimo");
            entity.Property(e => e.DescripcionPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_pos");
            entity.Property(e => e.Edicion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("edicion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdAlmacen).HasColumnName("id_almacen");
            entity.Property(e => e.IdEstatusArticulo).HasColumnName("id_estatus_articulo");
            entity.Property(e => e.IdExterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_externo");
            entity.Property(e => e.IdFamilia).HasColumnName("id_familia");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdProdServ).HasColumnName("id_ProdServ");
            entity.Property(e => e.IdTipoArticulo).HasColumnName("id_tipo_articulo");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndConsolidado).HasColumnName("ind_consolidado");
            entity.Property(e => e.IndControlSerie).HasColumnName("ind_control_serie");
            entity.Property(e => e.IndCostopaquete).HasColumnName("ind_costopaquete");
            entity.Property(e => e.IndGranel).HasColumnName("ind_granel");
            entity.Property(e => e.IndInventario).HasColumnName("ind_inventario");
            entity.Property(e => e.IndVolumen).HasColumnName("ind_volumen");
            entity.Property(e => e.NomArticulo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom_articulo");
            entity.Property(e => e.SkuInterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sku_interno");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdEstatusArticuloNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdEstatusArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_ESTATUS_");

            entity.HasOne(d => d.IdFamiliaNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdFamilia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_FAMILIA");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_MARCA");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_MODELO");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_MONEDA");

            entity.HasOne(d => d.IdTipoArticuloNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdTipoArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_TIPO_ART");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_UNIDAD_M");
        });

        modelBuilder.Entity<ArticuloConsolidar>(entity =>
        {
            entity.HasKey(e => new { e.SkuConsolidar, e.Sku }).HasName("pk_articulo_consolidar");

            entity.ToTable("articulo_consolidar");

            entity.Property(e => e.SkuConsolidar).HasColumnName("sku_consolidar");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndDefault).HasColumnName("ind_default");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ArticuloConsolidarSkuNavigations)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_CONS_REF_77803_ARTICULO");

            entity.HasOne(d => d.SkuConsolidarNavigation).WithMany(p => p.ArticuloConsolidarSkuConsolidarNavigations)
                .HasForeignKey(d => d.SkuConsolidar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_CONS_REF_77806_ARTICULO");
        });

        modelBuilder.Entity<ArticuloCostoHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("articulo_costo_hist");

            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoEstandar)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_estandar");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<ArticuloEmpaque>(entity =>
        {
            entity.HasKey(e => new { e.Sku, e.IdUnidadMedida, e.IdEmpaque }).HasName("PK_ARTICULO_EMPAQUE");

            entity.ToTable("articulo_empaque");

            entity.HasIndex(e => new { e.Sku, e.IdEmpaque }, "AK_articulo_empaque").IsUnique();

            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IdEmpaque).HasColumnName("id_empaque");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndEmpaqueBase).HasColumnName("ind_empaque_base");
            entity.Property(e => e.IndEmpaqueCompra).HasColumnName("ind_empaque_compra");
            entity.Property(e => e.IndEmpaqueInv).HasColumnName("ind_empaque_inv");
            entity.Property(e => e.IndEmpaqueStd).HasColumnName("ind_empaque_std");
            entity.Property(e => e.IndEmpaqueVta).HasColumnName("ind_empaque_vta");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdEmpaqueNavigation).WithMany(p => p.ArticuloEmpaqueIdEmpaqueNavigations)
                .HasForeignKey(d => d.IdEmpaque)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_UNIDADMEDIDA_EMP");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.ArticuloEmpaqueIdUnidadMedidaNavigations)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_UNIDADMEDIDA");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ArticuloEmpaques)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_EMPAQUE");
        });

        modelBuilder.Entity<ArticuloPrecio>(entity =>
        {
            entity.HasKey(e => new { e.Sku, e.IdLista }).HasName("PK_ARTICULO_PRECIO");

            entity.ToTable("articulo_precio");

            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Precio1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio1");
            entity.Property(e => e.Precio10)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio10");
            entity.Property(e => e.Precio2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio2");
            entity.Property(e => e.Precio3)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio3");
            entity.Property(e => e.Precio4)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio4");
            entity.Property(e => e.Precio5)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio5");
            entity.Property(e => e.Precio6)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio6");
            entity.Property(e => e.Precio7)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio7");
            entity.Property(e => e.Precio8)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio8");
            entity.Property(e => e.Precio9)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio9");
            entity.Property(e => e.PrecioSinIva1)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva1");
            entity.Property(e => e.PrecioSinIva10)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva10");
            entity.Property(e => e.PrecioSinIva2)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva2");
            entity.Property(e => e.PrecioSinIva3)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva3");
            entity.Property(e => e.PrecioSinIva4)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva4");
            entity.Property(e => e.PrecioSinIva5)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva5");
            entity.Property(e => e.PrecioSinIva6)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva6");
            entity.Property(e => e.PrecioSinIva7)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva7");
            entity.Property(e => e.PrecioSinIva8)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva8");
            entity.Property(e => e.PrecioSinIva9)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva9");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.ArticuloPrecios)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_PRECIO_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.IdListaNavigation).WithMany(p => p.ArticuloPrecios)
                .HasForeignKey(d => d.IdLista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_LISTA_PR");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ArticuloPrecios)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCE_ARTICULO_PRECIO");
        });

        modelBuilder.Entity<ArticuloPrecioVoluman>(entity =>
        {
            entity.HasKey(e => new { e.Sku, e.IdTipoprecio, e.IdTipounioper });

            entity.ToTable("articulo_precio_volumen");

            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdTipounioper).HasColumnName("id_tipounioper");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.Final)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("final");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Inicial)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("inicial");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipoprecioNavigation).WithMany(p => p.ArticuloPrecioVolumen)
                .HasForeignKey(d => d.IdTipoprecio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REF_ART_PRECIO_VOL_TPOPRECIO");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ArticuloPrecioVolumen)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCE_ART_PRECIO_VOL");
        });

        modelBuilder.Entity<ArticuloProveedor>(entity =>
        {
            entity.HasKey(e => new { e.Sku, e.IdProveedor }).HasName("pk_articulo_proveedor");

            entity.ToTable("articulo_proveedor");

            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.DctoLinea)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("dcto_linea");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IndProvPrincipal).HasColumnName("ind_prov_principal");
            entity.Property(e => e.IndTodasUo).HasColumnName("ind_todas_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.ArticuloProveedors)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_PROV_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.ArticuloProveedors)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_PROV_REFERENCE_MONEDA");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ArticuloProveedors)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REFERENCE_PROVEEDO");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ArticuloProveedors)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCE_ARTICULO_PROV");
        });

        modelBuilder.Entity<ArticuloProveedorUo>(entity =>
        {
            entity.HasKey(e => new { e.Sku, e.IdProveedor, e.IdUniOper }).HasName("pk_articulo_proveedor_uo");

            entity.ToTable("articulo_proveedor_uo");

            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndProvPrincipal).HasColumnName("ind_prov_principal");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.ArticuloProveedorUos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTPROVUO_REF_UO");

            entity.HasOne(d => d.ArticuloProveedor).WithMany(p => p.ArticuloProveedorUos)
                .HasForeignKey(d => new { d.Sku, d.IdProveedor })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REF_ARTPROV");
        });

        modelBuilder.Entity<ArticuloTransformado>(entity =>
        {
            entity.HasKey(e => new { e.SkuTransformado, e.Sku }).HasName("pk_articulo_transformado");

            entity.ToTable("articulo_transformado");

            entity.Property(e => e.SkuTransformado).HasColumnName("sku_transformado");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.CostoConIvaBase)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_con_iva_base");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.PorcValorPonderado)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("porc_valor_ponderado");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.ArticuloTransformados)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REF_77807_UNIMED");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ArticuloTransformadoSkuNavigations)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REF_77803_ARTICULO");

            entity.HasOne(d => d.SkuTransformadoNavigation).WithMany(p => p.ArticuloTransformadoSkuTransformadoNavigations)
                .HasForeignKey(d => d.SkuTransformado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARTICULO_REF_77806_ARTICULO");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.IdBanco).HasName("PK_BANCO");

            entity.ToTable("banco");

            entity.Property(e => e.IdBanco)
                .ValueGeneratedNever()
                .HasColumnName("id_banco");
            entity.Property(e => e.AbrevBanco)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_banco");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomBanco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_banco");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<BusquedaCriterio>(entity =>
        {
            entity.HasKey(e => new { e.IdBusqueda, e.IdCriterio }).HasName("PK_BUSQUEDA_CRITERIO");

            entity.ToTable("busqueda_criterios");

            entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");
            entity.Property(e => e.IdCriterio).HasColumnName("id_criterio");
            entity.Property(e => e.Campo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.DescCampo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("desc_campo");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Busquedum>(entity =>
        {
            entity.HasKey(e => e.IdBusqueda).HasName("PK_BUSQUEDA");

            entity.ToTable("busqueda");

            entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");
            entity.Property(e => e.DataobjectResultado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dataobject_resultado");
            entity.Property(e => e.DescripcionBusqueda)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_busqueda");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.IdCaja).HasName("PK_CAJA");

            entity.ToTable("caja", tb => tb.HasTrigger("ti_Caja"));

            entity.Property(e => e.IdCaja)
                .ValueGeneratedNever()
                .HasColumnName("id_caja");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndTipoCaja).HasColumnName("ind_tipo_caja");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.MaximoEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("maximo_efectivo");
            entity.Property(e => e.NomCaja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_caja");
            entity.Property(e => e.SugeridoFondo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("sugerido_fondo");
            entity.Property(e => e.SugeridoRetiro)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("sugerido_retiro");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<CambioCosto>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.FechaIni });

            entity.ToTable("cambio_costo");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.FechaIni)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoCantidad)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_cantidad");
            entity.Property(e => e.CostoExistencia)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_existencia");
            entity.Property(e => e.CostoPromedio)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_promedio");
            entity.Property(e => e.Existencia)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdUniOperDoc).HasColumnName("id_uni_oper_doc");
        });

        modelBuilder.Entity<CambioCostoOrigen>(entity =>
        {
            entity.HasKey(e => e.IdOrigen).HasName("PK__cambio_c__18ADDB0245400413");

            entity.ToTable("cambio_costo_origen");

            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.NombreOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_origen");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
        });

        modelBuilder.Entity<CambioPrecio>(entity =>
        {
            entity.HasKey(e => new { e.IdFolio, e.IdUniOper }).HasName("pk_cambio_precio");

            entity.ToTable("cambio_precio");

            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Estatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<CambioPrecioDet>(entity =>
        {
            entity.HasKey(e => new { e.IdFolioDet, e.IdFolio, e.IdUniOper }).HasName("pk_cambio_precio_det");

            entity.ToTable("cambio_precio_det");

            entity.HasIndex(e => new { e.Sku, e.IdLista, e.Fecha }, "ix_cambio_precio_det");

            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Estatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaApl)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_apl");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.Sku).HasColumnName("sku");
        });

        modelBuilder.Entity<CambioPrecioDetPl>(entity =>
        {
            entity.HasKey(e => new { e.IdFolioDet, e.IdFolio, e.IdUniOper, e.IdTipoprecio }).HasName("pk_cambio_precio_det_pl");

            entity.ToTable("cambio_precio_det_pl");

            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva");

            entity.HasOne(d => d.CambioPrecioDet).WithMany(p => p.CambioPrecioDetPls)
                .HasForeignKey(d => new { d.IdFolioDet, d.IdFolio, d.IdUniOper })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cambio_precio_det_pl_cambio_precio_det");
        });

        modelBuilder.Entity<CampoCatalogo>(entity =>
        {
            entity.HasKey(e => new { e.NombreDw, e.NombreCampo }).HasName("PK_CAMPO CATALOGO");

            entity.ToTable("campo_catalogo");

            entity.Property(e => e.NombreDw)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_dw");
            entity.Property(e => e.NombreCampo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_campo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NombreDwCat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_dw_cat");
            entity.Property(e => e.NombreUo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_uo");
            entity.Property(e => e.TituloVentana)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("titulo_ventana");
        });

        modelBuilder.Entity<CfdTipoFactura>(entity =>
        {
            entity.HasKey(e => e.IdTipofactura).HasName("PK_CFD_TIPO_FACTURA");

            entity.ToTable("cfd_tipo_factura");

            entity.Property(e => e.IdTipofactura).HasColumnName("id_tipofactura");
            entity.Property(e => e.AbrevTipofactura)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("abrev_tipofactura");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndCfdi).HasColumnName("ind_cfdi");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NoVersion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("no_version");
            entity.Property(e => e.NomTipofactura)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_tipofactura");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<CfdTipoFacturaOrigen>(entity =>
        {
            entity.HasKey(e => new { e.IdTipofactura, e.IndOrigen }).HasName("PK_CFD_TIPO_FACTURA_ORIGEN");

            entity.ToTable("cfd_tipo_factura_origen");

            entity.Property(e => e.IdTipofactura).HasColumnName("id_tipofactura");
            entity.Property(e => e.IndOrigen).HasColumnName("ind_origen");
            entity.Property(e => e.Abrev)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
        });

        modelBuilder.Entity<CfdTipoFacturaUo>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdTipofactura, e.Sserie }).HasName("PK_CFD_TIPO_FACTURA_UO");

            entity.ToTable("cfd_tipo_factura_uo");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdTipofactura).HasColumnName("id_tipofactura");
            entity.Property(e => e.Sserie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sserie");
            entity.Property(e => e.BIndDefault).HasColumnName("bIndDefault");
            entity.Property(e => e.BIndVigente)
                .HasDefaultValue((byte)1, "DF__cfd_tipo___bIndV__159F0B45")
                .HasColumnName("bIndVigente");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IfolioActual).HasColumnName("ifolio_actual");
            entity.Property(e => e.IndOrigen).HasColumnName("ind_origen");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipofacturaNavigation).WithMany(p => p.CfdTipoFacturaUos)
                .HasForeignKey(d => d.IdTipofactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CFD_TIPOFACTURAUO_REF_CFD_TIPO_FACTURA");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.CfdTipoFacturaUos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CFD_TIPO_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<CfdTipoFacturaUoFolio>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdTipofactura, e.Sserie, e.Ifolioinicial }).HasName("PK_CFD_TIPO_FACTURA_UO_FOLIOS");

            entity.ToTable("cfd_tipo_factura_uo_folios");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdTipofactura).HasColumnName("id_tipofactura");
            entity.Property(e => e.Sserie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sserie");
            entity.Property(e => e.Ifolioinicial).HasColumnName("ifolioinicial");
            entity.Property(e => e.Bindvigente).HasColumnName("bindvigente");
            entity.Property(e => e.Dfechaalta)
                .HasColumnType("smalldatetime")
                .HasColumnName("dfechaalta");
            entity.Property(e => e.Dfechaaprobacion)
                .HasColumnType("smalldatetime")
                .HasColumnName("dfechaaprobacion");
            entity.Property(e => e.Dfechamovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("dfechamovimiento");
            entity.Property(e => e.Ifoliofinal).HasColumnName("ifoliofinal");
            entity.Property(e => e.Iidusuarioalta).HasColumnName("iidusuarioalta");
            entity.Property(e => e.Iidusuariomovimiento).HasColumnName("iidusuariomovimiento");
            entity.Property(e => e.Inumaprobacion).HasColumnName("inumaprobacion");
            entity.Property(e => e.Sseriecertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sseriecertificado");

            entity.HasOne(d => d.CfdTipoFacturaUo).WithMany(p => p.CfdTipoFacturaUoFolios)
                .HasForeignKey(d => new { d.IdUniOper, d.IdTipofactura, d.Sserie })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CFD_TIPOFACUOFOLIO_REF_CFD_TIPOFACUO");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("pk_ciudad");

            entity.ToTable("ciudad");

            entity.HasIndex(e => new { e.IdUo, e.IdUniOper }, "AK_LLAVE_CIUDAD").IsUnique();

            entity.Property(e => e.IdCiudad)
                .ValueGeneratedNever()
                .HasColumnName("id_ciudad");
            entity.Property(e => e.AbrevCiudad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev_ciudad");
            entity.Property(e => e.CveCiudad).HasColumnName("cve_ciudad");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomCiudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_ciudad");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.Estado).WithMany(p => p.Ciudads)
                .HasForeignKey(d => new { d.IdEstado, d.IdPais })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CIUDAD_REFERENCE_ESTADO");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("pk_cliente");

            entity.ToTable("cliente");

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnName("id_cliente");
            entity.Property(e => e.ApMaterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ap_materno");
            entity.Property(e => e.ApPaterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ap_paterno");
            entity.Property(e => e.CalleYNumero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle_y_numero");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Cuenta).HasColumnName("cuenta");
            entity.Property(e => e.Cuentar).HasColumnName("cuentar");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EntreCalles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("entre_calles");
            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FechaUltimoPago)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ultimo_pago");
            entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");
            entity.Property(e => e.IdClienteReferencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id_cliente_referencia");
            entity.Property(e => e.IdGrupoCliente).HasColumnName("id_grupo_cliente");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdRegimenFiscalSat).HasColumnName("id_RegimenFiscal_sat");
            entity.Property(e => e.IdTipocliente).HasColumnName("id_tipocliente");
            entity.Property(e => e.IdTipoprecio)
                .HasDefaultValue((byte)1, "DF_cliente_id_tipoprecio")
                .HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndContado).HasColumnName("ind_contado");
            entity.Property(e => e.IndFacturar).HasColumnName("ind_facturar");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.LimiteCredito)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("limite_credito");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre_comercial");
            entity.Property(e => e.NumeroExterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_exterior");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.PlazoPago).HasColumnName("plazo_pago");
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.SaldoCliente)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_cliente");
            entity.Property(e => e.Ssubcuenta).HasColumnName("ssubcuenta");
            entity.Property(e => e.Ssubcuentar).HasColumnName("ssubcuentar");
            entity.Property(e => e.Subcuenta).HasColumnName("subcuenta");
            entity.Property(e => e.Subcuentar).HasColumnName("subcuentar");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_1");
            entity.Property(e => e.TelefonoOtro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("telefono_otro");
            entity.Property(e => e.TipoPeriodoPago).HasColumnName("tipo_periodo_pago");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("FK_CLIENTE_REFERENCE_CIUDAD");

            entity.HasOne(d => d.IdGrupoClienteNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdGrupoCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLIENTE_GRUPO_CLIENTE");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLIENTE_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<ClienteFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdFormaPago }).HasName("pk_cliente_forma_pago");

            entity.ToTable("cliente_forma_pago");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdOrden).HasColumnName("id_orden");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteFormaPagos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLIENTEFP_REF_CLIENTE");
        });

        modelBuilder.Entity<ClientePrecio>(entity =>
        {
            entity.HasKey(e => new { e.Sku, e.IdCliente }).HasName("PK_CLIENTE_PRECIO");

            entity.ToTable("cliente_precio");

            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.ClientePrecios)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLIENTE_PRECIO_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.ClientePrecios)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCE_CLIENTE_PRECIO");
        });

        modelBuilder.Entity<ClienteTarjetaCf>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdTarjeta }).HasName("PK_CLIENTE_TARJETA_CF");

            entity.ToTable("cliente_tarjeta_cf");

            entity.HasIndex(e => e.IdTarjeta, "ak_cliente_tarjeta_cf").IsUnique();

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteTarjetaCfs)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_tarjeta_cf_cliente");

            entity.HasOne(d => d.IdTarjetaNavigation).WithOne(p => p.ClienteTarjetaCf)
                .HasForeignKey<ClienteTarjetaCf>(d => d.IdTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_tarjeta_cf_tarjeta_cf_det");
        });

        modelBuilder.Entity<CodigoArticulo>(entity =>
        {
            entity.HasKey(e => new { e.IdCodigoBarras, e.Sku }).HasName("pk_codigo_articulo");

            entity.ToTable("codigo_articulo");

            entity.HasIndex(e => e.IdCodigoBarras, "IX_codigo_barras");

            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Principal).HasColumnName("principal");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.CodigoArticulos)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CODIGO_A_REF_1211_ARTICULO");
        });

        modelBuilder.Entity<CompaniaValore>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdUniOper }).HasName("PK_Compania_Valores_Id_IdUniOper");

            entity.ToTable("compania_valores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Abrev)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioMovimiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario_movimiento");
        });

        modelBuilder.Entity<ConfiguracionTeclado>(entity =>
        {
            entity.HasKey(e => e.IdTecla).HasName("PK_CONFIGURACION_TECLADO");

            entity.ToTable("configuracion_teclado");

            entity.Property(e => e.IdTecla)
                .ValueGeneratedNever()
                .HasColumnName("id_tecla");
            entity.Property(e => e.AbrevTecla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_tecla");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdFuncion).HasColumnName("id_funcion");
            entity.Property(e => e.Imagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.IndImagen).HasColumnName("ind_imagen");
            entity.Property(e => e.IndManauto)
                .HasDefaultValue(false, "DF__configura__ind_m__62458BBE")
                .HasColumnName("ind_manauto");
            entity.Property(e => e.IndRequiereAutorizacion).HasColumnName("ind_requiere_autorizacion");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Numsesionpago).HasColumnName("numsesionpago");
            entity.Property(e => e.Numsesionventa).HasColumnName("numsesionventa");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<CorreoMensaje>(entity =>
        {
            entity.HasKey(e => e.IdCorreoMensaje).HasName("PK_CORREO_MENSAJE");

            entity.ToTable("correo_mensaje");

            entity.HasIndex(e => e.IdUsuario, "IDX_CORREO_MENSAJE_USUARIO");

            entity.Property(e => e.IdCorreoMensaje)
                .ValueGeneratedNever()
                .HasColumnName("id_correo_mensaje");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mensaje");
        });

        modelBuilder.Entity<CorreoUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdCorreoMensaje, e.IdUsuarioDestino }).HasName("PK_CORREO_USUARIO");

            entity.ToTable("correo_usuario");

            entity.HasIndex(e => new { e.IdUsuarioDestino, e.IndLeido }, "IDX_CORREO_MENSAJE_USUARIO_DEST");

            entity.Property(e => e.IdCorreoMensaje).HasColumnName("id_correo_mensaje");
            entity.Property(e => e.IdUsuarioDestino).HasColumnName("id_usuario_destino");
            entity.Property(e => e.FechaLeido)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_leido");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IndLeido).HasColumnName("ind_leido");
            entity.Property(e => e.TipoCorreo).HasColumnName("tipo_correo");

            entity.HasOne(d => d.IdCorreoMensajeNavigation).WithMany(p => p.CorreoUsuarios)
                .HasForeignKey(d => d.IdCorreoMensaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORREO_USUARIO_REF_MENSAJE");
        });

        modelBuilder.Entity<CorteCaja>(entity =>
        {
            entity.HasKey(e => new { e.IdCorteCaja, e.IdCaja, e.IdUniOper }).HasName("PK_CORTE_CAJA");

            entity.ToTable("corte_caja");

            entity.Property(e => e.IdCorteCaja).HasColumnName("id_corte_caja");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.AjusteDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste_doc");
            entity.Property(e => e.AjusteEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste_efec");
            entity.Property(e => e.AjusteTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste_tot");
            entity.Property(e => e.DevDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dev_doc");
            entity.Property(e => e.DevEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dev_efec");
            entity.Property(e => e.DevolucionMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_mn");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.IdCorteTienda).HasColumnName("id_corte_tienda");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.MontoEntEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_ent_efectivo");
            entity.Property(e => e.MontoEntradaDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_entrada_doc");
            entity.Property(e => e.MontoEntradaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoEntrada_mn");
            entity.Property(e => e.MontoSalEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_sal_efectivo");
            entity.Property(e => e.MontoSalidaDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_salida_doc");
            entity.Property(e => e.MontoSalidaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoSalida_mn");
            entity.Property(e => e.SaldoDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_doc");
            entity.Property(e => e.SaldoEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_efectivo");
            entity.Property(e => e.SaldoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Saldo_Mn");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioCorte)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_corte");
            entity.Property(e => e.VentaDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_doc");
            entity.Property(e => e.VentaEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_efec");
            entity.Property(e => e.VentaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_mn");

            entity.HasOne(d => d.IdCajaNavigation).WithMany(p => p.CorteCajas)
                .HasForeignKey(d => d.IdCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_CA_REF_CAJA");

            entity.HasOne(d => d.IdTerminalNavigation).WithMany(p => p.CorteCajas)
                .HasForeignKey(d => d.IdTerminal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_CA_REF_18304_TERMINAL");
        });

        modelBuilder.Entity<CorteParcial>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCaja, e.IdCorte }).HasName("PK_CORTE_PARCIAL");

            entity.ToTable("corte_parcial");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.DevDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dev_doc");
            entity.Property(e => e.DevEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dev_efec");
            entity.Property(e => e.DevolucionMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_mn");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.IdCorteCaja).HasColumnName("id_corte_caja");
            entity.Property(e => e.IdCorteTienda).HasColumnName("id_corte_tienda");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.MontoEntEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_ent_efectivo");
            entity.Property(e => e.MontoEntradaDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_entrada_doc");
            entity.Property(e => e.MontoEntradaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoEntrada_mn");
            entity.Property(e => e.MontoSalEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_sal_efectivo");
            entity.Property(e => e.MontoSalidaDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_salida_doc");
            entity.Property(e => e.MontoSalidaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoSalida_mn");
            entity.Property(e => e.SaldoDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_doc");
            entity.Property(e => e.SaldoEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_efectivo");
            entity.Property(e => e.SaldoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Saldo_Mn");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioCorte)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_corte");
            entity.Property(e => e.VentaDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_doc");
            entity.Property(e => e.VentaEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_efec");
            entity.Property(e => e.VentaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_mn");

            entity.HasOne(d => d.IdCajaNavigation).WithMany(p => p.CorteParcials)
                .HasForeignKey(d => d.IdCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_PA_REF_CAJA");

            entity.HasOne(d => d.IdTerminalNavigation).WithMany(p => p.CorteParcials)
                .HasForeignKey(d => d.IdTerminal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_PA_REF_18304_TERMINAL");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CorteParcials)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_PA_REF_USUARIO");

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.CorteParcials)
                .HasForeignKey(d => new { d.IdCorteCaja, d.IdCaja, d.IdUniOper })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_PA_REF_CORTE_CAJA");
        });

        modelBuilder.Entity<CorteParcialFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCaja, e.IdFormaPago, e.IdCorte }).HasName("PK_CORTE_PARCIAL_FP");

            entity.ToTable("corte_parcial_forma_pago");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.Devolucion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion");
            entity.Property(e => e.DevolucionMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_mn");
            entity.Property(e => e.DevolucionPedido)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_pedido");
            entity.Property(e => e.DevolucionPedidoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_pedido_mn");
            entity.Property(e => e.MontoEntrada).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoEntradaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoEntrada_mn");
            entity.Property(e => e.MontoSalida).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoSalidaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoSalida_mn");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.SaldoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_mn");
            entity.Property(e => e.Venta)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta");
            entity.Property(e => e.VentaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_mn");
            entity.Property(e => e.VentaPedido)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_pedido");
            entity.Property(e => e.VentaPedidoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_pedido_mn");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.CorteParcialFormaPagos)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_PAFP_REF_FORMA_PAGO");

            entity.HasOne(d => d.CorteParcial).WithMany(p => p.CorteParcialFormaPagos)
                .HasForeignKey(d => new { d.IdUniOper, d.IdCaja, d.IdCorte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_corte_parcial_forma_pago_corte_parcial");
        });

        modelBuilder.Entity<CorteParcialFormaPagoTiendum>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCaja, e.IdFormaPago, e.IdCorte }).HasName("PK_CORTE_PARCIAL_TD");

            entity.ToTable("corte_parcial_forma_pago_tienda");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.Devolucion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion");
            entity.Property(e => e.DevolucionMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_mn");
            entity.Property(e => e.DevolucionPedido)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("devolucion_pedido");
            entity.Property(e => e.DevolucionPedidoMn)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("devolucion_pedido_mn");
            entity.Property(e => e.MontoEntrada).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoEntradaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoEntrada_mn");
            entity.Property(e => e.MontoSalida).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoSalidaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoSalida_mn");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.SaldoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_mn");
            entity.Property(e => e.Venta)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta");
            entity.Property(e => e.VentaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_mn");
            entity.Property(e => e.VentaPedido)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("venta_pedido");
            entity.Property(e => e.VentaPedidoMn)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("venta_pedido_mn");
        });

        modelBuilder.Entity<CorteTiendaFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCorteTienda, e.IdFormaPago }).HasName("PK_FORMA_PAGO_corte_tienda");

            entity.ToTable("corte_tienda_forma_pago");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCorteTienda).HasColumnName("id_corte_tienda");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.MontoAjuste).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoCaptura).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoFormaPago).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<CorteTiendaRelParcial>(entity =>
        {
            entity.HasKey(e => new { e.IdCorteTienda, e.IdCorteCaja, e.IdCorte, e.IdUniOper });

            entity.ToTable("corte_tienda_rel_parcial");

            entity.Property(e => e.IdCorteTienda).HasColumnName("id_corte_tienda");
            entity.Property(e => e.IdCorteCaja).HasColumnName("id_corte_caja");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");

            entity.HasOne(d => d.CorteTiendum).WithMany(p => p.CorteTiendaRelParcials)
                .HasForeignKey(d => new { d.IdUniOper, d.IdCorteTienda })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_corte_REL_REF_CORTE_REL");
        });

        modelBuilder.Entity<CorteTiendum>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdCorteTienda });

            entity.ToTable("CORTE_TIENDA");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdCorteTienda).HasColumnName("id_corte_tienda");
            entity.Property(e => e.AjusteDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste_doc");
            entity.Property(e => e.AjusteEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste_efec");
            entity.Property(e => e.AjusteTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste_tot");
            entity.Property(e => e.DevolucionMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("devolucion_mn");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.MontoEntradaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoEntrada_mn");
            entity.Property(e => e.MontoSalidaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MontoSalida_mn");
            entity.Property(e => e.Montocajafuerte)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montocajafuerte");
            entity.Property(e => e.Montodocumento)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montodocumento");
            entity.Property(e => e.Montoefectivo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoefectivo");
            entity.Property(e => e.MontoentradaDocumento)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoentrada_documento");
            entity.Property(e => e.MontoentradaEfecEi)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoentrada_efec_ei");
            entity.Property(e => e.MontoentradaEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoentrada_efectivo");
            entity.Property(e => e.MontosalidaDocumento)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montosalida_documento");
            entity.Property(e => e.MontosalidaEfecSi)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montosalida_efec_si");
            entity.Property(e => e.MontosalidaEfectivo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montosalida_efectivo");
            entity.Property(e => e.SaldoInicialDoc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_inicial_doc");
            entity.Property(e => e.SaldoInicialEfec)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_inicial_efec");
            entity.Property(e => e.SaldoInicialTot)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_inicial_tot");
            entity.Property(e => e.SaldoMn)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_mn");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioCorte)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_corte");
            entity.Property(e => e.VentaMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("venta_mn");

            entity.HasOne(d => d.IdTerminalNavigation).WithMany(p => p.CorteTienda)
                .HasForeignKey(d => d.IdTerminal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_TIENDA_REF_TERMINAL");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.CorteTienda)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORTE_TIENDA_REF_UNIOPER");
        });

        modelBuilder.Entity<CveEstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cve_estatus");

            entity.Property(e => e.AbreCveEstatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("abre_cve_estatus");
            entity.Property(e => e.CveEstatus1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus");
            entity.Property(e => e.IdCveEstatus).HasColumnName("id_cve_estatus");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
        });

        modelBuilder.Entity<CxcTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento).HasName("PK_CXC_TIPO_DOCUMENTO");

            entity.ToTable("cxc_tipo_documento");

            entity.Property(e => e.IdTipoDocumento).HasColumnName("Id_Tipo_Documento");
            entity.Property(e => e.Abrev)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Movimiento");
            entity.Property(e => e.Idarea).HasColumnName("idarea");
            entity.Property(e => e.IndTipoAfectacion).HasColumnName("Ind_Tipo_Afectacion");
            entity.Property(e => e.IndVigente).HasColumnName("Ind_Vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Usuario_Alta");
            entity.Property(e => e.UsuarioMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Usuario_Movimiento");
        });

        modelBuilder.Entity<DescuentoSupervisor>(entity =>
        {
            entity.HasKey(e => e.IdDescuento).HasName("PK_DESCUENTO_SUPERVISOR");

            entity.ToTable("descuento_supervisor");

            entity.Property(e => e.IdDescuento)
                .ValueGeneratedNever()
                .HasColumnName("id_descuento");
            entity.Property(e => e.DescripcionDescuento)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("descripcion_descuento");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.ValorPorcDescuento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("valor_porc_descuento");
        });

        modelBuilder.Entity<Devolucion>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_DEVOLUCION");

            entity.ToTable("devolucion");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaInterfase)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Devolucions)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEVOLUCI_REF_PROVEEDO");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.Devolucions)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEVOLUCI_REFERENCE_TIPO_MOV");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Devolucions)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEVOLUCI_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<DevolucionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_DEVOLUCION_DET");

            entity.ToTable("devolucion_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.DevolucionDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_devolucion_det_impuesto");

            entity.HasOne(d => d.Devolucion).WithMany(p => p.DevolucionDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEVOLUCI_REF_DEVOLUCI");

            entity.HasOne(d => d.Inventario).WithMany(p => p.DevolucionDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEVOLUCI_REF_INVENTAR");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.DevolucionDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_devolucion_det_art_empaque");
        });

        modelBuilder.Entity<DevolucionDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku, e.Serie }).HasName("PK_DEVOLUCION_DET_SERIE");

            entity.ToTable("devolucion_det_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");

            entity.HasOne(d => d.DevolucionDet).WithMany(p => p.DevolucionDetSeries)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEVOLUCI_REFERENCE_DEVOLUCI");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.IdDivision).HasName("PK_DIVISION");

            entity.ToTable("division");

            entity.Property(e => e.IdDivision)
                .ValueGeneratedNever()
                .HasColumnName("id_division");
            entity.Property(e => e.AbrevDivision)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_division");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdProdServ).HasColumnName("id_ProdServ");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomDivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_division");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("PK_DOCUMENTO");

            entity.ToTable("documento", tb => tb.HasTrigger("ti_Documento"));

            entity.HasIndex(e => e.NomDocumento, "AK_NOMTIPOMOV").IsUnique();

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.AbrevDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("abrev_documento");
            entity.Property(e => e.IndFoliador).HasColumnName("ind_foliador");
            entity.Property(e => e.IndSistema).HasColumnName("ind_sistema");
            entity.Property(e => e.IndTipoMovimiento).HasColumnName("ind_tipo_movimiento");
            entity.Property(e => e.NomDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_documento");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK_EMPRESA");

            entity.ToTable("empresa");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("id_empresa");
            entity.Property(e => e.AbrevEmpresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("abrev_empresa");
            entity.Property(e => e.CalleYNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("calle_y_numero");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))", "DF__empresa__codigo___0A7378A9")
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");
            entity.Property(e => e.ImagenEmpresa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("imagen_empresa");
            entity.Property(e => e.ImagenEmpresaReportes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("imagen_empresa_reportes");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_comercial");
            entity.Property(e => e.NomEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_empresa");
            entity.Property(e => e.NumeroExterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_exterior");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.PacPassword)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pac_password");
            entity.Property(e => e.PacUser)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pac_user");
            entity.Property(e => e.Paginaweb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paginaweb");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("regimen_fiscal");
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_REFERENCE_CIUDAD");
        });

        modelBuilder.Entity<EntregaValore>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdEntrega });

            entity.ToTable("entrega_valores");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdEntrega).HasColumnName("id_entrega");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.IdCompaniaValores).HasColumnName("id_compania_valores");
            entity.Property(e => e.IdCorteTienda).HasColumnName("id_corte_tienda");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_mn");
            entity.Property(e => e.NombreChofer)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre_chofer");
            entity.Property(e => e.NumCredencial).HasColumnName("Num_credencial");
            entity.Property(e => e.NumRemision).HasColumnName("num_remision");
            entity.Property(e => e.SaldoAnterior)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_anterior");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.EntregaValores)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_entrega_valores");
        });

        modelBuilder.Entity<EsMovimientoSocio>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento });

            entity.ToTable("es_movimiento_socio");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.IdTipomovSocio).HasColumnName("id_tipomov_socio");
            entity.Property(e => e.IdTipomovSocioAnula).HasColumnName("id_tipomov_socio_anula");
            entity.Property(e => e.IndTipoPrograma).HasColumnName("ind_tipo_programa");
            entity.Property(e => e.SaldoMonedero)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_monedero");
            entity.Property(e => e.SaldoPunto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_punto");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.ValorMovimiento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("valor_movimiento");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.EsMovimientoSocios)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_es_Movimiento_socio_Cliente");

            entity.HasOne(d => d.IdTarjetaNavigation).WithMany(p => p.EsMovimientoSocios)
                .HasForeignKey(d => d.IdTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_es_Movimiento_socio_Tarjeta");

            entity.HasOne(d => d.IdTipomovSocioNavigation).WithMany(p => p.EsMovimientoSocios)
                .HasForeignKey(d => d.IdTipomovSocio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_es_Movimiento_socio_Tipo_Mov");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.EsMovimientoSocios)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_es_Movimiento_socio_Unidad_Operativa");
        });

        modelBuilder.Entity<EsVaria>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_ES_VARIAS");

            entity.ToTable("es_varias");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaInterfase)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.EsVaria)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ES_VARIA_REFERENCE_TIPO_MOV");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.EsVaria)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ES_VARIA_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<EsVariasDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_ES_VARIAS_DET");

            entity.ToTable("es_varias_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.EsVariasDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_es_varias_det_impuesto");

            entity.HasOne(d => d.EsVaria).WithMany(p => p.EsVariasDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ES_VARIA_REFERENCE_ES_VARIA");

            entity.HasOne(d => d.Inventario).WithMany(p => p.EsVariasDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ES_VARIA_REFERENCE_INVENTAR");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.EsVariasDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_es_varias_det_articulo_empaque");
        });

        modelBuilder.Entity<EsVariasDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.Serie, e.IdMovimiento }).HasName("PK_ES_VARIAS_DET_SERIES");

            entity.ToTable("es_varias_det_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");

            entity.HasOne(d => d.EsVariasDet).WithMany(p => p.EsVariasDetSeries)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ES_VARIA_REF_ES_VARIA");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => new { e.IdEstado, e.IdPais }).HasName("PK_ESTADO");

            entity.ToTable("estado");

            entity.HasIndex(e => new { e.IdUo, e.IdUniOper }, "AK_LLAVE_ESTADO").IsUnique();

            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.AbrevEstado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("abrev_estado");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomEstado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_estado");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ESTADO_REFERENCE_PAIS");
        });

        modelBuilder.Entity<EstatusArticulo>(entity =>
        {
            entity.HasKey(e => e.IdEstatusArticulo).HasName("pk_estatus_articulo");

            entity.ToTable("estatus_articulo");

            entity.Property(e => e.IdEstatusArticulo).HasColumnName("id_estatus_articulo");
            entity.Property(e => e.DescripEstatus)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("descrip_estatus");
            entity.Property(e => e.NomEstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_estatus");
        });

        modelBuilder.Entity<ExistenciaHist>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.FechaIni });

            entity.ToTable("existencia_hist");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(15, 6)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(15, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Existencia)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("existencia");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio_sin_iva");

            entity.HasOne(d => d.Inventario).WithMany(p => p.ExistenciaHists)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_existencia_hist_inventario");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdFactura }).HasName("PK_FACTURA");

            entity.ToTable("factura");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.Anioaprobacion).HasColumnName("anioaprobacion");
            entity.Property(e => e.Certificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("certificado");
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.CostoImpuesto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Costosubtotal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Costototal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("datetime")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.FechaInterfase)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdFolioFactura).HasColumnName("id_folio_factura");
            entity.Property(e => e.IdTipofactura).HasColumnName("id_tipofactura");
            entity.Property(e => e.IdUniOperFactura).HasColumnName("id_uni_oper_factura");
            entity.Property(e => e.IdUnioperVenta).HasColumnName("id_unioper_venta");
            entity.Property(e => e.IndEstatusFactura).HasColumnName("ind_estatus_factura");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.IndOrigen).HasColumnName("ind_origen");
            entity.Property(e => e.IndTipoFactura).HasColumnName("ind_tipo_factura");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.IvaO)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("iva_o");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.NoVersion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("no_version");
            entity.Property(e => e.NomFormaPago)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nom_forma_pago");
            entity.Property(e => e.Numaprobacion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("numaprobacion");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.PorcjDesc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("porcj_desc");
            entity.Property(e => e.Sello)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("sello");
            entity.Property(e => e.SerieFactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie_factura");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SubtotalO)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal_o");
            entity.Property(e => e.Timbrefecha).HasColumnType("datetime");
            entity.Property(e => e.Timbrenocertsat)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Timbresellosat)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Timbreuuid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timbreversion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalO)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_o");
            entity.Property(e => e.UsoCfdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uso_cfdi");
            entity.Property(e => e.UsuarioCancela)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_cancela");
            entity.Property(e => e.UsuarioElabora)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_elabora");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACTURA_REF_6602_CLIENTE");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.FacturaIdUniOperNavigations)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACTURA_REF_6602_UNI_OPER");

            entity.HasOne(d => d.IdUniOperFacturaNavigation).WithMany(p => p.FacturaIdUniOperFacturaNavigations)
                .HasForeignKey(d => d.IdUniOperFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACTURA_REF_6602_UNI_OPER_FACT");

            entity.HasOne(d => d.CfdTipoFacturaOrigen).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.IdTipofactura, d.IndOrigen })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACTURA_REF_6602_FACTURA_ORIGEN");
        });

        modelBuilder.Entity<FacturaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdFactura, e.IdOrden }).HasName("PK_FACTURA_DETALLE");

            entity.ToTable("factura_detalle");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdOrden).HasColumnName("id_orden");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Costo).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoImpuesto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("Costo_sin_iva");
            entity.Property(e => e.CostoSubtotal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(15, 6)")
                .HasColumnName("precio_sin_iva");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("unidad_medida");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.FacturaDetalles)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_detalle_impuesto");

            entity.HasOne(d => d.Factura).WithMany(p => p.FacturaDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.IdFactura })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_detalle_factura");
        });

        modelBuilder.Entity<FacturaDocumento>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdFactura, e.IdTipoDoc, e.IdUniOperDoc, e.IdDocumento }).HasName("PK_FACTURA_DOCUMENTO");

            entity.ToTable("factura_documento");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.IdUniOperDoc).HasColumnName("id_uni_oper_doc");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");

            entity.HasOne(d => d.Factura).WithMany(p => p.FacturaDocumentos)
                .HasForeignKey(d => new { d.IdUniOper, d.IdFactura })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_documento_factura");
        });

        modelBuilder.Entity<FacturaImpuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdFactura, e.IdImpuesto }).HasName("PK_FACTURA_IMPUESTO");

            entity.ToTable("factura_impuesto");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TasaImpuesto).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.FacturaImpuestos)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_impuesto_impuesto");

            entity.HasOne(d => d.Factura).WithMany(p => p.FacturaImpuestos)
                .HasForeignKey(d => new { d.IdUniOper, d.IdFactura })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_impuesto_factura");
        });

        modelBuilder.Entity<Familium>(entity =>
        {
            entity.HasKey(e => e.IdFamilia).HasName("PK_FAMILIA");

            entity.ToTable("familia");

            entity.Property(e => e.IdFamilia)
                .ValueGeneratedNever()
                .HasColumnName("id_familia");
            entity.Property(e => e.AbrevFamilia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("abrev_familia");
            entity.Property(e => e.DiasInventario)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("dias_inventario");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdProdServ).HasColumnName("id_ProdServ");
            entity.Property(e => e.IdSubdivision).HasColumnName("id_subdivision");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Margen1)
                .HasDefaultValue(0m, "DF_familia_margen1")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen1");
            entity.Property(e => e.Margen10)
                .HasDefaultValue(0m, "DF_familia_margen10")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen10");
            entity.Property(e => e.Margen2)
                .HasDefaultValue(0m, "DF_familia_margen2")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen2");
            entity.Property(e => e.Margen3)
                .HasDefaultValue(0m, "DF_familia_margen3")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen3");
            entity.Property(e => e.Margen4)
                .HasDefaultValue(0m, "DF_familia_margen4")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen4");
            entity.Property(e => e.Margen5)
                .HasDefaultValue(0m, "DF_familia_margen5")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen5");
            entity.Property(e => e.Margen6)
                .HasDefaultValue(0m, "DF_familia_margen6")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen6");
            entity.Property(e => e.Margen7)
                .HasDefaultValue(0m, "DF_familia_margen7")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen7");
            entity.Property(e => e.Margen8)
                .HasDefaultValue(0m, "DF_familia_margen8")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen8");
            entity.Property(e => e.Margen9)
                .HasDefaultValue(0m, "DF_familia_margen9")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen9");
            entity.Property(e => e.NomFamilia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_familia");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdSubdivisionNavigation).WithMany(p => p.Familia)
                .HasForeignKey(d => d.IdSubdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAMILIA_REFERENCE_DIVISION");
        });

        modelBuilder.Entity<Folio>(entity =>
        {
            entity.HasKey(e => new { e.IdDocumento, e.IdUniOper, e.IdTipomov }).HasName("PK_FOLIO");

            entity.ToTable("folio");

            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.Folio1).HasColumnName("folio");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Folios)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Folio_Ref_Documento");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.IdFormaPago).HasName("PK_FORMA_PAGO");

            entity.ToTable("forma_pago");

            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdFormaPagoSat).HasColumnName("id_forma_pago_sat");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdTipoForma).HasColumnName("id_tipo_forma");
            entity.Property(e => e.IndAfectaPunto).HasColumnName("ind_afecta_punto");
            entity.Property(e => e.IndAplicaAjuste).HasColumnName("ind_aplica_ajuste");
            entity.Property(e => e.IndAutorizacion).HasColumnName("ind_autorizacion");
            entity.Property(e => e.IndCliente).HasColumnName("ind_cliente");
            entity.Property(e => e.IndCredito).HasColumnName("ind_credito");
            entity.Property(e => e.IndPos).HasColumnName("ind_pos");
            entity.Property(e => e.IndTerminaTransaccion).HasColumnName("ind_termina_transaccion");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomFormaPago)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nom_forma_pago");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<FormaPagoDenominacion>(entity =>
        {
            entity.HasKey(e => new { e.IdFormaPago, e.ValorDenominacion }).HasName("PK_FORMA_PAGO_DENOMINACION");

            entity.ToTable("forma_pago_denominacion");

            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.ValorDenominacion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valor_denominacion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdPresentacion).HasColumnName("id_presentacion");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.FormaPagoDenominacions)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DENOMINA_REF_26429_FORMA_PA");
        });

        modelBuilder.Entity<FormaPagoSat>(entity =>
        {
            entity.HasKey(e => e.IdFormaPagoSat).HasName("PK__Forma_pa__CBD876A35299FF31");

            entity.ToTable("Forma_pago_SAT");

            entity.Property(e => e.IdFormaPagoSat)
                .ValueGeneratedNever()
                .HasColumnName("id_forma_pago_sat");
            entity.Property(e => e.DescFormaPagoSat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_forma_pago_sat");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Reqcuenta).HasColumnName("reqcuenta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Funcion>(entity =>
        {
            entity.HasKey(e => e.IdFuncion).HasName("PK_FUNCION");

            entity.ToTable("funcion");

            entity.Property(e => e.IdFuncion)
                .ValueGeneratedNever()
                .HasColumnName("id_funcion");
            entity.Property(e => e.AbrevFuncion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("abrev_funcion");
            entity.Property(e => e.DescripcionFuncion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_funcion");
            entity.Property(e => e.IndCancelacion).HasColumnName("ind_cancelacion");
            entity.Property(e => e.IndCorte).HasColumnName("ind_corte");
            entity.Property(e => e.IndResetAut).HasColumnName("ind_reset_aut");
            entity.Property(e => e.IndSesionCaptura).HasColumnName("ind_sesion_captura");
            entity.Property(e => e.IndSesionInicio).HasColumnName("ind_sesion_inicio");
            entity.Property(e => e.IndSesionPago).HasColumnName("ind_sesion_pago");
            entity.Property(e => e.NombreObjeto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_objeto");
        });

        modelBuilder.Entity<GrupoCliente>(entity =>
        {
            entity.HasKey(e => e.IdGrupoCliente).HasName("PK_GRUPO_CLIENTE");

            entity.ToTable("grupo_cliente");

            entity.Property(e => e.IdGrupoCliente)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_cliente");
            entity.Property(e => e.AbrevGrupoCliente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_grupo_cliente");
            entity.Property(e => e.FactorPunto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("factor_punto");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdSuperGrupo).HasColumnName("id_super_grupo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomGrupoCliente)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_grupo_cliente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdSuperGrupoNavigation).WithMany(p => p.GrupoClientes)
                .HasForeignKey(d => d.IdSuperGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_grupo_cliente_super_grupo_cliente");

            entity.HasMany(d => d.IdClientes).WithMany(p => p.IdGrupoClientes)
                .UsingEntity<Dictionary<string, object>>(
                    "RelacionGrupoCliente",
                    r => r.HasOne<Cliente>().WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_RELACION_REFERENCE_CLIENTE"),
                    l => l.HasOne<GrupoCliente>().WithMany()
                        .HasForeignKey("IdGrupoCliente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_RELACION_REFERENCE_GRUPO_CL"),
                    j =>
                    {
                        j.HasKey("IdGrupoCliente", "IdCliente").HasName("PK_relacion_grupo_cliente_1");
                        j.ToTable("relacion_grupo_cliente");
                        j.IndexerProperty<int>("IdGrupoCliente").HasColumnName("id_grupo_cliente");
                        j.IndexerProperty<int>("IdCliente").HasColumnName("id_cliente");
                    });
        });

        modelBuilder.Entity<IfceCont>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TipoMov });

            entity.ToTable("IfceCont");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaContable).HasColumnType("datetime");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaProcesado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("money");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Moneda2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mov)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MovId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MovID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrigenTabla)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoInterface)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uen).HasColumnName("UEN");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IfceContD>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TipoMov, e.Renglon });

            entity.ToTable("IfceContD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Debe).HasColumnType("money");
            entity.Property(e => e.Debe2).HasColumnType("money");
            entity.Property(e => e.Empresa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaContable).HasColumnType("datetime");
            entity.Property(e => e.Haber).HasColumnType("money");
            entity.Property(e => e.Haber2).HasColumnType("money");
            entity.Property(e => e.SubCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCuenta2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IfceCx>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TipoMov });

            entity.ToTable("IfceCx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Agente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CteProv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaProcesado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fechaoriginal)
                .HasColumnType("datetime")
                .HasColumnName("fechaoriginal");
            entity.Property(e => e.FormaCobro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("money");
            entity.Property(e => e.Impuestos).HasColumnType("money");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mov)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MovId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MovID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Retencion).HasColumnType("money");
            entity.Property(e => e.TipoInterface)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uen).HasColumnName("UEN");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<IfceInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IfceInv");

            entity.Property(e => e.Almacen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AlmacenDestino)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaProcesado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaRequerida).HasColumnType("datetime");
            entity.Property(e => e.FormaEnvio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mov)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MovId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MovID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prioridad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Situacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoInterface)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uen).HasColumnName("UEN");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<IfceInvD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IfceInvD");

            entity.Property(e => e.Almacen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Articulo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Costo).HasColumnType("money");
            entity.Property(e => e.FechaRequerida).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RenglonId).HasColumnName("RenglonID");
            entity.Property(e => e.RenglonTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Unidad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImagenPo>(entity =>
        {
            entity.HasKey(e => e.IdImagenPos).HasName("PK_IMAGEN_POS");

            entity.ToTable("imagen_pos");

            entity.HasIndex(e => e.NomImagen, "AK_NOM_IMAGEN_POS").IsUnique();

            entity.Property(e => e.IdImagenPos)
                .ValueGeneratedNever()
                .HasColumnName("id_imagen_pos");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Intervalo).HasColumnName("intervalo");
            entity.Property(e => e.NomImagen)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nom_imagen");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<ImagenPosDet>(entity =>
        {
            entity.HasKey(e => new { e.IdImagenPos, e.IdImagen });

            entity.ToTable("imagen_pos_det");

            entity.Property(e => e.IdImagenPos).HasColumnName("id_imagen_pos");
            entity.Property(e => e.IdImagen).HasColumnName("id_imagen");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Ruta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ruta");
            entity.Property(e => e.TipoImagen).HasColumnName("tipo_imagen");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdImagenPosNavigation).WithMany(p => p.ImagenPosDets)
                .HasForeignKey(d => d.IdImagenPos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagen_pos_det_imagen_pos");
        });

        modelBuilder.Entity<ImagenPosUo>(entity =>
        {
            entity.HasKey(e => new { e.IdImagenPos, e.IdUniOper });

            entity.ToTable("imagen_pos_uo");

            entity.Property(e => e.IdImagenPos).HasColumnName("id_imagen_pos");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdImagenPosNavigation).WithMany(p => p.ImagenPosUos)
                .HasForeignKey(d => d.IdImagenPos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagen_pos_uo_imagen_pos");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.ImagenPosUos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagen_pos_uo_unidad_operativa");
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.HasKey(e => e.IdImpuesto).HasName("PK_IMPUESTO");

            entity.ToTable("impuesto");

            entity.Property(e => e.IdImpuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_impuesto");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdImpuestoSat).HasColumnName("id_impuesto_sat");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomImpuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_impuesto");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.ValorImpuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("valor_impuesto");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku }).HasName("PK_INVENTARIO");

            entity.ToTable("inventario", tb => tb.HasTrigger("ti_Inventario"));

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.CostoPromedio)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_promedio");
            entity.Property(e => e.CostoUltimo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_ultimo");
            entity.Property(e => e.Existencia)
                .HasComputedColumnSql("([existencia_teorica]-[existencia_reservada])", false)
                .HasColumnType("decimal(13, 3)")
                .HasColumnName("existencia");
            entity.Property(e => e.ExistenciaReservada)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia_reservada");
            entity.Property(e => e.ExistenciaTeorica)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia_teorica");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FechaUltimoInv)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ultimo_inv");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTipoComercializacion).HasColumnName("id_tipo_comercializacion");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IndDevolucion).HasColumnName("ind_devolucion");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Maximo)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("maximo");
            entity.Property(e => e.Minimo)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("minimo");
            entity.Property(e => e.Optimo)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("optimo");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva");
            entity.Property(e => e.StockBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("stock_base");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.IdListaNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdLista)
                .HasConstraintName("FK_INVENTAR_REFERENCE_LISTA_PRECIO");

            entity.HasOne(d => d.IdTipoComercializacionNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdTipoComercializacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_TIPO_COM");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_UNIDAD_O");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_UNIDAD_MEDIDA");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_ARTICULO");
        });

        modelBuilder.Entity<InventarioFisico>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.FolioInventario }).HasName("PK_INVENTARIO_FISICO");

            entity.ToTable("inventario_fisico");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FolioInventario).HasColumnName("folio_inventario");
            entity.Property(e => e.CveEstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaAplicacion)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_aplicacion");
            entity.Property(e => e.FechaGeneracion)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_generacion");
            entity.Property(e => e.FolioMovNeg).HasColumnName("folio_mov_neg");
            entity.Property(e => e.FolioMovNegAnula).HasColumnName("folio_mov_neg_anula");
            entity.Property(e => e.FolioMovPos).HasColumnName("folio_mov_pos");
            entity.Property(e => e.FolioMovPosAnula).HasColumnName("folio_mov_pos_anula");
            entity.Property(e => e.IdTipomovNeg).HasColumnName("id_tipomov_neg");
            entity.Property(e => e.IdTipomovNegAnula).HasColumnName("id_tipomov_neg_anula");
            entity.Property(e => e.IdTipomovPos).HasColumnName("id_tipomov_pos");
            entity.Property(e => e.IdTipomovPosAnula).HasColumnName("id_tipomov_pos_anula");
            entity.Property(e => e.TipoInventario)
                .HasDefaultValue((byte)1)
                .HasColumnName("tipo_inventario");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioAplica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_aplica");
            entity.Property(e => e.UsuarioGenera)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_genera");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.InventarioFisicos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_UO");
        });

        modelBuilder.Entity<InventarioFisicoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.FolioInventario, e.Sku }).HasName("PK_INVENTARIO_FISICO_DET");

            entity.ToTable("inventario_fisico_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FolioInventario).HasColumnName("folio_inventario");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadAjuste)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_ajuste");
            entity.Property(e => e.CantidadAjusteBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_ajuste_base");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.Entrada)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("entrada");
            entity.Property(e => e.EntradaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("entrada_base");
            entity.Property(e => e.Existencia)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia");
            entity.Property(e => e.ExistenciaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia_base");
            entity.Property(e => e.FechaCaptura)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_captura");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Inicial)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("inicial");
            entity.Property(e => e.InicialBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("inicial_base");
            entity.Property(e => e.MermAcum)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("merm_acum");
            entity.Property(e => e.MermKgs)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("merm_kgs");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PorcAcum)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("porc_acum");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");
            entity.Property(e => e.Salida)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("salida");
            entity.Property(e => e.SalidaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("salida_base");
            entity.Property(e => e.TipoAjuste).HasColumnName("tipo_ajuste");
            entity.Property(e => e.UsuarioCaptura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_captura");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.InventarioFisicoDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_inventario_fisico_det_impuesto");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.InventarioFisicoDets)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REF_ARTICULO");

            entity.HasOne(d => d.InventarioFisico).WithMany(p => p.InventarioFisicoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.FolioInventario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REF_INVENTAR");

            entity.HasOne(d => d.Inventario).WithMany(p => p.InventarioFisicoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_inventario_fisico_det_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.InventarioFisicoDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_inventario_fisico_det_articulo_empaque");
        });

        modelBuilder.Entity<InventarioFisicoDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.FolioInventario, e.Sku, e.Serie }).HasName("PK_INVENTARIO_FISICO_DET_SERIE");

            entity.ToTable("inventario_fisico_det_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FolioInventario).HasColumnName("folio_inventario");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");
            entity.Property(e => e.Tipo).HasColumnName("tipo");

            entity.HasOne(d => d.InventarioFisicoDet).WithMany(p => p.InventarioFisicoDetSeries)
                .HasForeignKey(d => new { d.IdUniOper, d.FolioInventario, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_INV");
        });

        modelBuilder.Entity<InventarioSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.Serie }).HasName("PK_INVENTARIO_SERIE");

            entity.ToTable("inventario_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");
            entity.Property(e => e.IndApartado).HasColumnName("ind_apartado");
            entity.Property(e => e.IndExistencia).HasColumnName("ind_existencia");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true, "DF_inventario_serie_ind_vigente")
                .HasColumnName("ind_vigente");

            entity.HasOne(d => d.Inventario).WithMany(p => p.InventarioSeries)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTAR_REFERENCE_INVENTAR");
        });

        modelBuilder.Entity<ListaPrecio>(entity =>
        {
            entity.HasKey(e => e.IdLista).HasName("PK_LISTA_PRECIO");

            entity.ToTable("lista_precio");

            entity.Property(e => e.IdLista)
                .ValueGeneratedNever()
                .HasColumnName("id_lista");
            entity.Property(e => e.AbrevLista)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("abrev_lista");
            entity.Property(e => e.FactorPrecio)
                .HasDefaultValue(0m, "DF_lista_precio_factor_precio")
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("factor_precio");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndCliente).HasColumnName("ind_cliente");
            entity.Property(e => e.IndDefault).HasColumnName("ind_default");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomLista)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_lista");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<LogTranCfc>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc, e.Tipo });

            entity.ToTable("LogTranCFC");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CFC");
        });

        modelBuilder.Entity<LogTranError>(entity =>
        {
            entity.HasKey(e => new { e.IdTrans, e.IdUniOper, e.InServer, e.Fecha });

            entity.ToTable("LogTranError");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ErrorText)
                .HasMaxLength(2050)
                .IsUnicode(false);
            entity.Property(e => e.Modulo)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogTranFolio>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.InServer });

            entity.ToTable("LogTranFolio");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
        });

        modelBuilder.Entity<LogTranIncoming>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc });

            entity.ToTable("LogTranIncoming");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfc");
            entity.Property(e => e.IState).HasColumnName("iState");
        });

        modelBuilder.Entity<LogTranMnl1>(entity =>
        {
            entity.HasKey(e => new { e.IdTrans, e.IdUniOper, e.InServer });

            entity.ToTable("LogTranMnl");

            entity.HasIndex(e => e.Fecha, "IX_LogTranMnl");

            entity.HasIndex(e => e.RepUni, "IX_LogTranMnl_1");

            entity.HasIndex(e => e.Estatus, "IX_LogTranMnl_2");

            entity.HasIndex(e => new { e.RepUni, e.Estatus }, "IX_LogTranMnl_3");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<LogTranMnlTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LogTranMnlTmp");

            entity.HasIndex(e => new { e.Spid, e.Id }, "IX_LogTranMnlTmp").IsClustered();

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
            entity.Property(e => e.Spid).HasColumnName("spid");
        });

        modelBuilder.Entity<LogTranPasoCte>(entity =>
        {
            entity.HasKey(e => new { e.IdTrans, e.IdUniOper, e.Cfc });

            entity.ToTable("LogTranPasoCte");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CFC");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<LogTranPasoCteCfc>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc });

            entity.ToTable("LogTranPasoCteCFC");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfc");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<LogTranPasoCteCfcIncoming>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc }).HasName("PK_LogTranPasoCteCFC1_Incoming");

            entity.ToTable("LogTranPasoCteCFC_Incoming");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfc");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<LogTranPasoCteIncoming>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc, e.IdTrans });

            entity.ToTable("LogTranPasoCte_Incoming");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CFC");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<LogTranPasoSrv>(entity =>
        {
            entity.HasKey(e => new { e.IdTrans, e.IdUniOper, e.Cfc }).HasName("PK_PasoLogTranSrv");

            entity.ToTable("LogTranPasoSrv");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CFC");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<LogTranPasoSrvCfc>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc });

            entity.ToTable("LogTranPasoSrvCFC");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfc");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<LogTranSendLogToClient>(entity =>
        {
            entity.HasKey(e => new { e.ICompany, e.IdUniOper, e.Cfc, e.IdUniOperSend }).HasName("PK_LogTrnaSendLogToClient");

            entity.ToTable("LogTranSendLogToClient");

            entity.Property(e => e.ICompany).HasColumnName("iCompany");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfc");
            entity.Property(e => e.IdUniOperSend).HasColumnName("id_uni_oper_send");
        });

        modelBuilder.Entity<LogTranSent>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Cfc }).HasName("PK_LogTrnaSent");

            entity.ToTable("LogTranSent");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Cfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfc");
        });

        modelBuilder.Entity<LogVentaDesc>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLog, e.Sku }).HasName("PK_log_desc_supervisor");

            entity.ToTable("log_venta_desc");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.LogVentum).WithMany(p => p.LogVentaDescs)
                .HasForeignKey(d => new { d.IdUniOper, d.IdLog })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_VENT_REF_12710_LOG_VENT");
        });

        modelBuilder.Entity<LogVentaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLog, e.Orden }).HasName("PK_log_VENTA_DETALLE");

            entity.ToTable("log_venta_detalle");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadEmpaque)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("cantidad_empaque");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoBaseConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base_con_iva");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.DescuentoGralPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_gral_porc");
            entity.Property(e => e.DescuentoPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_porc");
            entity.Property(e => e.DescuentoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("descuento_sin_iva");
            entity.Property(e => e.DescuentoSupPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_sup_porc");
            entity.Property(e => e.DescuentoSupTipo).HasColumnName("descuento_sup_tipo");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.IndTipoPrecio).HasColumnName("ind_tipo_precio");
            entity.Property(e => e.OrdenPrincipal).HasColumnName("orden_principal");
            entity.Property(e => e.PrecioCliente)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_cliente");
            entity.Property(e => e.PrecioClienteSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente_sin_iva");
            entity.Property(e => e.PrecioDescGral)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_gral");
            entity.Property(e => e.PrecioDescGralSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_gral_sin_iva");
            entity.Property(e => e.PrecioDescSup)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_sup");
            entity.Property(e => e.PrecioDescSupSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_sup_sin_iva");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto");
            entity.Property(e => e.PrecioNetoBase)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto_base");
            entity.Property(e => e.PrecioNetoBaseSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_base_sin_iva");
            entity.Property(e => e.PrecioNetoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_sin_iva");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.PrecioVentaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta_sin_iva");
            entity.Property(e => e.PrecioVolumen)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_volumen");
            entity.Property(e => e.PrecioVolumenSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_volumen_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");

            entity.HasOne(d => d.LogVentum).WithMany(p => p.LogVentaDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.IdLog })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_VENT_REF_2317_LOG_VENT");
        });

        modelBuilder.Entity<LogVentaDetalleComp>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLog, e.Orden, e.Sku, e.SkuTransformado }).HasName("PK_LOG_VENTA_DETALLE_COMP");

            entity.ToTable("log_venta_detalle_comp");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.SkuTransformado).HasColumnName("sku_transformado");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadProd)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_prod");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.PrecioCliente)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente");
            entity.Property(e => e.PrecioClienteSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente_sin_iva");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.PrecioVentaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta_sin_iva");
        });

        modelBuilder.Entity<LogVentaDetalleCon>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLog, e.Orden }).HasName("PK_log_VENTA_DETALLE_CONS");

            entity.ToTable("log_venta_detalle_cons");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadEmpaque)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("cantidad_empaque");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoBaseConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base_con_iva");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.DescuentoGralPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_gral_porc");
            entity.Property(e => e.DescuentoPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_porc");
            entity.Property(e => e.DescuentoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("descuento_sin_iva");
            entity.Property(e => e.DescuentoSupPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_sup_porc");
            entity.Property(e => e.DescuentoSupTipo).HasColumnName("descuento_sup_tipo");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.IndGranel).HasColumnName("ind_granel");
            entity.Property(e => e.IndTipoPrecio).HasColumnName("ind_tipo_precio");
            entity.Property(e => e.IndTipoPrecioCliente).HasColumnName("ind_tipo_precio_cliente");
            entity.Property(e => e.IndVolumen).HasColumnName("ind_volumen");
            entity.Property(e => e.PrecioCliente)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_cliente");
            entity.Property(e => e.PrecioClienteSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente_sin_iva");
            entity.Property(e => e.PrecioDescGral)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_gral");
            entity.Property(e => e.PrecioDescGralSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_gral_sin_iva");
            entity.Property(e => e.PrecioDescSup)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_sup");
            entity.Property(e => e.PrecioDescSupSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_sup_sin_iva");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto");
            entity.Property(e => e.PrecioNetoBase)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto_base");
            entity.Property(e => e.PrecioNetoBaseSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_base_sin_iva");
            entity.Property(e => e.PrecioNetoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_sin_iva");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.PrecioVentaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta_sin_iva");
            entity.Property(e => e.PrecioVolumen)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_volumen");
            entity.Property(e => e.PrecioVolumenSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_volumen_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");
        });

        modelBuilder.Entity<LogVentaForma>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLog, e.Orden }).HasName("PK_VENTA_FORMA_PAGO");

            entity.ToTable("log_venta_forma");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.FolioReferencia).HasColumnName("folio_referencia");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.ImporteMn)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("importe_mn");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.LogVentaFormas)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_VENT_REF_1164_FORMA_PA");

            entity.HasOne(d => d.LogVentum).WithMany(p => p.LogVentaFormas)
                .HasForeignKey(d => new { d.IdUniOper, d.IdLog })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_VENT_REF_1160_LOG_VENT");
        });

        modelBuilder.Entity<LogVentum>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLog });

            entity.ToTable("log_venta");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.DescGral)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_gral");
            entity.Property(e => e.DescGralIva)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_gral_iva");
            entity.Property(e => e.DescGralSubtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_gral_subtotal");
            entity.Property(e => e.DescGralTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_gral_total");
            entity.Property(e => e.DescIva)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_iva");
            entity.Property(e => e.DescSubtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_subtotal");
            entity.Property(e => e.DescTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_total");
            entity.Property(e => e.EstatusLog)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("estatus_log");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IndFacturar).HasColumnName("ind_facturar");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.IvaBruto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("iva_bruto");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SubtotalBruto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal_bruto");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalBruto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_bruto");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.LogVenta)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_VENT_REF_19704_UNIDAD_O");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LogVenta)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_VENT_REF_2323_USUARIO");
        });

        modelBuilder.Entity<LogtranMnl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_logtranMnl");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<Logtranmnl2>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.InServer, e.IdTrans }).HasName("PK_LogTranMnl_log");

            entity.ToTable("logtranmnl2");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<MacPc>(entity =>
        {
            entity.HasKey(e => new { e.IdPc, e.IdUniOper });

            entity.ToTable("MacPC");

            entity.HasIndex(e => new { e.Mac, e.IdUniOper }, "ak_MacPC");

            entity.Property(e => e.IdPc).HasColumnName("id_PC");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Adaptador)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Indice).HasColumnName("indice");
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Mac)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAC");
            entity.Property(e => e.NombreAdaptador)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Usuario_Alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Usuario_Modifica");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.MacPcs)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MacPC_unidad_operativa");
        });

        modelBuilder.Entity<MaqPc>(entity =>
        {
            entity.HasKey(e => e.IdPc);

            entity.ToTable("Maq_PC");

            entity.Property(e => e.IdPc)
                .ValueGeneratedNever()
                .HasColumnName("id_pc");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<MaqPcDet>(entity =>
        {
            entity.HasKey(e => new { e.IdPcDet, e.IdUniOper, e.IdPc });

            entity.ToTable("Maq_PC_Det");

            entity.HasIndex(e => new { e.Mac, e.IdUniOper }, "ak_Maq_PC_Det");

            entity.Property(e => e.IdPcDet).HasColumnName("id_PC_Det");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdPc).HasColumnName("id_PC");
            entity.Property(e => e.Adaptador)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Indice).HasColumnName("indice");
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Mac)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAC");
            entity.Property(e => e.NombreAdaptador)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Usuario_Alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Usuario_Modifica");

            entity.HasOne(d => d.IdPcNavigation).WithMany(p => p.MaqPcDets)
                .HasForeignKey(d => d.IdPc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maq_PC_Det_Maq_PC");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.MaqPcDets)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maq_PC_Det_unidad_operativa");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK_MARCA");

            entity.ToTable("marca");

            entity.Property(e => e.IdMarca)
                .ValueGeneratedNever()
                .HasColumnName("id_marca");
            entity.Property(e => e.AbrevMarca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("abrev_marca");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomMarca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_marca");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.IdMensaje).HasName("PK__mensaje__5E01903C");

            entity.ToTable("mensaje");

            entity.Property(e => e.IdMensaje)
                .ValueGeneratedNever()
                .HasColumnName("id_mensaje");
            entity.Property(e => e.DescripMensaje)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descrip_mensaje");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true, "DF__mensaje__ind_vig__5EF5B475")
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<MensajeUnidadOperativa>(entity =>
        {
            entity.HasKey(e => new { e.IdMensaje, e.IdUnidadOperativa }).HasName("PK__mensaje___CE0CD8FC5170D0CE");

            entity.ToTable("mensaje_unidad_operativa");

            entity.Property(e => e.IdMensaje).HasColumnName("id_mensaje");
            entity.Property(e => e.IdUnidadOperativa).HasColumnName("id_unidad_operativa");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");

            entity.HasOne(d => d.IdUnidadOperativaNavigation).WithMany(p => p.MensajeUnidadOperativas)
                .HasForeignKey(d => d.IdUnidadOperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mensaje_u__id_un__53591940");
        });

        modelBuilder.Entity<Merma>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_MERMA");

            entity.ToTable("merma");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaInterfase)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.Mermas)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MERMA_REFERENCE_TIPO_MOV");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Mermas)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MERMA_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<MermaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_merma_DET");

            entity.ToTable("merma_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.MermaDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_merma_det_impuesto");

            entity.HasOne(d => d.Merma).WithMany(p => p.MermaDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_merma_det_REFERENCE_merma");

            entity.HasOne(d => d.Inventario).WithMany(p => p.MermaDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_merma_REFERENCE_INVENTAR");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.MermaDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_merma_det_articulo_empaque");
        });

        modelBuilder.Entity<MermaDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.Serie, e.IdMovimiento }).HasName("PK_merma_DET_SERIES");

            entity.ToTable("merma_det_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");

            entity.HasOne(d => d.MermaDet).WithMany(p => p.MermaDetSeries)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_merma_det_serie_REF_merma_det");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("PK_MODELO");

            entity.ToTable("modelo");

            entity.Property(e => e.IdModelo)
                .ValueGeneratedNever()
                .HasColumnName("id_modelo");
            entity.Property(e => e.AbrevModelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("abrev_modelo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomModelo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom_modelo");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.IdMoneda).HasName("PK_MONEDA");

            entity.ToTable("moneda");

            entity.Property(e => e.IdMoneda)
                .ValueGeneratedNever()
                .HasColumnName("id_moneda");
            entity.Property(e => e.AbrevMoneda)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev_moneda");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdMonedaSat).HasColumnName("id_moneda_sat");
            entity.Property(e => e.IndBase).HasColumnName("ind_base");
            entity.Property(e => e.IndExtranjera).HasColumnName("ind_extranjera");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomMoneda)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_moneda");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<MonitorTerminal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("monitor_terminal");

            entity.HasIndex(e => new { e.IdUniOper, e.IdCaja, e.FechaMovimiento }, "IX_monitor_terminal").IsClustered();

            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IndTipo).HasColumnName("ind_tipo");
            entity.Property(e => e.Operacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("operacion");
        });

        modelBuilder.Entity<MotivoFaltanteRecibo>(entity =>
        {
            entity.HasKey(e => e.IdMotivo).HasName("PK_MOTIVO_FALTANTE_RECIBO");

            entity.ToTable("Motivo_Faltante_Recibo");

            entity.Property(e => e.IdMotivo)
                .ValueGeneratedNever()
                .HasColumnName("id_motivo");
            entity.Property(e => e.AbrevMotivo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_motivo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdTipomov)
                .HasDefaultValue((short)0, "DF__Motivo_Fa__id_ti__098A4168")
                .HasColumnName("id_tipomov");
            entity.Property(e => e.IndAfectaInv).HasColumnName("ind_afecta_inv");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomMotivo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_motivo");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<MovimientoCajaPo>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdCaja, e.IdUniOper }).HasName("PK_MOVIMIENTO_CAJA_POS");

            entity.ToTable("movimiento_caja_pos");

            entity.HasIndex(e => new { e.IdUniOper, e.IdCaja, e.IdCorte }, "IX_movimiento_caja_pos");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdMovTraslado).HasColumnName("id_mov_traslado");
            entity.Property(e => e.IdMovimientoRef).HasColumnName("id_movimiento_ref");
            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.IdTipoMovRef).HasColumnName("id_tipo_mov_ref");
            entity.Property(e => e.IdTipomovCaja).HasColumnName("id_tipomov_caja");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IndTipoCaja)
                .HasDefaultValue(1)
                .HasColumnName("ind_tipo_caja");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_mn");
            entity.Property(e => e.SaldoAnterior)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_anterior");
            entity.Property(e => e.SaldoAnteriorDoc)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_anterior_doc");
            entity.Property(e => e.SaldoAnteriorEfec)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("saldo_anterior_efec");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<MovimientoCajaPosDet>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdCaja, e.IdUniOper, e.IdFormaPago }).HasName("PK_MOVIMIENTO_CAJA_POS_DET");

            entity.ToTable("movimiento_caja_pos_det", tb => tb.HasTrigger("ti_Movimiento_caja_pos_Det"));

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_mn");

            entity.HasOne(d => d.MovimientoCajaPo).WithMany(p => p.MovimientoCajaPosDets)
                .HasForeignKey(d => new { d.IdMovimiento, d.IdCaja, d.IdUniOper })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIENTO_CAJA_POS_DET_REF_MOVIMIENTO_CAJA_POS");
        });

        modelBuilder.Entity<MovimientoCxc>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.FolioMov, e.IdTipomov }).HasName("PK_MOVIMIENTO_CXC");

            entity.ToTable("movimiento_cxc", tb => tb.HasTrigger("ti_Movimiento_cxc"));

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdMovimientoDoc).HasColumnName("id_movimiento_doc");
            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.IdUniOperDoc).HasColumnName("id_uni_oper_doc");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("Monto_mn");
            entity.Property(e => e.SaldoAnterior)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("saldo_anterior");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.MovimientoCxcs)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIENTO_CXC_REF_ID_UNI_OPER");
        });

        modelBuilder.Entity<MovimientoCxcDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.FolioMov, e.IdTipomov, e.IdFormaPago }).HasName("PK_MOVIMIENTO_CXC_DET");

            entity.ToTable("movimiento_cxc_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("monto_mn");

            entity.HasOne(d => d.MovimientoCxc).WithMany(p => p.MovimientoCxcDets)
                .HasForeignKey(d => new { d.IdUniOper, d.FolioMov, d.IdTipomov })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOV_CXC_DET_REF_MOV_CXC");
        });

        modelBuilder.Entity<MovimientoInventario>(entity =>
        {
            entity.HasKey(e => new { e.IdTipomov, e.FolioMov, e.IdUniOper }).HasName("PK_MOVIMIENTO_INVENTARIO");

            entity.ToTable("movimiento_inventario");

            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAplica)
                .HasColumnType("datetime")
                .HasColumnName("fecha_aplica");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioDoc).HasColumnName("folio_doc");
            entity.Property(e => e.IdUniOperTras).HasColumnName("id_uni_oper_tras");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REFERENCE_TIPO_MOV");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<MovimientoInventarioDet>(entity =>
        {
            entity.HasKey(e => new { e.IdTipomov, e.FolioMov, e.IdUniOper, e.Sku }).HasName("PK_MOVIMIENTO_INVENTARIO_DET");

            entity.ToTable("movimiento_inventario_det", tb => tb.HasTrigger("ti_Movimiento_Inventario_Det"));

            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.InvAnterior)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("inv_anterior");
            entity.Property(e => e.InvAnteriorBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("inv_anterior_base");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.MovimientoInventarioDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.Inventario).WithMany(p => p.MovimientoInventarioDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REFERENCE_INVENTAR");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.MovimientoInventarioDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REFERENCE_UNIDAD");

            entity.HasOne(d => d.MovimientoInventario).WithMany(p => p.MovimientoInventarioDets)
                .HasForeignKey(d => new { d.IdTipomov, d.FolioMov, d.IdUniOper })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REF_MOVIMIEN");
        });

        modelBuilder.Entity<MovimientoInventarioDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdTipomov, e.FolioMov, e.IdUniOper, e.Sku, e.Serie }).HasName("PK_MOVIMIENTO_INVENTARIO_DET_S");

            entity.ToTable("movimiento_inventario_det_serie");

            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serie");

            entity.HasOne(d => d.MovimientoInventarioDet).WithMany(p => p.MovimientoInventarioDetSeries)
                .HasForeignKey(d => new { d.IdTipomov, d.FolioMov, d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIEN_REFERENCE_MOVIMIEN");
        });

        modelBuilder.Entity<MovimientoSocio>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento });

            entity.ToTable("movimiento_socio", tb => tb.HasTrigger("ti_Movimiento_socio"));

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.FactorAplicado)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("factor_aplicado");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioDoc).HasColumnName("folio_doc");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.IdTipomovSocio).HasColumnName("id_tipomov_socio");
            entity.Property(e => e.SaldoAnterior)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("saldo_anterior");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.ValorMovimiento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("valor_movimiento");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.MovimientoSocios)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimiento_socio_Cliente");

            entity.HasOne(d => d.IdTarjetaNavigation).WithMany(p => p.MovimientoSocios)
                .HasForeignKey(d => d.IdTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimiento_socio_Tarjeta");

            entity.HasOne(d => d.IdTipomovSocioNavigation).WithMany(p => p.MovimientoSocios)
                .HasForeignKey(d => d.IdTipomovSocio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimiento_socio_Tipo_Mov");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.MovimientoSocios)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimiento_socio_Unidad_Operativa");
        });

        modelBuilder.Entity<Nodo>(entity =>
        {
            entity.HasKey(e => e.IdNodo).HasName("PK_NODO");

            entity.ToTable("nodo");

            entity.HasIndex(e => e.NombreNodo, "ak_nombre_nodo").IsUnique();

            entity.Property(e => e.IdNodo).HasColumnName("id_nodo");
            entity.Property(e => e.IndMuestraNavegacion)
                .HasDefaultValue(true, "DF__nodo__ind_muestr__20C1E124")
                .HasColumnName("ind_muestra_navegacion");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true, "DF__nodo__ind_vigent__21B6055D")
                .HasColumnName("ind_vigente");
            entity.Property(e => e.NombreNodo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_nodo");
            entity.Property(e => e.NombreUoInicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_uo_inicio");
            entity.Property(e => e.OrdenNodo).HasColumnName("orden_nodo");
        });

        modelBuilder.Entity<OfertaCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdFolio, e.IdUniOper }).HasName("pk_oferta_cliente");

            entity.ToTable("oferta_cliente");

            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Estatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<OfertaClienteDet>(entity =>
        {
            entity.HasKey(e => new { e.IdFolioDet, e.IdFolio, e.IdUniOperFolio }).HasName("pk_oferta_cliente_det");

            entity.ToTable("oferta_cliente_det");

            entity.HasIndex(e => new { e.Sku, e.IdUniOper, e.Estatus, e.FechaIni, e.FechaFin, e.HoraIni, e.HoraFin }, "IX_oferta_cliente_det");

            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdUniOperFolio).HasColumnName("id_uni_oper_folio");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.Dia1).HasColumnName("dia1");
            entity.Property(e => e.Dia2).HasColumnName("dia2");
            entity.Property(e => e.Dia3).HasColumnName("dia3");
            entity.Property(e => e.Dia4).HasColumnName("dia4");
            entity.Property(e => e.Dia5).HasColumnName("dia5");
            entity.Property(e => e.Dia6).HasColumnName("dia6");
            entity.Property(e => e.Dia7).HasColumnName("dia7");
            entity.Property(e => e.Estatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.HoraFin).HasColumnName("hora_fin");
            entity.Property(e => e.HoraIni).HasColumnName("hora_ini");
            entity.Property(e => e.IdFolioDetRef).HasColumnName("id_folio_det_ref");
            entity.Property(e => e.IdFolioRef).HasColumnName("id_folio_ref");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.IdTipoOferta).HasColumnName("id_tipo_oferta");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUniOperFolioRef).HasColumnName("id_uni_oper_folio_ref");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioOferta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_oferta");
            entity.Property(e => e.PrecioOfertaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_oferta_sin_iva");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");

            entity.HasOne(d => d.OfertaCliente).WithMany(p => p.OfertaClienteDets)
                .HasForeignKey(d => new { d.IdFolio, d.IdUniOperFolio })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_oferta_cliente_det_oferta_ciente");

            entity.HasOne(d => d.Inventario).WithMany(p => p.OfertaClienteDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_oferta_cliente_det_inventario");
        });

        modelBuilder.Entity<OfertaClienteDetFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oferta_cliente_det_fecha");

            entity.HasIndex(e => new { e.IdFolioDet, e.IdFolio, e.IdUniOperFolio, e.Sku, e.IdUniOper }, "IX_oferta_cliente_det_fecha").IsClustered();

            entity.HasIndex(e => new { e.Sku, e.IdUniOper, e.FechaIni, e.FechaFin }, "IX_oferta_cliente_det_fecha_1");

            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.Estatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.IdTipoOferta).HasColumnName("id_tipo_oferta");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUniOperFolio).HasColumnName("id_uni_oper_folio");
            entity.Property(e => e.PrecioOferta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_oferta");
            entity.Property(e => e.PrecioOfertaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_oferta_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("pk_pais");

            entity.ToTable("pais");

            entity.HasIndex(e => new { e.IdUniOper, e.IdUo }, "AK_LLAVE_PAIS").IsUnique();

            entity.Property(e => e.IdPais)
                .ValueGeneratedNever()
                .HasColumnName("id_pais");
            entity.Property(e => e.AbrevPais)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev_pais");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomPais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_pais");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Panel>(entity =>
        {
            entity.HasKey(e => e.IdPanel).HasName("PK_PANEL");

            entity.ToTable("panel");

            entity.Property(e => e.IdPanel)
                .ValueGeneratedNever()
                .HasColumnName("id_panel");
            entity.Property(e => e.IdNodo).HasColumnName("id_nodo");
            entity.Property(e => e.IndCatalogo)
                .HasDefaultValue(false, "DF_panel_ind_catalogo")
                .HasColumnName("ind_catalogo");
            entity.Property(e => e.IndMuestraArbol)
                .HasDefaultValue(true, "DF__panel__ind_muest__29572725")
                .HasColumnName("ind_muestra_arbol");
            entity.Property(e => e.IndPanelControl).HasColumnName("ind_panel_control");
            entity.Property(e => e.IndVerificaCuenta).HasColumnName("ind_verifica_cuenta");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NombreIcono16)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_icono16");
            entity.Property(e => e.NombreIcono32)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_icono32");
            entity.Property(e => e.NombrePanel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_panel");
            entity.Property(e => e.NombreUoPanel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_uo_panel");
            entity.Property(e => e.NombreUoPanelControl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_uo_panel_control");
            entity.Property(e => e.OrdenPanel).HasColumnName("orden_panel");
            entity.Property(e => e.TipoMenu).HasColumnName("tipo_menu");
            entity.Property(e => e.TituloPanel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titulo_panel");

            entity.HasOne(d => d.IdNodoNavigation).WithMany(p => p.Panels)
                .HasForeignKey(d => d.IdNodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PANEL_REF_40137_NODO");
        });

        modelBuilder.Entity<PanelUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdPanel, e.IdUsuario }).HasName("PK_PANEL_USUARIO");

            entity.ToTable("panel_usuario");

            entity.Property(e => e.IdPanel).HasColumnName("id_panel");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IndActualizar).HasColumnName("ind_actualizar");
            entity.Property(e => e.IndAgregar).HasColumnName("ind_agregar");
            entity.Property(e => e.IndBorrar).HasColumnName("ind_borrar");
            entity.Property(e => e.IndImprimir).HasColumnName("ind_imprimir");

            entity.HasOne(d => d.IdPanelNavigation).WithMany(p => p.PanelUsuarios)
                .HasForeignKey(d => d.IdPanel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PANEL_US_REF_54_PANEL");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.PanelUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PANEL_US_REF_7023_USUARIO");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.IdParametro).HasName("PK_PARAMETRO");

            entity.ToTable("parametro");

            entity.HasIndex(e => e.NombreParametro, "AK_NOMBRE_PARAMETR").IsUnique();

            entity.Property(e => e.IdParametro).HasColumnName("id_parametro");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true, "DF__parametro__ind_v__300424B4")
                .HasColumnName("ind_vigente");
            entity.Property(e => e.NombreParametro)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre_parametro");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.ValorParametro)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor_parametro");
        });

        modelBuilder.Entity<Pbcatcol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatcol");

            entity.HasIndex(e => new { e.PbcTnam, e.PbcOwnr, e.PbcCnam }, "pbcatcol_idx").IsUnique();

            entity.Property(e => e.PbcBmap)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbc_bmap");
            entity.Property(e => e.PbcCase).HasColumnName("pbc_case");
            entity.Property(e => e.PbcCid).HasColumnName("pbc_cid");
            entity.Property(e => e.PbcCmnt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_cmnt");
            entity.Property(e => e.PbcCnam)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbc_cnam");
            entity.Property(e => e.PbcEdit)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_edit");
            entity.Property(e => e.PbcHdr)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_hdr");
            entity.Property(e => e.PbcHght).HasColumnName("pbc_hght");
            entity.Property(e => e.PbcHpos).HasColumnName("pbc_hpos");
            entity.Property(e => e.PbcInit)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_init");
            entity.Property(e => e.PbcJtfy).HasColumnName("pbc_jtfy");
            entity.Property(e => e.PbcLabl)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_labl");
            entity.Property(e => e.PbcLpos).HasColumnName("pbc_lpos");
            entity.Property(e => e.PbcMask)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_mask");
            entity.Property(e => e.PbcOwnr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbc_ownr");
            entity.Property(e => e.PbcPtrn)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_ptrn");
            entity.Property(e => e.PbcTag)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_tag");
            entity.Property(e => e.PbcTid).HasColumnName("pbc_tid");
            entity.Property(e => e.PbcTnam)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbc_tnam");
            entity.Property(e => e.PbcWdth).HasColumnName("pbc_wdth");
        });

        modelBuilder.Entity<Pbcatedt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatedt");

            entity.HasIndex(e => new { e.PbeName, e.PbeSeqn }, "pbcatedt_idx")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PbeCntr).HasColumnName("pbe_cntr");
            entity.Property(e => e.PbeEdit)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbe_edit");
            entity.Property(e => e.PbeFlag).HasColumnName("pbe_flag");
            entity.Property(e => e.PbeName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbe_name");
            entity.Property(e => e.PbeSeqn).HasColumnName("pbe_seqn");
            entity.Property(e => e.PbeType).HasColumnName("pbe_type");
            entity.Property(e => e.PbeWork)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbe_work");
        });

        modelBuilder.Entity<Pbcatfmt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatfmt");

            entity.HasIndex(e => e.PbfName, "pbcatfmt_idx")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PbfCntr).HasColumnName("pbf_cntr");
            entity.Property(e => e.PbfFrmt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbf_frmt");
            entity.Property(e => e.PbfName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbf_name");
            entity.Property(e => e.PbfType).HasColumnName("pbf_type");
        });

        modelBuilder.Entity<Pbcattbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcattbl");

            entity.HasIndex(e => new { e.PbtTnam, e.PbtOwnr }, "pbcattbl_idx").IsUnique();

            entity.Property(e => e.PbdFchr).HasColumnName("pbd_fchr");
            entity.Property(e => e.PbdFfce)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbd_ffce");
            entity.Property(e => e.PbdFhgt).HasColumnName("pbd_fhgt");
            entity.Property(e => e.PbdFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbd_fitl");
            entity.Property(e => e.PbdFptc).HasColumnName("pbd_fptc");
            entity.Property(e => e.PbdFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbd_funl");
            entity.Property(e => e.PbdFwgt).HasColumnName("pbd_fwgt");
            entity.Property(e => e.PbhFchr).HasColumnName("pbh_fchr");
            entity.Property(e => e.PbhFfce)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbh_ffce");
            entity.Property(e => e.PbhFhgt).HasColumnName("pbh_fhgt");
            entity.Property(e => e.PbhFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbh_fitl");
            entity.Property(e => e.PbhFptc).HasColumnName("pbh_fptc");
            entity.Property(e => e.PbhFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbh_funl");
            entity.Property(e => e.PbhFwgt).HasColumnName("pbh_fwgt");
            entity.Property(e => e.PblFchr).HasColumnName("pbl_fchr");
            entity.Property(e => e.PblFfce)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbl_ffce");
            entity.Property(e => e.PblFhgt).HasColumnName("pbl_fhgt");
            entity.Property(e => e.PblFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbl_fitl");
            entity.Property(e => e.PblFptc).HasColumnName("pbl_fptc");
            entity.Property(e => e.PblFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbl_funl");
            entity.Property(e => e.PblFwgt).HasColumnName("pbl_fwgt");
            entity.Property(e => e.PbtCmnt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbt_cmnt");
            entity.Property(e => e.PbtOwnr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbt_ownr");
            entity.Property(e => e.PbtTid).HasColumnName("pbt_tid");
            entity.Property(e => e.PbtTnam)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pbt_tnam");
        });

        modelBuilder.Entity<Pbcatvld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatvld");

            entity.HasIndex(e => e.PbvName, "pbcatvld_idx")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PbvCntr).HasColumnName("pbv_cntr");
            entity.Property(e => e.PbvMsg)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbv_msg");
            entity.Property(e => e.PbvName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbv_name");
            entity.Property(e => e.PbvType).HasColumnName("pbv_type");
            entity.Property(e => e.PbvVald)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbv_vald");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_PEDIDO");

            entity.ToTable("pedido");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.CveEstatusFiscal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus_fiscal");
            entity.Property(e => e.CveEstatusOperativo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus_operativo");
            entity.Property(e => e.CveEstatusPago)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus_pago");
            entity.Property(e => e.CveEstatusPedido)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus_pedido");
            entity.Property(e => e.CveEstatusRequisicion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus_requisicion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaAutoriza)
                .HasColumnType("datetime")
                .HasColumnName("fecha_autoriza");
            entity.Property(e => e.FechaCancela)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancela");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("fecha_Entrega");
            entity.Property(e => e.FechaEntregaReal)
                .HasColumnType("datetime")
                .HasColumnName("fecha_Entrega_real");
            entity.Property(e => e.FechaModifica)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifica");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdMovimientoReq).HasColumnName("id_movimiento_req");
            entity.Property(e => e.IdTipoPrecio).HasColumnName("id_tipo_precio");
            entity.Property(e => e.IdUniOperEntrega).HasColumnName("id_uni_oper_entrega");
            entity.Property(e => e.IdUniOperReq).HasColumnName("id_uni_oper_req");
            entity.Property(e => e.IndCredito).HasColumnName("ind_credito");
            entity.Property(e => e.IndRequisicionAlmacen).HasColumnName("ind_requisicion_almacen");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.TotalEntregado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Total_Entregado");
            entity.Property(e => e.TotalPedido)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Total_Pedido");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioAutoriza)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_autoriza");
            entity.Property(e => e.UsuarioCancela)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_cancela");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ID_CLIENTE");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_REF_UNIOPER");
        });

        modelBuilder.Entity<PedidoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_PEDIDO_DET");

            entity.ToTable("pedido_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadEntregada)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_entregada");
            entity.Property(e => e.CantidadEntregadaBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_entregada_base");
            entity.Property(e => e.Comentario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CveEstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_base");
            entity.Property(e => e.TotalPartida)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_partida");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.PedidoDets)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_DET_UNIDAD_MEDIDA");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.PedidoDets)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_DET_ARTICULO");

            entity.HasOne(d => d.Pedido).WithMany(p => p.PedidoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_DET_REF_PEDIDO");
        });

        modelBuilder.Entity<PedidoEntrega>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_PEDIDO_ENTREGA");

            entity.ToTable("pedido_entrega");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.CveEstatusFiscal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("NFA")
                .IsFixedLength()
                .HasColumnName("cve_estatus_fiscal");
            entity.Property(e => e.CveEstatusPago)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus_pago");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FechaRealEntrega)
                .HasColumnType("datetime")
                .HasColumnName("fecha_real_entrega");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdEstatusRelacion).HasColumnName("id_estatus_relacion");
            entity.Property(e => e.IdMovimientoPedido).HasColumnName("id_movimiento_pedido");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdUniOperPedido).HasColumnName("id_uni_oper_pedido");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalPagado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_pagado");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioMovimiento)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_movimiento");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.PedidoEntregas)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ENTREGA_REF_ID_UNI_OPER");
        });

        modelBuilder.Entity<PedidoEntregaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_ENTREGA_PEDIDO_DET");

            entity.ToTable("pedido_entrega_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadPedido)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_pedido");
            entity.Property(e => e.CantidadPedidoBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_pedido_base");
            entity.Property(e => e.Comentario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IndOriginal).HasColumnName("ind_original");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");
            entity.Property(e => e.SubtotalPartida)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal_partida");
            entity.Property(e => e.TotalPartida)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total_partida");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.PedidoEntregaDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ENTREGADET_IMPUESTO");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.PedidoEntregaDets)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ENTREGADET_UNIDAD_MEDIDA");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.PedidoEntregaDets)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ENTREGADET_ARTICULO");

            entity.HasOne(d => d.PedidoEntrega).WithMany(p => p.PedidoEntregaDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ENTREGADET_REF_PEDIDO_ENTREGADET");
        });

        modelBuilder.Entity<PedidoEntregaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_PEDIDO_ENTREGA_PAGO");

            entity.ToTable("pedido_entrega_pago");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMovAnulaCxc).HasColumnName("folio_mov_anula_cxc");
            entity.Property(e => e.FolioMovCxc).HasColumnName("folio_mov_cxc");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdMovimientoPedido).HasColumnName("id_movimiento_pedido");
            entity.Property(e => e.IdMovimientoPedidoEntrega).HasColumnName("id_movimiento_pedido_entrega");
            entity.Property(e => e.IdSuperpago).HasColumnName("id_superpago");
            entity.Property(e => e.IdTipomovAnulaCxc).HasColumnName("id_tipomov_anula_cxc");
            entity.Property(e => e.IdTipomovCxc).HasColumnName("id_tipomov_cxc");
            entity.Property(e => e.IdUniOperPedido).HasColumnName("id_uni_oper_pedido");
            entity.Property(e => e.IdUniOperPedidoEntrega).HasColumnName("id_uni_oper_pedido_entrega");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("monto_mn");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioMovimiento)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_movimiento");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.PedidoEntregaPagos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDO_ENTREGA_PAGO_REF_ID_UNI_OPER");
        });

        modelBuilder.Entity<PedidoEntregaPagoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.IdFormaPago }).HasName("PK_PEDIDO_ENTREGA_PAGO_DET");

            entity.ToTable("pedido_entrega_pago_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.FolioMovCxc).HasColumnName("folio_mov_cxc");
            entity.Property(e => e.IdTipomovCxc).HasColumnName("id_tipomov_cxc");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("monto_mn");
            entity.Property(e => e.Orden).HasColumnName("orden");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.PedidoEntregaPagoDets)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDOENTPAGODET_REF_FORMAPAGO");

            entity.HasOne(d => d.PedidoEntregaPago).WithMany(p => p.PedidoEntregaPagoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEDIDOENTPAGO_DET_REF_PEDIDOENTPAGO");
        });

        modelBuilder.Entity<PedidoRequisicion>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.IdUniOperPedido, e.IdMovimientoPedido }).HasName("PK_PEDIDO_REQUISICION");

            entity.ToTable("pedido_requisicion");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOperPedido).HasColumnName("id_uni_oper_pedido");
            entity.Property(e => e.IdMovimientoPedido).HasColumnName("id_movimiento_pedido");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermiso).HasName("PK__permiso__228F224F5EE9FC26");

            entity.ToTable("permiso");

            entity.Property(e => e.IdPermiso)
                .ValueGeneratedNever()
                .HasColumnName("id_permiso");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndValidar).HasColumnName("ind_validar");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomPermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_permiso");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("pk_proveedor");

            entity.ToTable("proveedor");

            entity.Property(e => e.IdProveedor)
                .ValueGeneratedNever()
                .HasColumnName("id_proveedor");
            entity.Property(e => e.CalleYNumero)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("calle_y_numero");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.EntreCalles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("entre_calles");
            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");
            entity.Property(e => e.IdTipoProv).HasColumnName("id_tipo_prov");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_comercial");
            entity.Property(e => e.NomProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_proveedor");
            entity.Property(e => e.NumCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_cliente");
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagina_web");
            entity.Property(e => e.RfcProveedor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc_proveedor");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_1");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REFERENCE_CIUDAD");

            entity.HasOne(d => d.IdTipoProvNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdTipoProv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REF_TIPO_PRO");
        });

        modelBuilder.Entity<ProveedorCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.IdUniOperEntrega }).HasName("PK_destino_compra");

            entity.ToTable("proveedor_compra");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdUniOperEntrega).HasColumnName("id_uni_oper_entrega");
            entity.Property(e => e.DiasEntrega).HasColumnName("dias_entrega");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FrecuenciaCompra).HasColumnName("frecuencia_compra");
            entity.Property(e => e.IdUniOperFactura).HasColumnName("id_uni_oper_factura");
            entity.Property(e => e.IndAceptarParcial).HasColumnName("ind_aceptar_parcial");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProveedorCompras)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REFERENCE_PROVCOMPRA");

            entity.HasOne(d => d.IdUniOperEntregaNavigation).WithMany(p => p.ProveedorCompraIdUniOperEntregaNavigations)
                .HasForeignKey(d => d.IdUniOperEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCE_PROV_UNIOP");

            entity.HasOne(d => d.IdUniOperFacturaNavigation).WithMany(p => p.ProveedorCompraIdUniOperFacturaNavigations)
                .HasForeignKey(d => d.IdUniOperFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCE_PROV_COMPRA");
        });

        modelBuilder.Entity<ProveedorContacto>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.IdContactoProv }).HasName("pk_contacto_proveedor");

            entity.ToTable("proveedor_contacto");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdContactoProv).HasColumnName("id_contacto_prov");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.EMailContactoProv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("e_mail_contacto_prov");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroFax)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("numero_fax");
            entity.Property(e => e.Puesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("puesto");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_1");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_2");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProveedorContactos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REFERENCE_PROVEEDO");
        });

        modelBuilder.Entity<ProveedorCuentum>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.Cuenta }).HasName("PK_PROVEEDOR_CUENTA");

            entity.ToTable("proveedor_cuenta");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("cuenta");
            entity.Property(e => e.Clabe)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("clabe");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Nomsucursal)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("nomsucursal");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.ProveedorCuenta)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REFERENCE_BANCO");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProveedorCuenta)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REF_PROVEEDO");
        });

        modelBuilder.Entity<ProveedorPago>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.Consecutivo }).HasName("pk_pago_proveedor");

            entity.ToTable("proveedor_pago");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Dias).HasColumnName("dias");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("porcentaje");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProveedorPagos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REFERENCE_PROVPAGO");
        });

        modelBuilder.Entity<ProveedorTipoproducto>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.IdTipoproducto }).HasName("PK_PROVEEDOR_TIPOPRODUCTO");

            entity.ToTable("proveedor_tipoproducto");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdTipoproducto).HasColumnName("id_tipoproducto");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProveedorTipoproductos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDO_REF1_PROVEEDO");
        });

        modelBuilder.Entity<Recibo>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdUniOper }).HasName("PK_RECIBO");

            entity.ToTable("recibo");

            entity.HasIndex(e => new { e.IdUniOper, e.IdTipomov, e.FolioMov }, "AK_recibo_mov_inv");

            entity.HasIndex(e => new { e.IdUniOper, e.IdTipomovAnula, e.FolioMovAnula }, "IX_recibo_anula");

            entity.HasIndex(e => e.FechaRecibo, "IX_recibo_fecha");

            entity.HasIndex(e => e.IdProveedor, "IX_recibo_proveedor");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Factura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("factura");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaInterfase)
                .HasDefaultValueSql("((0))", "DF_recibo_fecha_interfase")
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.FechaRecibo)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_recibo");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdCompra).HasColumnName("id_compra");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioRecepcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_recepcion");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Recibos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RECIBO_REFERENCE_PROVEEDO");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.Recibos)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recibo_tipo_movimiento");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Recibos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recibo_unidad_operativa");
        });

        modelBuilder.Entity<ReciboDet>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdUniOper, e.Sku }).HasName("PK_RECIBO_DET");

            entity.ToTable("recibo_det");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoOriginal)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_original");
            entity.Property(e => e.CostoOriginalBase)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_original_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.ReciboDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RECIBO_D_REFERENCE_IMPUESTO");

            entity.HasOne(d => d.Inventario).WithMany(p => p.ReciboDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recibo_det_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.ReciboDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RECIBO_D_REFERENCE_UNIDAD");
        });

        modelBuilder.Entity<ReciboDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdUniOper, e.Sku, e.Serie }).HasName("PK_RECIBO_DET_SERIE");

            entity.ToTable("recibo_det_serie");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serie");

            entity.HasOne(d => d.ReciboDet).WithMany(p => p.ReciboDetSeries)
                .HasForeignKey(d => new { d.IdMovimiento, d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RECIBO_D_REFERENCE_RECIBO_D");
        });

        modelBuilder.Entity<RecoleccionValore>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdUniOper });

            entity.ToTable("recoleccion_valores");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FechaRecoleccion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recoleccion");
            entity.Property(e => e.IdCompaniaValores).HasColumnName("id_compania_valores");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioMovimiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario_movimiento");
        });

        modelBuilder.Entity<Requisicion>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_REQUISICION");

            entity.ToTable("requisicion", tb => tb.HasTrigger("ti_requisicion"));

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.CveEstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaInterfase)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FechaTermina)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_termina");
            entity.Property(e => e.FechaUtilizacion)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_utilizacion");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdUniOperSolicita).HasColumnName("id_uni_oper_solicita");
            entity.Property(e => e.IdUniOperSurte).HasColumnName("id_uni_oper_surte");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.UsuarioTermina)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_termina");
        });

        modelBuilder.Entity<RequisicionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_REQUISICION_DET");

            entity.ToTable("requisicion_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadLiberada)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_liberada");
            entity.Property(e => e.CantidadLiberadaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_liberada_base");
            entity.Property(e => e.CantidadSurtida)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_surtida");
            entity.Property(e => e.CantidadSurtidaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_surtida_base");
            entity.Property(e => e.Comentario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CveEstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cve_estatus");
            entity.Property(e => e.Existencia)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia");
            entity.Property(e => e.ExistenciaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("existencia_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");
            entity.Property(e => e.Stock)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("stock");
            entity.Property(e => e.Sugerido)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("sugerido");
            entity.Property(e => e.SugeridoBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("sugerido_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.RequisicionDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_requisicion_det_impuesto");

            entity.HasOne(d => d.SkuNavigation).WithMany(p => p.RequisicionDets)
                .HasForeignKey(d => d.Sku)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_requisicion_det_articulo");

            entity.HasOne(d => d.Requisicion).WithMany(p => p.RequisicionDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_requisicion_det_requisicion");

            entity.HasOne(d => d.Inventario).WithMany(p => p.RequisicionDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_requisicion_det_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.RequisicionDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_requisicion_det_articulo_empaque");
        });

        modelBuilder.Entity<RevisionSuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("revision_suc");

            entity.Property(e => e.DiaRevision)
                .HasColumnType("smalldatetime")
                .HasColumnName("dia_Revision");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.MatCantRegImportados).HasColumnName("mat_cant_reg_importados");
            entity.Property(e => e.MatCantRegMat).HasColumnName("mat_cant_reg_mat");
            entity.Property(e => e.MatCantRegSuc).HasColumnName("mat_cant_reg_suc");
            entity.Property(e => e.SucCantRegMat).HasColumnName("suc_cant_reg_mat");
            entity.Property(e => e.SucCantRegModificados).HasColumnName("suc_cant_reg_modificados");
            entity.Property(e => e.SucCantRegSuc).HasColumnName("suc_cant_reg_suc");
        });

        modelBuilder.Entity<SaldoCxc>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK_SALDO_CXC");

            entity.ToTable("saldo_cxc");

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnName("id_cliente");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("saldo");
        });

        modelBuilder.Entity<SaldoSocio>(entity =>
        {
            entity.HasKey(e => e.IdTarjeta).HasName("PK_SALDO_SOCIO");

            entity.ToTable("saldo_socio", tb => tb.HasTrigger("ti_Saldo_socio"));

            entity.Property(e => e.IdTarjeta)
                .ValueGeneratedNever()
                .HasColumnName("id_tarjeta");
            entity.Property(e => e.Monedero)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monedero");
            entity.Property(e => e.Punto).HasColumnName("punto");

            entity.HasOne(d => d.IdTarjetaNavigation).WithOne(p => p.SaldoSocio)
                .HasForeignKey<SaldoSocio>(d => d.IdTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_saldo_socio_Tarjeta");
        });

        modelBuilder.Entity<SaldoSocioHist>(entity =>
        {
            entity.HasKey(e => new { e.IdTarjeta, e.FechaIni }).HasName("PK_SALDO_SOCIO_HIST");

            entity.ToTable("saldo_socio_hist");

            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.Monedero)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monedero");
            entity.Property(e => e.Punto).HasColumnName("punto");

            entity.HasOne(d => d.IdTarjetaNavigation).WithMany(p => p.SaldoSocioHists)
                .HasForeignKey(d => d.IdTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_saldo_socio_hist_Tarjeta");
        });

        modelBuilder.Entity<SatCodigoPostal>(entity =>
        {
            entity.HasKey(e => new { e.IdCodigoPostal, e.CveCodigoPostal });

            entity.ToTable("Sat_codigo_postal");

            entity.Property(e => e.IdCodigoPostal).HasColumnName("id_codigo_postal");
            entity.Property(e => e.CveCodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cve_codigo_postal");
            entity.Property(e => e.CveEstado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_estado");
            entity.Property(e => e.CveLocalidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_localidad");
            entity.Property(e => e.CveMunicipio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_municipio");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdFormaPagoSat, e.ClaveFormaPagoSat }).HasName("id_formaPago_sat");

            entity.ToTable("sat_forma_pago");

            entity.Property(e => e.IdFormaPagoSat).HasColumnName("id_formaPago_sat");
            entity.Property(e => e.ClaveFormaPagoSat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clave_formaPago_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaFinVigencia)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vigencia");
            entity.Property(e => e.FechaIniVigencia)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vigencia");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.Reqcuenta).HasColumnName("reqcuenta");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatImpuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdImpuestoSat, e.ClaveImpuestoSat }).HasName("PK_IMPUESTO_sat");

            entity.ToTable("Sat_impuesto");

            entity.Property(e => e.IdImpuestoSat).HasColumnName("id_impuesto_sat");
            entity.Property(e => e.ClaveImpuestoSat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clave_impuesto_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.EntidadAplica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entidad_aplica");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.LocalFederal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Local_federal");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatMetodoPago>(entity =>
        {
            entity.HasKey(e => new { e.IdMetodoPagoSat, e.CveMetodoPago });

            entity.ToTable("Sat_metodo_pago");

            entity.Property(e => e.IdMetodoPagoSat).HasColumnName("id_metodo_pago_sat");
            entity.Property(e => e.CveMetodoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_metodo_pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaFinVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vig");
            entity.Property(e => e.FechaIniVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vig");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatMonedum>(entity =>
        {
            entity.HasKey(e => new { e.IdMonedaSat, e.ClaveMonedaSat }).HasName("PK_moneda_sat");

            entity.ToTable("Sat_moneda");

            entity.Property(e => e.IdMonedaSat).HasColumnName("id_moneda_sat");
            entity.Property(e => e.ClaveMonedaSat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clave_moneda_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatPai>(entity =>
        {
            entity.HasKey(e => new { e.IdPaisSat, e.CvePais }).HasName("PK_Sat_Pais_pago");

            entity.ToTable("Sat_Pais");

            entity.Property(e => e.IdPaisSat).HasColumnName("id_Pais_sat");
            entity.Property(e => e.CvePais)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_Pais");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatProductosServicio>(entity =>
        {
            entity.HasKey(e => new { e.IdProdServ, e.CveProdServ });

            entity.ToTable("Sat_Productos_servicios");

            entity.Property(e => e.IdProdServ).HasColumnName("id_ProdServ");
            entity.Property(e => e.CveProdServ)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_ProdServ");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaFinVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vig");
            entity.Property(e => e.FechaIniVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vig");
        });

        modelBuilder.Entity<SatRegimenFiscal>(entity =>
        {
            entity.HasKey(e => new { e.IdRegimenFiscalSat, e.CveRegimenFiscal });

            entity.ToTable("Sat_RegimenFiscal");

            entity.Property(e => e.IdRegimenFiscalSat).HasColumnName("id_RegimenFiscal_sat");
            entity.Property(e => e.CveRegimenFiscal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_RegimenFiscal");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaFinVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vig");
            entity.Property(e => e.FechaIniVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vig");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.Fisica).HasColumnName("fisica");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.Moral).HasColumnName("moral");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatTipoRelEntreCfdi>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoRel, e.CveTipoRel }).HasName("PK_Sat_tipo_rel");

            entity.ToTable("Sat_tipo_rel_entre_cfdi");

            entity.Property(e => e.IdTipoRel).HasColumnName("id_tipo_rel");
            entity.Property(e => e.CveTipoRel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_tipo_rel");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaFinVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vig");
            entity.Property(e => e.FechaIniVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vig");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatUnidadMedidum>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidadMedidaSat, e.CveUnidadMedida });

            entity.ToTable("Sat_unidad_medida");

            entity.Property(e => e.IdUnidadMedidaSat).HasColumnName("id_unidad_medida_sat");
            entity.Property(e => e.CveUnidadMedida)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_unidad_medida");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaFinVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vig");
            entity.Property(e => e.FechaIniVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vig");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nota)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("nota");
            entity.Property(e => e.Simbolo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("simbolo");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SatUsoComprobantesCfdi>(entity =>
        {
            entity.HasKey(e => new { e.IdUsoComp, e.CveUsoComp }).HasName("PK_Sat_uso_comp");

            entity.ToTable("Sat_uso_comprobantes_cfdi");

            entity.Property(e => e.IdUsoComp).HasColumnName("id_uso_comp");
            entity.Property(e => e.CveUsoComp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_uso_comp");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaFinVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin_vig");
            entity.Property(e => e.FechaIniVig)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini_vig");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente)
                .HasDefaultValue(true)
                .HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Sesion>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Spid, e.FechaIni }).HasName("PK__Sesion__2DD52ACC5C77A3CF");

            entity.ToTable("Sesion");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Spid).HasColumnName("spid");
            entity.Property(e => e.FechaIni).HasColumnType("datetime");
            entity.Property(e => e.ClaveUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_usuario");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTerminal).HasColumnName("Id_Terminal");
            entity.Property(e => e.IdTipounioper).HasColumnName("id_tipounioper");
            entity.Property(e => e.IdUniOperPpal).HasColumnName("Id_Uni_oper_Ppal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IndConsolidar).HasColumnName("ind_consolidar");
            entity.Property(e => e.IndPrincipal).HasColumnName("Ind_Principal");
            entity.Property(e => e.IndPrincipalPpal).HasColumnName("Ind_Principal_Ppal");
            entity.Property(e => e.IndVolumen).HasColumnName("ind_volumen");
            entity.Property(e => e.NombreTerminal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUniOper)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SesionHist>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Spid, e.FechaIni });

            entity.ToTable("Sesion_Hist");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Spid).HasColumnName("spid");
            entity.Property(e => e.FechaIni).HasColumnType("datetime");
            entity.Property(e => e.ClaveUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_usuario");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTerminal).HasColumnName("Id_Terminal");
            entity.Property(e => e.IdTipounioper).HasColumnName("id_tipounioper");
            entity.Property(e => e.IdUniOperPpal).HasColumnName("Id_Uni_oper_Ppal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IndConsolidar).HasColumnName("ind_consolidar");
            entity.Property(e => e.IndPrincipal).HasColumnName("Ind_Principal");
            entity.Property(e => e.IndPrincipalPpal).HasColumnName("Ind_Principal_Ppal");
            entity.Property(e => e.IndVolumen).HasColumnName("ind_volumen");
            entity.Property(e => e.NombreTerminal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUniOper)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SesionSuc>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Spid, e.FechaIni });

            entity.ToTable("Sesion_suc");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.Spid).HasColumnName("spid");
            entity.Property(e => e.FechaIni).HasColumnType("datetime");
            entity.Property(e => e.ClaveUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_usuario");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTerminal).HasColumnName("Id_Terminal");
            entity.Property(e => e.IdTipounioper).HasColumnName("id_tipounioper");
            entity.Property(e => e.IdUniOperPpal).HasColumnName("Id_Uni_oper_Ppal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IndConsolidar).HasColumnName("ind_consolidar");
            entity.Property(e => e.IndPrincipal).HasColumnName("Ind_Principal");
            entity.Property(e => e.IndPrincipalPpal).HasColumnName("Ind_Principal_Ppal");
            entity.Property(e => e.IndVolumen).HasColumnName("ind_volumen");
            entity.Property(e => e.NombreTerminal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUniOper)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SesionUnidadOperativa>(entity =>
        {
            entity.HasKey(e => new { e.Spid, e.IdUniOper }).HasName("PK_SESION_UNIDAD_OPERATIVA");

            entity.ToTable("sesion_unidad_operativa");

            entity.Property(e => e.Spid).HasColumnName("spid");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.AbrevUnioper)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_unioper");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IndLocal).HasColumnName("ind_local");
            entity.Property(e => e.NomUnioper)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_unioper");
        });

        modelBuilder.Entity<Subdivision>(entity =>
        {
            entity.HasKey(e => e.IdSubdivision).HasName("PK_SUBDIVISION");

            entity.ToTable("subdivision");

            entity.Property(e => e.IdSubdivision)
                .ValueGeneratedNever()
                .HasColumnName("id_subdivision");
            entity.Property(e => e.AbrevSubdivision)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_subdivision");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdDivision).HasColumnName("id_division");
            entity.Property(e => e.IdProdServ).HasColumnName("id_ProdServ");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomSubdivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_subdivision");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdDivisionNavigation).WithMany(p => p.Subdivisions)
                .HasForeignKey(d => d.IdDivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUBDIVISION_REF_DIVISION");
        });

        modelBuilder.Entity<SuperGrupoCliente>(entity =>
        {
            entity.HasKey(e => e.IdSuperGrupo).HasName("PK__super_gr__29AD3AFF59B11114");

            entity.ToTable("super_grupo_cliente");

            entity.Property(e => e.IdSuperGrupo)
                .ValueGeneratedNever()
                .HasColumnName("id_super_grupo");
            entity.Property(e => e.AbrevSuperGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_super_grupo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomSuperGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_super_grupo");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Superpago>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdSuperpago }).HasName("PK_SUPERPAGO");

            entity.ToTable("superpago");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdSuperpago).HasColumnName("id_superpago");
            entity.Property(e => e.CveEstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("cve_estatus");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaModifica)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifica");
            entity.Property(e => e.FolioMovAnulaCxc).HasColumnName("folio_mov_anula_cxc");
            entity.Property(e => e.FolioMovCxc).HasColumnName("folio_mov_cxc");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdTipomovAnulaCxc).HasColumnName("id_tipomov_anula_cxc");
            entity.Property(e => e.IdTipomovCxc).HasColumnName("id_tipomov_cxc");
            entity.Property(e => e.Monto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Monto_mn");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<SuperpagoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdSuperpago, e.IdTipoDoc, e.IdUniOperDoc, e.IdMovDoc }).HasName("PK_SUPERPAGO_DET");

            entity.ToTable("superpago_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdSuperpago).HasColumnName("id_superpago");
            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.IdUniOperDoc).HasColumnName("id_uni_oper_doc");
            entity.Property(e => e.IdMovDoc).HasColumnName("id_mov_doc");
            entity.Property(e => e.FolioMovCxc).HasColumnName("folio_mov_cxc");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdTipomovCxc).HasColumnName("id_tipomov_cxc");
            entity.Property(e => e.Monto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MontoMn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Monto_mn");
            entity.Property(e => e.MontoPagado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_pagado");
            entity.Property(e => e.MontoPagadoOriginal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto_pagado_original");

            entity.HasOne(d => d.Superpago).WithMany(p => p.SuperpagoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdSuperpago })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPERPAGO_DET_SUPERPAGO");
        });

        modelBuilder.Entity<TarjetaCf>(entity =>
        {
            entity.HasKey(e => e.IdTarjetaCf).HasName("PK_TARJETA_CF");

            entity.ToTable("tarjeta_cf");

            entity.Property(e => e.IdTarjetaCf)
                .ValueGeneratedNever()
                .HasColumnName("id_tarjeta_cf");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdLote).HasColumnName("id_lote");
            entity.Property(e => e.IdTipoTarjeta).HasColumnName("id_tipo_tarjeta");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipoTarjetaNavigation).WithMany(p => p.TarjetaCfs)
                .HasForeignKey(d => d.IdTipoTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TARJETA_CF_REF_TIPOTARJETA");
        });

        modelBuilder.Entity<TarjetaCfDet>(entity =>
        {
            entity.HasKey(e => e.IdTarjeta).HasName("PK_TARJETA_CF_DET");

            entity.ToTable("tarjeta_cf_det");

            entity.HasIndex(e => new { e.IdTipoTarjeta, e.IdLote, e.Id }, "IX_tarjeta_cf_det_tipo_lote").IsUnique();

            entity.HasIndex(e => e.IdCodigoBarras, "ak_tarjeta_cf_det_cb").IsUnique();

            entity.Property(e => e.IdTarjeta)
                .ValueGeneratedNever()
                .HasColumnName("id_tarjeta");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdLote).HasColumnName("id_lote");
            entity.Property(e => e.IdTarjetaCf).HasColumnName("id_tarjeta_cf");
            entity.Property(e => e.IdTipoTarjeta).HasColumnName("id_tipo_tarjeta");
            entity.Property(e => e.IndAsignado).HasColumnName("ind_asignado");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TarjetaCfFoliador>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoTarjeta, e.IdLote }).HasName("PK_TARJETA_CF_FOLIADOR");

            entity.ToTable("tarjeta_cf_foliador");

            entity.Property(e => e.IdTipoTarjeta).HasColumnName("id_tipo_tarjeta");
            entity.Property(e => e.IdLote).HasColumnName("id_lote");
            entity.Property(e => e.Folio).HasColumnName("folio");
        });

        modelBuilder.Entity<TemporalLogtranmnl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_temporal_logtranmnl");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<TemporalLogtranmnl3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_temporal_logtranmnl3");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEjec).HasColumnType("datetime");
            entity.Property(e => e.FechaTrans).HasColumnType("datetime");
            entity.Property(e => e.IdUniOper).HasColumnName("Id_Uni_Oper");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).IsUnicode(false);
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.HasKey(e => e.IdTerminal).HasName("PK__Terminal__4960D78F072CF7AA");

            entity.ToTable("Terminal");

            entity.Property(e => e.IdTerminal)
                .ValueGeneratedNever()
                .HasColumnName("id_terminal");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NombreTerminal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_terminal");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TerminalPc>(entity =>
        {
            entity.HasKey(e => new { e.IdTerminal, e.IdPc, e.IdUniOper });

            entity.ToTable("Terminal_PC");

            entity.Property(e => e.IdTerminal).HasColumnName("id_terminal");
            entity.Property(e => e.IdPc).HasColumnName("id_pc");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdPcNavigation).WithMany(p => p.TerminalPcs)
                .HasForeignKey(d => d.IdPc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terminal_PC_Maq_PC");

            entity.HasOne(d => d.IdTerminalNavigation).WithMany(p => p.TerminalPcs)
                .HasForeignKey(d => d.IdTerminal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terminal_PC_Terminal");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.TerminalPcs)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terminal_PC_unidad_operativa");
        });

        modelBuilder.Entity<Tiempo>(entity =>
        {
            entity.HasKey(e => e.Fecha).HasName("PK_tiempo");

            entity.ToTable("Tiempo");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.SemanaFin).HasColumnType("smalldatetime");
            entity.Property(e => e.SemanaIni).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TipoArticulo>(entity =>
        {
            entity.HasKey(e => e.IdTipoArticulo).HasName("PK_TIPO_ARTICULO");

            entity.ToTable("tipo_articulo");

            entity.Property(e => e.IdTipoArticulo).HasColumnName("id_tipo_articulo");
            entity.Property(e => e.AbrevTipoArticulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("abrev_tipo_articulo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndConsolidar).HasColumnName("ind_consolidar");
            entity.Property(e => e.IndPaquete).HasColumnName("ind_paquete");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoArticulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipo_articulo");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoCambio>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOperTc, e.IdTipoCambio }).HasName("PK_TIPO_CAMBIO");

            entity.ToTable("tipo_cambio");

            entity.Property(e => e.IdUniOperTc).HasColumnName("id_uni_oper_tc");
            entity.Property(e => e.IdTipoCambio).HasColumnName("id_tipo_cambio");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
            entity.Property(e => e.ValorCompra)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valor_compra");
            entity.Property(e => e.ValorVenta)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valor_venta");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.TipoCambios)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_CAM_REFERENCE_MONEDA");

            entity.HasOne(d => d.IdUniOperTcNavigation).WithMany(p => p.TipoCambios)
                .HasForeignKey(d => d.IdUniOperTc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_CAM_FK_REFERE_UNIDAD_O");
        });

        modelBuilder.Entity<TipoCliente>(entity =>
        {
            entity.HasKey(e => e.IdTipocliente).HasName("PK_TIPO_CLIENTE");

            entity.ToTable("tipo_cliente");

            entity.Property(e => e.IdTipocliente)
                .ValueGeneratedNever()
                .HasColumnName("id_tipocliente");
            entity.Property(e => e.NomTipocliente)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_tipocliente");
        });

        modelBuilder.Entity<TipoComercializacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoComercializacion).HasName("PK_TIPO_COMERCIALIZACION");

            entity.ToTable("tipo_comercializacion");

            entity.Property(e => e.IdTipoComercializacion).HasColumnName("id_tipo_comercializacion");
            entity.Property(e => e.NomTipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nom_tipo");
        });

        modelBuilder.Entity<TipoFormaPago>(entity =>
        {
            entity.HasKey(e => e.IdTipoForma).HasName("PK__tipo_for__B36E7C412A4C16B5");

            entity.ToTable("tipo_forma_pago");

            entity.Property(e => e.IdTipoForma).HasColumnName("id_tipo_forma");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndEfvoDoc).HasColumnName("ind_efvo_doc");
            entity.Property(e => e.IndUnico).HasColumnName("ind_unico");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoForma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipo_forma");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdTipomov).HasName("PK_TIPO_MOVIMIENTO");

            entity.ToTable("tipo_movimiento", tb => tb.HasTrigger("ti_Tipo_Movimiento"));

            entity.Property(e => e.IdTipomov)
                .ValueGeneratedNever()
                .HasColumnName("id_tipomov");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdTipoMovGrupo).HasColumnName("id_TipoMovGrupo");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IndEntradasalida).HasColumnName("ind_entradasalida");
            entity.Property(e => e.IndManauto).HasColumnName("ind_manauto");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipomov)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipomov");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TipoMovimientos)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_MOV_REFERENCE_DOCUMENT");

            entity.HasOne(d => d.IdTipoMovGrupoNavigation).WithMany(p => p.TipoMovimientos)
                .HasForeignKey(d => d.IdTipoMovGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_MOV_REFERENCE_GRUPO");
        });

        modelBuilder.Entity<TipoMovimientoCaja>(entity =>
        {
            entity.HasKey(e => e.IdTipomovCaja).HasName("PK__tipo_mov__0548E81460A82766");

            entity.ToTable("tipo_movimiento_caja");

            entity.Property(e => e.IdTipomovCaja)
                .ValueGeneratedNever()
                .HasColumnName("id_tipomov_caja");
            entity.Property(e => e.AbrevTipomovCaja)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_tipomov_caja");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdMovTraslado).HasColumnName("id_mov_traslado");
            entity.Property(e => e.IdTipomovCajaAnula).HasColumnName("id_tipomov_caja_anula");
            entity.Property(e => e.IndEntradasalida).HasColumnName("ind_entradasalida");
            entity.Property(e => e.IndManauto).HasColumnName("ind_manauto");
            entity.Property(e => e.IndTipoCaja).HasColumnName("ind_tipo_caja");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipomovCaja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipomov_caja");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoMovimientoCajaTipoPago>(entity =>
        {
            entity.HasKey(e => new { e.IdTipomovCaja, e.IdTipoForma });

            entity.ToTable("tipo_movimiento_caja_tipo_pago");

            entity.Property(e => e.IdTipomovCaja).HasColumnName("id_tipomov_caja");
            entity.Property(e => e.IdTipoForma).HasColumnName("id_tipo_forma");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipoFormaNavigation).WithMany(p => p.TipoMovimientoCajaTipoPagos)
                .HasForeignKey(d => d.IdTipoForma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_MOV_CAJA_TP_REF_TIPO_FORMA");

            entity.HasOne(d => d.IdTipomovCajaNavigation).WithMany(p => p.TipoMovimientoCajaTipoPagos)
                .HasForeignKey(d => d.IdTipomovCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_MOV_CAJA_TP_REF_TIPO_MOV_CAJA");
        });

        modelBuilder.Entity<TipoMovimientoCxc>(entity =>
        {
            entity.HasKey(e => e.IdTipomovCxc).HasName("PK_TIPO_MOVIMIENTO_CXC");

            entity.ToTable("tipo_movimiento_cxc", tb => tb.HasTrigger("ti_Tipo_Movimiento_cxc"));

            entity.Property(e => e.IdTipomovCxc)
                .ValueGeneratedNever()
                .HasColumnName("id_tipomov_cxc");
            entity.Property(e => e.AbrevTipomovCxc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_tipomov_cxc");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaModifica)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifica");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdTipomovCxcAnula).HasColumnName("id_tipomov_cxc_anula");
            entity.Property(e => e.IndAuto).HasColumnName("ind_auto");
            entity.Property(e => e.IndEntradasalida).HasColumnName("ind_entradasalida");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipomovCxc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipomov_cxc");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoMovimientoGrupo>(entity =>
        {
            entity.HasKey(e => e.IdTipoMovGrupo).HasName("PK_TIPO_MOVIMIENTO_GRUPO");

            entity.ToTable("tipo_movimiento_grupo");

            entity.Property(e => e.IdTipoMovGrupo)
                .ValueGeneratedNever()
                .HasColumnName("id_TipoMovGrupo");
            entity.Property(e => e.AbrevTipoMovGpo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("abrev_TipoMovGpo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndManauto).HasColumnName("ind_manauto");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoMovGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_TipoMovGrupo");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoMovimientoSocio>(entity =>
        {
            entity.HasKey(e => e.IdTipomovSocio).HasName("PK_TIPO_MOVIMIENTO_SOCIO");

            entity.ToTable("tipo_movimiento_socio");

            entity.Property(e => e.IdTipomovSocio)
                .ValueGeneratedNever()
                .HasColumnName("id_tipomov_socio");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaModifica)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_modifica");
            entity.Property(e => e.IdTipomovSocioAnula).HasColumnName("id_tipomov_socio_anula");
            entity.Property(e => e.IndSistema).HasColumnName("ind_sistema");
            entity.Property(e => e.IndTipoAfectacion).HasColumnName("ind_tipo_afectacion");
            entity.Property(e => e.IndTipoPrograma).HasColumnName("ind_tipo_programa");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipomovSocio)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("nom_tipomov_socio");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoOfertaFecha>(entity =>
        {
            entity.HasKey(e => e.IdTipoFecha).HasName("PK__tipo_ofe__3E1CD26E6F7569AA");

            entity.ToTable("tipo_oferta_fecha");

            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.AbrevTipoFecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("abrev_tipo_fecha");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoFecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nom_tipo_fecha");
        });

        modelBuilder.Entity<TipoOfertum>(entity =>
        {
            entity.HasKey(e => e.IdTipoOferta).HasName("PK__tipo_ofe__EA7B44966C0EED1A");

            entity.ToTable("tipo_oferta");

            entity.Property(e => e.IdTipoOferta).HasColumnName("id_tipo_oferta");
            entity.Property(e => e.AbrevTipoOferta)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Abrev_Tipo_Oferta");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoOferta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nom_Tipo_Oferta");
        });

        modelBuilder.Entity<TipoPrecio>(entity =>
        {
            entity.HasKey(e => e.IdTipoprecio).HasName("PK_TIPO_PRECIO");

            entity.ToTable("tipo_precio");

            entity.Property(e => e.IdTipoprecio)
                .ValueGeneratedNever()
                .HasColumnName("id_tipoprecio");
            entity.Property(e => e.AbrevTipoprecio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_tipoprecio");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndOrden).HasColumnName("ind_orden");
            entity.Property(e => e.IndRango).HasColumnName("ind_rango");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoprecio)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_tipoprecio");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoProveedor>(entity =>
        {
            entity.HasKey(e => e.IdTipoProv).HasName("PK_TIPO_PROVEEDOR");

            entity.ToTable("tipo_proveedor");

            entity.Property(e => e.IdTipoProv)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_prov");
            entity.Property(e => e.AbrevTipoprov)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("abrev_tipoprov");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipoprov)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipoprov");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoTarjetaCf>(entity =>
        {
            entity.HasKey(e => e.IdTipoTarjeta).HasName("PK_TIPO_TARJETA_CF");

            entity.ToTable("tipo_tarjeta_cf");

            entity.Property(e => e.IdTipoTarjeta).HasColumnName("id_tipo_tarjeta");
            entity.Property(e => e.AbrevTipotarjeta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abrev_tipotarjeta");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomTipotarjeta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_tipotarjeta");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoTicket>(entity =>
        {
            entity.HasKey(e => e.IdTipoTicket).HasName("PK_TIPO_TICKET");

            entity.ToTable("tipo_ticket");

            entity.Property(e => e.IdTipoTicket)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_ticket");
            entity.Property(e => e.DescripcionTipo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("descripcion_tipo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TipoTicketDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoTicket, e.IdTicket }).HasName("PK_TIPO_TICKET_DETALLE");

            entity.ToTable("tipo_ticket_detalle");

            entity.Property(e => e.IdTipoTicket).HasColumnName("id_tipo_ticket");
            entity.Property(e => e.IdTicket).HasColumnName("id_ticket");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.TipoDescripcion).HasColumnName("tipo_descripcion");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipoTicketNavigation).WithMany(p => p.TipoTicketDetalles)
                .HasForeignKey(d => d.IdTipoTicket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TICKET_D_REF_1619_TIPO_TIC");
        });

        modelBuilder.Entity<TipoTicketUnidad>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoTicket, e.IdUniOper }).HasName("PK_TIPO_TICKET_UNIDAD");

            entity.ToTable("tipo_ticket_unidad");

            entity.Property(e => e.IdTipoTicket).HasColumnName("id_tipo_ticket");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipoTicketNavigation).WithMany(p => p.TipoTicketUnidads)
                .HasForeignKey(d => d.IdTipoTicket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPO_TIC_REF_1624_TIPO_TIC");
        });

        modelBuilder.Entity<TipoUnidadOperativa>(entity =>
        {
            entity.HasKey(e => e.IdTipounioper).HasName("PK_TIPO_UNIDAD_OPERATIVA");

            entity.ToTable("tipo_unidad_operativa");

            entity.Property(e => e.IdTipounioper)
                .ValueGeneratedNever()
                .HasColumnName("id_tipounioper");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndConsolidar)
                .HasDefaultValue((byte)1)
                .HasColumnName("ind_consolidar");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.IndVolumen)
                .HasDefaultValue((byte)1)
                .HasColumnName("ind_volumen");
            entity.Property(e => e.NomTipounioper)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_tipounioper");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<TmpArticulo>(entity =>
        {
            entity.HasKey(e => new { e.IdSpid, e.Sku });

            entity.ToTable("tmp_articulo");

            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.AbrevUnidadMedida)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev_unidad_medida");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdDivision).HasColumnName("id_division");
            entity.Property(e => e.IdFamilia).HasColumnName("id_familia");
            entity.Property(e => e.IdSubdivision).HasColumnName("id_subdivision");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.NomDivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_division");
            entity.Property(e => e.NomFamilia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_familia");
            entity.Property(e => e.NomSubdivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_subdivision");
            entity.Property(e => e.NomUnidadMedida)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nom_unidad_medida");
        });

        modelBuilder.Entity<TmpCambioPrecio>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdSpid });

            entity.ToTable("tmp_cambio_precio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DescuentoO1).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.DescuentoO2).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.DescuentoO3).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.Existencia)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("existencia");
            entity.Property(e => e.FechaFinO1).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFinO2).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFinO3).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaIniO1).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaIniO2).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaIniO3).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicioPrecio)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_inicio_precio");
            entity.Property(e => e.FechaP1).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaP2).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaP3).HasColumnType("smalldatetime");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdImpuestoO).HasColumnName("id_impuesto_o");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IndAgregado).HasColumnName("ind_agregado");
            entity.Property(e => e.IndAplicar).HasColumnName("ind_aplicar");
            entity.Property(e => e.IndCancelar).HasColumnName("ind_cancelar");
            entity.Property(e => e.IndModificado).HasColumnName("ind_modificado");
            entity.Property(e => e.Margen1)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen1");
            entity.Property(e => e.Margen10)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen10");
            entity.Property(e => e.Margen10Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen10_fam");
            entity.Property(e => e.Margen1Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen1_fam");
            entity.Property(e => e.Margen2)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen2");
            entity.Property(e => e.Margen2Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen2_fam");
            entity.Property(e => e.Margen3)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen3");
            entity.Property(e => e.Margen3Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen3_fam");
            entity.Property(e => e.Margen4)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen4");
            entity.Property(e => e.Margen4Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen4_fam");
            entity.Property(e => e.Margen5)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen5");
            entity.Property(e => e.Margen5Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen5_fam");
            entity.Property(e => e.Margen6)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen6");
            entity.Property(e => e.Margen6Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen6_fam");
            entity.Property(e => e.Margen7)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen7");
            entity.Property(e => e.Margen7Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen7_fam");
            entity.Property(e => e.Margen8)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen8");
            entity.Property(e => e.Margen8Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen8_fam");
            entity.Property(e => e.Margen9)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen9");
            entity.Property(e => e.Margen9Fam)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("margen9_fam");
            entity.Property(e => e.NombreLista)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_lista");
            entity.Property(e => e.Precio1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio1");
            entity.Property(e => e.Precio10)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio10");
            entity.Property(e => e.Precio10O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio10_o");
            entity.Property(e => e.Precio1O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio1_o");
            entity.Property(e => e.Precio2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio2");
            entity.Property(e => e.Precio2O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio2_o");
            entity.Property(e => e.Precio3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio3");
            entity.Property(e => e.Precio3O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio3_o");
            entity.Property(e => e.Precio4)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio4");
            entity.Property(e => e.Precio4O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio4_o");
            entity.Property(e => e.Precio5)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio5");
            entity.Property(e => e.Precio5O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio5_o");
            entity.Property(e => e.Precio6)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio6");
            entity.Property(e => e.Precio6O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio6_o");
            entity.Property(e => e.Precio7)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio7");
            entity.Property(e => e.Precio7O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio7_o");
            entity.Property(e => e.Precio8)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio8");
            entity.Property(e => e.Precio8O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio8_o");
            entity.Property(e => e.Precio9)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio9");
            entity.Property(e => e.Precio9O)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio9_o");
            entity.Property(e => e.PrecioO1)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precioO1");
            entity.Property(e => e.PrecioO2)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precioO2");
            entity.Property(e => e.PrecioO3)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precioO3");
            entity.Property(e => e.PrecioSinIva1)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva1");
            entity.Property(e => e.PrecioSinIva10)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva10");
            entity.Property(e => e.PrecioSinIva2)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva2");
            entity.Property(e => e.PrecioSinIva3)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva3");
            entity.Property(e => e.PrecioSinIva4)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva4");
            entity.Property(e => e.PrecioSinIva5)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva5");
            entity.Property(e => e.PrecioSinIva6)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva6");
            entity.Property(e => e.PrecioSinIva7)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva7");
            entity.Property(e => e.PrecioSinIva8)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva8");
            entity.Property(e => e.PrecioSinIva9)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva9");
            entity.Property(e => e.Precioant1)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precioant1");
            entity.Property(e => e.Precioant2)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precioant2");
            entity.Property(e => e.Precioant3)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precioant3");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.StrModificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("str_modificado");
            entity.Property(e => e.TipoRegistro).HasColumnName("tipo_registro");
            entity.Property(e => e.ValorImpuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("valor_impuesto");
        });

        modelBuilder.Entity<TmpCfdCliente>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id }).HasName("PK_CFD_TMP_CLIENTE");

            entity.ToTable("tmp_cfd_cliente");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Colonia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CvePais)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_pais");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(140)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroExterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc");
        });

        modelBuilder.Entity<TmpCfdEmisor>(entity =>
        {
            entity.HasKey(e => new { e.IdProceso, e.IdUniOper }).HasName("PK_CFD_TMP_EMISOR");

            entity.ToTable("tmp_cfd_emisor");

            entity.Property(e => e.IdUniOper).HasColumnName("Id_UniOper");
            entity.Property(e => e.CvePais)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_pais");
            entity.Property(e => e.CveRegimenFiscal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_RegimenFiscal");
            entity.Property(e => e.EmiCiudad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmiColonia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmiDireccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmiEstado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmiNombre)
                .HasMaxLength(140)
                .IsUnicode(false);
            entity.Property(e => e.EmiNumeroExterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmiNumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmiPais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmiRfc)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmiTelefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ExpCiudad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExpColonia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpDireccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExpEstado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExpLocalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpNombre)
                .HasMaxLength(140)
                .IsUnicode(false);
            entity.Property(e => e.ExpNumeroExterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpNumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpPais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExpTelefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PacIdentificador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pac_identificador");
            entity.Property(e => e.PacPassword)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pac_password");
            entity.Property(e => e.PacUser)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pac_user");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("regimen_fiscal");
        });

        modelBuilder.Entity<TmpCfdFactura>(entity =>
        {
            entity.HasKey(e => new { e.IdProceso, e.Id });

            entity.ToTable("tmp_cfd_factura");

            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CostoImpuesto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoSubtotal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoTotal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Descuento).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdTipoFactura).HasColumnName("id_TipoFactura");
            entity.Property(e => e.IdUniOper).HasColumnName("Id_UniOper");
            entity.Property(e => e.IdUniOperFolio).HasColumnName("Id_UniOper_Folio");
            entity.Property(e => e.IdUniOperSerie).HasColumnName("Id_UniOper_Serie");
            entity.Property(e => e.IdUnioperVenta).HasColumnName("id_unioper_venta");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ImpuestoNeto).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.IndCfdi).HasColumnName("ind_cfdi");
            entity.Property(e => e.IndEstatusFactura).HasColumnName("ind_estatus_factura");
            entity.Property(e => e.IndOrigen).HasColumnName("ind_origen");
            entity.Property(e => e.IndTipoFactura).HasColumnName("ind_tipo_factura");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.NoVersion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("no_version");
            entity.Property(e => e.NomFormaPago)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nom_forma_pago");
            entity.Property(e => e.NomMoneda)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_moneda");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.PorcjDesc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("porcj_desc");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubTotal).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SubTotalNeto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TotalNeto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UsoCfdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uso_cfdi");
            entity.Property(e => e.Usuario)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.ValorTipoCambio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valor_tipo_cambio");
        });

        modelBuilder.Entity<TmpCfdFacturaCadena>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id, e.Idorden });

            entity.ToTable("tmp_cfd_factura_cadena");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idorden).HasColumnName("idorden");
            entity.Property(e => e.Cadena)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("cadena");
        });

        modelBuilder.Entity<TmpCfdFacturaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id, e.IdOrden });

            entity.ToTable("tmp_cfd_factura_detalle");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdOrden).HasColumnName("id_orden");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.ClaveImpuestoSat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clave_impuesto_sat");
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Costo).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoImporte).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoImpuesto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoSiva)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("Costo_siva");
            entity.Property(e => e.CveProdServ)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_ProdServ");
            entity.Property(e => e.CveUnidadMedida)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cve_unidad_medida");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.Idcliente)
                .HasDefaultValue(0)
                .HasColumnName("idcliente");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ImporteImpuesto).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.Medida)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NomArticulo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nom_articulo");
            entity.Property(e => e.NomFormaPago)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nom_forma_pago");
            entity.Property(e => e.NomImpuesto)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.PorcjDesc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Porcj_desc");
            entity.Property(e => e.Precio).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.PrecioSiva)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("Precio_siva");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.SkuInterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sku_interno");
            entity.Property(e => e.TasaImpuesto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactorSat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo_factor_sat");
        });

        modelBuilder.Entity<TmpCfdFacturaFormapago>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id, e.IdFormaPago });

            entity.ToTable("tmp_cfd_factura_formapago");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idcliente).HasColumnName("idcliente");
            entity.Property(e => e.IndCuenta).HasColumnName("ind_cuenta");
            entity.Property(e => e.IndSeleccion).HasColumnName("ind_seleccion");
            entity.Property(e => e.NomFormaPago)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TmpCfdFacturaImpuesto>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id, e.IdImpuesto });

            entity.ToTable("tmp_cfd_factura_impuesto");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClaveImpuestoSat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clave_impuesto_sat");
            entity.Property(e => e.ImporteImpuesto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ImporteVenta).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.NomImpuesto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TasaImpuesto).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TipoFactorSat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo_factor_sat");
        });

        modelBuilder.Entity<TmpCfdFacturaPosXml>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id, e.Idorden });

            entity.ToTable("tmp_cfd_factura_pos_xml");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idorden).HasColumnName("idorden");
            entity.Property(e => e.Stringxml)
                .HasMaxLength(7000)
                .IsUnicode(false)
                .HasColumnName("stringxml");
        });

        modelBuilder.Entity<TmpCfdFacturaSello>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id });

            entity.ToTable("tmp_cfd_factura_sello");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Error)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("error");
            entity.Property(e => e.SCertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sCertificado");
            entity.Property(e => e.Sello)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("sello");
            entity.Property(e => e.Timbrefecha).HasColumnType("datetime");
            entity.Property(e => e.Timbrenocertsat)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Timbresellosat)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Timbreuuid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timbreversion)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpCfdTicket>(entity =>
        {
            entity.HasKey(e => new { e.Idproceso, e.Id, e.IdUniOper, e.IdVenta, e.IdTipo });

            entity.ToTable("tmp_cfd_ticket");

            entity.Property(e => e.Idproceso).HasColumnName("idproceso");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Idcliente).HasColumnName("idcliente");
            entity.Property(e => e.NomFormaPago)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nom_forma_pago");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.PorcjDesc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("porcj_desc");
        });

        modelBuilder.Entity<TmpListaPrecio>(entity =>
        {
            entity.HasKey(e => new { e.IdSpid, e.IdLista });

            entity.ToTable("tmp_lista_precio");

            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.NomLista)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_lista");
        });

        modelBuilder.Entity<TmpOfertaClte>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdSpid });

            entity.ToTable("tmp_oferta_clte");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(13, 6)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(13, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Descuento1)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("descuento1");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.HoraFin).HasColumnName("hora_fin");
            entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");
            entity.Property(e => e.HoraMinima).HasColumnName("hora_minima");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdEstatusOferta).HasColumnName("id_estatus_oferta");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.IdTipoOferta).HasColumnName("id_tipo_oferta");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUniOperFolio).HasColumnName("id_uni_oper_folio");
            entity.Property(e => e.IndAgregado).HasColumnName("ind_agregado");
            entity.Property(e => e.IndAplicar).HasColumnName("ind_aplicar");
            entity.Property(e => e.IndCancelar).HasColumnName("ind_cancelar");
            entity.Property(e => e.IndIncluirOferta).HasColumnName("ind_incluir_oferta");
            entity.Property(e => e.IndModificado).HasColumnName("ind_modificado");
            entity.Property(e => e.IndOfertaHora).HasColumnName("ind_oferta_hora");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("margen");
            entity.Property(e => e.MargenO)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("margen_o");
            entity.Property(e => e.MargenVig)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("margen_vig");
            entity.Property(e => e.NombreUniOper)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_uni_oper");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioOferta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_oferta");
            entity.Property(e => e.PrecioOfertaO)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_oferta_o");
            entity.Property(e => e.PrecioOfertaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_oferta_sin_iva");
            entity.Property(e => e.PrecioOfertaVig)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_oferta_vig");
            entity.Property(e => e.PrecioSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.TipoRegistro).HasColumnName("tipo_registro");
            entity.Property(e => e.ValorImpuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("valor_impuesto");
        });

        modelBuilder.Entity<TmpOfertaClteCorte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_oferta_clte_corte");

            entity.Property(e => e.Estatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaFin)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.HoraFin).HasColumnName("hora_fin");
            entity.Property(e => e.HoraIni).HasColumnName("hora_ini");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdFolio).HasColumnName("id_folio");
            entity.Property(e => e.IdFolioDet).HasColumnName("id_folio_det");
            entity.Property(e => e.IdFolioDetRef).HasColumnName("id_folio_det_ref");
            entity.Property(e => e.IdFolioRef).HasColumnName("id_folio_ref");
            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.IdUniOperFolio).HasColumnName("id_uni_oper_folio");
            entity.Property(e => e.IdUniOperFolioRef).HasColumnName("id_uni_oper_folio_ref");
            entity.Property(e => e.TipoOper).HasColumnName("tipo_oper");
        });

        modelBuilder.Entity<TmpProveedor>(entity =>
        {
            entity.HasKey(e => new { e.IdSpid, e.IdProveedor });

            entity.ToTable("tmp_proveedor");

            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_comercial");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("razon_social");
            entity.Property(e => e.RfcProveedor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc_proveedor");
        });

        modelBuilder.Entity<TmpUnidadOperativa>(entity =>
        {
            entity.HasKey(e => new { e.IdSpid, e.IdUniOper });

            entity.ToTable("tmp_unidad_operativa");

            entity.Property(e => e.IdSpid).HasColumnName("id_spid");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdTipoUniOper).HasColumnName("id_tipo_uni_oper");
            entity.Property(e => e.NombreTipoUniOper)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_tipo_uni_oper");
            entity.Property(e => e.NombreUniOper)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_uni_oper");
        });

        modelBuilder.Entity<Transformado>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_Transformado");

            entity.ToTable("transformado");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.FolioMovComp).HasColumnName("folio_mov_comp");
            entity.Property(e => e.FolioMovCompAnula).HasColumnName("folio_mov_comp_anula");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdTipomovComp).HasColumnName("id_tipomov_comp");
            entity.Property(e => e.IdTipomovCompAnula).HasColumnName("id_tipomov_comp_anula");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.Transformados)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFOR_REFERENCE_TIPO_MOV");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Transformados)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFOR_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<TransformadoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_Transformado_DET");

            entity.ToTable("Transformado_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.TransformadoDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transformado_det_impuesto");

            entity.HasOne(d => d.Transformado).WithMany(p => p.TransformadoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFOR_REFERENCE_TRANSFOR");

            entity.HasOne(d => d.Inventario).WithMany(p => p.TransformadoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFOR_REFERENCE_INVENTAR");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.TransformadoDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transformado_det_articulo_empaque");
        });

        modelBuilder.Entity<TransformadoDetComp>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku, e.SkuTransformado }).HasName("PK_Transformado_DET_comp");

            entity.ToTable("Transformado_det_comp");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.SkuTransformado).HasColumnName("sku_transformado");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadReceta)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_receta");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.TransformadoDetComps)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transformado_det_comp_impuesto");

            entity.HasOne(d => d.Inventario).WithMany(p => p.TransformadoDetComps)
                .HasForeignKey(d => new { d.IdUniOper, d.SkuTransformado })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transformado_det_comp_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.TransformadoDetComps)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.SkuTransformado, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transformado_det_comp_articulo_empaque");

            entity.HasOne(d => d.TransformadoDet).WithMany(p => p.TransformadoDetComps)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSCOMP_REFERENCE_TRANSFOR_DET");
        });

        modelBuilder.Entity<TransformadoDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.Serie, e.IdMovimiento }).HasName("PK_Transformado_DET_SERIES");

            entity.ToTable("Transformado_det_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");

            entity.HasOne(d => d.TransformadoDet).WithMany(p => p.TransformadoDetSeries)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFOR_REF_TRANSFOR");
        });

        modelBuilder.Entity<Traslado>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento }).HasName("PK_TRASLADO");

            entity.ToTable("Traslado");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaInterfase)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_interfase");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioInterfase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Folio_Interfase");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdMovimientoReq).HasColumnName("id_movimiento_req");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdUniOperDestino).HasColumnName("id_uni_oper_destino");
            entity.Property(e => e.IdUniOperReq).HasColumnName("id_uni_oper_req");
            entity.Property(e => e.IndInterfase).HasColumnName("ind_interfase");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.TrasladoIdUniOperNavigations)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traslado_unidad_operativa");

            entity.HasOne(d => d.IdUniOperDestinoNavigation).WithMany(p => p.TrasladoIdUniOperDestinoNavigations)
                .HasForeignKey(d => d.IdUniOperDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traslado_unidad_operativa1");
        });

        modelBuilder.Entity<TrasladoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_TRASLADO_DET");

            entity.ToTable("traslado_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadFaltante)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_faltante");
            entity.Property(e => e.CantidadFaltanteBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_faltante_base");
            entity.Property(e => e.CantidadRecibida)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_recibida");
            entity.Property(e => e.CantidadRecibidaBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_recibida_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IndOriginal)
                .HasDefaultValue((byte)1, "DF_traslado_det_ind_original")
                .HasColumnName("ind_original");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.TrasladoDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_det_impuesto");

            entity.HasOne(d => d.Traslado).WithMany(p => p.TrasladoDets)
                .HasForeignKey(d => new { d.IdUniOper, d.IdMovimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_det_Traslado");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.TrasladoDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_det_articulo_empaque");
        });

        modelBuilder.Entity<TrasladoDetSerie>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.Sku, e.Serie, e.IdMovimiento }).HasName("PK_TRASLADO_DET_SERIES");

            entity.ToTable("traslado_det_serie");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Serie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("serie");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
        });

        modelBuilder.Entity<TrasladoRecibo>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdUniOper }).HasName("PK_TRASLADO_RECIBO");

            entity.ToTable("traslado_recibo");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdTraslado).HasColumnName("id_traslado");
            entity.Property(e => e.IdUniOperOrigen).HasColumnName("id_uni_oper_origen");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_anula");
            entity.Property(e => e.UsuarioMovimiento)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_movimiento");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.TrasladoRecibos)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_recibo_unidad_operativa");

            entity.HasOne(d => d.Traslado).WithMany(p => p.TrasladoRecibos)
                .HasForeignKey(d => new { d.IdUniOperOrigen, d.IdTraslado })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_recibo_Traslado");
        });

        modelBuilder.Entity<TrasladoReciboDet>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdMovimiento, e.Sku }).HasName("PK_TRASLADO_RECIBO_DET");

            entity.ToTable("traslado_recibo_det");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadFaltante)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_faltante");
            entity.Property(e => e.CantidadFaltanteBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_faltante_base");
            entity.Property(e => e.CantidadTotal)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_total");
            entity.Property(e => e.CantidadTotalBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_total_base");
            entity.Property(e => e.CantidadTraslado)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_traslado");
            entity.Property(e => e.CantidadTrasladoBase)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad_traslado_base");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdMotivo).HasColumnName("id_motivo");
            entity.Property(e => e.IdMovimientoMotivo).HasColumnName("id_movimiento_motivo");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IndAfectaInv).HasColumnName("ind_afecta_inv");
            entity.Property(e => e.IndOriginal)
                .HasDefaultValue((byte)1, "DF_traslado_recibo_det_ind_original")
                .HasColumnName("ind_original");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("precio_base");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.TrasladoReciboDets)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_recibo_det_impuesto");

            entity.HasOne(d => d.TrasladoRecibo).WithMany(p => p.TrasladoReciboDets)
                .HasForeignKey(d => new { d.IdMovimiento, d.IdUniOper })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_recibo_det_traslado_recibo");

            entity.HasOne(d => d.Inventario).WithMany(p => p.TrasladoReciboDets)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_recibo_det_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.TrasladoReciboDets)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_traslado_recibo_det_articulo_empaque");
        });

        modelBuilder.Entity<UnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.IdUnidadMedida).HasName("PK_UNIDAD_MEDIDA");

            entity.ToTable("unidad_medida");

            entity.Property(e => e.IdUnidadMedida)
                .ValueGeneratedNever()
                .HasColumnName("id_unidad_medida");
            entity.Property(e => e.AbrevUnimedida)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("abrev_unimedida");
            entity.Property(e => e.AbrevUnimedidaExt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("abrev_unimedida_ext");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdUnidadMedidaSat).HasColumnName("id_unidad_medida_sat");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Nodecimal).HasColumnName("nodecimal");
            entity.Property(e => e.NomUnidadmedida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_unidadmedida");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<UnidadOperativa>(entity =>
        {
            entity.HasKey(e => e.IdUniOper).HasName("PK_UNIDAD_OPERATIVA");

            entity.ToTable("unidad_operativa", tb => tb.HasTrigger("ti_Unidad_Operativa"));

            entity.Property(e => e.IdUniOper)
                .ValueGeneratedNever()
                .HasColumnName("id_uni_oper");
            entity.Property(e => e.AbrevUnioper)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("abrev_unioper");
            entity.Property(e => e.CalleYNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("calle_y_numero");
            entity.Property(e => e.CfdArchivoCer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfd_archivo_cer");
            entity.Property(e => e.CfdArchivoKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfd_archivo_key");
            entity.Property(e => e.CfdClavePrivada)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfd_clave_privada");
            entity.Property(e => e.CfdFolderFirmas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfd_folder_firmas");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))", "DF__unidad_op__codig__0B679CE2")
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuenta_contable");
            entity.Property(e => e.DiasApertura).HasColumnName("dias_apertura");
            entity.Property(e => e.Entrecalles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("entrecalles");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTipounioper).HasColumnName("id_tipounioper");
            entity.Property(e => e.IdZona).HasColumnName("id_zona");
            entity.Property(e => e.IndLocal).HasColumnName("ind_local");
            entity.Property(e => e.IndPrincipal).HasColumnName("ind_principal");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomUnioper)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_unioper");
            entity.Property(e => e.NumeroExterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_exterior");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.SubcuentaContable)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("subcuenta_contable");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_1");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_2");
            entity.Property(e => e.TelefonoFax)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono_fax");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.UnidadOperativas)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_O_REFERENCE_CIUDAD");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.UnidadOperativas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_O_REFERENCE_EMPRESA");

            entity.HasOne(d => d.IdListaNavigation).WithMany(p => p.UnidadOperativas)
                .HasForeignKey(d => d.IdLista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_O_REFERENCE_LISTA_PRECIO");

            entity.HasOne(d => d.IdTipounioperNavigation).WithMany(p => p.UnidadOperativas)
                .HasForeignKey(d => d.IdTipounioper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_O_REFERENCE_TIPO_UNI");
        });

        modelBuilder.Entity<UnidadOperativaClienteExt>(entity =>
        {
            entity.HasKey(e => e.IdUniOper);

            entity.ToTable("unidad_operativa_cliente_ext");

            entity.Property(e => e.IdUniOper)
                .ValueGeneratedNever()
                .HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<UnidadOperativaListaPrecio>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdLista }).HasName("PK_UNIDAD_OPERATIVA_LISTA_PREC");

            entity.ToTable("unidad_operativa_lista_precio");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IndDefault).HasColumnName("ind_default");
            entity.Property(e => e.IndMinrepcomision).HasColumnName("ind_minrepcomision");

            entity.HasOne(d => d.IdListaNavigation).WithMany(p => p.UnidadOperativaListaPrecios)
                .HasForeignKey(d => d.IdLista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_O_REFERENCE_LISTA_PR");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.UnidadOperativaListaPrecios)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_O_REFERENCE_UNIDAD_O");
        });

        modelBuilder.Entity<UnidadOperativaZona>(entity =>
        {
            entity.HasKey(e => e.IdZona).HasName("PK_UNIDAD_OPERATIVA_ZONA");

            entity.ToTable("unidad_operativa_zona");

            entity.Property(e => e.IdZona)
                .ValueGeneratedNever()
                .HasColumnName("id_zona");
            entity.Property(e => e.AbrevZona)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("abrev_zona");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.NomZona)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nom_zona");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("pk_usuario");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.ClaveUsuario, "AK_CVE_PASSWORD_USUARIO").IsUnique();

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.AbrevUsuario)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abrev_usuario");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.ClaveUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_usuario");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FechaVigPassword)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_vig_password");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdUo).HasColumnName("id_uo");
            entity.Property(e => e.IndAdministrador).HasColumnName("ind_administrador");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");
        });

        modelBuilder.Entity<UsuarioDescuento>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdDescuento }).HasName("PK_USUARIO_DESCUENTO");

            entity.ToTable("usuario_descuento");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdDescuento).HasColumnName("id_descuento");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdDescuentoNavigation).WithMany(p => p.UsuarioDescuentos)
                .HasForeignKey(d => d.IdDescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__REF_932_DESCUENT");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioDescuentos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__REF_928_USUARIO");
        });

        modelBuilder.Entity<UsuarioPermiso>(entity =>
        {
            entity.HasKey(e => new { e.IdPermiso, e.IdUsuario });

            entity.ToTable("usuario_permiso");

            entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdPermisoNavigation).WithMany(p => p.UsuarioPermisos)
                .HasForeignKey(d => d.IdPermiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuario_permiso_permiso");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioPermisos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuario_permiso_usuario");
        });

        modelBuilder.Entity<UsuarioUnidadOperativa>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdUniOper }).HasName("PK_USUARIO_UNIDAD_OPERATIVA");

            entity.ToTable("usuario_unidad_operativa");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IndOpera).HasColumnName("ind_opera");
            entity.Property(e => e.IndVigente).HasColumnName("ind_vigente");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_alta");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("usuario_modifica");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.UsuarioUnidadOperativas)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__REFERENCE_UNIDAD_O");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioUnidadOperativas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__REFERENCE_USUARIO");
        });

        modelBuilder.Entity<VentaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdVenta, e.Orden }).HasName("PK_VENTA_DETALLE");

            entity.ToTable("venta_detalle");

            entity.HasIndex(e => e.Sku, "IX_Venta_detalle_sku");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadEmpaque)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("cantidad_empaque");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoBaseConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base_con_iva");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.DescuentoGralPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_gral_porc");
            entity.Property(e => e.DescuentoPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_porc");
            entity.Property(e => e.DescuentoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("descuento_sin_iva");
            entity.Property(e => e.DescuentoSupPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_sup_porc");
            entity.Property(e => e.DescuentoSupTipo).HasColumnName("descuento_sup_tipo");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.IndTipoPrecio).HasColumnName("ind_tipo_precio");
            entity.Property(e => e.PrecioCliente)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_cliente");
            entity.Property(e => e.PrecioClienteSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente_sin_iva");
            entity.Property(e => e.PrecioDescGral)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_gral");
            entity.Property(e => e.PrecioDescGralSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_gral_sin_iva");
            entity.Property(e => e.PrecioDescSup)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_sup");
            entity.Property(e => e.PrecioDescSupSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_sup_sin_iva");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto");
            entity.Property(e => e.PrecioNetoBase)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto_base");
            entity.Property(e => e.PrecioNetoBaseSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_base_sin_iva");
            entity.Property(e => e.PrecioNetoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_sin_iva");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.PrecioVentaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta_sin_iva");
            entity.Property(e => e.PrecioVolumen)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_volumen");
            entity.Property(e => e.PrecioVolumenSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_volumen_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_impuesto");

            entity.HasOne(d => d.Ventum).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.IdVenta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTDET_REF_VENTA");

            entity.HasOne(d => d.Inventario).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.VentaDetalles)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_articulo_empaque");
        });

        modelBuilder.Entity<VentaDetalleComp>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdVenta, e.Orden, e.Sku, e.SkuTransformado }).HasName("PK_VENTA_DETALLE_COMP");

            entity.ToTable("venta_detalle_comp");

            entity.HasIndex(e => e.Sku, "IX_Venta_detalle_comp_sku");

            entity.HasIndex(e => e.SkuTransformado, "IX_Venta_detalle_comp_sku_tran");

            entity.HasIndex(e => new { e.IdUniOper, e.IdVenta, e.Orden }, "IX_Venta_detalle_comp_venta");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.SkuTransformado).HasColumnName("sku_transformado");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadProd)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_prod");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.PrecioCliente)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente");
            entity.Property(e => e.PrecioClienteSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente_sin_iva");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.PrecioVentaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta_sin_iva");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.VentaDetalleComps)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_comp_impuesto");

            entity.HasOne(d => d.Inventario).WithMany(p => p.VentaDetalleComps)
                .HasForeignKey(d => new { d.IdUniOper, d.SkuTransformado })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTDETCOMP_REF_ARTICULO");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.VentaDetalleComps)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.SkuTransformado, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_comp_articulo_empaque");
        });

        modelBuilder.Entity<VentaDetalleCon>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdVenta, e.Orden }).HasName("PK_VENTA_DETALLE_CONS");

            entity.ToTable("venta_detalle_cons");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.CantidadEmpaque)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("cantidad_empaque");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoBaseConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_base_con_iva");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.DescuentoGralPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_gral_porc");
            entity.Property(e => e.DescuentoPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_porc");
            entity.Property(e => e.DescuentoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("descuento_sin_iva");
            entity.Property(e => e.DescuentoSupPorc)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("descuento_sup_porc");
            entity.Property(e => e.DescuentoSupTipo).HasColumnName("descuento_sup_tipo");
            entity.Property(e => e.IdCodigoBarras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_codigo_barras");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.IndTipoPrecio).HasColumnName("ind_tipo_precio");
            entity.Property(e => e.PrecioCliente)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_cliente");
            entity.Property(e => e.PrecioClienteSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_cliente_sin_iva");
            entity.Property(e => e.PrecioDescGral)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_gral");
            entity.Property(e => e.PrecioDescGralSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_gral_sin_iva");
            entity.Property(e => e.PrecioDescSup)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_desc_sup");
            entity.Property(e => e.PrecioDescSupSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_desc_sup_sin_iva");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto");
            entity.Property(e => e.PrecioNetoBase)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto_base");
            entity.Property(e => e.PrecioNetoBaseSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_base_sin_iva");
            entity.Property(e => e.PrecioNetoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_sin_iva");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.PrecioVentaSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_venta_sin_iva");
            entity.Property(e => e.PrecioVolumen)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_volumen");
            entity.Property(e => e.PrecioVolumenSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_volumen_sin_iva");
            entity.Property(e => e.Sku).HasColumnName("sku");

            entity.HasOne(d => d.Ventum).WithMany(p => p.VentaDetalleCons)
                .HasForeignKey(d => new { d.IdUniOper, d.IdVenta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTDETCONS_REF_VENTA");
        });

        modelBuilder.Entity<VentaDevolucion>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdDevolucion }).HasName("PK_VENTA_DEVOLUCION");

            entity.ToTable("venta_devolucion");

            entity.HasIndex(e => new { e.IdUniOper, e.IdTipomov, e.FolioMov }, "AK_venta_devolucion_mov_inv").IsUnique();

            entity.HasIndex(e => e.IdEstatus, "IX_Venta_devolucion_estatus");

            entity.HasIndex(e => e.FechaMovimiento, "IX_Venta_devolucion_fecha");

            entity.HasIndex(e => new { e.IdUniOper, e.IdVenta }, "IX_Venta_devolucion_venta");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdDevolucion).HasColumnName("id_devolucion");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUsuarioAnula).HasColumnName("id_usuario_anula");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdTipomovNavigation).WithMany(p => p.VentaDevolucions)
                .HasForeignKey(d => d.IdTipomov)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_DE_REF_1040_Tipo");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.VentaDevolucions)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_devolucion_unidad_operativa");

            entity.HasOne(d => d.Ventum).WithMany(p => p.VentaDevolucions)
                .HasForeignKey(d => new { d.IdUniOper, d.IdVenta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_DE_REF_1031_VENTA");
        });

        modelBuilder.Entity<VentaDevolucionDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdDevolucion, e.Sku, e.Orden }).HasName("PK_VENTA_DEVOLUCION_DETALLE");

            entity.ToTable("venta_devolucion_detalle");

            entity.HasIndex(e => e.Sku, "IX_Venta_devolucion_det_sku");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdDevolucion).HasColumnName("id_devolucion");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("cantidad_base");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoBase)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("costo_base");
            entity.Property(e => e.CostoBaseConIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo_base_con_iva");
            entity.Property(e => e.CostoConIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("costo_con_iva");
            entity.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto");
            entity.Property(e => e.PrecioNetoBase)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precio_neto_base");
            entity.Property(e => e.PrecioNetoBaseSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_base_sin_iva");
            entity.Property(e => e.PrecioNetoSinIva)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("precio_neto_sin_iva");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.VentaDevolucionDetalles)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_devolucion_detalle_impuesto");

            entity.HasOne(d => d.VentaDevolucion).WithMany(p => p.VentaDevolucionDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.IdDevolucion })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_DE_REF_1034_VENTA_DE");

            entity.HasOne(d => d.Inventario).WithMany(p => p.VentaDevolucionDetalles)
                .HasForeignKey(d => new { d.IdUniOper, d.Sku })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_devolucion_detalle_inventario");

            entity.HasOne(d => d.ArticuloEmpaque).WithMany(p => p.VentaDevolucionDetalles)
                .HasPrincipalKey(p => new { p.Sku, p.IdEmpaque })
                .HasForeignKey(d => new { d.Sku, d.IdUnidadMedida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_devolucion_detalle_articulo_empaque");
        });

        modelBuilder.Entity<VentaFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdVenta, e.Orden, e.IdFormaPago }).HasName("PK_VENTA_FORMA_PAGO1");

            entity.ToTable("venta_forma_pago");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.FolioReferencia).HasColumnName("folio_referencia");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.ImporteMn)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("importe_mn");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.VentaFormaPagos)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FO_REF_990_FORMA_PA");

            entity.HasOne(d => d.Ventum).WithMany(p => p.VentaFormaPagos)
                .HasForeignKey(d => new { d.IdUniOper, d.IdVenta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FO_REF_940_VENTA");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => new { e.IdUniOper, e.IdVenta }).HasName("PK_VENTA");

            entity.ToTable("venta");

            entity.HasIndex(e => new { e.IdUniOper, e.IdCaja, e.IdFolioVenta }, "AK_venta_folio").IsUnique();

            entity.HasIndex(e => new { e.IdUniOper, e.IdTipomov, e.FolioMov }, "AK_venta_mov_inv").IsUnique();

            entity.HasIndex(e => e.IdEstatus, "IX_Venta_estatus");

            entity.HasIndex(e => new { e.IdUniOper, e.IdCaja, e.IdCorte }, "IX_venta");

            entity.HasIndex(e => e.FechaMovimiento, "IX_venta_Fecha_movimiento");

            entity.Property(e => e.IdUniOper).HasColumnName("id_uni_oper");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Cambio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cambio");
            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.DescGral)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("desc_gral");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("descuento");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fecha_anula");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.FolioMov).HasColumnName("folio_mov");
            entity.Property(e => e.FolioMovAnula).HasColumnName("folio_mov_anula");
            entity.Property(e => e.FolioMovComp).HasColumnName("folio_mov_comp");
            entity.Property(e => e.FolioMovCompAnula).HasColumnName("folio_mov_comp_anula");
            entity.Property(e => e.IdCaja).HasColumnName("id_caja");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdFolioVenta).HasColumnName("id_folio_venta");
            entity.Property(e => e.IdLista).HasColumnName("id_lista");
            entity.Property(e => e.IdTarjeta).HasColumnName("id_tarjeta");
            entity.Property(e => e.IdTipomov).HasColumnName("id_tipomov");
            entity.Property(e => e.IdTipomovAnula).HasColumnName("id_tipomov_anula");
            entity.Property(e => e.IdTipomovComp).HasColumnName("id_tipomov_comp");
            entity.Property(e => e.IdTipomovCompAnula).HasColumnName("id_tipomov_comp_anula");
            entity.Property(e => e.IdTipoprecio).HasColumnName("id_tipoprecio");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUsuarioAnula).HasColumnName("id_usuario_anula");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("impuesto");
            entity.Property(e => e.IndFacturado).HasColumnName("ind_facturado");
            entity.Property(e => e.IndFacturar).HasColumnName("ind_facturar");
            entity.Property(e => e.Pago)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pago");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_cliente");

            entity.HasOne(d => d.IdUniOperNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUniOper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_unidad_operativa");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_REF_1037_USUARIO");

            entity.HasOne(d => d.CorteParcial).WithMany(p => p.Venta)
                .HasForeignKey(d => new { d.IdUniOper, d.IdCaja, d.IdCorte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_corte_parcial");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
