using WorkShopAPI.Domain.Context;

namespace WorkShopAPI.Domain.DTOs { 
    public class ClienteDto
    {
        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public int Documento { get; set; }

        public string Correo { get; set; } = null!;

        public string Celular { get; set; } = null!;

        public decimal PresupuestoMaximo { get; set; }

        public virtual IList<UsuarioDto> Usuarios { get; set; } = [];

        public virtual IList<VehiculoDto> Vehiculos { get; set; } = [];

    }
}
