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
    /// The user&#39;s legal name
    /// </summary>
    [DataContract(Name = "SignalPersonName")]
    public partial class SignalPersonName : IEquatable<SignalPersonName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalPersonName" /> class.
        /// </summary>
        /// <param name="prefix">The user&#39;s name prefix (e.g. \&quot;Mr.\&quot;).</param>
        /// <param name="givenName">The user&#39;s given name. If the user has a one-word name, it should be provided in this field..</param>
        /// <param name="middleName">The user&#39;s middle name.</param>
        /// <param name="familyName">The user&#39;s family name / surname.</param>
        /// <param name="suffix">The user&#39;s name suffix (e.g. \&quot;II\&quot;).</param>
        public SignalPersonName(string prefix = default(string), string givenName = default(string), string middleName = default(string), string familyName = default(string), string suffix = default(string))
        {
            this.Prefix = prefix;
            this.GivenName = givenName;
            this.MiddleName = middleName;
            this.FamilyName = familyName;
            this.Suffix = suffix;
        }

        /// <summary>
        /// The user&#39;s name prefix (e.g. \&quot;Mr.\&quot;)
        /// </summary>
        /// <value>The user&#39;s name prefix (e.g. \&quot;Mr.\&quot;)</value>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// The user&#39;s given name. If the user has a one-word name, it should be provided in this field.
        /// </summary>
        /// <value>The user&#39;s given name. If the user has a one-word name, it should be provided in this field.</value>
        [DataMember(Name = "given_name", EmitDefaultValue = true)]
        public string GivenName { get; set; }

        /// <summary>
        /// The user&#39;s middle name
        /// </summary>
        /// <value>The user&#39;s middle name</value>
        [DataMember(Name = "middle_name", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The user&#39;s family name / surname
        /// </summary>
        /// <value>The user&#39;s family name / surname</value>
        [DataMember(Name = "family_name", EmitDefaultValue = true)]
        public string FamilyName { get; set; }

        /// <summary>
        /// The user&#39;s name suffix (e.g. \&quot;II\&quot;)
        /// </summary>
        /// <value>The user&#39;s name suffix (e.g. \&quot;II\&quot;)</value>
        [DataMember(Name = "suffix", EmitDefaultValue = true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignalPersonName {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
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
            return this.Equals(input as SignalPersonName);
        }

        /// <summary>
        /// Returns true if SignalPersonName instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalPersonName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalPersonName input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.Prefix != null)
                {
                    hashCode = (hashCode * 59) + this.Prefix.GetHashCode();
                }
                if (this.GivenName != null)
                {
                    hashCode = (hashCode * 59) + this.GivenName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.FamilyName != null)
                {
                    hashCode = (hashCode * 59) + this.FamilyName.GetHashCode();
                }
                if (this.Suffix != null)
                {
                    hashCode = (hashCode * 59) + this.Suffix.GetHashCode();
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
