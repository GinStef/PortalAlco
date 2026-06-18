using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArqueoTerminal
{
    public int IdArqueo { get; set; }

    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public int IdUsuario { get; set; }

    public int IdUsuarioAudita { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string? Comentario { get; set; }

    public decimal TotalCapturado { get; set; }

    public decimal TotalVenta { get; set; }

    public decimal TotalFondoSal { get; set; }

    public decimal TotalFondoEnt { get; set; }

    public decimal TotalDiferencia { get; set; }

    public int? IdCorte { get; set; }

    public virtual ICollection<ArqueoTerminalDetalle> ArqueoTerminalDetalles { get; set; } = new List<ArqueoTerminalDetalle>();

    public virtual Usuario IdUsuarioAuditaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
