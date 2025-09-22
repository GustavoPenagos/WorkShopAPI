using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Application.Common.Wrappers
{
    public class MessageResponse : IMessageResponse
    {
        public Response Message(int code, string message, object? body = null)
        => code switch
        {
            200 => SuccessFulMessage200(code, body),
            400 => ErrorMessage400(code, message),
            _ => throw new NotImplementedException("No se obtuvo una respuesta controlada.")
        };

        private static Response SuccessFulMessage200(int code, object body)
        => new()
        {
            MsgRsHdr = new()
            {
                Error = null
            },
            Body = new()
            {
                Result = body,
            }
        };

        private static Response ErrorMessage400(int code, string message)
        => new()
        {
            MsgRsHdr = new()
            {
                Error = new()
                {
                    Status = code,
                    StatusDesc = message,
                }
            },
            Body = new()
            {
                Result = null,
            }
        };

    }
}
