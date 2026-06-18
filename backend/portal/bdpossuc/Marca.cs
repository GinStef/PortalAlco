using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Marca
{
    public int IdMarca { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomMarca { get; set; } = null!;

    public string AbrevMarca { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
