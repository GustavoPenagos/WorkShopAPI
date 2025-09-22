using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Vehiculo
{
    public int VehiculoId { get; set; }

    public int ClienteId { get; set; }

    public string Placa { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Año { get; set; } = null!;

    public string Color { get; set; } = null!;
}
