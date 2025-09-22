using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string? PresupuestoMaximo { get; set; }
}
