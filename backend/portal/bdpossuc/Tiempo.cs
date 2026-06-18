using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Tiempo
{
    public DateTime Fecha { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public int NoDiaSem { get; set; }

    public DateTime SemanaIni { get; set; }

    public DateTime SemanaFin { get; set; }

    public int? AnioSemana { get; set; }

    public int? NumSemana { get; set; }

    public byte DiaMes { get; set; }

    public byte MesAnio { get; set; }
}
