namespace WorkShopAPI.Domain.DTOs
{
    public class FacturaDto
    {
        public string? FechaEmision { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Iva { get; set; }

        public decimal Total { get; set; }

        public int AlertaPresupuesto { get; set; }
    }
}

