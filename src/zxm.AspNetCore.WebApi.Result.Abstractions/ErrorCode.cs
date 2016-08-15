namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    public enum ErrorCode
    {
        None = 0,

        InvalidHttpMethod = 1000,

        InvalidContentType = 2000,

        InvalidSignature = 3000,
        InvalidClientId = 3001,

        InvalidLoggedUserToken = 4000,
        LoggedUserTokenExpired = 4001,

        InternalServerError = 5000
    }
}
