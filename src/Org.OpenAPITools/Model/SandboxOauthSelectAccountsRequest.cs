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
    /// Defines the request schema for &#x60;sandbox/oauth/select_accounts&#x60;
    /// </summary>
    [DataContract(Name = "SandboxOauthSelectAccountsRequest")]
    public partial class SandboxOauthSelectAccountsRequest : IEquatable<SandboxOauthSelectAccountsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxOauthSelectAccountsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SandboxOauthSelectAccountsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxOauthSelectAccountsRequest" /> class.
        /// </summary>
        /// <param name="oauthStateId">oauthStateId (required).</param>
        /// <param name="accounts">accounts (required).</param>
        public SandboxOauthSelectAccountsRequest(string oauthStateId = default(string), List<string> accounts = default(List<string>))
        {
            // to ensure "oauthStateId" is required (not null)
            if (oauthStateId == null)
            {
                throw new ArgumentNullException("oauthStateId is a required property for SandboxOauthSelectAccountsRequest and cannot be null");
            }
            this.OauthStateId = oauthStateId;
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new ArgumentNullException("accounts is a required property for SandboxOauthSelectAccountsRequest and cannot be null");
            }
            this.Accounts = accounts;
        }

        /// <summary>
        /// Gets or Sets OauthStateId
        /// </summary>
        [DataMember(Name = "oauth_state_id", IsRequired = true, EmitDefaultValue = false)]
        public string OauthStateId { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SandboxOauthSelectAccountsRequest {\n");
            sb.Append("  OauthStateId: ").Append(OauthStateId).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as SandboxOauthSelectAccountsRequest);
        }

        /// <summary>
        /// Returns true if SandboxOauthSelectAccountsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SandboxOauthSelectAccountsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SandboxOauthSelectAccountsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OauthStateId == input.OauthStateId ||
                    (this.OauthStateId != null &&
                    this.OauthStateId.Equals(input.OauthStateId))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.OauthStateId != null)
                {
                    hashCode = (hashCode * 59) + this.OauthStateId.GetHashCode();
                }
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
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
