
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Error response from the API
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Error code (e.g., INVALID_PARAMETERS, INVALID_API_KEY, INSUFFICIENT_CREDITS, INFERENCE_FAILED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Human-readable error description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error code (e.g., INVALID_PARAMETERS, INVALID_API_KEY, INSUFFICIENT_CREDITS, INFERENCE_FAILED)
        /// </param>
        /// <param name="message">
        /// Human-readable error description
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string? error,
            string? message)
        {
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}