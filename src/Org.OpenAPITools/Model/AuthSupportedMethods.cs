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
    /// Metadata specifically related to which auth methods an institution supports.
    /// </summary>
    [DataContract(Name = "AuthSupportedMethods")]
    public partial class AuthSupportedMethods : Dictionary<String, Object>, IEquatable<AuthSupportedMethods>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSupportedMethods" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthSupportedMethods()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSupportedMethods" /> class.
        /// </summary>
        /// <param name="instantAuth">Indicates if instant auth is supported. (required).</param>
        /// <param name="instantMatch">Indicates if instant match is supported. (required).</param>
        /// <param name="automatedMicroDeposits">Indicates if automated microdeposits are supported. (required).</param>
        public AuthSupportedMethods(bool instantAuth = default(bool), bool instantMatch = default(bool), bool automatedMicroDeposits = default(bool)) : base()
        {
            this.InstantAuth = instantAuth;
            this.InstantMatch = instantMatch;
            this.AutomatedMicroDeposits = automatedMicroDeposits;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Indicates if instant auth is supported.
        /// </summary>
        /// <value>Indicates if instant auth is supported.</value>
        [DataMember(Name = "instant_auth", IsRequired = true, EmitDefaultValue = true)]
        public bool InstantAuth { get; set; }

        /// <summary>
        /// Indicates if instant match is supported.
        /// </summary>
        /// <value>Indicates if instant match is supported.</value>
        [DataMember(Name = "instant_match", IsRequired = true, EmitDefaultValue = true)]
        public bool InstantMatch { get; set; }

        /// <summary>
        /// Indicates if automated microdeposits are supported.
        /// </summary>
        /// <value>Indicates if automated microdeposits are supported.</value>
        [DataMember(Name = "automated_micro_deposits", IsRequired = true, EmitDefaultValue = true)]
        public bool AutomatedMicroDeposits { get; set; }

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
            sb.Append("class AuthSupportedMethods {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  InstantAuth: ").Append(InstantAuth).Append("\n");
            sb.Append("  InstantMatch: ").Append(InstantMatch).Append("\n");
            sb.Append("  AutomatedMicroDeposits: ").Append(AutomatedMicroDeposits).Append("\n");
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
            return this.Equals(input as AuthSupportedMethods);
        }

        /// <summary>
        /// Returns true if AuthSupportedMethods instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthSupportedMethods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthSupportedMethods input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.InstantAuth == input.InstantAuth ||
                    this.InstantAuth.Equals(input.InstantAuth)
                ) && base.Equals(input) && 
                (
                    this.InstantMatch == input.InstantMatch ||
                    this.InstantMatch.Equals(input.InstantMatch)
                ) && base.Equals(input) && 
                (
                    this.AutomatedMicroDeposits == input.AutomatedMicroDeposits ||
                    this.AutomatedMicroDeposits.Equals(input.AutomatedMicroDeposits)
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
                hashCode = (hashCode * 59) + this.InstantAuth.GetHashCode();
                hashCode = (hashCode * 59) + this.InstantMatch.GetHashCode();
                hashCode = (hashCode * 59) + this.AutomatedMicroDeposits.GetHashCode();
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
