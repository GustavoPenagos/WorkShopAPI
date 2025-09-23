using AutoMapper;
using Azure.Core;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.Execute.Repositories.Register
{
    public class RegisterClient(WorskShopContext context,
        IMapper mapper) : IRegisterClient
    {
        private readonly WorskShopContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<bool> RegisterAsync<T>(T data)
        {
            try
            {
                _context.Add(data);
                return ValidRegister(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private static bool ValidRegister(int v)
        => v > 0;
    }
}
