using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Impuesto
{
    public short IdImpuesto { get; set; }

    public string NomImpuesto { get; set; } = null!;

    public decimal ValorImpuesto { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public short? IdImpuestoSat { get; set; }

    public virtual ICollection<ArticuloPrecio> ArticuloPrecios { get; set; } = new List<ArticuloPrecio>();

    public virtual ICollection<ArticuloProveedor> ArticuloProveedors { get; set; } = new List<ArticuloProveedor>();

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual ICollection<ClientePrecio> ClientePrecios { get; set; } = new List<ClientePrecio>();

    public virtual ICollection<DevolucionDet> DevolucionDets { get; set; } = new List<DevolucionDet>();

    public virtual ICollection<EsVariasDet> EsVariasDets { get; set; } = new List<EsVariasDet>();

    public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; } = new List<FacturaDetalle>();

    public virtual ICollection<FacturaImpuesto> FacturaImpuestos { get; set; } = new List<FacturaImpuesto>();

    public virtual ICollection<InventarioFisicoDet> InventarioFisicoDets { get; set; } = new List<InventarioFisicoDet>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<MermaDet> MermaDets { get; set; } = new List<MermaDet>();

    public virtual ICollection<MovimientoInventarioDet> MovimientoInventarioDets { get; set; } = new List<MovimientoInventarioDet>();

    public virtual ICollection<PedidoEntregaDet> PedidoEntregaDets { get; set; } = new List<PedidoEntregaDet>();

    public virtual ICollection<ReciboDet> ReciboDets { get; set; } = new List<ReciboDet>();

    public virtual ICollection<RequisicionDet> RequisicionDets { get; set; } = new List<RequisicionDet>();

    public virtual ICollection<TransformadoDetComp> TransformadoDetComps { get; set; } = new List<TransformadoDetComp>();

    public virtual ICollection<TransformadoDet> TransformadoDets { get; set; } = new List<TransformadoDet>();

    public virtual ICollection<TrasladoDet> TrasladoDets { get; set; } = new List<TrasladoDet>();

    public virtual ICollection<TrasladoReciboDet> TrasladoReciboDets { get; set; } = new List<TrasladoReciboDet>();

    public virtual ICollection<VentaDetalleComp> VentaDetalleComps { get; set; } = new List<VentaDetalleComp>();

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

    public virtual ICollection<VentaDevolucionDetalle> VentaDevolucionDetalles { get; set; } = new List<VentaDevolucionDetalle>();
}
