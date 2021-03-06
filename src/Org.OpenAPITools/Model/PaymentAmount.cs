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
    /// The amount and currency of a payment
    /// </summary>
    [DataContract(Name = "PaymentAmount")]
    public partial class PaymentAmount : Dictionary<String, Object>, IEquatable<PaymentAmount>, IValidatableObject
    {
        /// <summary>
        /// The ISO-4217 currency code of the payment. For standing orders, &#x60;\&quot;GBP\&quot;&#x60; must be used.
        /// </summary>
        /// <value>The ISO-4217 currency code of the payment. For standing orders, &#x60;\&quot;GBP\&quot;&#x60; must be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum GBP for value: GBP
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBP = 1,

            /// <summary>
            /// Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR = 2

        }


        /// <summary>
        /// The ISO-4217 currency code of the payment. For standing orders, &#x60;\&quot;GBP\&quot;&#x60; must be used.
        /// </summary>
        /// <value>The ISO-4217 currency code of the payment. For standing orders, &#x60;\&quot;GBP\&quot;&#x60; must be used.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAmount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentAmount()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAmount" /> class.
        /// </summary>
        /// <param name="currency">The ISO-4217 currency code of the payment. For standing orders, &#x60;\&quot;GBP\&quot;&#x60; must be used. (required).</param>
        /// <param name="value">The amount of the payment. Must contain at most two digits of precision e.g. &#x60;1.23&#x60;. Minimum accepted value is &#x60;1&#x60;. (required).</param>
        public PaymentAmount(CurrencyEnum currency = default(CurrencyEnum), decimal value = default(decimal)) : base()
        {
            this.Currency = currency;
            this.Value = value;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The amount of the payment. Must contain at most two digits of precision e.g. &#x60;1.23&#x60;. Minimum accepted value is &#x60;1&#x60;.
        /// </summary>
        /// <value>The amount of the payment. Must contain at most two digits of precision e.g. &#x60;1.23&#x60;. Minimum accepted value is &#x60;1&#x60;.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public decimal Value { get; set; }

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
            sb.Append("class PaymentAmount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as PaymentAmount);
        }

        /// <summary>
        /// Returns true if PaymentAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAmount input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
