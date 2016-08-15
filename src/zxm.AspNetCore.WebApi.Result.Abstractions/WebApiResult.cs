namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    public class WebApiResult : IWebApiResult
    {
        public WebApiResult()
        {
            Successed = true;
        }

        public WebApiResult(object value)
        {
            Successed = true;
            Value = value;
        }

        public WebApiResult(ErrorCode errorCode, string errorMessage)
        {
            Successed = false;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
        
        public bool Successed { get; set; }
        
        public object Value { get; set; }

        public ErrorCode ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
