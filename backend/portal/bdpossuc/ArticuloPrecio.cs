using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloPrecio
{
    public int Sku { get; set; }

    public short IdLista { get; set; }

    public decimal Precio1 { get; set; }

    public decimal PrecioSinIva1 { get; set; }

    public decimal Precio2 { get; set; }

    public decimal PrecioSinIva2 { get; set; }

    public decimal Precio3 { get; set; }

    public decimal PrecioSinIva3 { get; set; }

    public decimal Precio4 { get; set; }

    public decimal PrecioSinIva4 { get; set; }

    public decimal Precio5 { get; set; }

    public decimal PrecioSinIva5 { get; set; }

    public decimal Precio6 { get; set; }

    public decimal PrecioSinIva6 { get; set; }

    public decimal Precio7 { get; set; }

    public decimal PrecioSinIva7 { get; set; }

    public decimal Precio8 { get; set; }

    public decimal PrecioSinIva8 { get; set; }

    public decimal Precio9 { get; set; }

    public decimal PrecioSinIva9 { get; set; }

    public decimal Precio10 { get; set; }

    public decimal PrecioSinIva10 { get; set; }

    public short IdImpuesto { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual ListaPrecio IdListaNavigation { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
