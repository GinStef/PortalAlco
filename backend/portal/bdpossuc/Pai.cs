using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Pai
{
    public int IdPais { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomPais { get; set; } = null!;

    public string AbrevPais { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
