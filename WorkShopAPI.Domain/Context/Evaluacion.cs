using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Evaluacion
{
    public int EvaluacionId { get; set; }

    public int CitaId { get; set; }

    public string DescripcionDanios { get; set; } = null!;

    public DateTime TiempoEstimado { get; set; }

    public decimal CostoManoObra { get; set; }

    public virtual ICollection<FotografiaVehiculo> FotografiaVehiculos { get; set; } = new List<FotografiaVehiculo>();

    public virtual ICollection<RepuestoEvaluacion> RepuestoEvaluacions { get; set; } = new List<RepuestoEvaluacion>();
}
