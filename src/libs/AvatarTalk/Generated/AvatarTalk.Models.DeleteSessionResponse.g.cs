
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Response from deleting a session
    /// </summary>
    public sealed partial class DeleteSessionResponse
    {
        /// <summary>
        /// Status message confirming deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The task ID of the deleted session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSessionResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status message confirming deletion
        /// </param>
        /// <param name="taskId">
        /// The task ID of the deleted session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSessionResponse(
            string? status,
            string? taskId)
        {
            this.Status = status;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSessionResponse" /> class.
        /// </summary>
        public DeleteSessionResponse()
        {
        }
    }
}