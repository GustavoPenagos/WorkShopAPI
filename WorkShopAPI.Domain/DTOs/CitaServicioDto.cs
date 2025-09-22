using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs
{
    public class CitaServicioDto
    {
        public string? FechaSolicitud { get; set; }

        public string? FechaProgramada { get; set; }

        public int Estado { get; set; }
    }
}
