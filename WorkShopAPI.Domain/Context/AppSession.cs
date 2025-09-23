using System;
using System.Collections.Generic;

namespace WorkShopAPI.Domain.Context;

public partial class AppSession
{
    public int Id { get; set; }

    public string Session { get; set; } = null!;
}
