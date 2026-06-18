using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoOfertaFecha
{
    public byte IdTipoFecha { get; set; }

    public string NomTipoFecha { get; set; } = null!;

    public string AbrevTipoFecha { get; set; } = null!;

    public bool IndVigente { get; set; }
}
