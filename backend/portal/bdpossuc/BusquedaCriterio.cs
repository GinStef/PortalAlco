using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class BusquedaCriterio
{
    public byte IdBusqueda { get; set; }

    public byte IdCriterio { get; set; }

    public string Campo { get; set; } = null!;

    public string DescCampo { get; set; } = null!;

    public byte Tipo { get; set; }

    public string? Valor { get; set; }
}
