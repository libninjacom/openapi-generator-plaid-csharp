/*
 * The Plaid API
 *
 * The Plaid REST API. Please see https://plaid.com/docs/api for more details.
 *
 * The version of the OpenAPI document: 2020-09-14_1.64.13
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// The transaction details
    /// </summary>
    [DataContract(Name = "WalletTransaction")]
    public partial class WalletTransaction : Dictionary<String, Object>, IEquatable<WalletTransaction>, IValidatableObject
    {
        /// <summary>
        /// The type of of the transaction. Currently, only &#x60;\&quot;PAYOUT\&quot;&#x60; is supported.
        /// </summary>
        /// <value>The type of of the transaction. Currently, only &#x60;\&quot;PAYOUT\&quot;&#x60; is supported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PAYOUT for value: PAYOUT
            /// </summary>
            [EnumMember(Value = "PAYOUT")]
            PAYOUT = 1

        }


        /// <summary>
        /// The type of of the transaction. Currently, only &#x60;\&quot;PAYOUT\&quot;&#x60; is supported.
        /// </summary>
        /// <value>The type of of the transaction. Currently, only &#x60;\&quot;PAYOUT\&quot;&#x60; is supported.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletTransaction()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransaction" /> class.
        /// </summary>
        /// <param name="transactionId">A unique ID identifying the transaction (required).</param>
        /// <param name="reference">A reference for the transaction (required).</param>
        /// <param name="type">The type of of the transaction. Currently, only &#x60;\&quot;PAYOUT\&quot;&#x60; is supported. (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="counterparty">counterparty (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="createdAt">Timestamp when the transaction was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
        public WalletTransaction(string transactionId = default(string), string reference = default(string), TypeEnum type = default(TypeEnum), WalletTransactionAmount amount = default(WalletTransactionAmount), WalletTransactionCounterparty counterparty = default(WalletTransactionCounterparty), WalletTransactionStatus status = default(WalletTransactionStatus), DateTime createdAt = default(DateTime)) : base()
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for WalletTransaction and cannot be null");
            }
            this.TransactionId = transactionId;
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new ArgumentNullException("reference is a required property for WalletTransaction and cannot be null");
            }
            this.Reference = reference;
            this.Type = type;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for WalletTransaction and cannot be null");
            }
            this.Amount = amount;
            // to ensure "counterparty" is required (not null)
            if (counterparty == null)
            {
                throw new ArgumentNullException("counterparty is a required property for WalletTransaction and cannot be null");
            }
            this.Counterparty = counterparty;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A unique ID identifying the transaction
        /// </summary>
        /// <value>A unique ID identifying the transaction</value>
        [DataMember(Name = "transaction_id", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// A reference for the transaction
        /// </summary>
        /// <value>A reference for the transaction</value>
        [DataMember(Name = "reference", IsRequired = true, EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionAmount Amount { get; set; }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionCounterparty Counterparty { get; set; }

        /// <summary>
        /// Timestamp when the transaction was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>Timestamp when the transaction was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WalletTransaction);
        }

        /// <summary>
        /// Returns true if WalletTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTransaction input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && base.Equals(input) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}