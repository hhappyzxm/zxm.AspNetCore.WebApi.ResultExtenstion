using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using zxm.AspNetCore.WebApi.Result.Abstractions;

namespace zxm.AspNetCore.WebApi.ResultExtenstion
{
    /// <summary>
    /// ResultActionFilterAttributer
    /// </summary>
    public class ResultActionFilterAttributer : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var successed = context.Exception == null;
            if (!successed)
            {
                if (context.Exception is NonSystemException)
                {
                    context.Result = new ObjectResult(new WebApiResult(ErrorCode.InternalServerError, context.Exception.Message));
                    context.ExceptionHandled = true;
                }
            }
            else
            {
                if (context.Result != null)
                {
                    if (context.Result is ObjectResult)
                    {
                        var originalResult = (ObjectResult) context.Result;
                        context.Result = new ObjectResult(new WebApiResult(originalResult.Value));
                    }
                    else if (context.Result is EmptyResult)
                    {
                        context.Result = new ObjectResult(new WebApiResult());
                    }
                    else if (context.Result is JsonResult)
                    {
                        var originalResult = (JsonResult)context.Result;
                        context.Result = new JsonResult(new WebApiResult(originalResult.Value));
                    }
                }
                else
                {
                    throw new ArgumentNullException(nameof(context.Result));
                }
            }

            base.OnActionExecuted(context);
        }
    }
}
