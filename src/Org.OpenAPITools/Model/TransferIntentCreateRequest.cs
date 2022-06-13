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
    /// Defines the request schema for &#x60;/transfer/intent/create&#x60;
    /// </summary>
    [DataContract(Name = "TransferIntentCreateRequest")]
    public partial class TransferIntentCreateRequest : IEquatable<TransferIntentCreateRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = false)]
        public TransferIntentCreateMode Mode { get; set; }

        /// <summary>
        /// Gets or Sets AchClass
        /// </summary>
        [DataMember(Name = "ach_class", IsRequired = true, EmitDefaultValue = false)]
        public ACHClass AchClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferIntentCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferIntentCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferIntentCreateRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body. (required).</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body. (required).</param>
        /// <param name="accountId">The Plaid &#x60;account_id&#x60; for the account that will be debited or credited..</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="amount">The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). (required).</param>
        /// <param name="description">A description for the underlying transfer. Maximum of 8 characters. (required).</param>
        /// <param name="achClass">achClass (required).</param>
        /// <param name="originationAccountId">Plaid’s unique identifier for the origination account for the intent. If not provided, the default account will be used..</param>
        /// <param name="user">user (required).</param>
        /// <param name="metadata">The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters .</param>
        /// <param name="isoCurrencyCode">The currency of the transfer amount, e.g. \&quot;USD\&quot;.</param>
        public TransferIntentCreateRequest(string clientId = default(string), string secret = default(string), string accountId = default(string), TransferIntentCreateMode mode = default(TransferIntentCreateMode), string amount = default(string), string description = default(string), ACHClass achClass = default(ACHClass), string originationAccountId = default(string), TransferUserInRequest user = default(TransferUserInRequest), Dictionary<string, string> metadata = default(Dictionary<string, string>), string isoCurrencyCode = default(string))
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for TransferIntentCreateRequest and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new ArgumentNullException("secret is a required property for TransferIntentCreateRequest and cannot be null");
            }
            this.Secret = secret;
            this.Mode = mode;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TransferIntentCreateRequest and cannot be null");
            }
            this.Amount = amount;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TransferIntentCreateRequest and cannot be null");
            }
            this.Description = description;
            this.AchClass = achClass;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for TransferIntentCreateRequest and cannot be null");
            }
            this.User = user;
            this.AccountId = accountId;
            this.OriginationAccountId = originationAccountId;
            this.Metadata = metadata;
            this.IsoCurrencyCode = isoCurrencyCode;
        }

        /// <summary>
        /// Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.</value>
        [DataMember(Name = "secret", IsRequired = true, EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// The Plaid &#x60;account_id&#x60; for the account that will be debited or credited.
        /// </summary>
        /// <value>The Plaid &#x60;account_id&#x60; for the account that will be debited or credited.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).
        /// </summary>
        /// <value>The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// A description for the underlying transfer. Maximum of 8 characters.
        /// </summary>
        /// <value>A description for the underlying transfer. Maximum of 8 characters.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Plaid’s unique identifier for the origination account for the intent. If not provided, the default account will be used.
        /// </summary>
        /// <value>Plaid’s unique identifier for the origination account for the intent. If not provided, the default account will be used.</value>
        [DataMember(Name = "origination_account_id", EmitDefaultValue = true)]
        public string OriginationAccountId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public TransferUserInRequest User { get; set; }

        /// <summary>
        /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters 
        /// </summary>
        /// <value>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters </value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The currency of the transfer amount, e.g. \&quot;USD\&quot;
        /// </summary>
        /// <value>The currency of the transfer amount, e.g. \&quot;USD\&quot;</value>
        [DataMember(Name = "iso_currency_code", EmitDefaultValue = false)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferIntentCreateRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AchClass: ").Append(AchClass).Append("\n");
            sb.Append("  OriginationAccountId: ").Append(OriginationAccountId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
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
            return this.Equals(input as TransferIntentCreateRequest);
        }

        /// <summary>
        /// Returns true if TransferIntentCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferIntentCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferIntentCreateRequest input)
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AchClass == input.AchClass ||
                    this.AchClass.Equals(input.AchClass)
                ) && 
                (
                    this.OriginationAccountId == input.OriginationAccountId ||
                    (this.OriginationAccountId != null &&
                    this.OriginationAccountId.Equals(input.OriginationAccountId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AchClass.GetHashCode();
                if (this.OriginationAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginationAccountId.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 8.", new [] { "Description" });
            }

            yield break;
        }
    }

}
