namespace Soenneker.Constants.UserMessages;

/// <summary>
/// Various constants for displaying to users
/// </summary>
public static class UserMessages
{
    /// <summary>
    /// The something went wrong title.
    /// </summary>
    public const string SomethingWentWrongTitle = "Something went wrong";
    /// <summary>
    /// The something went wrong detail.
    /// </summary>
    public const string SomethingWentWrongDetail = "We couldn't complete your request. Please try again.";

    /// <summary>
    /// The request canceled title.
    /// </summary>
    public const string RequestCanceledTitle = "Request canceled";
    /// <summary>
    /// The request canceled detail.
    /// </summary>
    public const string RequestCanceledDetail = "The request was canceled before it could complete.";

    /// <summary>
    /// The timeout title.
    /// </summary>
    public const string TimeoutTitle = "Request timeout";
    /// <summary>
    /// The timeout detail.
    /// </summary>
    public const string TimeoutDetail = "The request took too long to complete.";
}