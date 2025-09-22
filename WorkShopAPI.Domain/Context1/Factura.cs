using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int EvaluacionId { get; set; }

    public DateTime FechaEmision { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public int AlertaPresupuesto { get; set; }
}
