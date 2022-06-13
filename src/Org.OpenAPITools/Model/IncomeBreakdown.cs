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
    /// An object representing a breakdown of the different income types on the paystub.
    /// </summary>
    [DataContract(Name = "IncomeBreakdown")]
    public partial class IncomeBreakdown : Dictionary<String, Object>, IEquatable<IncomeBreakdown>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public IncomeBreakdownType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeBreakdown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncomeBreakdown()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeBreakdown" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="rate">The hourly rate at which the income is paid. (required).</param>
        /// <param name="hours">The number of hours logged for this income for this pay period. (required).</param>
        /// <param name="total">The total pay for this pay period. (required).</param>
        public IncomeBreakdown(IncomeBreakdownType type = default(IncomeBreakdownType), decimal? rate = default(decimal?), decimal? hours = default(decimal?), decimal? total = default(decimal?)) : base()
        {
            this.Type = type;
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new ArgumentNullException("rate is a required property for IncomeBreakdown and cannot be null");
            }
            this.Rate = rate;
            // to ensure "hours" is required (not null)
            if (hours == null)
            {
                throw new ArgumentNullException("hours is a required property for IncomeBreakdown and cannot be null");
            }
            this.Hours = hours;
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for IncomeBreakdown and cannot be null");
            }
            this.Total = total;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The hourly rate at which the income is paid.
        /// </summary>
        /// <value>The hourly rate at which the income is paid.</value>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// The number of hours logged for this income for this pay period.
        /// </summary>
        /// <value>The number of hours logged for this income for this pay period.</value>
        [DataMember(Name = "hours", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Hours { get; set; }

        /// <summary>
        /// The total pay for this pay period.
        /// </summary>
        /// <value>The total pay for this pay period.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Total { get; set; }

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
            sb.Append("class IncomeBreakdown {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as IncomeBreakdown);
        }

        /// <summary>
        /// Returns true if IncomeBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeBreakdown input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && base.Equals(input) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && base.Equals(input) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
                ) && base.Equals(input) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.Hours != null)
                {
                    hashCode = (hashCode * 59) + this.Hours.GetHashCode();
                }
                if (this.Total != null)
                {
                    hashCode = (hashCode * 59) + this.Total.GetHashCode();
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