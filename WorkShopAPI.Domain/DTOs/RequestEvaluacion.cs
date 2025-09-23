
namespace WorkShopAPI.Domain.DTOs
{
    public class RequestEvaluacion
    {
        public EvaluacionDto Evaluacion { get; set; } = null;
        public RepuestoEvaluacionDto RuestoEvaluacion { get; set; } = null;
        public FotografiaVehiculoDto FotografiaVehiculo { get; set; } = null;

    }
}
