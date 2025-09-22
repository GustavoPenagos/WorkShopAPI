using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Application.Execute.Usuarios.Command
{
    public class LoginProcess(IAutenticate autenticate) : ILoginProcess
    {
        private readonly IAutenticate _autenticate = autenticate;
        public async Task<bool> Login(string userData)
        {
            try
            {
                var user = userData.Split(';');
                var response = await _autenticate.Autenticate(user[0], user[1].GeneratePassword());
                if (response.Body?.Result != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}
