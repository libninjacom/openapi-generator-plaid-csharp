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
    /// Represents a return on a Guaranteed ACH transfer that is included in the specified repayment.
    /// </summary>
    [DataContract(Name = "TransferRepaymentReturn")]
    public partial class TransferRepaymentReturn : Dictionary<String, Object>, IEquatable<TransferRepaymentReturn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRepaymentReturn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferRepaymentReturn()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRepaymentReturn" /> class.
        /// </summary>
        /// <param name="transferId">The unique identifier of the guaranteed transfer that was returned. (required).</param>
        /// <param name="eventId">The unique identifier of the corresponding &#x60;reversed&#x60; transfer event. (required).</param>
        /// <param name="amount">The value of the returned transfer. (required).</param>
        /// <param name="isoCurrencyCode">The currency of the repayment, e.g. \&quot;USD\&quot;. (required).</param>
        public TransferRepaymentReturn(string transferId = default(string), int eventId = default(int), string amount = default(string), string isoCurrencyCode = default(string)) : base()
        {
            // to ensure "transferId" is required (not null)
            if (transferId == null)
            {
                throw new ArgumentNullException("transferId is a required property for TransferRepaymentReturn and cannot be null");
            }
            this.TransferId = transferId;
            this.EventId = eventId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TransferRepaymentReturn and cannot be null");
            }
            this.Amount = amount;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for TransferRepaymentReturn and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The unique identifier of the guaranteed transfer that was returned.
        /// </summary>
        /// <value>The unique identifier of the guaranteed transfer that was returned.</value>
        [DataMember(Name = "transfer_id", IsRequired = true, EmitDefaultValue = false)]
        public string TransferId { get; set; }

        /// <summary>
        /// The unique identifier of the corresponding &#x60;reversed&#x60; transfer event.
        /// </summary>
        /// <value>The unique identifier of the corresponding &#x60;reversed&#x60; transfer event.</value>
        [DataMember(Name = "event_id", IsRequired = true, EmitDefaultValue = false)]
        public int EventId { get; set; }

        /// <summary>
        /// The value of the returned transfer.
        /// </summary>
        /// <value>The value of the returned transfer.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The currency of the repayment, e.g. \&quot;USD\&quot;.
        /// </summary>
        /// <value>The currency of the repayment, e.g. \&quot;USD\&quot;.</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = false)]
        public string IsoCurrencyCode { get; set; }

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
            sb.Append("class TransferRepaymentReturn {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TransferId: ").Append(TransferId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
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
            return this.Equals(input as TransferRepaymentReturn);
        }

        /// <summary>
        /// Returns true if TransferRepaymentReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRepaymentReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRepaymentReturn input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.TransferId == input.TransferId ||
                    (this.TransferId != null &&
                    this.TransferId.Equals(input.TransferId))
                ) && base.Equals(input) && 
                (
                    this.EventId == input.EventId ||
                    this.EventId.Equals(input.EventId)
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
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
                if (this.TransferId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
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
            // EventId (int) minimum
            if (this.EventId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventId, must be a value greater than or equal to 0.", new [] { "EventId" });
            }

            yield break;
        }
    }

}
