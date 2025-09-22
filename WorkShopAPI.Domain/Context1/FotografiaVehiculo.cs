using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class FotografiaVehiculo
{
    public int FotoId { get; set; }

    public int VehiculoId { get; set; }

    public string Foto { get; set; } = null!;

    public DateTime FechaCarga { get; set; }
}
