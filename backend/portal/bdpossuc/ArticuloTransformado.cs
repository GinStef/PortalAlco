using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloTransformado
{
    public int Sku { get; set; }

    public int SkuTransformado { get; set; }

    public decimal Cantidad { get; set; }

    public decimal CantidadBase { get; set; }

    public short IdUnidadMedida { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal CostoBase { get; set; }

    public decimal CostoConIvaBase { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public decimal PorcValorPonderado { get; set; }

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;

    public virtual Articulo SkuTransformadoNavigation { get; set; } = null!;
}
