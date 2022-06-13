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
    /// SignalEvaluateRequest defines the request schema for &#x60;/signal/evaluate&#x60;
    /// </summary>
    [DataContract(Name = "SignalEvaluateRequest")]
    public partial class SignalEvaluateRequest : IEquatable<SignalEvaluateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalEvaluateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignalEvaluateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalEvaluateRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="accessToken">The access token associated with the Item data is being requested for. (required).</param>
        /// <param name="accountId">The &#x60;account_id&#x60; of the account whose verification status is to be modified (required).</param>
        /// <param name="clientTransactionId">The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters. (required).</param>
        /// <param name="amount">The transaction amount, in USD (e.g. &#x60;102.05&#x60;) (required).</param>
        /// <param name="userPresent">&#x60;true&#x60; if the end user is present while initiating the ACH transfer and the endpoint is being called; &#x60;false&#x60; otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing)..</param>
        /// <param name="clientUserId">A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters..</param>
        /// <param name="user">user.</param>
        /// <param name="device">device.</param>
        public SignalEvaluateRequest(string clientId = default(string), string secret = default(string), string accessToken = default(string), string accountId = default(string), string clientTransactionId = default(string), decimal amount = default(decimal), bool? userPresent = default(bool?), string clientUserId = default(string), SignalUser user = default(SignalUser), SignalDevice device = default(SignalDevice))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new ArgumentNullException("accessToken is a required property for SignalEvaluateRequest and cannot be null");
            }
            this.AccessToken = accessToken;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for SignalEvaluateRequest and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "clientTransactionId" is required (not null)
            if (clientTransactionId == null)
            {
                throw new ArgumentNullException("clientTransactionId is a required property for SignalEvaluateRequest and cannot be null");
            }
            this.ClientTransactionId = clientTransactionId;
            this.Amount = amount;
            this.ClientId = clientId;
            this.Secret = secret;
            this.UserPresent = userPresent;
            this.ClientUserId = clientUserId;
            this.User = user;
            this.Device = device;
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
        /// The access token associated with the Item data is being requested for.
        /// </summary>
        /// <value>The access token associated with the Item data is being requested for.</value>
        [DataMember(Name = "access_token", IsRequired = true, EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The &#x60;account_id&#x60; of the account whose verification status is to be modified
        /// </summary>
        /// <value>The &#x60;account_id&#x60; of the account whose verification status is to be modified</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters.
        /// </summary>
        /// <value>The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters.</value>
        [DataMember(Name = "client_transaction_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientTransactionId { get; set; }

        /// <summary>
        /// The transaction amount, in USD (e.g. &#x60;102.05&#x60;)
        /// </summary>
        /// <value>The transaction amount, in USD (e.g. &#x60;102.05&#x60;)</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if the end user is present while initiating the ACH transfer and the endpoint is being called; &#x60;false&#x60; otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing).
        /// </summary>
        /// <value>&#x60;true&#x60; if the end user is present while initiating the ACH transfer and the endpoint is being called; &#x60;false&#x60; otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing).</value>
        [DataMember(Name = "user_present", EmitDefaultValue = true)]
        public bool? UserPresent { get; set; }

        /// <summary>
        /// A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters.
        /// </summary>
        /// <value>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters.</value>
        [DataMember(Name = "client_user_id", EmitDefaultValue = false)]
        public string ClientUserId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public SignalUser User { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public SignalDevice Device { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignalEvaluateRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ClientTransactionId: ").Append(ClientTransactionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UserPresent: ").Append(UserPresent).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
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
            return this.Equals(input as SignalEvaluateRequest);
        }

        /// <summary>
        /// Returns true if SignalEvaluateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalEvaluateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalEvaluateRequest input)
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
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ClientTransactionId == input.ClientTransactionId ||
                    (this.ClientTransactionId != null &&
                    this.ClientTransactionId.Equals(input.ClientTransactionId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.UserPresent == input.UserPresent ||
                    (this.UserPresent != null &&
                    this.UserPresent.Equals(input.UserPresent))
                ) && 
                (
                    this.ClientUserId == input.ClientUserId ||
                    (this.ClientUserId != null &&
                    this.ClientUserId.Equals(input.ClientUserId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
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
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.ClientTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientTransactionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.UserPresent != null)
                {
                    hashCode = (hashCode * 59) + this.UserPresent.GetHashCode();
                }
                if (this.ClientUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientUserId.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
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
            // ClientTransactionId (string) maxLength
            if (this.ClientTransactionId != null && this.ClientTransactionId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientTransactionId, length must be less than 36.", new [] { "ClientTransactionId" });
            }

            // ClientTransactionId (string) minLength
            if (this.ClientTransactionId != null && this.ClientTransactionId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientTransactionId, length must be greater than 1.", new [] { "ClientTransactionId" });
            }

            // ClientUserId (string) maxLength
            if (this.ClientUserId != null && this.ClientUserId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientUserId, length must be less than 36.", new [] { "ClientUserId" });
            }

            yield break;
        }
    }

}