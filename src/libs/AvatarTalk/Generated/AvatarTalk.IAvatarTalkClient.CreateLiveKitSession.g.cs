#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Create a LiveKit avatar session<br/>
        /// Creates a new LiveKit session for real-time avatar interaction.<br/>
        /// Returns session details including a participant token for joining the LiveKit room.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.LiveKitSessionResponse> CreateLiveKitSessionAsync(

            global::AvatarTalk.CreateLiveKitSessionRequest request,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a LiveKit avatar session<br/>
        /// Creates a new LiveKit session for real-time avatar interaction.<br/>
        /// Returns session details including a participant token for joining the LiveKit room.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::AvatarTalk.LiveKitSessionResponse> CreateLiveKitSessionAsync(
            global::AvatarTalk.AvatarName avatar,
            global::AvatarTalk.Emotion? emotion = default,
            global::AvatarTalk.Language? language = default,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}