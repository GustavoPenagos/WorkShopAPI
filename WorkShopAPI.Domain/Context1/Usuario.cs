using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int ClienteId { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;
}
