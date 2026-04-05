
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Response containing a Lightning Network invoice for payment
    /// </summary>
    public sealed partial class LightningInvoiceResponse
    {
        /// <summary>
        /// Lightning Network payment invoice (BOLT 11 format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice")]
        public string? Invoice { get; set; }

        /// <summary>
        /// Amount in satoshis required for payment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_sats")]
        public int? AmountSats { get; set; }

        /// <summary>
        /// When the invoice expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LightningInvoiceResponse" /> class.
        /// </summary>
        /// <param name="invoice">
        /// Lightning Network payment invoice (BOLT 11 format)
        /// </param>
        /// <param name="amountSats">
        /// Amount in satoshis required for payment
        /// </param>
        /// <param name="expiresAt">
        /// When the invoice expires
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LightningInvoiceResponse(
            string? invoice,
            int? amountSats,
            global::System.DateTime? expiresAt)
        {
            this.Invoice = invoice;
            this.AmountSats = amountSats;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightningInvoiceResponse" /> class.
        /// </summary>
        public LightningInvoiceResponse()
        {
        }
    }
}