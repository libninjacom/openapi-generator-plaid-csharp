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
    /// The following currency codes are supported by Plaid.
    /// </summary>
    [DataContract(Name = "StandaloneCurrencyCodeList")]
    public partial class StandaloneCurrencyCodeList : Dictionary<String, Object>, IEquatable<StandaloneCurrencyCodeList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandaloneCurrencyCodeList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StandaloneCurrencyCodeList()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StandaloneCurrencyCodeList" /> class.
        /// </summary>
        /// <param name="isoCurrencyCode">Plaid supports all ISO 4217 currency codes. (required).</param>
        /// <param name="unofficialCurrencyCode">List of unofficial currency codes (required).</param>
        public StandaloneCurrencyCodeList(string isoCurrencyCode = default(string), string unofficialCurrencyCode = default(string)) : base()
        {
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for StandaloneCurrencyCodeList and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            // to ensure "unofficialCurrencyCode" is required (not null)
            if (unofficialCurrencyCode == null)
            {
                throw new ArgumentNullException("unofficialCurrencyCode is a required property for StandaloneCurrencyCodeList and cannot be null");
            }
            this.UnofficialCurrencyCode = unofficialCurrencyCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Plaid supports all ISO 4217 currency codes.
        /// </summary>
        /// <value>Plaid supports all ISO 4217 currency codes.</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = false)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// List of unofficial currency codes
        /// </summary>
        /// <value>List of unofficial currency codes</value>
        [DataMember(Name = "unofficial_currency_code", IsRequired = true, EmitDefaultValue = false)]
        public string UnofficialCurrencyCode { get; set; }

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
            sb.Append("class StandaloneCurrencyCodeList {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
            sb.Append("  UnofficialCurrencyCode: ").Append(UnofficialCurrencyCode).Append("\n");
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
            return this.Equals(input as StandaloneCurrencyCodeList);
        }

        /// <summary>
        /// Returns true if StandaloneCurrencyCodeList instances are equal
        /// </summary>
        /// <param name="input">Instance of StandaloneCurrencyCodeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandaloneCurrencyCodeList input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
                ) && base.Equals(input) && 
                (
                    this.UnofficialCurrencyCode == input.UnofficialCurrencyCode ||
                    (this.UnofficialCurrencyCode != null &&
                    this.UnofficialCurrencyCode.Equals(input.UnofficialCurrencyCode))
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
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
                }
                if (this.UnofficialCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.UnofficialCurrencyCode.GetHashCode();
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