using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloPrecioVoluman
{
    public int Sku { get; set; }

    public short IdTipoprecio { get; set; }

    public short IdTipounioper { get; set; }

    public decimal? Inicial { get; set; }

    public decimal? Final { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual TipoPrecio IdTipoprecioNavigation { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
