using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Cliente
{
    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public int Documento { get; set; }

    public string Correo { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public decimal PresupuestoMaximo { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
