
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestVideoByAudioRequest
    {
        /// <summary>
        /// Audio file for avatar lip-sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Audio file for avatar lip-sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Avatar name to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Avatar { get; set; }

        /// <summary>
        /// Emotion state for the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVideoByAudioRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestVideoByAudioRequest(
            byte[] audio,
            string audioname,
            string avatar,
            string? emotion)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVideoByAudioRequest" /> class.
        /// </summary>
        public RequestVideoByAudioRequest()
        {
        }
    }
}