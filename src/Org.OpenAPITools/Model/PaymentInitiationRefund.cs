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
    /// PaymentInitiationRefund defines a payment initiation refund
    /// </summary>
    [DataContract(Name = "PaymentInitiationRefund")]
    public partial class PaymentInitiationRefund : Dictionary<String, Object>, IEquatable<PaymentInitiationRefund>, IValidatableObject
    {
        /// <summary>
        /// The status of the refund.  &#x60;PROCESSING&#x60;: The refund is currently being processed. The refund will automatically exit this state when processing is complete.  &#x60;INITIATED&#x60;: The refund has been successfully initiated.  &#x60;EXECUTED&#x60;: Indicates that the refund has been successfully executed.  &#x60;FAILED&#x60;: The refund has failed to be executed. This error is retryable once the root cause is resolved.
        /// </summary>
        /// <value>The status of the refund.  &#x60;PROCESSING&#x60;: The refund is currently being processed. The refund will automatically exit this state when processing is complete.  &#x60;INITIATED&#x60;: The refund has been successfully initiated.  &#x60;EXECUTED&#x60;: Indicates that the refund has been successfully executed.  &#x60;FAILED&#x60;: The refund has failed to be executed. This error is retryable once the root cause is resolved.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING = 1,

            /// <summary>
            /// Enum INITIATED for value: INITIATED
            /// </summary>
            [EnumMember(Value = "INITIATED")]
            INITIATED = 2,

            /// <summary>
            /// Enum EXECUTED for value: EXECUTED
            /// </summary>
            [EnumMember(Value = "EXECUTED")]
            EXECUTED = 3,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 4

        }


        /// <summary>
        /// The status of the refund.  &#x60;PROCESSING&#x60;: The refund is currently being processed. The refund will automatically exit this state when processing is complete.  &#x60;INITIATED&#x60;: The refund has been successfully initiated.  &#x60;EXECUTED&#x60;: Indicates that the refund has been successfully executed.  &#x60;FAILED&#x60;: The refund has failed to be executed. This error is retryable once the root cause is resolved.
        /// </summary>
        /// <value>The status of the refund.  &#x60;PROCESSING&#x60;: The refund is currently being processed. The refund will automatically exit this state when processing is complete.  &#x60;INITIATED&#x60;: The refund has been successfully initiated.  &#x60;EXECUTED&#x60;: Indicates that the refund has been successfully executed.  &#x60;FAILED&#x60;: The refund has failed to be executed. This error is retryable once the root cause is resolved.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationRefund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInitiationRefund()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationRefund" /> class.
        /// </summary>
        /// <param name="refundId">The ID of the refund. Like all Plaid identifiers, the &#x60;refund_id&#x60; is case sensitive. (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="status">The status of the refund.  &#x60;PROCESSING&#x60;: The refund is currently being processed. The refund will automatically exit this state when processing is complete.  &#x60;INITIATED&#x60;: The refund has been successfully initiated.  &#x60;EXECUTED&#x60;: Indicates that the refund has been successfully executed.  &#x60;FAILED&#x60;: The refund has failed to be executed. This error is retryable once the root cause is resolved. (required).</param>
        /// <param name="lastStatusUpdate">The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format (required).</param>
        public PaymentInitiationRefund(string refundId = default(string), PaymentAmount amount = default(PaymentAmount), StatusEnum status = default(StatusEnum), DateTime lastStatusUpdate = default(DateTime)) : base()
        {
            // to ensure "refundId" is required (not null)
            if (refundId == null)
            {
                throw new ArgumentNullException("refundId is a required property for PaymentInitiationRefund and cannot be null");
            }
            this.RefundId = refundId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for PaymentInitiationRefund and cannot be null");
            }
            this.Amount = amount;
            this.Status = status;
            this.LastStatusUpdate = lastStatusUpdate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the refund. Like all Plaid identifiers, the &#x60;refund_id&#x60; is case sensitive.
        /// </summary>
        /// <value>The ID of the refund. Like all Plaid identifiers, the &#x60;refund_id&#x60; is case sensitive.</value>
        [DataMember(Name = "refund_id", IsRequired = true, EmitDefaultValue = false)]
        public string RefundId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public PaymentAmount Amount { get; set; }

        /// <summary>
        /// The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format
        /// </summary>
        /// <value>The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format</value>
        [DataMember(Name = "last_status_update", IsRequired = true, EmitDefaultValue = false)]
        public DateTime LastStatusUpdate { get; set; }

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
            sb.Append("class PaymentInitiationRefund {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastStatusUpdate: ").Append(LastStatusUpdate).Append("\n");
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
            return this.Equals(input as PaymentInitiationRefund);
        }

        /// <summary>
        /// Returns true if PaymentInitiationRefund instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInitiationRefund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInitiationRefund input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.RefundId == input.RefundId ||
                    (this.RefundId != null &&
                    this.RefundId.Equals(input.RefundId))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.LastStatusUpdate == input.LastStatusUpdate ||
                    (this.LastStatusUpdate != null &&
                    this.LastStatusUpdate.Equals(input.LastStatusUpdate))
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
                if (this.RefundId != null)
                {
                    hashCode = (hashCode * 59) + this.RefundId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.LastStatusUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastStatusUpdate.GetHashCode();
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
