using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Modelo
{
    public int IdModelo { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomModelo { get; set; } = null!;

    public string AbrevModelo { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
