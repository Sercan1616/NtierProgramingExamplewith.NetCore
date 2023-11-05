using System.Collections.Generic;

namespace Udemy.TodoAppNTier.Common.ResponseObject
{
    public class Response<T> : Response, IResponse<T>
    {
        public T Data { get; set; }
        public Response  (ResponseType responseType, T data) : base(responseType)
        {
            Data = data;
        }

        public Response(ResponseType responseType, string message) : base(responseType,message)
        {
        }
        public Response(ResponseType responseType, T data, List<CustomValidatorError> errors) : base(responseType)
        {
            ValidatorErrors = errors;
            Data            = data;
        }
        public List<CustomValidatorError> ValidatorErrors { get; set; }
}
}
