using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB
{
    public interface IRegisterClient
    {
        Task<bool> RegisterAsync<T>(T data);
    }
}
