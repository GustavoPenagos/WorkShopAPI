namespace WorkShopAPI.Domain.DTOs
{
    public class RepuestoEvaluacionDto
    {
        public int EvaluacionId { get; set; }

        public int RepuestoId { get; set; }

        public int Cantidad { get; set; }

        public int CambioAdicional { get; set; }
    }
}
