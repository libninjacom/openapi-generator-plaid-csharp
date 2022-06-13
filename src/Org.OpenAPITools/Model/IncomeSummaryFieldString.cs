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
    /// Data about the income summary
    /// </summary>
    [DataContract(Name = "IncomeSummaryFieldString")]
    public partial class IncomeSummaryFieldString : Dictionary<String, Object>, IEquatable<IncomeSummaryFieldString>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VerificationStatus
        /// </summary>
        [DataMember(Name = "verification_status", IsRequired = true, EmitDefaultValue = false)]
        public VerificationStatus VerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeSummaryFieldString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncomeSummaryFieldString()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeSummaryFieldString" /> class.
        /// </summary>
        /// <param name="value">The value of the field. (required).</param>
        /// <param name="verificationStatus">verificationStatus (required).</param>
        public IncomeSummaryFieldString(string value = default(string), VerificationStatus verificationStatus = default(VerificationStatus)) : base()
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for IncomeSummaryFieldString and cannot be null");
            }
            this.Value = value;
            this.VerificationStatus = verificationStatus;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The value of the field.
        /// </summary>
        /// <value>The value of the field.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

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
            sb.Append("class IncomeSummaryFieldString {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(input as IncomeSummaryFieldString);
        }

        /// <summary>
        /// Returns true if IncomeSummaryFieldString instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeSummaryFieldString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeSummaryFieldString input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    this.VerificationStatus.Equals(input.VerificationStatus)
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
