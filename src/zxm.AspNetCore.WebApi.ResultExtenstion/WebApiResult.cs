namespace zxm.AspNetCore.WebApi.ResultExtenstion
{
    public class WebApiResult : IWebApiResult
    {
        public WebApiResult()
        {
            Success = true;
        }

        public WebApiResult(object value)
        {
            Success = true;
            Value = value;
        }

        public WebApiResult(string errorMessage, string errorCode = null)
        {
            Success = false;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
        
        public bool Success { get; set; }
        
        public object Value { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
