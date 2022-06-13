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
    /// Information about the APR on the account.
    /// </summary>
    [DataContract(Name = "APR")]
    public partial class APR : Dictionary<String, Object>, IEquatable<APR>, IValidatableObject
    {
        /// <summary>
        /// The type of balance to which the APR applies.
        /// </summary>
        /// <value>The type of balance to which the APR applies.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AprTypeEnum
        {
            /// <summary>
            /// Enum BalanceTransferApr for value: balance_transfer_apr
            /// </summary>
            [EnumMember(Value = "balance_transfer_apr")]
            BalanceTransferApr = 1,

            /// <summary>
            /// Enum CashApr for value: cash_apr
            /// </summary>
            [EnumMember(Value = "cash_apr")]
            CashApr = 2,

            /// <summary>
            /// Enum PurchaseApr for value: purchase_apr
            /// </summary>
            [EnumMember(Value = "purchase_apr")]
            PurchaseApr = 3,

            /// <summary>
            /// Enum Special for value: special
            /// </summary>
            [EnumMember(Value = "special")]
            Special = 4

        }


        /// <summary>
        /// The type of balance to which the APR applies.
        /// </summary>
        /// <value>The type of balance to which the APR applies.</value>
        [DataMember(Name = "apr_type", IsRequired = true, EmitDefaultValue = false)]
        public AprTypeEnum AprType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="APR" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APR()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="APR" /> class.
        /// </summary>
        /// <param name="aprPercentage">Annual Percentage Rate applied.  (required).</param>
        /// <param name="aprType">The type of balance to which the APR applies. (required).</param>
        /// <param name="balanceSubjectToApr">Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance. (required).</param>
        /// <param name="interestChargeAmount">Amount of money charged due to interest from last statement. (required).</param>
        public APR(decimal aprPercentage = default(decimal), AprTypeEnum aprType = default(AprTypeEnum), decimal? balanceSubjectToApr = default(decimal?), decimal? interestChargeAmount = default(decimal?)) : base()
        {
            this.AprPercentage = aprPercentage;
            this.AprType = aprType;
            // to ensure "balanceSubjectToApr" is required (not null)
            if (balanceSubjectToApr == null)
            {
                throw new ArgumentNullException("balanceSubjectToApr is a required property for APR and cannot be null");
            }
            this.BalanceSubjectToApr = balanceSubjectToApr;
            // to ensure "interestChargeAmount" is required (not null)
            if (interestChargeAmount == null)
            {
                throw new ArgumentNullException("interestChargeAmount is a required property for APR and cannot be null");
            }
            this.InterestChargeAmount = interestChargeAmount;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Annual Percentage Rate applied. 
        /// </summary>
        /// <value>Annual Percentage Rate applied. </value>
        [DataMember(Name = "apr_percentage", IsRequired = true, EmitDefaultValue = false)]
        public decimal AprPercentage { get; set; }

        /// <summary>
        /// Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance.
        /// </summary>
        /// <value>Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance.</value>
        [DataMember(Name = "balance_subject_to_apr", IsRequired = true, EmitDefaultValue = true)]
        public decimal? BalanceSubjectToApr { get; set; }

        /// <summary>
        /// Amount of money charged due to interest from last statement.
        /// </summary>
        /// <value>Amount of money charged due to interest from last statement.</value>
        [DataMember(Name = "interest_charge_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal? InterestChargeAmount { get; set; }

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
            sb.Append("class APR {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AprPercentage: ").Append(AprPercentage).Append("\n");
            sb.Append("  AprType: ").Append(AprType).Append("\n");
            sb.Append("  BalanceSubjectToApr: ").Append(BalanceSubjectToApr).Append("\n");
            sb.Append("  InterestChargeAmount: ").Append(InterestChargeAmount).Append("\n");
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
            return this.Equals(input as APR);
        }

        /// <summary>
        /// Returns true if APR instances are equal
        /// </summary>
        /// <param name="input">Instance of APR to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APR input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AprPercentage == input.AprPercentage ||
                    this.AprPercentage.Equals(input.AprPercentage)
                ) && base.Equals(input) && 
                (
                    this.AprType == input.AprType ||
                    this.AprType.Equals(input.AprType)
                ) && base.Equals(input) && 
                (
                    this.BalanceSubjectToApr == input.BalanceSubjectToApr ||
                    (this.BalanceSubjectToApr != null &&
                    this.BalanceSubjectToApr.Equals(input.BalanceSubjectToApr))
                ) && base.Equals(input) && 
                (
                    this.InterestChargeAmount == input.InterestChargeAmount ||
                    (this.InterestChargeAmount != null &&
                    this.InterestChargeAmount.Equals(input.InterestChargeAmount))
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
                hashCode = (hashCode * 59) + this.AprPercentage.GetHashCode();
                hashCode = (hashCode * 59) + this.AprType.GetHashCode();
                if (this.BalanceSubjectToApr != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceSubjectToApr.GetHashCode();
                }
                if (this.InterestChargeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InterestChargeAmount.GetHashCode();
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