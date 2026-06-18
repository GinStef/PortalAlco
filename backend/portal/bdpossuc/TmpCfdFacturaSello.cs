using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdFacturaSello
{
    public int Idproceso { get; set; }

    public int Id { get; set; }

    public string? Sello { get; set; }

    public string? Error { get; set; }

    public string? SCertificado { get; set; }

    public string? Timbreversion { get; set; }

    public string? Timbreuuid { get; set; }

    public DateTime? Timbrefecha { get; set; }

    public string? Timbresellosat { get; set; }

    public string? Timbrenocertsat { get; set; }
}
