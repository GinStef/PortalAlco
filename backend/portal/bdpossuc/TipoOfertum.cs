using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoOfertum
{
    public byte IdTipoOferta { get; set; }

    public string? NomTipoOferta { get; set; }

    public string? AbrevTipoOferta { get; set; }

    public bool? IndVigente { get; set; }
}
