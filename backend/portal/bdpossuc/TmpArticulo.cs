using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpArticulo
{
    public int IdSpid { get; set; }

    public int Sku { get; set; }

    public string IdCodigoBarras { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdUnidadMedida { get; set; }

    public string? NomUnidadMedida { get; set; }

    public string? AbrevUnidadMedida { get; set; }

    public int IdFamilia { get; set; }

    public string? NomFamilia { get; set; }

    public int IdSubdivision { get; set; }

    public string? NomSubdivision { get; set; }

    public int IdDivision { get; set; }

    public string? NomDivision { get; set; }
}
