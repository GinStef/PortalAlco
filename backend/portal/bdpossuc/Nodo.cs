using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Nodo
{
    public byte IdNodo { get; set; }

    public byte OrdenNodo { get; set; }

    public string NombreNodo { get; set; } = null!;

    public string? NombreUoInicio { get; set; }

    public bool IndMuestraNavegacion { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Panel> Panels { get; set; } = new List<Panel>();
}
