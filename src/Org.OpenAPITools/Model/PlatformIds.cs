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
    /// An object containing a set of ids related to an employee
    /// </summary>
    [DataContract(Name = "PlatformIds")]
    public partial class PlatformIds : Dictionary<String, Object>, IEquatable<PlatformIds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformIds" /> class.
        /// </summary>
        /// <param name="employeeId">The ID of an employee as given by their employer.</param>
        /// <param name="payrollId">The ID of an employee as given by their payroll.</param>
        /// <param name="positionId">The ID of the position of the employee.</param>
        public PlatformIds(string employeeId = default(string), string payrollId = default(string), string positionId = default(string)) : base()
        {
            this.EmployeeId = employeeId;
            this.PayrollId = payrollId;
            this.PositionId = positionId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of an employee as given by their employer
        /// </summary>
        /// <value>The ID of an employee as given by their employer</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = true)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// The ID of an employee as given by their payroll
        /// </summary>
        /// <value>The ID of an employee as given by their payroll</value>
        [DataMember(Name = "payroll_id", EmitDefaultValue = true)]
        public string PayrollId { get; set; }

        /// <summary>
        /// The ID of the position of the employee
        /// </summary>
        /// <value>The ID of the position of the employee</value>
        [DataMember(Name = "position_id", EmitDefaultValue = true)]
        public string PositionId { get; set; }

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
            sb.Append("class PlatformIds {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  PayrollId: ").Append(PayrollId).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
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
            return this.Equals(input as PlatformIds);
        }

        /// <summary>
        /// Returns true if PlatformIds instances are equal
        /// </summary>
        /// <param name="input">Instance of PlatformIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlatformIds input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && base.Equals(input) && 
                (
                    this.PayrollId == input.PayrollId ||
                    (this.PayrollId != null &&
                    this.PayrollId.Equals(input.PayrollId))
                ) && base.Equals(input) && 
                (
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
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
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.PayrollId != null)
                {
                    hashCode = (hashCode * 59) + this.PayrollId.GetHashCode();
                }
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
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
