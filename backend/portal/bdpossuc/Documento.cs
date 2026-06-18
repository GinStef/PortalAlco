using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Documento
{
    public short IdDocumento { get; set; }

    public string NomDocumento { get; set; } = null!;

    public string AbrevDocumento { get; set; } = null!;

    public bool IndSistema { get; set; }

    public byte IndFoliador { get; set; }

    public byte IndTipoMovimiento { get; set; }

    public virtual ICollection<Folio> Folios { get; set; } = new List<Folio>();

    public virtual ICollection<TipoMovimiento> TipoMovimientos { get; set; } = new List<TipoMovimiento>();
}
