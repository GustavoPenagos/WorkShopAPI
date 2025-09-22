using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Mecanico
{
    public int MecanicoId { get; set; }

    public int VehiculoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Especialidad { get; set; } = null!;

    public int Estado { get; set; }
}
