using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Terminal
{
    public int IdTerminal { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NombreTerminal { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<CorteCaja> CorteCajas { get; set; } = new List<CorteCaja>();

    public virtual ICollection<CorteParcial> CorteParcials { get; set; } = new List<CorteParcial>();

    public virtual ICollection<CorteTiendum> CorteTienda { get; set; } = new List<CorteTiendum>();

    public virtual ICollection<TerminalPc> TerminalPcs { get; set; } = new List<TerminalPc>();
}
