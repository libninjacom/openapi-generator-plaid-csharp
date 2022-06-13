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
    /// InvestmentsHoldingsGetResponse defines the response schema for &#x60;/investments/holdings/get&#x60;
    /// </summary>
    [DataContract(Name = "InvestmentsHoldingsGetResponse")]
    public partial class InvestmentsHoldingsGetResponse : Dictionary<String, Object>, IEquatable<InvestmentsHoldingsGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentsHoldingsGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvestmentsHoldingsGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentsHoldingsGetResponse" /> class.
        /// </summary>
        /// <param name="accounts">The accounts associated with the Item (required).</param>
        /// <param name="holdings">The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the &#x60;securities&#x60; field.  (required).</param>
        /// <param name="securities">Objects describing the securities held in the accounts associated with the Item.  (required).</param>
        /// <param name="item">item (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public InvestmentsHoldingsGetResponse(List<AccountBase> accounts = default(List<AccountBase>), List<Holding> holdings = default(List<Holding>), List<Security> securities = default(List<Security>), Item item = default(Item), string requestId = default(string)) : base()
        {
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new ArgumentNullException("accounts is a required property for InvestmentsHoldingsGetResponse and cannot be null");
            }
            this.Accounts = accounts;
            // to ensure "holdings" is required (not null)
            if (holdings == null)
            {
                throw new ArgumentNullException("holdings is a required property for InvestmentsHoldingsGetResponse and cannot be null");
            }
            this.Holdings = holdings;
            // to ensure "securities" is required (not null)
            if (securities == null)
            {
                throw new ArgumentNullException("securities is a required property for InvestmentsHoldingsGetResponse and cannot be null");
            }
            this.Securities = securities;
            // to ensure "item" is required (not null)
            if (item == null)
            {
                throw new ArgumentNullException("item is a required property for InvestmentsHoldingsGetResponse and cannot be null");
            }
            this.Item = item;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for InvestmentsHoldingsGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The accounts associated with the Item
        /// </summary>
        /// <value>The accounts associated with the Item</value>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = false)]
        public List<AccountBase> Accounts { get; set; }

        /// <summary>
        /// The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the &#x60;securities&#x60; field. 
        /// </summary>
        /// <value>The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the &#x60;securities&#x60; field. </value>
        [DataMember(Name = "holdings", IsRequired = true, EmitDefaultValue = false)]
        public List<Holding> Holdings { get; set; }

        /// <summary>
        /// Objects describing the securities held in the accounts associated with the Item. 
        /// </summary>
        /// <value>Objects describing the securities held in the accounts associated with the Item. </value>
        [DataMember(Name = "securities", IsRequired = true, EmitDefaultValue = false)]
        public List<Security> Securities { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public Item Item { get; set; }

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
            sb.Append("class InvestmentsHoldingsGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Holdings: ").Append(Holdings).Append("\n");
            sb.Append("  Securities: ").Append(Securities).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
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
            return this.Equals(input as InvestmentsHoldingsGetResponse);
        }

        /// <summary>
        /// Returns true if InvestmentsHoldingsGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvestmentsHoldingsGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvestmentsHoldingsGetResponse input)
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
                    this.Holdings == input.Holdings ||
                    this.Holdings != null &&
                    input.Holdings != null &&
                    this.Holdings.SequenceEqual(input.Holdings)
                ) && base.Equals(input) && 
                (
                    this.Securities == input.Securities ||
                    this.Securities != null &&
                    input.Securities != null &&
                    this.Securities.SequenceEqual(input.Securities)
                ) && base.Equals(input) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                if (this.Holdings != null)
                {
                    hashCode = (hashCode * 59) + this.Holdings.GetHashCode();
                }
                if (this.Securities != null)
                {
                    hashCode = (hashCode * 59) + this.Securities.GetHashCode();
                }
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
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