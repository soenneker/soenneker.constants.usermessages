namespace Soenneker.Constants.UserMessages;

/// <summary>
/// Provides neutral user-facing messages for common request failures.
/// </summary>
public static class UserMessages
{
    /// <summary>
    /// The title for an unexpected failure.
    /// </summary>
    public const string SomethingWentWrongTitle = "Something went wrong";
    /// <summary>
    /// The detail for an unexpected failure.
    /// </summary>
    public const string SomethingWentWrongDetail = "We couldn't complete your request. Please try again.";

    /// <summary>
    /// The title for a canceled request.
    /// </summary>
    public const string RequestCanceledTitle = "Request canceled";
    /// <summary>
    /// The detail for a canceled request.
    /// </summary>
    public const string RequestCanceledDetail = "The request was canceled before it could complete.";

    /// <summary>
    /// The title for a request timeout.
    /// </summary>
    public const string TimeoutTitle = "Request timeout";
    /// <summary>
    /// The detail for a request timeout.
    /// </summary>
    public const string TimeoutDetail = "The request took too long to complete.";
}
