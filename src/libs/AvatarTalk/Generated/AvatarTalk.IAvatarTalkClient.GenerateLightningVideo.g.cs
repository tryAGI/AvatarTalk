#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Generate video after Lightning payment<br/>
        /// Generate the avatar video after a Lightning Network invoice has been paid.<br/>
        /// Use the invoice from the request-video endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.InferenceResponse> GenerateLightningVideoAsync(

            global::AvatarTalk.GenerateLightningVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video after Lightning payment<br/>
        /// Generate the avatar video after a Lightning Network invoice has been paid.<br/>
        /// Use the invoice from the request-video endpoint.
        /// </summary>
        /// <param name="invoice">
        /// The Lightning invoice that has been paid
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.InferenceResponse> GenerateLightningVideoAsync(
            string invoice,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}