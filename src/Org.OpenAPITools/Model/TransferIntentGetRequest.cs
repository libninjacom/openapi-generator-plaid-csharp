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
    /// Defines the request schema for &#x60;/transfer/intent/get&#x60;
    /// </summary>
    [DataContract(Name = "TransferIntentGetRequest")]
    public partial class TransferIntentGetRequest : Dictionary<String, Object>, IEquatable<TransferIntentGetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferIntentGetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferIntentGetRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferIntentGetRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. (required).</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. (required).</param>
        /// <param name="transferIntentId">Plaid&#39;s unique identifier for a transfer intent object. (required).</param>
        public TransferIntentGetRequest(string clientId = default(string), string secret = default(string), string transferIntentId = default(string)) : base()
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for TransferIntentGetRequest and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new ArgumentNullException("secret is a required property for TransferIntentGetRequest and cannot be null");
            }
            this.Secret = secret;
            // to ensure "transferIntentId" is required (not null)
            if (transferIntentId == null)
            {
                throw new ArgumentNullException("transferIntentId is a required property for TransferIntentGetRequest and cannot be null");
            }
            this.TransferIntentId = transferIntentId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.</value>
        [DataMember(Name = "secret", IsRequired = true, EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// Plaid&#39;s unique identifier for a transfer intent object.
        /// </summary>
        /// <value>Plaid&#39;s unique identifier for a transfer intent object.</value>
        [DataMember(Name = "transfer_intent_id", IsRequired = true, EmitDefaultValue = false)]
        public string TransferIntentId { get; set; }

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
            sb.Append("class TransferIntentGetRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  TransferIntentId: ").Append(TransferIntentId).Append("\n");
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
            return this.Equals(input as TransferIntentGetRequest);
        }

        /// <summary>
        /// Returns true if TransferIntentGetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferIntentGetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferIntentGetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && base.Equals(input) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && base.Equals(input) && 
                (
                    this.TransferIntentId == input.TransferIntentId ||
                    (this.TransferIntentId != null &&
                    this.TransferIntentId.Equals(input.TransferIntentId))
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                if (this.TransferIntentId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferIntentId.GetHashCode();
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
