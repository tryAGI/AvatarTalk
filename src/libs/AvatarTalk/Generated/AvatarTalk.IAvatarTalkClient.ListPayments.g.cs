#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// List all Lightning payments<br/>
        /// List all Lightning Network payments associated with the API key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.PaymentsListResponse> ListPaymentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}