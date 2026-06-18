using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoProveedor
{
    public int IdTipoProv { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomTipoprov { get; set; } = null!;

    public string AbrevTipoprov { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
