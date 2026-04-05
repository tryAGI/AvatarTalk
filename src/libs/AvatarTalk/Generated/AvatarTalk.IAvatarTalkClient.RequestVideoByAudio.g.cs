#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Request video via Lightning Network (audio)<br/>
        /// Request an avatar video generation using Bitcoin Lightning Network payment.<br/>
        /// Submit an audio file to generate a Lightning invoice for payment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.LightningInvoiceResponse> RequestVideoByAudioAsync(

            global::AvatarTalk.RequestVideoByAudioRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request video via Lightning Network (audio)<br/>
        /// Request an avatar video generation using Bitcoin Lightning Network payment.<br/>
        /// Submit an audio file to generate a Lightning invoice for payment.
        /// </summary>
        /// <param name="audio">
        /// Audio file for avatar lip-sync
        /// </param>
        /// <param name="audioname">
        /// Audio file for avatar lip-sync
        /// </param>
        /// <param name="avatar">
        /// Avatar name to use
        /// </param>
        /// <param name="emotion">
        /// Emotion state for the avatar
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.LightningInvoiceResponse> RequestVideoByAudioAsync(
            byte[] audio,
            string audioname,
            string avatar,
            string? emotion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}