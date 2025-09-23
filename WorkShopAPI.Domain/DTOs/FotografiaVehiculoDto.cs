namespace WorkShopAPI.Domain.DTOs
{
    public class FotografiaVehiculoDto
    {
        public string Placa { get; set; } = null!;

        public int EvaluacionId { get; set; }

        public string Foto { get; set; } = null!;

        public DateTime FechaCarga { get; set; }
    }
}
