using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloEmpaque
{
    public int Sku { get; set; }

    public short IdUnidadMedida { get; set; }

    public short IdEmpaque { get; set; }

    public decimal CantidadBase { get; set; }

    public decimal Cantidad { get; set; }

    public bool IndEmpaqueBase { get; set; }

    public bool IndEmpaqueCompra { get; set; }

    public bool IndEmpaqueInv { get; set; }

    public bool IndEmpaqueVta { get; set; }

    public bool IndEmpaqueStd { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual ICollection<DevolucionDet> DevolucionDets { get; set; } = new List<DevolucionDet>();

    public virtual ICollection<EsVariasDet> EsVariasDets { get; set; } = new List<EsVariasDet>();

    public virtual UnidadMedidum IdEmpaqueNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual ICollection<InventarioFisicoDet> InventarioFisicoDets { get; set; } = new List<InventarioFisicoDet>();

    public virtual ICollection<MermaDet> MermaDets { get; set; } = new List<MermaDet>();

    public virtual ICollection<MovimientoInventarioDet> MovimientoInventarioDets { get; set; } = new List<MovimientoInventarioDet>();

    public virtual ICollection<ReciboDet> ReciboDets { get; set; } = new List<ReciboDet>();

    public virtual ICollection<RequisicionDet> RequisicionDets { get; set; } = new List<RequisicionDet>();

    public virtual Articulo SkuNavigation { get; set; } = null!;

    public virtual ICollection<TransformadoDetComp> TransformadoDetComps { get; set; } = new List<TransformadoDetComp>();

    public virtual ICollection<TransformadoDet> TransformadoDets { get; set; } = new List<TransformadoDet>();

    public virtual ICollection<TrasladoDet> TrasladoDets { get; set; } = new List<TrasladoDet>();

    public virtual ICollection<TrasladoReciboDet> TrasladoReciboDets { get; set; } = new List<TrasladoReciboDet>();

    public virtual ICollection<VentaDetalleComp> VentaDetalleComps { get; set; } = new List<VentaDetalleComp>();

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

    public virtual ICollection<VentaDevolucionDetalle> VentaDevolucionDetalles { get; set; } = new List<VentaDevolucionDetalle>();
}
