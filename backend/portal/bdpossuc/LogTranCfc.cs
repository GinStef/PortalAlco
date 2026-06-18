using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogTranCfc
{
    public int IdUniOper { get; set; }

    public string Cfc { get; set; } = null!;

    public byte Tipo { get; set; }

    public byte Estatus { get; set; }
}
