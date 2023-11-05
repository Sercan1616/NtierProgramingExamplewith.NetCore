using static Udemy.TodoAppNTier.Common.ResponseObject.Response;

namespace Udemy.TodoAppNTier.Common.ResponseObject
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseTypes { get; set; }
    }
}
