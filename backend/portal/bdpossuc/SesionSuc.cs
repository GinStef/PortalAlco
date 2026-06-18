using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SesionSuc
{
    public int IdUniOper { get; set; }

    public int Spid { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public string NombreUniOper { get; set; } = null!;

    public byte IndPrincipal { get; set; }

    public int IdTerminal { get; set; }

    public string NombreTerminal { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string ClaveUsuario { get; set; } = null!;

    public byte Administrador { get; set; }

    public byte Replicar { get; set; }

    public int IdUniOperPpal { get; set; }

    public byte IndPrincipalPpal { get; set; }

    public byte InServer { get; set; }

    public int? IdLista { get; set; }

    public short? IdTipounioper { get; set; }

    public byte? IndConsolidar { get; set; }

    public byte? IndVolumen { get; set; }
}
