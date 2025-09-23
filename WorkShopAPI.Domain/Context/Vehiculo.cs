using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Vehiculo
{
    public int Documento { get; set; }

    public string Placa { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Color { get; set; } = null!;

    public virtual Cliente DocumentoNavigation { get; set; } = null!;

    public virtual ICollection<FotografiaVehiculo> FotografiaVehiculos { get; set; } = new List<FotografiaVehiculo>();
}
