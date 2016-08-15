using System;
using System.Collections.Generic;

namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    public class ErrorMessageDefaults
    {
        public const string InvalidHttpMethod = "Invalid http method.";

        public const string InvalidContentType = "Invalid content type.";

        public const string InvalidSignature = "Invalid signature.";

        public const string InvalidClientId = "Invalid client id.";

        public const string InvalidLoggedUserToken = "Invalid logged user token.";

        public const string LoggedUserTokenExpired = "Logged user token expiried.";

        public const string InternalServerError = "Internal server error.";
    }
}
