
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Status of a Lightning Network payment
    /// </summary>
    public sealed partial class PaymentStatusResponse
    {
        /// <summary>
        /// The Lightning invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice")]
        public string? Invoice { get; set; }

        /// <summary>
        /// Whether the invoice has been paid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid")]
        public bool? Paid { get; set; }

        /// <summary>
        /// Amount in satoshis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_sats")]
        public int? AmountSats { get; set; }

        /// <summary>
        /// When the payment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentStatusResponse" /> class.
        /// </summary>
        /// <param name="invoice">
        /// The Lightning invoice
        /// </param>
        /// <param name="paid">
        /// Whether the invoice has been paid
        /// </param>
        /// <param name="amountSats">
        /// Amount in satoshis
        /// </param>
        /// <param name="createdAt">
        /// When the payment was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentStatusResponse(
            string? invoice,
            bool? paid,
            int? amountSats,
            global::System.DateTime? createdAt)
        {
            this.Invoice = invoice;
            this.Paid = paid;
            this.AmountSats = amountSats;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentStatusResponse" /> class.
        /// </summary>
        public PaymentStatusResponse()
        {
        }
    }
}