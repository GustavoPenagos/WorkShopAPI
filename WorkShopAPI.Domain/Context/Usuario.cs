using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class Usuario
{
    public int Documento { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public virtual Cliente DocumentoNavigation { get; set; } = null!;
}
