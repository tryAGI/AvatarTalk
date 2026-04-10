#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Generate avatar video<br/>
        /// Generate a lip-synced avatar video from text. The API uses text-to-speech<br/>
        /// to create audio and synchronizes avatar lip movements with the generated audio.<br/>
        /// Standard requests return a JSON response with video URLs.<br/>
        /// Set the stream query parameter to true for streaming MP4 video response.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.InferenceResponse> GenerateVideoAsync(

            global::AvatarTalk.InferenceRequest request,
            global::AvatarTalk.GenerateVideoStream? stream = default,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate avatar video<br/>
        /// Generate a lip-synced avatar video from text. The API uses text-to-speech<br/>
        /// to create audio and synchronizes avatar lip movements with the generated audio.<br/>
        /// Standard requests return a JSON response with video URLs.<br/>
        /// Set the stream query parameter to true for streaming MP4 video response.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="text">
        /// The text for the avatar to speak. Will be converted to speech using TTS.
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
        /// <param name="delayed">
        /// When true, the request is processed asynchronously.<br/>
        /// The response will include a task ID for polling the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.InferenceResponse> GenerateVideoAsync(
            string text,
            global::AvatarTalk.AvatarName avatar,
            global::AvatarTalk.Emotion emotion,
            global::AvatarTalk.GenerateVideoStream? stream = default,
            global::AvatarTalk.Language? language = default,
            bool? delayed = default,
            global::AvatarTalk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}