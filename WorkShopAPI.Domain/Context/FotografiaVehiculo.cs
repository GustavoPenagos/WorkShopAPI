using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class FotografiaVehiculo
{
    public int FotoId { get; set; }

    public string Placa { get; set; } = null!;

    public int EvaluacionId { get; set; }

    public string Foto { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public virtual Evaluacion Evaluacion { get; set; } = null!;

    public virtual Vehiculo PlacaNavigation { get; set; } = null!;
}
