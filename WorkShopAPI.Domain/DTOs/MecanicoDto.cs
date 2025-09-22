namespace WorkShopAPI.Domain.DTOs
{
    public class MecanicoDto
    {
        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Especialidad { get; set; } = null!;

        public int Estado { get; set; }
    }
}
