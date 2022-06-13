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
    /// Metadata that captures information about the Auth features of an institution.
    /// </summary>
    [DataContract(Name = "AuthMetadata")]
    public partial class AuthMetadata : Dictionary<String, Object>, IEquatable<AuthMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthMetadata()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthMetadata" /> class.
        /// </summary>
        /// <param name="supportedMethods">supportedMethods (required).</param>
        public AuthMetadata(AuthSupportedMethods supportedMethods = default(AuthSupportedMethods)) : base()
        {
            // to ensure "supportedMethods" is required (not null)
            if (supportedMethods == null)
            {
                throw new ArgumentNullException("supportedMethods is a required property for AuthMetadata and cannot be null");
            }
            this.SupportedMethods = supportedMethods;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets SupportedMethods
        /// </summary>
        [DataMember(Name = "supported_methods", IsRequired = true, EmitDefaultValue = true)]
        public AuthSupportedMethods SupportedMethods { get; set; }

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
            sb.Append("class AuthMetadata {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SupportedMethods: ").Append(SupportedMethods).Append("\n");
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
            return this.Equals(input as AuthMetadata);
        }

        /// <summary>
        /// Returns true if AuthMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.SupportedMethods == input.SupportedMethods ||
                    (this.SupportedMethods != null &&
                    this.SupportedMethods.Equals(input.SupportedMethods))
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
                if (this.SupportedMethods != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedMethods.GetHashCode();
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
