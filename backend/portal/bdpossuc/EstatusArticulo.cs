using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class EstatusArticulo
{
    public byte IdEstatusArticulo { get; set; }

    public string NomEstatus { get; set; } = null!;

    public string DescripEstatus { get; set; } = null!;

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
