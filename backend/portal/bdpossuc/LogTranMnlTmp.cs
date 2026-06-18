using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogTranMnlTmp
{
    public int Spid { get; set; }

    public int Id { get; set; }

    public int IdUniOper { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string Secuencia { get; set; } = null!;

    public bool Replicar { get; set; }

    public bool InServer { get; set; }

    public short RepUni { get; set; }

    public string Referencia { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
