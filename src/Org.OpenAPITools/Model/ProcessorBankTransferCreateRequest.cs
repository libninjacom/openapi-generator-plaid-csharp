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
    /// Defines the request schema for &#x60;/processor/bank_transfer/create&#x60;
    /// </summary>
    [DataContract(Name = "ProcessorBankTransferCreateRequest")]
    public partial class ProcessorBankTransferCreateRequest : IEquatable<ProcessorBankTransferCreateRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public BankTransferType Type { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public BankTransferNetwork Network { get; set; }

        /// <summary>
        /// Gets or Sets AchClass
        /// </summary>
        [DataMember(Name = "ach_class", EmitDefaultValue = false)]
        public ACHClass? AchClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorBankTransferCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessorBankTransferCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorBankTransferCreateRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="idempotencyKey">A random key provided by the client, per unique bank transfer. Maximum of 50 characters.  The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a bank transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single bank transfer is created. (required).</param>
        /// <param name="processorToken">The processor token obtained from the Plaid integration partner. Processor tokens are in the format: &#x60;processor-&lt;environment&gt;-&lt;identifier&gt;&#x60; (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="amount">The amount of the bank transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). (required).</param>
        /// <param name="isoCurrencyCode">The currency of the transfer amount – should be set to \&quot;USD\&quot;. (required).</param>
        /// <param name="description">The transfer description. Maximum of 10 characters. (required).</param>
        /// <param name="achClass">achClass.</param>
        /// <param name="user">user (required).</param>
        /// <param name="customTag">An arbitrary string provided by the client for storage with the bank transfer. May be up to 100 characters..</param>
        /// <param name="metadata">The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters .</param>
        /// <param name="originationAccountId">Plaid’s unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified..</param>
        public ProcessorBankTransferCreateRequest(string clientId = default(string), string secret = default(string), string idempotencyKey = default(string), string processorToken = default(string), BankTransferType type = default(BankTransferType), BankTransferNetwork network = default(BankTransferNetwork), string amount = default(string), string isoCurrencyCode = default(string), string description = default(string), ACHClass? achClass = default(ACHClass?), BankTransferUser user = default(BankTransferUser), string customTag = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string originationAccountId = default(string))
        {
            // to ensure "idempotencyKey" is required (not null)
            if (idempotencyKey == null)
            {
                throw new ArgumentNullException("idempotencyKey is a required property for ProcessorBankTransferCreateRequest and cannot be null");
            }
            this.IdempotencyKey = idempotencyKey;
            // to ensure "processorToken" is required (not null)
            if (processorToken == null)
            {
                throw new ArgumentNullException("processorToken is a required property for ProcessorBankTransferCreateRequest and cannot be null");
            }
            this.ProcessorToken = processorToken;
            this.Type = type;
            this.Network = network;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ProcessorBankTransferCreateRequest and cannot be null");
            }
            this.Amount = amount;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for ProcessorBankTransferCreateRequest and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ProcessorBankTransferCreateRequest and cannot be null");
            }
            this.Description = description;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for ProcessorBankTransferCreateRequest and cannot be null");
            }
            this.User = user;
            this.ClientId = clientId;
            this.Secret = secret;
            this.AchClass = achClass;
            this.CustomTag = customTag;
            this.Metadata = metadata;
            this.OriginationAccountId = originationAccountId;
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
        /// A random key provided by the client, per unique bank transfer. Maximum of 50 characters.  The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a bank transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single bank transfer is created.
        /// </summary>
        /// <value>A random key provided by the client, per unique bank transfer. Maximum of 50 characters.  The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a bank transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single bank transfer is created.</value>
        [DataMember(Name = "idempotency_key", IsRequired = true, EmitDefaultValue = false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// The processor token obtained from the Plaid integration partner. Processor tokens are in the format: &#x60;processor-&lt;environment&gt;-&lt;identifier&gt;&#x60;
        /// </summary>
        /// <value>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: &#x60;processor-&lt;environment&gt;-&lt;identifier&gt;&#x60;</value>
        [DataMember(Name = "processor_token", IsRequired = true, EmitDefaultValue = false)]
        public string ProcessorToken { get; set; }

        /// <summary>
        /// The amount of the bank transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).
        /// </summary>
        /// <value>The amount of the bank transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The currency of the transfer amount – should be set to \&quot;USD\&quot;.
        /// </summary>
        /// <value>The currency of the transfer amount – should be set to \&quot;USD\&quot;.</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = false)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// The transfer description. Maximum of 10 characters.
        /// </summary>
        /// <value>The transfer description. Maximum of 10 characters.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public BankTransferUser User { get; set; }

        /// <summary>
        /// An arbitrary string provided by the client for storage with the bank transfer. May be up to 100 characters.
        /// </summary>
        /// <value>An arbitrary string provided by the client for storage with the bank transfer. May be up to 100 characters.</value>
        [DataMember(Name = "custom_tag", EmitDefaultValue = true)]
        public string CustomTag { get; set; }

        /// <summary>
        /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters 
        /// </summary>
        /// <value>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters </value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Plaid’s unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified.
        /// </summary>
        /// <value>Plaid’s unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified.</value>
        [DataMember(Name = "origination_account_id", EmitDefaultValue = true)]
        public string OriginationAccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessorBankTransferCreateRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  ProcessorToken: ").Append(ProcessorToken).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AchClass: ").Append(AchClass).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CustomTag: ").Append(CustomTag).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  OriginationAccountId: ").Append(OriginationAccountId).Append("\n");
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
            return this.Equals(input as ProcessorBankTransferCreateRequest);
        }

        /// <summary>
        /// Returns true if ProcessorBankTransferCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessorBankTransferCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessorBankTransferCreateRequest input)
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
                    this.IdempotencyKey == input.IdempotencyKey ||
                    (this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(input.IdempotencyKey))
                ) && 
                (
                    this.ProcessorToken == input.ProcessorToken ||
                    (this.ProcessorToken != null &&
                    this.ProcessorToken.Equals(input.ProcessorToken))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Network == input.Network ||
                    this.Network.Equals(input.Network)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
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
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.CustomTag == input.CustomTag ||
                    (this.CustomTag != null &&
                    this.CustomTag.Equals(input.CustomTag))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.OriginationAccountId == input.OriginationAccountId ||
                    (this.OriginationAccountId != null &&
                    this.OriginationAccountId.Equals(input.OriginationAccountId))
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
                if (this.IdempotencyKey != null)
                {
                    hashCode = (hashCode * 59) + this.IdempotencyKey.GetHashCode();
                }
                if (this.ProcessorToken != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessorToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AchClass.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.CustomTag != null)
                {
                    hashCode = (hashCode * 59) + this.CustomTag.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.OriginationAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginationAccountId.GetHashCode();
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
            // IdempotencyKey (string) maxLength
            if (this.IdempotencyKey != null && this.IdempotencyKey.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdempotencyKey, length must be less than 50.", new [] { "IdempotencyKey" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 10.", new [] { "Description" });
            }

            // CustomTag (string) maxLength
            if (this.CustomTag != null && this.CustomTag.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomTag, length must be less than 100.", new [] { "CustomTag" });
            }

            yield break;
        }
    }

}
