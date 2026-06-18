using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Inventario
{
    public short IdUniOper { get; set; }

    public int Sku { get; set; }

    public byte IdTipoComercializacion { get; set; }

    public short IdImpuesto { get; set; }

    public short? IdLista { get; set; }

    public decimal Precio { get; set; }

    public decimal PrecioSinIva { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal ExistenciaTeorica { get; set; }

    public decimal ExistenciaReservada { get; set; }

    public decimal? Existencia { get; set; }

    public decimal Minimo { get; set; }

    public decimal Optimo { get; set; }

    public decimal Maximo { get; set; }

    public decimal StockBase { get; set; }

    public short IdUnidadMedida { get; set; }

    public DateTime? FechaUltimoInv { get; set; }

    public bool IndDevolucion { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public decimal? CostoPromedio { get; set; }

    public decimal? CostoUltimo { get; set; }

    public virtual ICollection<DevolucionDet> DevolucionDets { get; set; } = new List<DevolucionDet>();

    public virtual ICollection<EsVariasDet> EsVariasDets { get; set; } = new List<EsVariasDet>();

    public virtual ICollection<ExistenciaHist> ExistenciaHists { get; set; } = new List<ExistenciaHist>();

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual ListaPrecio? IdListaNavigation { get; set; }

    public virtual TipoComercializacion IdTipoComercializacionNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual ICollection<InventarioFisicoDet> InventarioFisicoDets { get; set; } = new List<InventarioFisicoDet>();

    public virtual ICollection<InventarioSerie> InventarioSeries { get; set; } = new List<InventarioSerie>();

    public virtual ICollection<MermaDet> MermaDets { get; set; } = new List<MermaDet>();

    public virtual ICollection<MovimientoInventarioDet> MovimientoInventarioDets { get; set; } = new List<MovimientoInventarioDet>();

    public virtual ICollection<OfertaClienteDet> OfertaClienteDets { get; set; } = new List<OfertaClienteDet>();

    public virtual ICollection<ReciboDet> ReciboDets { get; set; } = new List<ReciboDet>();

    public virtual ICollection<RequisicionDet> RequisicionDets { get; set; } = new List<RequisicionDet>();

    public virtual Articulo SkuNavigation { get; set; } = null!;

    public virtual ICollection<TransformadoDetComp> TransformadoDetComps { get; set; } = new List<TransformadoDetComp>();

    public virtual ICollection<TransformadoDet> TransformadoDets { get; set; } = new List<TransformadoDet>();

    public virtual ICollection<TrasladoReciboDet> TrasladoReciboDets { get; set; } = new List<TrasladoReciboDet>();

    public virtual ICollection<VentaDetalleComp> VentaDetalleComps { get; set; } = new List<VentaDetalleComp>();

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

    public virtual ICollection<VentaDevolucionDetalle> VentaDevolucionDetalles { get; set; } = new List<VentaDevolucionDetalle>();
}
