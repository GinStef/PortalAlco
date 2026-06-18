using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogTranError
{
    public int IdTrans { get; set; }

    public int IdUniOper { get; set; }

    public bool InServer { get; set; }

    public DateTime Fecha { get; set; }

    public string Modulo { get; set; } = null!;

    public int ErrorCode { get; set; }

    public string ErrorText { get; set; } = null!;
}
