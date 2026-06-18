using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SuperGrupoCliente
{
    public int IdSuperGrupo { get; set; }

    public string NomSuperGrupo { get; set; } = null!;

    public string AbrevSuperGrupo { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool? IndVigente { get; set; }

    public virtual ICollection<GrupoCliente> GrupoClientes { get; set; } = new List<GrupoCliente>();
}
