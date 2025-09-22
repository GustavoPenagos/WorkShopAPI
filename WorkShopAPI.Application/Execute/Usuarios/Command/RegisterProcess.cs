using AutoMapper;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Application.Execute.Usuarios.Command
{
    public class RegisterProcess(IRegisterClient register,
        IMessageResponse response,
        IMapper mapper) : IRegisterProcess
    {
        private readonly IMapper _mapper = mapper;
        private readonly IMessageResponse _response = response;
        private readonly IRegisterClient _register = register;

        public async Task<Response> RegisterClientAsync(ClienteBase clienteBase, string token)
        {
            var register = await _register.RegisterDBAsync(
                _mapper.Map<Cliente>(clienteBase.Cliente),
                _mapper.Map<Usuario>(clienteBase.Usuario),
                _mapper.Map<CitaServicio>(clienteBase.CitaServicio),
                _mapper.Map<Vehiculo>(clienteBase.Vehiculo),
                
                token.GeneratePassword()
            );


            return _response.Message(200, MessageGenerics.Success, register);
        }
    }
}
