namespace zxm.AspNetCore.WebApi.ResultExtenstion
{
    /// <summary>
    /// WebApiResult model for webapi response
    /// </summary>
    public interface IWebApiResult
    {
        /// <summary>
        /// Determine whether action was successed
        /// </summary>
        bool Successed { get; set; }

        /// <summary>
        /// Returned object
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Returned message, usually it as error message if action was not successed
        /// </summary>
        string Message { get; set; }
    }
}
