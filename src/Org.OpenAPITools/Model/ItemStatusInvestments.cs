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
    /// Information about the last successful and failed investments update for the Item.
    /// </summary>
    [DataContract(Name = "ItemStatusInvestments")]
    public partial class ItemStatusInvestments : Dictionary<String, Object>, IEquatable<ItemStatusInvestments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStatusInvestments" /> class.
        /// </summary>
        /// <param name="lastSuccessfulUpdate">[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last successful investments update for the Item. The status will update each time Plaid successfully connects with the institution, regardless of whether any new data is available in the update..</param>
        /// <param name="lastFailedUpdate">[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last failed investments update for the Item. The status will update each time Plaid fails an attempt to connect with the institution, regardless of whether any new data is available in the update..</param>
        public ItemStatusInvestments(DateTime? lastSuccessfulUpdate = default(DateTime?), DateTime? lastFailedUpdate = default(DateTime?)) : base()
        {
            this.LastSuccessfulUpdate = lastSuccessfulUpdate;
            this.LastFailedUpdate = lastFailedUpdate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// [ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last successful investments update for the Item. The status will update each time Plaid successfully connects with the institution, regardless of whether any new data is available in the update.
        /// </summary>
        /// <value>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last successful investments update for the Item. The status will update each time Plaid successfully connects with the institution, regardless of whether any new data is available in the update.</value>
        [DataMember(Name = "last_successful_update", EmitDefaultValue = true)]
        public DateTime? LastSuccessfulUpdate { get; set; }

        /// <summary>
        /// [ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last failed investments update for the Item. The status will update each time Plaid fails an attempt to connect with the institution, regardless of whether any new data is available in the update.
        /// </summary>
        /// <value>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last failed investments update for the Item. The status will update each time Plaid fails an attempt to connect with the institution, regardless of whether any new data is available in the update.</value>
        [DataMember(Name = "last_failed_update", EmitDefaultValue = true)]
        public DateTime? LastFailedUpdate { get; set; }

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
            sb.Append("class ItemStatusInvestments {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LastSuccessfulUpdate: ").Append(LastSuccessfulUpdate).Append("\n");
            sb.Append("  LastFailedUpdate: ").Append(LastFailedUpdate).Append("\n");
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
            return this.Equals(input as ItemStatusInvestments);
        }

        /// <summary>
        /// Returns true if ItemStatusInvestments instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemStatusInvestments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemStatusInvestments input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.LastSuccessfulUpdate == input.LastSuccessfulUpdate ||
                    (this.LastSuccessfulUpdate != null &&
                    this.LastSuccessfulUpdate.Equals(input.LastSuccessfulUpdate))
                ) && base.Equals(input) && 
                (
                    this.LastFailedUpdate == input.LastFailedUpdate ||
                    (this.LastFailedUpdate != null &&
                    this.LastFailedUpdate.Equals(input.LastFailedUpdate))
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
                if (this.LastSuccessfulUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastSuccessfulUpdate.GetHashCode();
                }
                if (this.LastFailedUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastFailedUpdate.GetHashCode();
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
