using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogTranSendLogToClient
{
    public int ICompany { get; set; }

    public int IdUniOper { get; set; }

    public string Cfc { get; set; } = null!;

    public int IdUniOperSend { get; set; }
}
