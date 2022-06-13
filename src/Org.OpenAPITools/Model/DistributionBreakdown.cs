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
    /// Information about the accounts that the payment was distributed to.
    /// </summary>
    [DataContract(Name = "DistributionBreakdown")]
    public partial class DistributionBreakdown : Dictionary<String, Object>, IEquatable<DistributionBreakdown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionBreakdown" /> class.
        /// </summary>
        /// <param name="accountName">Name of the account for the given distribution..</param>
        /// <param name="bankName">The name of the bank that the payment is being deposited to..</param>
        /// <param name="currentAmount">The amount distributed to this account..</param>
        /// <param name="isoCurrencyCode">The ISO-4217 currency code of the net pay. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null..</param>
        /// <param name="mask">The last 2-4 alphanumeric characters of an account&#39;s official account number..</param>
        /// <param name="type">Type of the account that the paystub was sent to (e.g. &#39;checking&#39;)..</param>
        /// <param name="unofficialCurrencyCode">The unofficial currency code associated with the net pay. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s..</param>
        /// <param name="currentPay">currentPay.</param>
        public DistributionBreakdown(string accountName = default(string), string bankName = default(string), decimal? currentAmount = default(decimal?), string isoCurrencyCode = default(string), string mask = default(string), string type = default(string), string unofficialCurrencyCode = default(string), Pay currentPay = default(Pay)) : base()
        {
            this.AccountName = accountName;
            this.BankName = bankName;
            this.CurrentAmount = currentAmount;
            this.IsoCurrencyCode = isoCurrencyCode;
            this.Mask = mask;
            this.Type = type;
            this.UnofficialCurrencyCode = unofficialCurrencyCode;
            this.CurrentPay = currentPay;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Name of the account for the given distribution.
        /// </summary>
        /// <value>Name of the account for the given distribution.</value>
        [DataMember(Name = "account_name", EmitDefaultValue = true)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the bank that the payment is being deposited to.
        /// </summary>
        /// <value>The name of the bank that the payment is being deposited to.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName { get; set; }

        /// <summary>
        /// The amount distributed to this account.
        /// </summary>
        /// <value>The amount distributed to this account.</value>
        [DataMember(Name = "current_amount", EmitDefaultValue = true)]
        public decimal? CurrentAmount { get; set; }

        /// <summary>
        /// The ISO-4217 currency code of the net pay. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null.
        /// </summary>
        /// <value>The ISO-4217 currency code of the net pay. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-null.</value>
        [DataMember(Name = "iso_currency_code", EmitDefaultValue = true)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// The last 2-4 alphanumeric characters of an account&#39;s official account number.
        /// </summary>
        /// <value>The last 2-4 alphanumeric characters of an account&#39;s official account number.</value>
        [DataMember(Name = "mask", EmitDefaultValue = true)]
        public string Mask { get; set; }

        /// <summary>
        /// Type of the account that the paystub was sent to (e.g. &#39;checking&#39;).
        /// </summary>
        /// <value>Type of the account that the paystub was sent to (e.g. &#39;checking&#39;).</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The unofficial currency code associated with the net pay. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.
        /// </summary>
        /// <value>The unofficial currency code associated with the net pay. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.</value>
        [DataMember(Name = "unofficial_currency_code", EmitDefaultValue = true)]
        public string UnofficialCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPay
        /// </summary>
        [DataMember(Name = "current_pay", EmitDefaultValue = false)]
        [Obsolete]
        public Pay CurrentPay { get; set; }

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
            sb.Append("class DistributionBreakdown {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
            sb.Append("  Mask: ").Append(Mask).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnofficialCurrencyCode: ").Append(UnofficialCurrencyCode).Append("\n");
            sb.Append("  CurrentPay: ").Append(CurrentPay).Append("\n");
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
            return this.Equals(input as DistributionBreakdown);
        }

        /// <summary>
        /// Returns true if DistributionBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionBreakdown input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && base.Equals(input) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && base.Equals(input) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    (this.CurrentAmount != null &&
                    this.CurrentAmount.Equals(input.CurrentAmount))
                ) && base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
                ) && base.Equals(input) && 
                (
                    this.Mask == input.Mask ||
                    (this.Mask != null &&
                    this.Mask.Equals(input.Mask))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.UnofficialCurrencyCode == input.UnofficialCurrencyCode ||
                    (this.UnofficialCurrencyCode != null &&
                    this.UnofficialCurrencyCode.Equals(input.UnofficialCurrencyCode))
                ) && base.Equals(input) && 
                (
                    this.CurrentPay == input.CurrentPay ||
                    (this.CurrentPay != null &&
                    this.CurrentPay.Equals(input.CurrentPay))
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
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.CurrentAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAmount.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
                }
                if (this.Mask != null)
                {
                    hashCode = (hashCode * 59) + this.Mask.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UnofficialCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.UnofficialCurrencyCode.GetHashCode();
                }
                if (this.CurrentPay != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentPay.GetHashCode();
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
