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
    /// LiabilitiesGetResponse defines the response schema for &#x60;/liabilities/get&#x60;
    /// </summary>
    [DataContract(Name = "LiabilitiesGetResponse")]
    public partial class LiabilitiesGetResponse : Dictionary<String, Object>, IEquatable<LiabilitiesGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiabilitiesGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LiabilitiesGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiabilitiesGetResponse" /> class.
        /// </summary>
        /// <param name="accounts">An array of accounts associated with the Item (required).</param>
        /// <param name="item">item (required).</param>
        /// <param name="liabilities">liabilities (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public LiabilitiesGetResponse(List<AccountBase> accounts = default(List<AccountBase>), Item item = default(Item), LiabilitiesObject liabilities = default(LiabilitiesObject), string requestId = default(string)) : base()
        {
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new ArgumentNullException("accounts is a required property for LiabilitiesGetResponse and cannot be null");
            }
            this.Accounts = accounts;
            // to ensure "item" is required (not null)
            if (item == null)
            {
                throw new ArgumentNullException("item is a required property for LiabilitiesGetResponse and cannot be null");
            }
            this.Item = item;
            // to ensure "liabilities" is required (not null)
            if (liabilities == null)
            {
                throw new ArgumentNullException("liabilities is a required property for LiabilitiesGetResponse and cannot be null");
            }
            this.Liabilities = liabilities;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for LiabilitiesGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An array of accounts associated with the Item
        /// </summary>
        /// <value>An array of accounts associated with the Item</value>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = false)]
        public List<AccountBase> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public Item Item { get; set; }

        /// <summary>
        /// Gets or Sets Liabilities
        /// </summary>
        [DataMember(Name = "liabilities", IsRequired = true, EmitDefaultValue = false)]
        public LiabilitiesObject Liabilities { get; set; }

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
            sb.Append("class LiabilitiesGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Liabilities: ").Append(Liabilities).Append("\n");
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
            return this.Equals(input as LiabilitiesGetResponse);
        }

        /// <summary>
        /// Returns true if LiabilitiesGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LiabilitiesGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiabilitiesGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && base.Equals(input) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && base.Equals(input) && 
                (
                    this.Liabilities == input.Liabilities ||
                    (this.Liabilities != null &&
                    this.Liabilities.Equals(input.Liabilities))
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
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.Liabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Liabilities.GetHashCode();
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