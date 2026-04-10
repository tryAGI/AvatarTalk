#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Request video via Lightning Network (text)<br/>
        /// Request an avatar video generation using Bitcoin Lightning Network payment.<br/>
        /// Provide text to generate a Lightning invoice for payment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.LightningInvoiceResponse> RequestVideoByTextAsync(

            global::AvatarTalk.LightningTextRequest request,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request video via Lightning Network (text)<br/>
        /// Request an avatar video generation using Bitcoin Lightning Network payment.<br/>
        /// Provide text to generate a Lightning invoice for payment.
        /// </summary>
        /// <param name="text">
        /// The text for the avatar to speak
        /// </param>
        /// <param name="avatar">
        /// Available avatar characters. Each avatar represents a different<br/>
        /// person with distinct appearance and demographics.
        /// </param>
        /// <param name="emotion">
        /// Emotion state for the avatar. Controls facial expression during speech.
        /// </param>
        /// <param name="language">
        /// Language code for text-to-speech. Determines the voice language<br/>
        /// and pronunciation used for generating the avatar's speech.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.LightningInvoiceResponse> RequestVideoByTextAsync(
            string text,
            global::AvatarTalk.AvatarName avatar,
            global::AvatarTalk.Emotion emotion,
            global::AvatarTalk.Language? language = default,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}