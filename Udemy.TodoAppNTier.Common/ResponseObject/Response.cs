namespace Udemy.TodoAppNTier.Common.ResponseObject
{
    public class Response : IResponse
    {
        public Response(ResponseType responseType)
        {
            ResponseTypes = responseType;
        }

        public Response(ResponseType responseType, string message)
        {
            ResponseTypes = responseType;
            Message       = message;
        }

        public string Message{ get; set; }
        public ResponseType ResponseTypes { get; set; }
        public enum ResponseType
        {
            Success,
            ValidationError,
            NotFound
        }
    }
}
