using WorkShopAPI.Application.Common.Wrappers;

namespace WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB
{
    public interface IAutenticate
    {
        Task<Response> Autenticate(string username, string password);
    }
}
