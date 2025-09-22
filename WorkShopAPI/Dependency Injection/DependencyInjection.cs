
using Microsoft.EntityFrameworkCore;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Application.Execute.Consultas;
using WorkShopAPI.Application.Execute.Usuarios.Command;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.Utils;
using WorkShopAPI.Infrastructure.AutoMappers;
using WorkShopAPI.Infrastructure.Execute.Repositories.Consult;
using WorkShopAPI.Infrastructure.Execute.Repositories.LogIn;
using WorkShopAPI.Infrastructure.Execute.Repositories.Register;

namespace WorkShopAPI.RestService.Dependency_Injection
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection service, WebApplicationBuilder builder)
        {
            //Dependency injection
            service.AddTransient<IAutenticate, AutenticateProcess>();
            service.AddTransient<IRegisterClient, RegisterClient>();
            service.AddTransient<IConsults, Consults>();

            service.AddTransient<ILoginProcess, LoginProcess>();
            service.AddTransient<IMessageResponse, MessageResponse>();
            service.AddTransient<IRegisterProcess, RegisterProcess>();
            service.AddTransient<IConsultProcess, ConsultProcess>();



            //Context configuration
            service.AddDbContext<WorskShopContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WorkShopConnection")));

            //Use Angular Service
            service.AddCors(options =>
            {
                options.AddPolicy("AngularServiceName".GetFromApp<string>(), policy =>
                {
                    policy.WithOrigins("AngularUrlService".GetFromApp<string>())
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            //AutoMapper
            #region AutoMapperConfig
            service.AddAutoMapper(typeof(ClienteProfile));
            service.AddAutoMapper(typeof(UsuarioProfile));
            service.AddAutoMapper(typeof(CitaSercivioProfile));
            service.AddAutoMapper(typeof(EvaluacionProfile));
            service.AddAutoMapper(typeof(FacturaProfile));
            service.AddAutoMapper(typeof(FotografiaVehiculoProfile));
            service.AddAutoMapper(typeof(MecanicoProfile));
            service.AddAutoMapper(typeof(RepuestoEvaluacionProfile));
            service.AddAutoMapper(typeof(RespuestoProfile));
            service.AddAutoMapper(typeof(VehiculoProfile));
            #endregion


            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
