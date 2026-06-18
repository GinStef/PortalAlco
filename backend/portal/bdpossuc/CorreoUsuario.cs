using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorreoUsuario
{
    public int IdCorreoMensaje { get; set; }

    public int IdUsuarioDestino { get; set; }

    public int? IdUsuario { get; set; }

    public byte TipoCorreo { get; set; }

    public bool IndLeido { get; set; }

    public DateTime? FechaLeido { get; set; }

    public virtual CorreoMensaje IdCorreoMensajeNavigation { get; set; } = null!;
}
