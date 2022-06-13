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
    /// An object representing the earnings line items for the pay period.
    /// </summary>
    [DataContract(Name = "EarningsBreakdown")]
    public partial class EarningsBreakdown : Dictionary<String, Object>, IEquatable<EarningsBreakdown>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CanonicalDescription
        /// </summary>
        [DataMember(Name = "canonical_description", EmitDefaultValue = true)]
        public EarningsBreakdownCanonicalDescription? CanonicalDescription { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EarningsBreakdown" /> class.
        /// </summary>
        /// <param name="canonicalDescription">canonicalDescription.</param>
        /// <param name="currentAmount">Raw amount of the earning line item..</param>
        /// <param name="description">Description of the earning line item..</param>
        /// <param name="hours">Number of hours applicable for this earning..</param>
        /// <param name="isoCurrencyCode">The ISO-4217 currency code of the line item. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null..</param>
        /// <param name="rate">Hourly rate applicable for this earning..</param>
        /// <param name="unofficialCurrencyCode">The unofficial currency code associated with the line item. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s..</param>
        /// <param name="ytdAmount">The year-to-date amount of the deduction..</param>
        public EarningsBreakdown(EarningsBreakdownCanonicalDescription? canonicalDescription = default(EarningsBreakdownCanonicalDescription?), decimal? currentAmount = default(decimal?), string description = default(string), decimal? hours = default(decimal?), string isoCurrencyCode = default(string), decimal? rate = default(decimal?), string unofficialCurrencyCode = default(string), decimal? ytdAmount = default(decimal?)) : base()
        {
            this.CanonicalDescription = canonicalDescription;
            this.CurrentAmount = currentAmount;
            this.Description = description;
            this.Hours = hours;
            this.IsoCurrencyCode = isoCurrencyCode;
            this.Rate = rate;
            this.UnofficialCurrencyCode = unofficialCurrencyCode;
            this.YtdAmount = ytdAmount;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Raw amount of the earning line item.
        /// </summary>
        /// <value>Raw amount of the earning line item.</value>
        [DataMember(Name = "current_amount", EmitDefaultValue = true)]
        public decimal? CurrentAmount { get; set; }

        /// <summary>
        /// Description of the earning line item.
        /// </summary>
        /// <value>Description of the earning line item.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Number of hours applicable for this earning.
        /// </summary>
        /// <value>Number of hours applicable for this earning.</value>
        [DataMember(Name = "hours", EmitDefaultValue = true)]
        public decimal? Hours { get; set; }

        /// <summary>
        /// The ISO-4217 currency code of the line item. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null.
        /// </summary>
        /// <value>The ISO-4217 currency code of the line item. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null.</value>
        [DataMember(Name = "iso_currency_code", EmitDefaultValue = true)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// Hourly rate applicable for this earning.
        /// </summary>
        /// <value>Hourly rate applicable for this earning.</value>
        [DataMember(Name = "rate", EmitDefaultValue = true)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// The unofficial currency code associated with the line item. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.
        /// </summary>
        /// <value>The unofficial currency code associated with the line item. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.</value>
        [DataMember(Name = "unofficial_currency_code", EmitDefaultValue = true)]
        public string UnofficialCurrencyCode { get; set; }

        /// <summary>
        /// The year-to-date amount of the deduction.
        /// </summary>
        /// <value>The year-to-date amount of the deduction.</value>
        [DataMember(Name = "ytd_amount", EmitDefaultValue = true)]
        public decimal? YtdAmount { get; set; }

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
            sb.Append("class EarningsBreakdown {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CanonicalDescription: ").Append(CanonicalDescription).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  UnofficialCurrencyCode: ").Append(UnofficialCurrencyCode).Append("\n");
            sb.Append("  YtdAmount: ").Append(YtdAmount).Append("\n");
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
            return this.Equals(input as EarningsBreakdown);
        }

        /// <summary>
        /// Returns true if EarningsBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsBreakdown input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.CanonicalDescription == input.CanonicalDescription ||
                    this.CanonicalDescription.Equals(input.CanonicalDescription)
                ) && base.Equals(input) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    (this.CurrentAmount != null &&
                    this.CurrentAmount.Equals(input.CurrentAmount))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
                ) && base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
                ) && base.Equals(input) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && base.Equals(input) && 
                (
                    this.UnofficialCurrencyCode == input.UnofficialCurrencyCode ||
                    (this.UnofficialCurrencyCode != null &&
                    this.UnofficialCurrencyCode.Equals(input.UnofficialCurrencyCode))
                ) && base.Equals(input) && 
                (
                    this.YtdAmount == input.YtdAmount ||
                    (this.YtdAmount != null &&
                    this.YtdAmount.Equals(input.YtdAmount))
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
                hashCode = (hashCode * 59) + this.CanonicalDescription.GetHashCode();
                if (this.CurrentAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAmount.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Hours != null)
                {
                    hashCode = (hashCode * 59) + this.Hours.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
                }
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.UnofficialCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.UnofficialCurrencyCode.GetHashCode();
                }
                if (this.YtdAmount != null)
                {
                    hashCode = (hashCode * 59) + this.YtdAmount.GetHashCode();
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