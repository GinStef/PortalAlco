using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdFacturaImpuesto
{
    public int Idproceso { get; set; }

    public int Id { get; set; }

    public decimal? ImporteVenta { get; set; }

    public string? NomImpuesto { get; set; }

    public decimal? TasaImpuesto { get; set; }

    public decimal? ImporteImpuesto { get; set; }

    public short IdImpuesto { get; set; }

    public string? ClaveImpuestoSat { get; set; }

    public string? TipoFactorSat { get; set; }
}
