using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdFacturaFormapago
{
    public int Idproceso { get; set; }

    public int Id { get; set; }

    public int Idcliente { get; set; }

    public short IdFormaPago { get; set; }

    public string NomFormaPago { get; set; } = null!;

    public string? NumeroCuenta { get; set; }

    public byte IndCuenta { get; set; }

    public byte IndSeleccion { get; set; }

    public string? Usuario { get; set; }
}
