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
    /// An update on the health incident
    /// </summary>
    [DataContract(Name = "IncidentUpdate")]
    public partial class IncidentUpdate : Dictionary<String, Object>, IEquatable<IncidentUpdate>, IValidatableObject
    {
        /// <summary>
        /// The status of the incident.
        /// </summary>
        /// <value>The status of the incident.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum INVESTIGATING for value: INVESTIGATING
            /// </summary>
            [EnumMember(Value = "INVESTIGATING")]
            INVESTIGATING = 1,

            /// <summary>
            /// Enum IDENTIFIED for value: IDENTIFIED
            /// </summary>
            [EnumMember(Value = "IDENTIFIED")]
            IDENTIFIED = 2,

            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 3,

            /// <summary>
            /// Enum RESOLVED for value: RESOLVED
            /// </summary>
            [EnumMember(Value = "RESOLVED")]
            RESOLVED = 4,

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 5

        }


        /// <summary>
        /// The status of the incident.
        /// </summary>
        /// <value>The status of the incident.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentUpdate" /> class.
        /// </summary>
        /// <param name="description">The content of the update..</param>
        /// <param name="status">The status of the incident..</param>
        /// <param name="updatedDate">The date when the update was published, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;..</param>
        public IncidentUpdate(string description = default(string), StatusEnum? status = default(StatusEnum?), DateTime updatedDate = default(DateTime)) : base()
        {
            this.Description = description;
            this.Status = status;
            this.UpdatedDate = updatedDate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The content of the update.
        /// </summary>
        /// <value>The content of the update.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The date when the update was published, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;.
        /// </summary>
        /// <value>The date when the update was published, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;.</value>
        [DataMember(Name = "updated_date", EmitDefaultValue = false)]
        public DateTime UpdatedDate { get; set; }

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
            sb.Append("class IncidentUpdate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as IncidentUpdate);
        }

        /// <summary>
        /// Returns true if IncidentUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentUpdate input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.UpdatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedDate.GetHashCode();
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
