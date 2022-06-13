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
    /// A filter to apply to &#x60;investment&#x60;-type accounts (or &#x60;brokerage&#x60;-type accounts for API versions 2018-05-22 and earlier).
    /// </summary>
    [DataContract(Name = "LinkTokenCreateInvestmentFilter")]
    public partial class LinkTokenCreateInvestmentFilter : Dictionary<String, Object>, IEquatable<LinkTokenCreateInvestmentFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkTokenCreateInvestmentFilter" /> class.
        /// </summary>
        /// <param name="accountSubtypes">An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the [Account schema](https://plaid.com/docs/api/accounts#account-type-schema). .</param>
        public LinkTokenCreateInvestmentFilter(List<InvestmentAccountSubtype> accountSubtypes = default(List<InvestmentAccountSubtype>)) : base()
        {
            this.AccountSubtypes = accountSubtypes;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the [Account schema](https://plaid.com/docs/api/accounts#account-type-schema). 
        /// </summary>
        /// <value>An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the [Account schema](https://plaid.com/docs/api/accounts#account-type-schema). </value>
        [DataMember(Name = "account_subtypes", EmitDefaultValue = false)]
        public List<InvestmentAccountSubtype> AccountSubtypes { get; set; }

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
            sb.Append("class LinkTokenCreateInvestmentFilter {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountSubtypes: ").Append(AccountSubtypes).Append("\n");
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
            return this.Equals(input as LinkTokenCreateInvestmentFilter);
        }

        /// <summary>
        /// Returns true if LinkTokenCreateInvestmentFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkTokenCreateInvestmentFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkTokenCreateInvestmentFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AccountSubtypes == input.AccountSubtypes ||
                    this.AccountSubtypes != null &&
                    input.AccountSubtypes != null &&
                    this.AccountSubtypes.SequenceEqual(input.AccountSubtypes)
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
                if (this.AccountSubtypes != null)
                {
                    hashCode = (hashCode * 59) + this.AccountSubtypes.GetHashCode();
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