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
    /// Allow or disallow product access by account. Unlisted (e.g. missing) accounts will be considered &#x60;new_accounts&#x60;.
    /// </summary>
    [DataContract(Name = "AccountAccess")]
    public partial class AccountAccess : IEquatable<AccountAccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountAccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAccess" /> class.
        /// </summary>
        /// <param name="uniqueId">The unique account identifier for this account. This value must match that returned by the data access API for this account. (required).</param>
        /// <param name="authorized">Allow the application to see this account (and associated details, including balance) in the list of accounts  If unset, defaults to &#x60;true&#x60;. (default to true).</param>
        /// <param name="accountProductAccess">accountProductAccess.</param>
        public AccountAccess(string uniqueId = default(string), bool? authorized = true, AccountProductAccessNullable accountProductAccess = default(AccountProductAccessNullable))
        {
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new ArgumentNullException("uniqueId is a required property for AccountAccess and cannot be null");
            }
            this.UniqueId = uniqueId;
            // use default value if no "authorized" provided
            this.Authorized = authorized ?? true;
            this.AccountProductAccess = accountProductAccess;
        }

        /// <summary>
        /// The unique account identifier for this account. This value must match that returned by the data access API for this account.
        /// </summary>
        /// <value>The unique account identifier for this account. This value must match that returned by the data access API for this account.</value>
        [DataMember(Name = "unique_id", IsRequired = true, EmitDefaultValue = false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Allow the application to see this account (and associated details, including balance) in the list of accounts  If unset, defaults to &#x60;true&#x60;.
        /// </summary>
        /// <value>Allow the application to see this account (and associated details, including balance) in the list of accounts  If unset, defaults to &#x60;true&#x60;.</value>
        [DataMember(Name = "authorized", EmitDefaultValue = true)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// Gets or Sets AccountProductAccess
        /// </summary>
        [DataMember(Name = "account_product_access", EmitDefaultValue = true)]
        public AccountProductAccessNullable AccountProductAccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountAccess {\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  Authorized: ").Append(Authorized).Append("\n");
            sb.Append("  AccountProductAccess: ").Append(AccountProductAccess).Append("\n");
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
            return this.Equals(input as AccountAccess);
        }

        /// <summary>
        /// Returns true if AccountAccess instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAccess input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.Authorized == input.Authorized ||
                    (this.Authorized != null &&
                    this.Authorized.Equals(input.Authorized))
                ) && 
                (
                    this.AccountProductAccess == input.AccountProductAccess ||
                    (this.AccountProductAccess != null &&
                    this.AccountProductAccess.Equals(input.AccountProductAccess))
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
                if (this.UniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueId.GetHashCode();
                }
                if (this.Authorized != null)
                {
                    hashCode = (hashCode * 59) + this.Authorized.GetHashCode();
                }
                if (this.AccountProductAccess != null)
                {
                    hashCode = (hashCode * 59) + this.AccountProductAccess.GetHashCode();
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
