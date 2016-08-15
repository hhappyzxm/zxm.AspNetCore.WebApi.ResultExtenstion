namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    public enum ErrorCode
    {
        None = 0,

        InvalidHttpMethod = 1000,

        InvalidContentType = 2000,

        InvalidSignature = 3000,
        MissingClientId = 3001,
        InvalidClientId = 3002,
        MissingSignature = 3003,
        MissingTimestamp = 3004,
        TimestampExpired = 3005,

        MissingUserAccessToken = 4000,
        InvalidUserAccessToken = 4001,
        UserAccessTokenExpired = 4002,

        InternalServerError = 5000
    }
}
