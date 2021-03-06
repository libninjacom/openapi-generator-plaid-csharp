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
    /// The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The &#x60;first_name&#x60;, &#x60;last_name&#x60;, and &#x60;ssn&#x60; fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.
    /// </summary>
    [DataContract(Name = "AssetReportUser")]
    public partial class AssetReportUser : Dictionary<String, Object>, IEquatable<AssetReportUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReportUser" /> class.
        /// </summary>
        /// <param name="clientUserId">An identifier you determine and submit for the user..</param>
        /// <param name="firstName">The user&#39;s first name. Required for the Fannie Mae Day 1 Certainty™ program..</param>
        /// <param name="middleName">The user&#39;s middle name.</param>
        /// <param name="lastName">The user&#39;s last name.  Required for the Fannie Mae Day 1 Certainty™ program..</param>
        /// <param name="ssn">The user&#39;s Social Security Number. Required for the Fannie Mae Day 1 Certainty™ program.  Format: \&quot;ddd-dd-dddd\&quot;.</param>
        /// <param name="phoneNumber">The user&#39;s phone number, in E.164 format: +{countrycode}{number}. For example: \&quot;+14151234567\&quot;. Phone numbers provided in other formats will be parsed on a best-effort basis..</param>
        /// <param name="email">The user&#39;s email address..</param>
        public AssetReportUser(string clientUserId = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string), string ssn = default(string), string phoneNumber = default(string), string email = default(string)) : base()
        {
            this.ClientUserId = clientUserId;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An identifier you determine and submit for the user.
        /// </summary>
        /// <value>An identifier you determine and submit for the user.</value>
        [DataMember(Name = "client_user_id", EmitDefaultValue = true)]
        public string ClientUserId { get; set; }

        /// <summary>
        /// The user&#39;s first name. Required for the Fannie Mae Day 1 Certainty™ program.
        /// </summary>
        /// <value>The user&#39;s first name. Required for the Fannie Mae Day 1 Certainty™ program.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#39;s middle name
        /// </summary>
        /// <value>The user&#39;s middle name</value>
        [DataMember(Name = "middle_name", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The user&#39;s last name.  Required for the Fannie Mae Day 1 Certainty™ program.
        /// </summary>
        /// <value>The user&#39;s last name.  Required for the Fannie Mae Day 1 Certainty™ program.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#39;s Social Security Number. Required for the Fannie Mae Day 1 Certainty™ program.  Format: \&quot;ddd-dd-dddd\&quot;
        /// </summary>
        /// <value>The user&#39;s Social Security Number. Required for the Fannie Mae Day 1 Certainty™ program.  Format: \&quot;ddd-dd-dddd\&quot;</value>
        [DataMember(Name = "ssn", EmitDefaultValue = true)]
        public string Ssn { get; set; }

        /// <summary>
        /// The user&#39;s phone number, in E.164 format: +{countrycode}{number}. For example: \&quot;+14151234567\&quot;. Phone numbers provided in other formats will be parsed on a best-effort basis.
        /// </summary>
        /// <value>The user&#39;s phone number, in E.164 format: +{countrycode}{number}. For example: \&quot;+14151234567\&quot;. Phone numbers provided in other formats will be parsed on a best-effort basis.</value>
        [DataMember(Name = "phone_number", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

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
            sb.Append("class AssetReportUser {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as AssetReportUser);
        }

        /// <summary>
        /// Returns true if AssetReportUser instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetReportUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetReportUser input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ClientUserId == input.ClientUserId ||
                    (this.ClientUserId != null &&
                    this.ClientUserId.Equals(input.ClientUserId))
                ) && base.Equals(input) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && base.Equals(input) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && base.Equals(input) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && base.Equals(input) && 
                (
                    this.Ssn == input.Ssn ||
                    (this.Ssn != null &&
                    this.Ssn.Equals(input.Ssn))
                ) && base.Equals(input) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.ClientUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientUserId.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Ssn != null)
                {
                    hashCode = (hashCode * 59) + this.Ssn.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
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
