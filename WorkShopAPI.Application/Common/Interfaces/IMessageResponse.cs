using WorkShopAPI.Application.Common.Wrappers;

namespace WorkShopAPI.Application.Common.Interfaces
{
    public interface IMessageResponse
    {
        Response Message(int code, string message, object? body = null);
    }
}
