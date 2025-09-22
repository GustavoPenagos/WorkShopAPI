using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class CitaServicio
{
    public int CitaId { get; set; }

    public int VehiculoId { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public DateTime FechaProgramada { get; set; }

    public int Estado { get; set; }

    public int? MecanicoId { get; set; }
}
