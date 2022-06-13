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
    /// PaymentInitiationPaymentTokenCreateResponse defines the response schema for &#x60;/payment_initiation/payment/token/create&#x60;
    /// </summary>
    [DataContract(Name = "PaymentInitiationPaymentTokenCreateResponse")]
    public partial class PaymentInitiationPaymentTokenCreateResponse : Dictionary<String, Object>, IEquatable<PaymentInitiationPaymentTokenCreateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationPaymentTokenCreateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInitiationPaymentTokenCreateResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationPaymentTokenCreateResponse" /> class.
        /// </summary>
        /// <param name="paymentToken">A &#x60;payment_token&#x60; that can be provided to Link initialization to enter the payment initiation flow (required).</param>
        /// <param name="paymentTokenExpirationTime">The date and time at which the token will expire, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. A &#x60;payment_token&#x60; expires after 15 minutes. (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public PaymentInitiationPaymentTokenCreateResponse(string paymentToken = default(string), DateTime paymentTokenExpirationTime = default(DateTime), string requestId = default(string)) : base()
        {
            // to ensure "paymentToken" is required (not null)
            if (paymentToken == null)
            {
                throw new ArgumentNullException("paymentToken is a required property for PaymentInitiationPaymentTokenCreateResponse and cannot be null");
            }
            this.PaymentToken = paymentToken;
            this.PaymentTokenExpirationTime = paymentTokenExpirationTime;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for PaymentInitiationPaymentTokenCreateResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A &#x60;payment_token&#x60; that can be provided to Link initialization to enter the payment initiation flow
        /// </summary>
        /// <value>A &#x60;payment_token&#x60; that can be provided to Link initialization to enter the payment initiation flow</value>
        [DataMember(Name = "payment_token", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentToken { get; set; }

        /// <summary>
        /// The date and time at which the token will expire, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. A &#x60;payment_token&#x60; expires after 15 minutes.
        /// </summary>
        /// <value>The date and time at which the token will expire, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. A &#x60;payment_token&#x60; expires after 15 minutes.</value>
        [DataMember(Name = "payment_token_expiration_time", IsRequired = true, EmitDefaultValue = false)]
        public DateTime PaymentTokenExpirationTime { get; set; }

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
            sb.Append("class PaymentInitiationPaymentTokenCreateResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  PaymentTokenExpirationTime: ").Append(PaymentTokenExpirationTime).Append("\n");
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
            return this.Equals(input as PaymentInitiationPaymentTokenCreateResponse);
        }

        /// <summary>
        /// Returns true if PaymentInitiationPaymentTokenCreateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInitiationPaymentTokenCreateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInitiationPaymentTokenCreateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && base.Equals(input) && 
                (
                    this.PaymentTokenExpirationTime == input.PaymentTokenExpirationTime ||
                    (this.PaymentTokenExpirationTime != null &&
                    this.PaymentTokenExpirationTime.Equals(input.PaymentTokenExpirationTime))
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
                if (this.PaymentToken != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentToken.GetHashCode();
                }
                if (this.PaymentTokenExpirationTime != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentTokenExpirationTime.GetHashCode();
                }
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
