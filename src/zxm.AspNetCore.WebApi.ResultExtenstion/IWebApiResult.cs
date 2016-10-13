namespace zxm.AspNetCore.WebApi.ResultExtenstion
{
    /// <summary>
    /// WebApiResult model for webapi response
    /// </summary>
    public interface IWebApiResult
    {
        bool Success { get; set; }

        object Value { get; set; }

        string ErrorCode { get; set; }

        string ErrorMessage { get; set; }
    }
}
