
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Response from a successful video generation request
    /// </summary>
    public sealed partial class InferenceResponse
    {
        /// <summary>
        /// Unique identifier for the inference request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Status of the inference (e.g., "success")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The input text that was spoken
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The avatar name that was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The emotion state that was applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// The language used for TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Number of credits consumed for this generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_consumed")]
        public double? CreditsConsumed { get; set; }

        /// <summary>
        /// Duration of the generated video in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_duration_seconds")]
        public double? VideoDurationSeconds { get; set; }

        /// <summary>
        /// Direct download URL for the generated MP4 video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mp4_url")]
        public string? Mp4Url { get; set; }

        /// <summary>
        /// URL for viewing the video in a web browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the inference request
        /// </param>
        /// <param name="status">
        /// Status of the inference (e.g., "success")
        /// </param>
        /// <param name="text">
        /// The input text that was spoken
        /// </param>
        /// <param name="avatar">
        /// The avatar name that was used
        /// </param>
        /// <param name="emotion">
        /// The emotion state that was applied
        /// </param>
        /// <param name="language">
        /// The language used for TTS
        /// </param>
        /// <param name="creditsConsumed">
        /// Number of credits consumed for this generation
        /// </param>
        /// <param name="videoDurationSeconds">
        /// Duration of the generated video in seconds
        /// </param>
        /// <param name="mp4Url">
        /// Direct download URL for the generated MP4 video
        /// </param>
        /// <param name="htmlUrl">
        /// URL for viewing the video in a web browser
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceResponse(
            global::System.Guid id,
            string status,
            string? text,
            string? avatar,
            string? emotion,
            string? language,
            double? creditsConsumed,
            double? videoDurationSeconds,
            string? mp4Url,
            string? htmlUrl)
        {
            this.Id = id;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Text = text;
            this.Avatar = avatar;
            this.Emotion = emotion;
            this.Language = language;
            this.CreditsConsumed = creditsConsumed;
            this.VideoDurationSeconds = videoDurationSeconds;
            this.Mp4Url = mp4Url;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResponse" /> class.
        /// </summary>
        public InferenceResponse()
        {
        }
    }
}