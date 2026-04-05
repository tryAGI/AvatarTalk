
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// List of Lightning Network payments
    /// </summary>
    public sealed partial class PaymentsListResponse
    {
        /// <summary>
        /// Array of payment records
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payments")]
        public global::System.Collections.Generic.IList<global::AvatarTalk.PaymentStatusResponse>? Payments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsListResponse" /> class.
        /// </summary>
        /// <param name="payments">
        /// Array of payment records
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentsListResponse(
            global::System.Collections.Generic.IList<global::AvatarTalk.PaymentStatusResponse>? payments)
        {
            this.Payments = payments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsListResponse" /> class.
        /// </summary>
        public PaymentsListResponse()
        {
        }
    }
}