﻿namespace zxm.AspNetCore.WebApi.Result.Abstractions
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

        public WebApiResult(ErrorCode errorCode, string errorMessage)
        {
            Success = false;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
        
        public bool Success { get; set; }
        
        public object Value { get; set; }

        public ErrorCode ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
