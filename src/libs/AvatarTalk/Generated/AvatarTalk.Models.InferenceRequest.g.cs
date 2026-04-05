
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Request body for generating an avatar video from text
    /// </summary>
    public sealed partial class InferenceRequest
    {
        /// <summary>
        /// The text for the avatar to speak. Will be converted to speech using TTS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AvatarTalk.Emotion Emotion { get; set; }

        /// <summary>
        /// Language code for text-to-speech. Determines the voice language<br/>
        /// and pronunciation used for generating the avatar's speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AvatarTalk.JsonConverters.LanguageJsonConverter))]
        public global::AvatarTalk.Language? Language { get; set; }

        /// <summary>
        /// When true, the request is processed asynchronously.<br/>
        /// The response will include a task ID for polling the result.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delayed")]
        public bool? Delayed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceRequest(
            string text,
            global::AvatarTalk.AvatarName avatar,
            global::AvatarTalk.Emotion emotion,
            global::AvatarTalk.Language? language,
            bool? delayed)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Avatar = avatar;
            this.Emotion = emotion;
            this.Language = language;
            this.Delayed = delayed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequest" /> class.
        /// </summary>
        public InferenceRequest()
        {
        }
    }
}