using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CfdTipoFacturaUoFolio
{
    public short IdUniOper { get; set; }

    public byte IdTipofactura { get; set; }

    public string Sserie { get; set; } = null!;

    public int Ifolioinicial { get; set; }

    public int Ifoliofinal { get; set; }

    public DateTime Dfechaaprobacion { get; set; }

    public int Inumaprobacion { get; set; }

    public string? Sseriecertificado { get; set; }

    public int Iidusuarioalta { get; set; }

    public DateTime Dfechaalta { get; set; }

    public int Iidusuariomovimiento { get; set; }

    public DateTime Dfechamovimiento { get; set; }

    public bool Bindvigente { get; set; }

    public virtual CfdTipoFacturaUo CfdTipoFacturaUo { get; set; } = null!;
}
