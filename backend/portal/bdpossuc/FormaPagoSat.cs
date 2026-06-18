using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class FormaPagoSat
{
    public int IdFormaPagoSat { get; set; }

    public string? DescFormaPagoSat { get; set; }

    public bool? Reqcuenta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public bool? IndVigente { get; set; }
}
