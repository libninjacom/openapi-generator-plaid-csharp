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
    /// A status health incident
    /// </summary>
    [DataContract(Name = "HealthIncident")]
    public partial class HealthIncident : Dictionary<String, Object>, IEquatable<HealthIncident>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthIncident" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HealthIncident()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthIncident" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;. (required).</param>
        /// <param name="endDate">The end date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;..</param>
        /// <param name="title">The title of the incident (required).</param>
        /// <param name="incidentUpdates">Updates on the health incident. (required).</param>
        public HealthIncident(DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), string title = default(string), List<IncidentUpdate> incidentUpdates = default(List<IncidentUpdate>)) : base()
        {
            this.StartDate = startDate;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for HealthIncident and cannot be null");
            }
            this.Title = title;
            // to ensure "incidentUpdates" is required (not null)
            if (incidentUpdates == null)
            {
                throw new ArgumentNullException("incidentUpdates is a required property for HealthIncident and cannot be null");
            }
            this.IncidentUpdates = incidentUpdates;
            this.EndDate = endDate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The start date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;.
        /// </summary>
        /// <value>The start date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;.</value>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;.
        /// </summary>
        /// <value>The end date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. &#x60;\&quot;2020-10-30T15:26:48Z\&quot;&#x60;.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The title of the incident
        /// </summary>
        /// <value>The title of the incident</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Updates on the health incident.
        /// </summary>
        /// <value>Updates on the health incident.</value>
        [DataMember(Name = "incident_updates", IsRequired = true, EmitDefaultValue = false)]
        public List<IncidentUpdate> IncidentUpdates { get; set; }

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
            sb.Append("class HealthIncident {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IncidentUpdates: ").Append(IncidentUpdates).Append("\n");
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
            return this.Equals(input as HealthIncident);
        }

        /// <summary>
        /// Returns true if HealthIncident instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthIncident to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthIncident input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && base.Equals(input) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && base.Equals(input) && 
                (
                    this.IncidentUpdates == input.IncidentUpdates ||
                    this.IncidentUpdates != null &&
                    input.IncidentUpdates != null &&
                    this.IncidentUpdates.SequenceEqual(input.IncidentUpdates)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.IncidentUpdates != null)
                {
                    hashCode = (hashCode * 59) + this.IncidentUpdates.GetHashCode();
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
