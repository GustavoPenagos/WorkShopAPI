using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs { 
    public class ClienteDto
    {
        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Documento { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Celular { get; set; } = null!;

        public string? PresupuestoMaximo { get; set; }

    }
}
