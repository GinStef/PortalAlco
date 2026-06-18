using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ClientePrecio
{
    public int Sku { get; set; }

    public int IdCliente { get; set; }

    public decimal Precio { get; set; }

    public decimal PrecioSinIva { get; set; }

    public short IdImpuesto { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
