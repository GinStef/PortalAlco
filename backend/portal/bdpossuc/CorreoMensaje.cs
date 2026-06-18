using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorreoMensaje
{
    public int IdCorreoMensaje { get; set; }

    public int IdUsuario { get; set; }

    public string Mensaje { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public byte? IdUniOper { get; set; }

    public int? IdMovimiento { get; set; }

    public virtual ICollection<CorreoUsuario> CorreoUsuarios { get; set; } = new List<CorreoUsuario>();
}
