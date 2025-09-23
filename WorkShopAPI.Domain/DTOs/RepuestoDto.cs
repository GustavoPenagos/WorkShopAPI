namespace WorkShopAPI.Domain.DTOs
{
    public class RepuestoDto
    {
        public int RepuestoId { get; set; }
        public string Nombre { get; set; } = null!;

        public decimal PrecioUnitario { get; set; }
    }
}
