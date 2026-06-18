using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class InventarioFisicoDet
{
    public short IdUniOper { get; set; }

    public int FolioInventario { get; set; }

    public int Sku { get; set; }

    public int Orden { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal Precio { get; set; }

    public decimal CantidadBase { get; set; }

    public decimal CostoBase { get; set; }

    public decimal PrecioBase { get; set; }

    public short IdImpuesto { get; set; }

    public short IdUnidadMedida { get; set; }

    public decimal Inicial { get; set; }

    public decimal InicialBase { get; set; }

    public decimal Entrada { get; set; }

    public decimal EntradaBase { get; set; }

    public decimal Salida { get; set; }

    public decimal SalidaBase { get; set; }

    public decimal Existencia { get; set; }

    public decimal ExistenciaBase { get; set; }

    public int TipoAjuste { get; set; }

    public decimal CantidadAjuste { get; set; }

    public decimal? CantidadAjusteBase { get; set; }

    public string? UsuarioCaptura { get; set; }

    public DateTime? FechaCaptura { get; set; }

    public decimal MermKgs { get; set; }

    public decimal MermAcum { get; set; }

    public decimal PorcAcum { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual InventarioFisico InventarioFisico { get; set; } = null!;

    public virtual ICollection<InventarioFisicoDetSerie> InventarioFisicoDetSeries { get; set; } = new List<InventarioFisicoDetSerie>();

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
