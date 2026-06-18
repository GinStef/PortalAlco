using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogTranPasoCteCfcIncoming
{
    public int IdUniOper { get; set; }

    public string Cfc { get; set; } = null!;

    public int Registros { get; set; }

    public DateTime Fecha { get; set; }

    public byte Estatus { get; set; }
}
