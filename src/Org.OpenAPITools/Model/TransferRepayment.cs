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
    /// A repayment is created automatically after one or more guaranteed transactions receive a return. If there are multiple eligible returns in a day, they are batched together into a single repayment.  Repayments are sent over ACH, with funds typically available on the next banking day.
    /// </summary>
    [DataContract(Name = "TransferRepayment")]
    public partial class TransferRepayment : Dictionary<String, Object>, IEquatable<TransferRepayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRepayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferRepayment()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRepayment" /> class.
        /// </summary>
        /// <param name="repaymentId">Identifier of the repayment. (required).</param>
        /// <param name="created">The datetime when the repayment occurred, in RFC 3339 format. (required).</param>
        /// <param name="amount">Decimal amount of the repayment as it appears on your account ledger. (required).</param>
        /// <param name="isoCurrencyCode">The currency of the repayment, e.g. \&quot;USD\&quot;. (required).</param>
        public TransferRepayment(string repaymentId = default(string), DateTime created = default(DateTime), string amount = default(string), string isoCurrencyCode = default(string)) : base()
        {
            // to ensure "repaymentId" is required (not null)
            if (repaymentId == null)
            {
                throw new ArgumentNullException("repaymentId is a required property for TransferRepayment and cannot be null");
            }
            this.RepaymentId = repaymentId;
            this.Created = created;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TransferRepayment and cannot be null");
            }
            this.Amount = amount;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for TransferRepayment and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Identifier of the repayment.
        /// </summary>
        /// <value>Identifier of the repayment.</value>
        [DataMember(Name = "repayment_id", IsRequired = true, EmitDefaultValue = false)]
        public string RepaymentId { get; set; }

        /// <summary>
        /// The datetime when the repayment occurred, in RFC 3339 format.
        /// </summary>
        /// <value>The datetime when the repayment occurred, in RFC 3339 format.</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Decimal amount of the repayment as it appears on your account ledger.
        /// </summary>
        /// <value>Decimal amount of the repayment as it appears on your account ledger.</value>
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
            sb.Append("class TransferRepayment {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RepaymentId: ").Append(RepaymentId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(input as TransferRepayment);
        }

        /// <summary>
        /// Returns true if TransferRepayment instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRepayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRepayment input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.RepaymentId == input.RepaymentId ||
                    (this.RepaymentId != null &&
                    this.RepaymentId.Equals(input.RepaymentId))
                ) && base.Equals(input) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.RepaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.RepaymentId.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
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
            yield break;
        }
    }

}
