using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdTicket
{
    public int Idproceso { get; set; }

    public int Id { get; set; }

    public int IdUniOper { get; set; }

    public int IdVenta { get; set; }

    public byte IdTipo { get; set; }

    public decimal PorcjDesc { get; set; }

    public string? Concepto { get; set; }

    public int Idcliente { get; set; }

    public string? NomFormaPago { get; set; }

    public string? NumeroCuenta { get; set; }
}
