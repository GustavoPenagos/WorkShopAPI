using WorkShopAPI.Application.Common.Wrappers;

namespace WorkShopAPI.Application.Common.Interfaces
{
    public interface ILoginProcess
    {
        Task<bool> Login(string userData);
    }
}
