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
    /// Identifying information for transferring money to or from a US account via ACH or wire transfer.
    /// </summary>
    [DataContract(Name = "NumbersACH")]
    public partial class NumbersACH : Dictionary<String, Object>, IEquatable<NumbersACH>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumbersACH" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NumbersACH()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumbersACH" /> class.
        /// </summary>
        /// <param name="accountId">The Plaid account ID associated with the account numbers (required).</param>
        /// <param name="account">The ACH account number for the account.  Note that when using OAuth with Chase Bank (&#x60;ins_56&#x60;), Chase will issue \&quot;tokenized\&quot; routing and account numbers, which are not the user&#39;s actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the &#x60;mask&#x60; field will continue to reflect the actual account number, rather than the tokenized account number; for this reason, when displaying account numbers to the user to help them identify their account in your UI, always use the &#x60;mask&#x60; rather than truncating the &#x60;account&#x60; number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals. (required).</param>
        /// <param name="routing">The ACH routing number for the account. If the institution is &#x60;ins_56&#x60;, this may be a tokenized routing number. For more information, see the description of the &#x60;account&#x60; field. (required).</param>
        /// <param name="wireRouting">The wire transfer routing number for the account, if available (required).</param>
        public NumbersACH(string accountId = default(string), string account = default(string), string routing = default(string), string wireRouting = default(string)) : base()
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for NumbersACH and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for NumbersACH and cannot be null");
            }
            this.Account = account;
            // to ensure "routing" is required (not null)
            if (routing == null)
            {
                throw new ArgumentNullException("routing is a required property for NumbersACH and cannot be null");
            }
            this.Routing = routing;
            // to ensure "wireRouting" is required (not null)
            if (wireRouting == null)
            {
                throw new ArgumentNullException("wireRouting is a required property for NumbersACH and cannot be null");
            }
            this.WireRouting = wireRouting;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Plaid account ID associated with the account numbers
        /// </summary>
        /// <value>The Plaid account ID associated with the account numbers</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The ACH account number for the account.  Note that when using OAuth with Chase Bank (&#x60;ins_56&#x60;), Chase will issue \&quot;tokenized\&quot; routing and account numbers, which are not the user&#39;s actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the &#x60;mask&#x60; field will continue to reflect the actual account number, rather than the tokenized account number; for this reason, when displaying account numbers to the user to help them identify their account in your UI, always use the &#x60;mask&#x60; rather than truncating the &#x60;account&#x60; number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals.
        /// </summary>
        /// <value>The ACH account number for the account.  Note that when using OAuth with Chase Bank (&#x60;ins_56&#x60;), Chase will issue \&quot;tokenized\&quot; routing and account numbers, which are not the user&#39;s actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the &#x60;mask&#x60; field will continue to reflect the actual account number, rather than the tokenized account number; for this reason, when displaying account numbers to the user to help them identify their account in your UI, always use the &#x60;mask&#x60; rather than truncating the &#x60;account&#x60; number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals.</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// The ACH routing number for the account. If the institution is &#x60;ins_56&#x60;, this may be a tokenized routing number. For more information, see the description of the &#x60;account&#x60; field.
        /// </summary>
        /// <value>The ACH routing number for the account. If the institution is &#x60;ins_56&#x60;, this may be a tokenized routing number. For more information, see the description of the &#x60;account&#x60; field.</value>
        [DataMember(Name = "routing", IsRequired = true, EmitDefaultValue = false)]
        public string Routing { get; set; }

        /// <summary>
        /// The wire transfer routing number for the account, if available
        /// </summary>
        /// <value>The wire transfer routing number for the account, if available</value>
        [DataMember(Name = "wire_routing", IsRequired = true, EmitDefaultValue = true)]
        public string WireRouting { get; set; }

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
            sb.Append("class NumbersACH {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Routing: ").Append(Routing).Append("\n");
            sb.Append("  WireRouting: ").Append(WireRouting).Append("\n");
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
            return this.Equals(input as NumbersACH);
        }

        /// <summary>
        /// Returns true if NumbersACH instances are equal
        /// </summary>
        /// <param name="input">Instance of NumbersACH to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumbersACH input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.Routing == input.Routing ||
                    (this.Routing != null &&
                    this.Routing.Equals(input.Routing))
                ) && base.Equals(input) && 
                (
                    this.WireRouting == input.WireRouting ||
                    (this.WireRouting != null &&
                    this.WireRouting.Equals(input.WireRouting))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Routing != null)
                {
                    hashCode = (hashCode * 59) + this.Routing.GetHashCode();
                }
                if (this.WireRouting != null)
                {
                    hashCode = (hashCode * 59) + this.WireRouting.GetHashCode();
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
