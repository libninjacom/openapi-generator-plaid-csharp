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
    /// An object representing a balance held by an account in the past
    /// </summary>
    [DataContract(Name = "HistoricalBalance")]
    public partial class HistoricalBalance : Dictionary<String, Object>, IEquatable<HistoricalBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HistoricalBalance()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalBalance" /> class.
        /// </summary>
        /// <param name="date">The date of the calculated historical balance, in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD) (required).</param>
        /// <param name="current">The total amount of funds in the account, calculated from the &#x60;current&#x60; balance in the &#x60;balance&#x60; object by subtracting inflows and adding back outflows according to the posted date of each transaction.  If the account has any pending transactions, historical balance amounts on or after the date of the earliest pending transaction may differ if retrieved in subsequent Asset Reports as a result of those pending transactions posting. (required).</param>
        /// <param name="isoCurrencyCode">The ISO-4217 currency code of the balance. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-&#x60;null&#x60;. (required).</param>
        /// <param name="unofficialCurrencyCode">The unofficial currency code associated with the balance. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s. (required).</param>
        public HistoricalBalance(DateTime date = default(DateTime), decimal current = default(decimal), string isoCurrencyCode = default(string), string unofficialCurrencyCode = default(string)) : base()
        {
            this.Date = date;
            this.Current = current;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for HistoricalBalance and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            // to ensure "unofficialCurrencyCode" is required (not null)
            if (unofficialCurrencyCode == null)
            {
                throw new ArgumentNullException("unofficialCurrencyCode is a required property for HistoricalBalance and cannot be null");
            }
            this.UnofficialCurrencyCode = unofficialCurrencyCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The date of the calculated historical balance, in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD)
        /// </summary>
        /// <value>The date of the calculated historical balance, in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD)</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// The total amount of funds in the account, calculated from the &#x60;current&#x60; balance in the &#x60;balance&#x60; object by subtracting inflows and adding back outflows according to the posted date of each transaction.  If the account has any pending transactions, historical balance amounts on or after the date of the earliest pending transaction may differ if retrieved in subsequent Asset Reports as a result of those pending transactions posting.
        /// </summary>
        /// <value>The total amount of funds in the account, calculated from the &#x60;current&#x60; balance in the &#x60;balance&#x60; object by subtracting inflows and adding back outflows according to the posted date of each transaction.  If the account has any pending transactions, historical balance amounts on or after the date of the earliest pending transaction may differ if retrieved in subsequent Asset Reports as a result of those pending transactions posting.</value>
        [DataMember(Name = "current", IsRequired = true, EmitDefaultValue = false)]
        public decimal Current { get; set; }

        /// <summary>
        /// The ISO-4217 currency code of the balance. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-&#x60;null&#x60;.
        /// </summary>
        /// <value>The ISO-4217 currency code of the balance. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-&#x60;null&#x60;.</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = true)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// The unofficial currency code associated with the balance. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.
        /// </summary>
        /// <value>The unofficial currency code associated with the balance. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.</value>
        [DataMember(Name = "unofficial_currency_code", IsRequired = true, EmitDefaultValue = true)]
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
            sb.Append("class HistoricalBalance {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
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
            return this.Equals(input as HistoricalBalance);
        }

        /// <summary>
        /// Returns true if HistoricalBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricalBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalBalance input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.Current == input.Current ||
                    this.Current.Equals(input.Current)
                ) && base.Equals(input) && 
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Current.GetHashCode();
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
