using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Banco
{
    public short IdBanco { get; set; }

    public string NomBanco { get; set; } = null!;

    public string AbrevBanco { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<ProveedorCuentum> ProveedorCuenta { get; set; } = new List<ProveedorCuentum>();
}
