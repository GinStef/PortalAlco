using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UnidadOperativa
{
    public short IdUniOper { get; set; }

    public string NomUnioper { get; set; } = null!;

    public string AbrevUnioper { get; set; } = null!;

    public string CalleYNumero { get; set; } = null!;

    public string? Entrecalles { get; set; }

    public string Colonia { get; set; } = null!;

    public string? NumeroInterior { get; set; }

    public string NumeroExterior { get; set; } = null!;

    public int IdCiudad { get; set; }

    public string CodigoPostal { get; set; } = null!;

    public short IdTipounioper { get; set; }

    public short IdEmpresa { get; set; }

    public string Telefono1 { get; set; } = null!;

    public string? Telefono2 { get; set; }

    public string? TelefonoFax { get; set; }

    public string? CfdFolderFirmas { get; set; }

    public string? CfdArchivoCer { get; set; }

    public string? CfdArchivoKey { get; set; }

    public string? CfdClavePrivada { get; set; }

    public short IdLista { get; set; }

    public short IdZona { get; set; }

    public short IdImpuesto { get; set; }

    public short GrupoReplicar { get; set; }

    public byte IndPrincipal { get; set; }

    public bool IndLocal { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public string? CuentaContable { get; set; }

    public string? SubcuentaContable { get; set; }

    public int? DiasApertura { get; set; }

    public virtual ICollection<ArticuloProveedorUo> ArticuloProveedorUos { get; set; } = new List<ArticuloProveedorUo>();

    public virtual ICollection<CfdTipoFacturaUo> CfdTipoFacturaUos { get; set; } = new List<CfdTipoFacturaUo>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<CorteTiendum> CorteTienda { get; set; } = new List<CorteTiendum>();

    public virtual ICollection<Devolucion> Devolucions { get; set; } = new List<Devolucion>();

    public virtual ICollection<EntregaValore> EntregaValores { get; set; } = new List<EntregaValore>();

    public virtual ICollection<EsMovimientoSocio> EsMovimientoSocios { get; set; } = new List<EsMovimientoSocio>();

    public virtual ICollection<EsVaria> EsVaria { get; set; } = new List<EsVaria>();

    public virtual ICollection<Factura> FacturaIdUniOperFacturaNavigations { get; set; } = new List<Factura>();

    public virtual ICollection<Factura> FacturaIdUniOperNavigations { get; set; } = new List<Factura>();

    public virtual Ciudad IdCiudadNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ListaPrecio IdListaNavigation { get; set; } = null!;

    public virtual TipoUnidadOperativa IdTipounioperNavigation { get; set; } = null!;

    public virtual ICollection<ImagenPosUo> ImagenPosUos { get; set; } = new List<ImagenPosUo>();

    public virtual ICollection<InventarioFisico> InventarioFisicos { get; set; } = new List<InventarioFisico>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<LogVentum> LogVenta { get; set; } = new List<LogVentum>();

    public virtual ICollection<MacPc> MacPcs { get; set; } = new List<MacPc>();

    public virtual ICollection<MaqPcDet> MaqPcDets { get; set; } = new List<MaqPcDet>();

    public virtual ICollection<MensajeUnidadOperativa> MensajeUnidadOperativas { get; set; } = new List<MensajeUnidadOperativa>();

    public virtual ICollection<Merma> Mermas { get; set; } = new List<Merma>();

    public virtual ICollection<MovimientoCxc> MovimientoCxcs { get; set; } = new List<MovimientoCxc>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<MovimientoSocio> MovimientoSocios { get; set; } = new List<MovimientoSocio>();

    public virtual ICollection<PedidoEntregaPago> PedidoEntregaPagos { get; set; } = new List<PedidoEntregaPago>();

    public virtual ICollection<PedidoEntrega> PedidoEntregas { get; set; } = new List<PedidoEntrega>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<ProveedorCompra> ProveedorCompraIdUniOperEntregaNavigations { get; set; } = new List<ProveedorCompra>();

    public virtual ICollection<ProveedorCompra> ProveedorCompraIdUniOperFacturaNavigations { get; set; } = new List<ProveedorCompra>();

    public virtual ICollection<Recibo> Recibos { get; set; } = new List<Recibo>();

    public virtual ICollection<TerminalPc> TerminalPcs { get; set; } = new List<TerminalPc>();

    public virtual ICollection<TipoCambio> TipoCambios { get; set; } = new List<TipoCambio>();

    public virtual ICollection<Transformado> Transformados { get; set; } = new List<Transformado>();

    public virtual ICollection<Traslado> TrasladoIdUniOperDestinoNavigations { get; set; } = new List<Traslado>();

    public virtual ICollection<Traslado> TrasladoIdUniOperNavigations { get; set; } = new List<Traslado>();

    public virtual ICollection<TrasladoRecibo> TrasladoRecibos { get; set; } = new List<TrasladoRecibo>();

    public virtual ICollection<UnidadOperativaListaPrecio> UnidadOperativaListaPrecios { get; set; } = new List<UnidadOperativaListaPrecio>();

    public virtual ICollection<UsuarioUnidadOperativa> UsuarioUnidadOperativas { get; set; } = new List<UsuarioUnidadOperativa>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<VentaDevolucion> VentaDevolucions { get; set; } = new List<VentaDevolucion>();
}
