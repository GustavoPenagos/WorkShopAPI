using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs
{
    public class VehiculoDto
    {
        public string Placa { get; set; } = null!;

        public string Marca { get; set; } = null!;

        public string Modelo { get; set; } = null!;

        public string Color { get; set; } = null!;

    }
}
