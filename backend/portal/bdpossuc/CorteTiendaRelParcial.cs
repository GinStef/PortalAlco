using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorteTiendaRelParcial
{
    public int IdCorteTienda { get; set; }

    public int IdCorteCaja { get; set; }

    public int IdCaja { get; set; }

    public int IdCorte { get; set; }

    public short IdUniOper { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }

    public virtual CorteTiendum CorteTiendum { get; set; } = null!;
}
