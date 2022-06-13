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
    /// An object representing the repayment plan for the student loan
    /// </summary>
    [DataContract(Name = "StudentRepaymentPlan")]
    public partial class StudentRepaymentPlan : Dictionary<String, Object>, IEquatable<StudentRepaymentPlan>, IValidatableObject
    {
        /// <summary>
        /// The type of the repayment plan.
        /// </summary>
        /// <value>The type of the repayment plan.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ExtendedGraduated for value: extended graduated
            /// </summary>
            [EnumMember(Value = "extended graduated")]
            ExtendedGraduated = 1,

            /// <summary>
            /// Enum ExtendedStandard for value: extended standard
            /// </summary>
            [EnumMember(Value = "extended standard")]
            ExtendedStandard = 2,

            /// <summary>
            /// Enum Graduated for value: graduated
            /// </summary>
            [EnumMember(Value = "graduated")]
            Graduated = 3,

            /// <summary>
            /// Enum IncomeContingentRepayment for value: income-contingent repayment
            /// </summary>
            [EnumMember(Value = "income-contingent repayment")]
            IncomeContingentRepayment = 4,

            /// <summary>
            /// Enum IncomeBasedRepayment for value: income-based repayment
            /// </summary>
            [EnumMember(Value = "income-based repayment")]
            IncomeBasedRepayment = 5,

            /// <summary>
            /// Enum InterestOnly for value: interest-only
            /// </summary>
            [EnumMember(Value = "interest-only")]
            InterestOnly = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7,

            /// <summary>
            /// Enum PayAsYouEarn for value: pay as you earn
            /// </summary>
            [EnumMember(Value = "pay as you earn")]
            PayAsYouEarn = 8,

            /// <summary>
            /// Enum RevisedPayAsYouEarn for value: revised pay as you earn
            /// </summary>
            [EnumMember(Value = "revised pay as you earn")]
            RevisedPayAsYouEarn = 9,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 10,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 11

        }


        /// <summary>
        /// The type of the repayment plan.
        /// </summary>
        /// <value>The type of the repayment plan.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentRepaymentPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StudentRepaymentPlan()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentRepaymentPlan" /> class.
        /// </summary>
        /// <param name="description">The description of the repayment plan as provided by the servicer. (required).</param>
        /// <param name="type">The type of the repayment plan. (required).</param>
        public StudentRepaymentPlan(string description = default(string), TypeEnum type = default(TypeEnum)) : base()
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for StudentRepaymentPlan and cannot be null");
            }
            this.Description = description;
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The description of the repayment plan as provided by the servicer.
        /// </summary>
        /// <value>The description of the repayment plan as provided by the servicer.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

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
            sb.Append("class StudentRepaymentPlan {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StudentRepaymentPlan);
        }

        /// <summary>
        /// Returns true if StudentRepaymentPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of StudentRepaymentPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentRepaymentPlan input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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