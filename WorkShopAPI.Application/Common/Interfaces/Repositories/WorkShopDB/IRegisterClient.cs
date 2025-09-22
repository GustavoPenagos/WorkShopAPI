using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB
{
    public interface IRegisterClient
    {
        Task<ClienteBase> RegisterDBAsync(Cliente cliente, 
            Usuario usuario, 
            CitaServicio citaServicio, 
            Vehiculo vehiculo,  
            string token);
    }
}
