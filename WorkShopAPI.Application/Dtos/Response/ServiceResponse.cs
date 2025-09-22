using WorkShopAPI.Domain.Enums;

namespace WorkShopAPI.Application.Dtos.Response
{
    public class ServiceResponse
    {
        public EstadoOperacion Estado {  get; set; }
        public object? Message { get; set; }
        public string? CodigoValidacion { get; set; }
    }
}
