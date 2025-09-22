using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Application.Common.Interfaces
{
    public interface IRegisterProcess
    {
        Task<Response> RegisterClientAsync(ClienteBase clienteBase, string token);
    }
}
