using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpOfertaClteCorte
{
    public int Id { get; set; }

    public int IdSpid { get; set; }

    public int? IdFolioDet { get; set; }

    public int? IdFolio { get; set; }

    public short? IdUniOperFolio { get; set; }

    public byte? IdTipoFecha { get; set; }

    public string Estatus { get; set; } = null!;

    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }

    public byte Dia1 { get; set; }

    public byte Dia2 { get; set; }

    public byte Dia3 { get; set; }

    public byte Dia4 { get; set; }

    public byte Dia5 { get; set; }

    public byte Dia6 { get; set; }

    public byte Dia7 { get; set; }

    public int HoraIni { get; set; }

    public int HoraFin { get; set; }

    public int? IdFolioDetRef { get; set; }

    public int? IdFolioRef { get; set; }

    public short? IdUniOperFolioRef { get; set; }

    public byte? TipoOper { get; set; }
}
