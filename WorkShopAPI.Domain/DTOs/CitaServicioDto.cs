using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs
{
    public class CitaServicioDto
    {
        public int CitaId { get; set; }
        public int MecanicoId { get; set; }
        public string Placa { get; set; } = null!;
        public string? FechaSolicitud { get; set; }

        public string? FechaProgramada { get; set; }

        public int Estado { get; set; }
    }
}
