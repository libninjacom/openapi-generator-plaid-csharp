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
    /// An object representing employment details found on a paystub.
    /// </summary>
    [DataContract(Name = "EmploymentDetails")]
    public partial class EmploymentDetails : Dictionary<String, Object>, IEquatable<EmploymentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmploymentDetails" /> class.
        /// </summary>
        /// <param name="annualSalary">annualSalary.</param>
        /// <param name="hireDate">Date on which the employee was hired, in the YYYY-MM-DD format..</param>
        public EmploymentDetails(Pay annualSalary = default(Pay), DateTime? hireDate = default(DateTime?)) : base()
        {
            this.AnnualSalary = annualSalary;
            this.HireDate = hireDate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AnnualSalary
        /// </summary>
        [DataMember(Name = "annual_salary", EmitDefaultValue = false)]
        [Obsolete]
        public Pay AnnualSalary { get; set; }

        /// <summary>
        /// Date on which the employee was hired, in the YYYY-MM-DD format.
        /// </summary>
        /// <value>Date on which the employee was hired, in the YYYY-MM-DD format.</value>
        [DataMember(Name = "hire_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? HireDate { get; set; }

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
            sb.Append("class EmploymentDetails {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AnnualSalary: ").Append(AnnualSalary).Append("\n");
            sb.Append("  HireDate: ").Append(HireDate).Append("\n");
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
            return this.Equals(input as EmploymentDetails);
        }

        /// <summary>
        /// Returns true if EmploymentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of EmploymentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmploymentDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AnnualSalary == input.AnnualSalary ||
                    (this.AnnualSalary != null &&
                    this.AnnualSalary.Equals(input.AnnualSalary))
                ) && base.Equals(input) && 
                (
                    this.HireDate == input.HireDate ||
                    (this.HireDate != null &&
                    this.HireDate.Equals(input.HireDate))
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
                if (this.AnnualSalary != null)
                {
                    hashCode = (hashCode * 59) + this.AnnualSalary.GetHashCode();
                }
                if (this.HireDate != null)
                {
                    hashCode = (hashCode * 59) + this.HireDate.GetHashCode();
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
