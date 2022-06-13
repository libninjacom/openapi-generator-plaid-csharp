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
    /// The deposit switch destination account
    /// </summary>
    [DataContract(Name = "DepositSwitchTargetAccount")]
    public partial class DepositSwitchTargetAccount : Dictionary<String, Object>, IEquatable<DepositSwitchTargetAccount>, IValidatableObject
    {
        /// <summary>
        /// The account subtype of the account, either &#x60;checking&#x60; or &#x60;savings&#x60;.
        /// </summary>
        /// <value>The account subtype of the account, either &#x60;checking&#x60; or &#x60;savings&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountSubtypeEnum
        {
            /// <summary>
            /// Enum Checking for value: checking
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking = 1,

            /// <summary>
            /// Enum Savings for value: savings
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings = 2

        }


        /// <summary>
        /// The account subtype of the account, either &#x60;checking&#x60; or &#x60;savings&#x60;.
        /// </summary>
        /// <value>The account subtype of the account, either &#x60;checking&#x60; or &#x60;savings&#x60;.</value>
        [DataMember(Name = "account_subtype", IsRequired = true, EmitDefaultValue = false)]
        public AccountSubtypeEnum AccountSubtype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositSwitchTargetAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepositSwitchTargetAccount()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositSwitchTargetAccount" /> class.
        /// </summary>
        /// <param name="accountNumber">Account number for deposit switch destination (required).</param>
        /// <param name="routingNumber">Routing number for deposit switch destination (required).</param>
        /// <param name="accountName">The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking. (required).</param>
        /// <param name="accountSubtype">The account subtype of the account, either &#x60;checking&#x60; or &#x60;savings&#x60;. (required).</param>
        public DepositSwitchTargetAccount(string accountNumber = default(string), string routingNumber = default(string), string accountName = default(string), AccountSubtypeEnum accountSubtype = default(AccountSubtypeEnum)) : base()
        {
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new ArgumentNullException("accountNumber is a required property for DepositSwitchTargetAccount and cannot be null");
            }
            this.AccountNumber = accountNumber;
            // to ensure "routingNumber" is required (not null)
            if (routingNumber == null)
            {
                throw new ArgumentNullException("routingNumber is a required property for DepositSwitchTargetAccount and cannot be null");
            }
            this.RoutingNumber = routingNumber;
            // to ensure "accountName" is required (not null)
            if (accountName == null)
            {
                throw new ArgumentNullException("accountName is a required property for DepositSwitchTargetAccount and cannot be null");
            }
            this.AccountName = accountName;
            this.AccountSubtype = accountSubtype;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Account number for deposit switch destination
        /// </summary>
        /// <value>Account number for deposit switch destination</value>
        [DataMember(Name = "account_number", IsRequired = true, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Routing number for deposit switch destination
        /// </summary>
        /// <value>Routing number for deposit switch destination</value>
        [DataMember(Name = "routing_number", IsRequired = true, EmitDefaultValue = false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking.
        /// </summary>
        /// <value>The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking.</value>
        [DataMember(Name = "account_name", IsRequired = true, EmitDefaultValue = false)]
        public string AccountName { get; set; }

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
            sb.Append("class DepositSwitchTargetAccount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountSubtype: ").Append(AccountSubtype).Append("\n");
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
            return this.Equals(input as DepositSwitchTargetAccount);
        }

        /// <summary>
        /// Returns true if DepositSwitchTargetAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositSwitchTargetAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositSwitchTargetAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && base.Equals(input) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && base.Equals(input) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && base.Equals(input) && 
                (
                    this.AccountSubtype == input.AccountSubtype ||
                    this.AccountSubtype.Equals(input.AccountSubtype)
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountSubtype.GetHashCode();
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
