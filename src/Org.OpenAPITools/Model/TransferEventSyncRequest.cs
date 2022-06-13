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
    /// Defines the request schema for &#x60;/transfer/event/sync&#x60;
    /// </summary>
    [DataContract(Name = "TransferEventSyncRequest")]
    public partial class TransferEventSyncRequest : IEquatable<TransferEventSyncRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferEventSyncRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferEventSyncRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferEventSyncRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="afterId">The latest (largest) &#x60;event_id&#x60; fetched via the sync endpoint, or 0 initially. (required).</param>
        /// <param name="count">The maximum number of transfer events to return. (default to 25).</param>
        public TransferEventSyncRequest(string clientId = default(string), string secret = default(string), int afterId = default(int), int? count = 25)
        {
            this.AfterId = afterId;
            this.ClientId = clientId;
            this.Secret = secret;
            // use default value if no "count" provided
            this.Count = count ?? 25;
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
        /// The latest (largest) &#x60;event_id&#x60; fetched via the sync endpoint, or 0 initially.
        /// </summary>
        /// <value>The latest (largest) &#x60;event_id&#x60; fetched via the sync endpoint, or 0 initially.</value>
        [DataMember(Name = "after_id", IsRequired = true, EmitDefaultValue = false)]
        public int AfterId { get; set; }

        /// <summary>
        /// The maximum number of transfer events to return.
        /// </summary>
        /// <value>The maximum number of transfer events to return.</value>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public int? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferEventSyncRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  AfterId: ").Append(AfterId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as TransferEventSyncRequest);
        }

        /// <summary>
        /// Returns true if TransferEventSyncRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferEventSyncRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferEventSyncRequest input)
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
                    this.AfterId == input.AfterId ||
                    this.AfterId.Equals(input.AfterId)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                hashCode = (hashCode * 59) + this.AfterId.GetHashCode();
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
            // AfterId (int) minimum
            if (this.AfterId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AfterId, must be a value greater than or equal to 0.", new [] { "AfterId" });
            }

            // Count (int?) maximum
            if (this.Count > (int?)25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value less than or equal to 25.", new [] { "Count" });
            }

            // Count (int?) minimum
            if (this.Count < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to 1.", new [] { "Count" });
            }

            yield break;
        }
    }

}
