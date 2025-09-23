using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Application.Common.Interfaces
{
    public interface IRegisterProcess
    {
        Task<Response> RegisterAsync<T>(object dataDto);
        Task<Response> RegisterClientAsync(ClienteDto clienteDto, string token);
        Task<Response> RegisterValoracionAsync(RequestEvaluacion requestEvaluacion);
    }
}
