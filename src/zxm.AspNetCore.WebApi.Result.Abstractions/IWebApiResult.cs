﻿namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    /// <summary>
    /// WebApiResult model for webapi response
    /// </summary>
    public interface IWebApiResult
    {
        bool Success { get; set; }

        object Value { get; set; }

        ErrorCode ErrorCode { get; set; }

        string ErrorMessage { get; set; }
    }
}
