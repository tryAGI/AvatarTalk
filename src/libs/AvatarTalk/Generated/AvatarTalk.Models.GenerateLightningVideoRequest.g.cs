
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Request body for generating a video after Lightning payment
    /// </summary>
    public sealed partial class GenerateLightningVideoRequest
    {
        /// <summary>
        /// The Lightning invoice that has been paid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Invoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLightningVideoRequest" /> class.
        /// </summary>
        /// <param name="invoice">
        /// The Lightning invoice that has been paid
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateLightningVideoRequest(
            string invoice)
        {
            this.Invoice = invoice ?? throw new global::System.ArgumentNullException(nameof(invoice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLightningVideoRequest" /> class.
        /// </summary>
        public GenerateLightningVideoRequest()
        {
        }
    }
}