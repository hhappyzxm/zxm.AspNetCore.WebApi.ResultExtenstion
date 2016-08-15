using System;
using System.Collections.Generic;

namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    public static class ErrorMessageFactory
    {
        public static string GetErrorMessage(ErrorCode errorCode)
        {
            switch (errorCode)
            {
                case ErrorCode.InvalidHttpMethod:
                    return "invalid http method";
                case ErrorCode.InvalidContentType:
                    return "invalid content";
                case ErrorCode.InvalidSignature:
                    return "invalid signature";
                case ErrorCode.MissingClientId:
                    return "missing client id";
                case ErrorCode.InvalidClientId:
                    return "invalid client id";
                case ErrorCode.MissingSignature:
                    return "missing signature";
                case ErrorCode.MissingTimestamp:
                    return "missing timestamp";
                case ErrorCode.TimestampExpired:
                    return "timestamp expired";
                case ErrorCode.MissingUserAccessToken:
                    return "missing user access token";
                case ErrorCode.InvalidUserAccessToken:
                    return "invalid user access token";
                case ErrorCode.UserAccessTokenExpired:
                    return "user access token expired";
                case ErrorCode.InternalServerError:
                    return "internal server error";
                default:
                    return string.Empty;
            }
        }
    }
}
