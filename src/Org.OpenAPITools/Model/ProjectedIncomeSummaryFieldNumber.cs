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
    /// The employee&#39;s estimated annual salary, as derived from information reported on the paystub.
    /// </summary>
    [DataContract(Name = "ProjectedIncomeSummaryFieldNumber")]
    public partial class ProjectedIncomeSummaryFieldNumber : IEquatable<ProjectedIncomeSummaryFieldNumber>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VerificationStatus
        /// </summary>
        [DataMember(Name = "verification_status", IsRequired = true, EmitDefaultValue = false)]
        public VerificationStatus VerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectedIncomeSummaryFieldNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectedIncomeSummaryFieldNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectedIncomeSummaryFieldNumber" /> class.
        /// </summary>
        /// <param name="value">The value of the field. (required).</param>
        /// <param name="verificationStatus">verificationStatus (required).</param>
        public ProjectedIncomeSummaryFieldNumber(decimal value = default(decimal), VerificationStatus verificationStatus = default(VerificationStatus))
        {
            this.Value = value;
            this.VerificationStatus = verificationStatus;
        }

        /// <summary>
        /// The value of the field.
        /// </summary>
        /// <value>The value of the field.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectedIncomeSummaryFieldNumber {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ProjectedIncomeSummaryFieldNumber);
        }

        /// <summary>
        /// Returns true if ProjectedIncomeSummaryFieldNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectedIncomeSummaryFieldNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectedIncomeSummaryFieldNumber input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    this.VerificationStatus.Equals(input.VerificationStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
