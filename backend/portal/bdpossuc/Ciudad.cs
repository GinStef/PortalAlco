using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Ciudad
{
    public int IdCiudad { get; set; }

    public int IdEstado { get; set; }

    public int IdPais { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public int CveCiudad { get; set; }

    public string NomCiudad { get; set; } = null!;

    public string AbrevCiudad { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();

    public virtual ICollection<UnidadOperativa> UnidadOperativas { get; set; } = new List<UnidadOperativa>();
}
