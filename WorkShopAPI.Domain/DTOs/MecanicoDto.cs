using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs
{
    public class MecanicoDto
    {
        public int Documento { get; set; }
        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Especialidad { get; set; } = null!;

        public int Estado { get; set; }
        public virtual IList<CitaServicioDto> CitaServicios { get; set; } = [];
    }
}
