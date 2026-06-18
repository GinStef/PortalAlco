using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class GrupoCliente
{
    public int IdGrupoCliente { get; set; }

    public string NomGrupoCliente { get; set; } = null!;

    public string AbrevGrupoCliente { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public decimal FactorPunto { get; set; }

    public int IdSuperGrupo { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual SuperGrupoCliente IdSuperGrupoNavigation { get; set; } = null!;

    public virtual ICollection<Cliente> IdClientes { get; set; } = new List<Cliente>();
}
