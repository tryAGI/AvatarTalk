
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Request body for creating a LiveKit avatar session
    /// </summary>
    public sealed partial class CreateLiveKitSessionRequest
    {
        /// <summary>
        /// Available avatar characters. Each avatar represents a different<br/>
        /// person with distinct appearance and demographics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AvatarTalk.JsonConverters.AvatarNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AvatarTalk.AvatarName Avatar { get; set; }

        /// <summary>
        /// Emotion state for the avatar. Controls facial expression during speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AvatarTalk.JsonConverters.EmotionJsonConverter))]
        public global::AvatarTalk.Emotion? Emotion { get; set; }

        /// <summary>
        /// Language code for text-to-speech. Determines the voice language<br/>
        /// and pronunciation used for generating the avatar's speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AvatarTalk.JsonConverters.LanguageJsonConverter))]
        public global::AvatarTalk.Language? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveKitSessionRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLiveKitSessionRequest(
            global::AvatarTalk.AvatarName avatar,
            global::AvatarTalk.Emotion? emotion,
            global::AvatarTalk.Language? language)
        {
            this.Avatar = avatar;
            this.Emotion = emotion;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveKitSessionRequest" /> class.
        /// </summary>
        public CreateLiveKitSessionRequest()
        {
        }
    }
}