#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Check Lightning payment status<br/>
        /// Check the payment status of a Lightning Network invoice.
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.PaymentStatusResponse> GetPaymentStatusAsync(
            string invoice,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}