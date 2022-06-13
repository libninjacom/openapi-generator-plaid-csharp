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
    /// PaymentInitiationPaymentReverseResponse defines the response schema for &#x60;/payment_initation/payment/reverse&#x60;
    /// </summary>
    [DataContract(Name = "PaymentInitiationPaymentReverseResponse")]
    public partial class PaymentInitiationPaymentReverseResponse : Dictionary<String, Object>, IEquatable<PaymentInitiationPaymentReverseResponse>, IValidatableObject
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
            /// Enum EXECUTED for value: EXECUTED
            /// </summary>
            [EnumMember(Value = "EXECUTED")]
            EXECUTED = 2,

            /// <summary>
            /// Enum INITIATED for value: INITIATED
            /// </summary>
            [EnumMember(Value = "INITIATED")]
            INITIATED = 3,

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
        /// Initializes a new instance of the <see cref="PaymentInitiationPaymentReverseResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInitiationPaymentReverseResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationPaymentReverseResponse" /> class.
        /// </summary>
        /// <param name="refundId">A unique ID identifying the refund (required).</param>
        /// <param name="status">The status of the refund.  &#x60;PROCESSING&#x60;: The refund is currently being processed. The refund will automatically exit this state when processing is complete.  &#x60;INITIATED&#x60;: The refund has been successfully initiated.  &#x60;EXECUTED&#x60;: Indicates that the refund has been successfully executed.  &#x60;FAILED&#x60;: The refund has failed to be executed. This error is retryable once the root cause is resolved. (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public PaymentInitiationPaymentReverseResponse(string refundId = default(string), StatusEnum status = default(StatusEnum), string requestId = default(string)) : base()
        {
            // to ensure "refundId" is required (not null)
            if (refundId == null)
            {
                throw new ArgumentNullException("refundId is a required property for PaymentInitiationPaymentReverseResponse and cannot be null");
            }
            this.RefundId = refundId;
            this.Status = status;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for PaymentInitiationPaymentReverseResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A unique ID identifying the refund
        /// </summary>
        /// <value>A unique ID identifying the refund</value>
        [DataMember(Name = "refund_id", IsRequired = true, EmitDefaultValue = false)]
        public string RefundId { get; set; }

        /// <summary>
        /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
        /// </summary>
        /// <value>A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.</value>
        [DataMember(Name = "request_id", IsRequired = true, EmitDefaultValue = false)]
        public string RequestId { get; set; }

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
            sb.Append("class PaymentInitiationPaymentReverseResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as PaymentInitiationPaymentReverseResponse);
        }

        /// <summary>
        /// Returns true if PaymentInitiationPaymentReverseResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInitiationPaymentReverseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInitiationPaymentReverseResponse input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
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