
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Response from creating a LiveKit session
    /// </summary>
    public sealed partial class LiveKitSessionResponse
    {
        /// <summary>
        /// Unique task identifier for the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Token for joining the LiveKit room as a participant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participant_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParticipantToken { get; set; }

        /// <summary>
        /// The LiveKit server URL to connect to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// Status of the session creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveKitSessionResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task identifier for the session
        /// </param>
        /// <param name="participantToken">
        /// Token for joining the LiveKit room as a participant
        /// </param>
        /// <param name="serverUrl">
        /// The LiveKit server URL to connect to
        /// </param>
        /// <param name="status">
        /// Status of the session creation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveKitSessionResponse(
            string taskId,
            string participantToken,
            string? serverUrl,
            string? status)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.ParticipantToken = participantToken ?? throw new global::System.ArgumentNullException(nameof(participantToken));
            this.ServerUrl = serverUrl;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveKitSessionResponse" /> class.
        /// </summary>
        public LiveKitSessionResponse()
        {
        }
    }
}