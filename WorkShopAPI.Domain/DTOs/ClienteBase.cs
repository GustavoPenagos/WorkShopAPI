
namespace WorkShopAPI.Domain.DTOs
{
    public class ClienteBase
    {
        public ClienteDto? Cliente { get; set; }
        public UsuarioDto? Usuario { get; set; }
        public VehiculoDto? Vehiculo { get; set; }
        public MecanicoDto? Mecanico { get; set; }
        public CitaServicioDto? CitaServicio { get; set; }
        public EvaluacionDto? Evaluacion { get; set; }
        public FacturaDto? Factura { get; set; }
        public FotografiaVehiculoDto? FotografiaVehiculo { get; set; }
        public RepuestoDto? Repuesto { get; set; }
        public RepuestoEvaluacionDto? RepuestoEvaluacion { get; set; }


    }
}
