using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CfdTipoFacturaOrigen
{
    public byte IdTipofactura { get; set; }

    public byte IndOrigen { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte IdTipoDoc { get; set; }

    public bool IndVigente { get; set; }

    public string? Abrev { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
