using Microsoft.EntityFrameworkCore;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Infrastructure.Execute.Repositories.LogIn
{
    public class AutenticateProcess(WorskShopContext context, 
        IMessageResponse response) : IAutenticate
    {
        private readonly WorskShopContext _context = context;
        private readonly IMessageResponse _response = response;

        public async Task<Response> Autenticate(string username, string password)
        {
            try
            {
                var response = await _context.Usuarios.FirstAsync(i => i.Usuario1.Equals(username) && i.Contrasenia.Equals(password));
                if (response == null)
                {
                    return _response.Message(404, MessageGenerics.NotFound, null);
                }
                return _response.Message(200, MessageGenerics.Success, username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
