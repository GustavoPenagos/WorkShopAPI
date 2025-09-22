using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs
{
    public class EvaluacionDto
    {
        public string DescripcionDanios { get; set; } = null!;

        public string? TiempoEstimado { get; set; }

        public decimal CostoManoObra { get; set; }

    }
}
