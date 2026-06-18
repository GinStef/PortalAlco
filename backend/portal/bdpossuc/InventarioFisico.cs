using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class InventarioFisico
{
    public short IdUniOper { get; set; }

    public int FolioInventario { get; set; }

    public string CveEstatus { get; set; } = null!;

    public DateTime FechaGeneracion { get; set; }

    public string UsuarioGenera { get; set; } = null!;

    public DateTime? FechaAplicacion { get; set; }

    public string? UsuarioAplica { get; set; }

    public short? IdTipomovPos { get; set; }

    public int? FolioMovPos { get; set; }

    public short? IdTipomovNeg { get; set; }

    public int? FolioMovNeg { get; set; }

    public short? IdTipomovPosAnula { get; set; }

    public int? FolioMovPosAnula { get; set; }

    public short? IdTipomovNegAnula { get; set; }

    public int? FolioMovNegAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public byte TipoInventario { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<InventarioFisicoDet> InventarioFisicoDets { get; set; } = new List<InventarioFisicoDet>();
}
