using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatProductosServicio
{
    public int IdProdServ { get; set; }

    public string CveProdServ { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? FechaIniVig { get; set; }

    public DateTime? FechaFinVig { get; set; }
}
