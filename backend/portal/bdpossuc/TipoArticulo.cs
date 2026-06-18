using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoArticulo
{
    public byte IdTipoArticulo { get; set; }

    public string NomTipoArticulo { get; set; } = null!;

    public string AbrevTipoArticulo { get; set; } = null!;

    public byte IndPaquete { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public bool IndConsolidar { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
