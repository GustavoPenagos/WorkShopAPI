using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs
{
    public class EvaluacionDto
    {
        public int CitaId { get; set; }

        public string DescripcionDanios { get; set; } = null!;

        public int TiempoEstimado { get; set; }

        public decimal CostoManoObra { get; set; }

    }
}
