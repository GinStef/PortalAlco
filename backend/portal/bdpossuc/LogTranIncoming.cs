using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogTranIncoming
{
    public int IdUniOper { get; set; }

    public string Cfc { get; set; } = null!;

    public bool IState { get; set; }
}
