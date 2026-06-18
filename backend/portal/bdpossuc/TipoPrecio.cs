using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoPrecio
{
    public short IdTipoprecio { get; set; }

    public string NomTipoprecio { get; set; } = null!;

    public string AbrevTipoprecio { get; set; } = null!;

    public bool IndRango { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public byte IndOrden { get; set; }

    public virtual ICollection<ArticuloPrecioVoluman> ArticuloPrecioVolumen { get; set; } = new List<ArticuloPrecioVoluman>();
}
