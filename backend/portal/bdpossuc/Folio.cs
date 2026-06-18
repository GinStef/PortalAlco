using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Folio
{
    public short IdDocumento { get; set; }

    public short IdUniOper { get; set; }

    public short IdTipomov { get; set; }

    public int Folio1 { get; set; }

    public virtual Documento IdDocumentoNavigation { get; set; } = null!;
}
