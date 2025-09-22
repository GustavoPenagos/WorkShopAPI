using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Repuesto
{
    public int RepuestoId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal PrecioUnitario { get; set; }
}
