using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloProveedor
{
    public int Sku { get; set; }

    public int IdProveedor { get; set; }

    public short IdImpuesto { get; set; }

    public short IdMoneda { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public string? CodigoProveedor { get; set; }

    public bool IndProvPrincipal { get; set; }

    public decimal DctoLinea { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public bool IndTodasUo { get; set; }

    public virtual ICollection<ArticuloProveedorUo> ArticuloProveedorUos { get; set; } = new List<ArticuloProveedorUo>();

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
