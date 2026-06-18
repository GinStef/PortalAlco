using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CveEstatus
{
    public short IdCveEstatus { get; set; }

    public string CveEstatus1 { get; set; } = null!;

    public string AbreCveEstatus { get; set; } = null!;

    public byte? IndVigente { get; set; }
}
