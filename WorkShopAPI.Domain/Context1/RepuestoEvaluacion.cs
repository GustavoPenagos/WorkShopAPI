using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class RepuestoEvaluacion
{
    public int IdRepEval { get; set; }

    public int EvaluacionId { get; set; }

    public int RepuestoId { get; set; }

    public int Cantidad { get; set; }

    public int CambioAdicional { get; set; }
}
