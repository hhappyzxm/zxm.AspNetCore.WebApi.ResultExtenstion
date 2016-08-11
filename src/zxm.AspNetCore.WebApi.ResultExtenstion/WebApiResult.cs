namespace zxm.AspNetCore.WebApi.ResultExtenstion
{
    /// <summary>
    /// WebApiResult model for webapi response
    /// </summary>
    public class WebApiResult : IWebApiResult
    {
        /// <summary>
        /// Constructor of MessageResult
        /// </summary>
        /// <param name="successed"></param>
        /// <param name="value"></param>
        /// <param name="message"></param>
        public WebApiResult(bool successed, object value = null, string message = null)
        {
            Successed = successed;
            Value = value;
            Message = message;
        }

        /// <summary>
        /// Determine whether action was successed
        /// </summary>
        public bool Successed { get; set; }

        /// <summary>
        /// Returned object
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Returned message, usually it as error message if action was not successed
        /// </summary>
        public string Message { get; set; }
    }
}
