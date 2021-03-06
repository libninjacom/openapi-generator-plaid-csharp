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
    /// DepositSwitchAltCreateRequest defines the request schema for &#x60;/deposit_switch/alt/create&#x60;
    /// </summary>
    [DataContract(Name = "DepositSwitchAltCreateRequest")]
    public partial class DepositSwitchAltCreateRequest : IEquatable<DepositSwitchAltCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// ISO-3166-1 alpha-2 country code standard.
        /// </summary>
        /// <value>ISO-3166-1 alpha-2 country code standard.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountryCodeEnum
        {
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 1,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 2

        }


        /// <summary>
        /// ISO-3166-1 alpha-2 country code standard.
        /// </summary>
        /// <value>ISO-3166-1 alpha-2 country code standard.</value>
        [DataMember(Name = "country_code", EmitDefaultValue = true)]
        public CountryCodeEnum? CountryCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositSwitchAltCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepositSwitchAltCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositSwitchAltCreateRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="targetAccount">targetAccount (required).</param>
        /// <param name="targetUser">targetUser (required).</param>
        /// <param name="options">options.</param>
        /// <param name="countryCode">ISO-3166-1 alpha-2 country code standard..</param>
        public DepositSwitchAltCreateRequest(string clientId = default(string), string secret = default(string), DepositSwitchTargetAccount targetAccount = default(DepositSwitchTargetAccount), DepositSwitchTargetUser targetUser = default(DepositSwitchTargetUser), DepositSwitchCreateRequestOptions options = default(DepositSwitchCreateRequestOptions), CountryCodeEnum? countryCode = default(CountryCodeEnum?))
        {
            // to ensure "targetAccount" is required (not null)
            if (targetAccount == null)
            {
                throw new ArgumentNullException("targetAccount is a required property for DepositSwitchAltCreateRequest and cannot be null");
            }
            this.TargetAccount = targetAccount;
            // to ensure "targetUser" is required (not null)
            if (targetUser == null)
            {
                throw new ArgumentNullException("targetUser is a required property for DepositSwitchAltCreateRequest and cannot be null");
            }
            this.TargetUser = targetUser;
            this.ClientId = clientId;
            this.Secret = secret;
            this.Options = options;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or Sets TargetAccount
        /// </summary>
        [DataMember(Name = "target_account", IsRequired = true, EmitDefaultValue = false)]
        public DepositSwitchTargetAccount TargetAccount { get; set; }

        /// <summary>
        /// Gets or Sets TargetUser
        /// </summary>
        [DataMember(Name = "target_user", IsRequired = true, EmitDefaultValue = false)]
        public DepositSwitchTargetUser TargetUser { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public DepositSwitchCreateRequestOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepositSwitchAltCreateRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  TargetAccount: ").Append(TargetAccount).Append("\n");
            sb.Append("  TargetUser: ").Append(TargetUser).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as DepositSwitchAltCreateRequest);
        }

        /// <summary>
        /// Returns true if DepositSwitchAltCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositSwitchAltCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositSwitchAltCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.TargetAccount == input.TargetAccount ||
                    (this.TargetAccount != null &&
                    this.TargetAccount.Equals(input.TargetAccount))
                ) && 
                (
                    this.TargetUser == input.TargetUser ||
                    (this.TargetUser != null &&
                    this.TargetUser.Equals(input.TargetUser))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    this.CountryCode.Equals(input.CountryCode)
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                if (this.TargetAccount != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAccount.GetHashCode();
                }
                if (this.TargetUser != null)
                {
                    hashCode = (hashCode * 59) + this.TargetUser.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
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
