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
    /// LinkTokenGetResponse defines the response schema for &#x60;/link/token/get&#x60;
    /// </summary>
    [DataContract(Name = "LinkTokenGetResponse")]
    public partial class LinkTokenGetResponse : Dictionary<String, Object>, IEquatable<LinkTokenGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkTokenGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkTokenGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkTokenGetResponse" /> class.
        /// </summary>
        /// <param name="linkToken">A &#x60;link_token&#x60;, which can be supplied to Link in order to initialize it and receive a &#x60;public_token&#x60;, which can be exchanged for an &#x60;access_token&#x60;. (required).</param>
        /// <param name="createdAt">The creation timestamp for the &#x60;link_token&#x60;, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
        /// <param name="expiration">The expiration timestamp for the &#x60;link_token&#x60;, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public LinkTokenGetResponse(string linkToken = default(string), DateTime? createdAt = default(DateTime?), DateTime? expiration = default(DateTime?), LinkTokenGetMetadataResponse metadata = default(LinkTokenGetMetadataResponse), string requestId = default(string)) : base()
        {
            // to ensure "linkToken" is required (not null)
            if (linkToken == null)
            {
                throw new ArgumentNullException("linkToken is a required property for LinkTokenGetResponse and cannot be null");
            }
            this.LinkToken = linkToken;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for LinkTokenGetResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "expiration" is required (not null)
            if (expiration == null)
            {
                throw new ArgumentNullException("expiration is a required property for LinkTokenGetResponse and cannot be null");
            }
            this.Expiration = expiration;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for LinkTokenGetResponse and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for LinkTokenGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A &#x60;link_token&#x60;, which can be supplied to Link in order to initialize it and receive a &#x60;public_token&#x60;, which can be exchanged for an &#x60;access_token&#x60;.
        /// </summary>
        /// <value>A &#x60;link_token&#x60;, which can be supplied to Link in order to initialize it and receive a &#x60;public_token&#x60;, which can be exchanged for an &#x60;access_token&#x60;.</value>
        [DataMember(Name = "link_token", IsRequired = true, EmitDefaultValue = false)]
        public string LinkToken { get; set; }

        /// <summary>
        /// The creation timestamp for the &#x60;link_token&#x60;, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>The creation timestamp for the &#x60;link_token&#x60;, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The expiration timestamp for the &#x60;link_token&#x60;, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>The expiration timestamp for the &#x60;link_token&#x60;, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name = "expiration", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = false)]
        public LinkTokenGetMetadataResponse Metadata { get; set; }

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
            sb.Append("class LinkTokenGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LinkToken: ").Append(LinkToken).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as LinkTokenGetResponse);
        }

        /// <summary>
        /// Returns true if LinkTokenGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkTokenGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkTokenGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.LinkToken == input.LinkToken ||
                    (this.LinkToken != null &&
                    this.LinkToken.Equals(input.LinkToken))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && base.Equals(input) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.LinkToken != null)
                {
                    hashCode = (hashCode * 59) + this.LinkToken.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Expiration != null)
                {
                    hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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