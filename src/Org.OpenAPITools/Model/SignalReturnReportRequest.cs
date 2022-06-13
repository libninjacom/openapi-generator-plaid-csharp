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
    /// SignalReturnReportRequest defines the request schema for &#x60;/signal/return/report&#x60;
    /// </summary>
    [DataContract(Name = "SignalReturnReportRequest")]
    public partial class SignalReturnReportRequest : IEquatable<SignalReturnReportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalReturnReportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignalReturnReportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalReturnReportRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="clientTransactionId">Must be the same as the &#x60;client_transaction_id&#x60; supplied when calling &#x60;/signal/evaluate&#x60; (required).</param>
        /// <param name="returnCode">Must be a valid ACH return code (e.g. \&quot;R01\&quot;) (required).</param>
        public SignalReturnReportRequest(string clientId = default(string), string secret = default(string), string clientTransactionId = default(string), string returnCode = default(string))
        {
            // to ensure "clientTransactionId" is required (not null)
            if (clientTransactionId == null)
            {
                throw new ArgumentNullException("clientTransactionId is a required property for SignalReturnReportRequest and cannot be null");
            }
            this.ClientTransactionId = clientTransactionId;
            // to ensure "returnCode" is required (not null)
            if (returnCode == null)
            {
                throw new ArgumentNullException("returnCode is a required property for SignalReturnReportRequest and cannot be null");
            }
            this.ReturnCode = returnCode;
            this.ClientId = clientId;
            this.Secret = secret;
        }

        /// <summary>
        /// Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// Must be the same as the &#x60;client_transaction_id&#x60; supplied when calling &#x60;/signal/evaluate&#x60;
        /// </summary>
        /// <value>Must be the same as the &#x60;client_transaction_id&#x60; supplied when calling &#x60;/signal/evaluate&#x60;</value>
        [DataMember(Name = "client_transaction_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientTransactionId { get; set; }

        /// <summary>
        /// Must be a valid ACH return code (e.g. \&quot;R01\&quot;)
        /// </summary>
        /// <value>Must be a valid ACH return code (e.g. \&quot;R01\&quot;)</value>
        [DataMember(Name = "return_code", IsRequired = true, EmitDefaultValue = false)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignalReturnReportRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  ClientTransactionId: ").Append(ClientTransactionId).Append("\n");
            sb.Append("  ReturnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SignalReturnReportRequest);
        }

        /// <summary>
        /// Returns true if SignalReturnReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalReturnReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalReturnReportRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.ClientTransactionId == input.ClientTransactionId ||
                    (this.ClientTransactionId != null &&
                    this.ClientTransactionId.Equals(input.ClientTransactionId))
                ) && 
                (
                    this.ReturnCode == input.ReturnCode ||
                    (this.ReturnCode != null &&
                    this.ReturnCode.Equals(input.ReturnCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                if (this.ClientTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientTransactionId.GetHashCode();
                }
                if (this.ReturnCode != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnCode.GetHashCode();
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
            // ClientTransactionId (string) maxLength
            if (this.ClientTransactionId != null && this.ClientTransactionId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientTransactionId, length must be less than 36.", new [] { "ClientTransactionId" });
            }

            // ClientTransactionId (string) minLength
            if (this.ClientTransactionId != null && this.ClientTransactionId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientTransactionId, length must be greater than 1.", new [] { "ClientTransactionId" });
            }

            yield break;
        }
    }

}
