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
    /// WalletTransactionExecuteRequest defines the request schema for &#x60;/wallet/transaction/execute&#x60;
    /// </summary>
    [DataContract(Name = "WalletTransactionExecuteRequest")]
    public partial class WalletTransactionExecuteRequest : IEquatable<WalletTransactionExecuteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionExecuteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletTransactionExecuteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionExecuteRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="idempotencyKey">A random key provided by the client, per unique wallet transaction. Maximum of 128 characters.  The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a wallet transaction fails due to a network connection error, then after a minimum delay of one minute, you can retry the request with the same idempotency key to guarantee that only a single wallet transaction is created. If the request was successfully processed, it will prevent any transaction that uses the same idempotency key, and was received within 24 hours of the first request, from being processed. (required).</param>
        /// <param name="walletId">The ID of the e-wallet to debit from (required).</param>
        /// <param name="counterparty">counterparty (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="reference">A reference for the transaction. This must be an alphanumeric string with at most 18 characters and must not contain any special characters or spaces. (required).</param>
        public WalletTransactionExecuteRequest(string clientId = default(string), string secret = default(string), string idempotencyKey = default(string), string walletId = default(string), WalletTransactionCounterparty counterparty = default(WalletTransactionCounterparty), WalletTransactionAmount amount = default(WalletTransactionAmount), string reference = default(string))
        {
            // to ensure "idempotencyKey" is required (not null)
            if (idempotencyKey == null)
            {
                throw new ArgumentNullException("idempotencyKey is a required property for WalletTransactionExecuteRequest and cannot be null");
            }
            this.IdempotencyKey = idempotencyKey;
            // to ensure "walletId" is required (not null)
            if (walletId == null)
            {
                throw new ArgumentNullException("walletId is a required property for WalletTransactionExecuteRequest and cannot be null");
            }
            this.WalletId = walletId;
            // to ensure "counterparty" is required (not null)
            if (counterparty == null)
            {
                throw new ArgumentNullException("counterparty is a required property for WalletTransactionExecuteRequest and cannot be null");
            }
            this.Counterparty = counterparty;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for WalletTransactionExecuteRequest and cannot be null");
            }
            this.Amount = amount;
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new ArgumentNullException("reference is a required property for WalletTransactionExecuteRequest and cannot be null");
            }
            this.Reference = reference;
            this.ClientId = clientId;
            this.Secret = secret;
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
        /// A random key provided by the client, per unique wallet transaction. Maximum of 128 characters.  The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a wallet transaction fails due to a network connection error, then after a minimum delay of one minute, you can retry the request with the same idempotency key to guarantee that only a single wallet transaction is created. If the request was successfully processed, it will prevent any transaction that uses the same idempotency key, and was received within 24 hours of the first request, from being processed.
        /// </summary>
        /// <value>A random key provided by the client, per unique wallet transaction. Maximum of 128 characters.  The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a wallet transaction fails due to a network connection error, then after a minimum delay of one minute, you can retry the request with the same idempotency key to guarantee that only a single wallet transaction is created. If the request was successfully processed, it will prevent any transaction that uses the same idempotency key, and was received within 24 hours of the first request, from being processed.</value>
        [DataMember(Name = "idempotency_key", IsRequired = true, EmitDefaultValue = false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// The ID of the e-wallet to debit from
        /// </summary>
        /// <value>The ID of the e-wallet to debit from</value>
        [DataMember(Name = "wallet_id", IsRequired = true, EmitDefaultValue = false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionCounterparty Counterparty { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionAmount Amount { get; set; }

        /// <summary>
        /// A reference for the transaction. This must be an alphanumeric string with at most 18 characters and must not contain any special characters or spaces.
        /// </summary>
        /// <value>A reference for the transaction. This must be an alphanumeric string with at most 18 characters and must not contain any special characters or spaces.</value>
        [DataMember(Name = "reference", IsRequired = true, EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletTransactionExecuteRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as WalletTransactionExecuteRequest);
        }

        /// <summary>
        /// Returns true if WalletTransactionExecuteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletTransactionExecuteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTransactionExecuteRequest input)
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
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.WalletId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletId.GetHashCode();
                }
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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
            if (this.IdempotencyKey != null && this.IdempotencyKey.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdempotencyKey, length must be less than 128.", new [] { "IdempotencyKey" });
            }

            // IdempotencyKey (string) minLength
            if (this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            // WalletId (string) minLength
            if (this.WalletId != null && this.WalletId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WalletId, length must be greater than 1.", new [] { "WalletId" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 18.", new [] { "Reference" });
            }

            // Reference (string) minLength
            if (this.Reference != null && this.Reference.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be greater than 1.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
