using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class RevisionSuc
{
    public int? IdUniOper { get; set; }

    public int? SucCantRegSuc { get; set; }

    public int? SucCantRegMat { get; set; }

    public int? SucCantRegModificados { get; set; }

    public int? MatCantRegSuc { get; set; }

    public int? MatCantRegMat { get; set; }

    public int? MatCantRegImportados { get; set; }

    public DateTime? DiaRevision { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
