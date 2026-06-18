using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Caja
{
    public int IdCaja { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomCaja { get; set; } = null!;

    public byte IndTipoCaja { get; set; }

    public int? IdTerminal { get; set; }

    public decimal MaximoEfectivo { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public decimal SugeridoFondo { get; set; }

    public decimal SugeridoRetiro { get; set; }

    public virtual ICollection<CorteCaja> CorteCajas { get; set; } = new List<CorteCaja>();

    public virtual ICollection<CorteParcial> CorteParcials { get; set; } = new List<CorteParcial>();
}
