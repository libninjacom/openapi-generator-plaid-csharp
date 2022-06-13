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
    /// Represents a transfer within the Transfers API.
    /// </summary>
    [DataContract(Name = "Transfer")]
    public partial class Transfer : Dictionary<String, Object>, IEquatable<Transfer>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AchClass
        /// </summary>
        [DataMember(Name = "ach_class", IsRequired = true, EmitDefaultValue = false)]
        public ACHClass AchClass { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TransferType Type { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public TransferStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets SweepStatus
        /// </summary>
        [DataMember(Name = "sweep_status", EmitDefaultValue = true)]
        public TransferSweepStatus? SweepStatus { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public TransferNetwork Network { get; set; }

        /// <summary>
        /// Gets or Sets GuaranteeDecision
        /// </summary>
        [DataMember(Name = "guarantee_decision", IsRequired = true, EmitDefaultValue = true)]
        public TransferAuthorizationGuaranteeDecision GuaranteeDecision { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Transfer()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer" /> class.
        /// </summary>
        /// <param name="id">Plaid’s unique identifier for a transfer. (required).</param>
        /// <param name="achClass">achClass (required).</param>
        /// <param name="accountId">The account ID that should be credited/debited for this transfer. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="amount">The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). (required).</param>
        /// <param name="description">The description of the transfer. (required).</param>
        /// <param name="created">The datetime when this transfer was created. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60; (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="sweepStatus">sweepStatus.</param>
        /// <param name="network">network (required).</param>
        /// <param name="cancellable">When &#x60;true&#x60;, you can still cancel this transfer. (required).</param>
        /// <param name="failureReason">failureReason (required).</param>
        /// <param name="metadata">The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters  (required).</param>
        /// <param name="originationAccountId">Plaid’s unique identifier for the origination account that was used for this transfer. (required).</param>
        /// <param name="guaranteeDecision">guaranteeDecision (required).</param>
        /// <param name="guaranteeDecisionRationale">guaranteeDecisionRationale (required).</param>
        /// <param name="isoCurrencyCode">The currency of the transfer amount, e.g. \&quot;USD\&quot; (required).</param>
        public Transfer(string id = default(string), ACHClass achClass = default(ACHClass), string accountId = default(string), TransferType type = default(TransferType), TransferUserInResponse user = default(TransferUserInResponse), string amount = default(string), string description = default(string), DateTime created = default(DateTime), TransferStatus status = default(TransferStatus), TransferSweepStatus? sweepStatus = default(TransferSweepStatus?), TransferNetwork network = default(TransferNetwork), bool cancellable = default(bool), TransferFailure failureReason = default(TransferFailure), Dictionary<string, string> metadata = default(Dictionary<string, string>), string originationAccountId = default(string), TransferAuthorizationGuaranteeDecision guaranteeDecision = default(TransferAuthorizationGuaranteeDecision), TransferAuthorizationGuaranteeDecisionRationale guaranteeDecisionRationale = default(TransferAuthorizationGuaranteeDecisionRationale), string isoCurrencyCode = default(string)) : base()
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Transfer and cannot be null");
            }
            this.Id = id;
            this.AchClass = achClass;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for Transfer and cannot be null");
            }
            this.AccountId = accountId;
            this.Type = type;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for Transfer and cannot be null");
            }
            this.User = user;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for Transfer and cannot be null");
            }
            this.Amount = amount;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Transfer and cannot be null");
            }
            this.Description = description;
            this.Created = created;
            this.Status = status;
            this.Network = network;
            this.Cancellable = cancellable;
            // to ensure "failureReason" is required (not null)
            if (failureReason == null)
            {
                throw new ArgumentNullException("failureReason is a required property for Transfer and cannot be null");
            }
            this.FailureReason = failureReason;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for Transfer and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "originationAccountId" is required (not null)
            if (originationAccountId == null)
            {
                throw new ArgumentNullException("originationAccountId is a required property for Transfer and cannot be null");
            }
            this.OriginationAccountId = originationAccountId;
            this.GuaranteeDecision = guaranteeDecision;
            // to ensure "guaranteeDecisionRationale" is required (not null)
            if (guaranteeDecisionRationale == null)
            {
                throw new ArgumentNullException("guaranteeDecisionRationale is a required property for Transfer and cannot be null");
            }
            this.GuaranteeDecisionRationale = guaranteeDecisionRationale;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for Transfer and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            this.SweepStatus = sweepStatus;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Plaid’s unique identifier for a transfer.
        /// </summary>
        /// <value>Plaid’s unique identifier for a transfer.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The account ID that should be credited/debited for this transfer.
        /// </summary>
        /// <value>The account ID that should be credited/debited for this transfer.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public TransferUserInResponse User { get; set; }

        /// <summary>
        /// The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).
        /// </summary>
        /// <value>The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The description of the transfer.
        /// </summary>
        /// <value>The description of the transfer.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The datetime when this transfer was created. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;
        /// </summary>
        /// <value>The datetime when this transfer was created. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// When &#x60;true&#x60;, you can still cancel this transfer.
        /// </summary>
        /// <value>When &#x60;true&#x60;, you can still cancel this transfer.</value>
        [DataMember(Name = "cancellable", IsRequired = true, EmitDefaultValue = true)]
        public bool Cancellable { get; set; }

        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failure_reason", IsRequired = true, EmitDefaultValue = true)]
        public TransferFailure FailureReason { get; set; }

        /// <summary>
        /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters 
        /// </summary>
        /// <value>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply: - The JSON values must be Strings (no nested JSON objects allowed) - Only ASCII characters may be used - Maximum of 50 key/value pairs - Maximum key length of 40 characters - Maximum value length of 500 characters </value>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Plaid’s unique identifier for the origination account that was used for this transfer.
        /// </summary>
        /// <value>Plaid’s unique identifier for the origination account that was used for this transfer.</value>
        [DataMember(Name = "origination_account_id", IsRequired = true, EmitDefaultValue = false)]
        public string OriginationAccountId { get; set; }

        /// <summary>
        /// Gets or Sets GuaranteeDecisionRationale
        /// </summary>
        [DataMember(Name = "guarantee_decision_rationale", IsRequired = true, EmitDefaultValue = true)]
        public TransferAuthorizationGuaranteeDecisionRationale GuaranteeDecisionRationale { get; set; }

        /// <summary>
        /// The currency of the transfer amount, e.g. \&quot;USD\&quot;
        /// </summary>
        /// <value>The currency of the transfer amount, e.g. \&quot;USD\&quot;</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = false)]
        public string IsoCurrencyCode { get; set; }

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
            sb.Append("class Transfer {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AchClass: ").Append(AchClass).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SweepStatus: ").Append(SweepStatus).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Cancellable: ").Append(Cancellable).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  OriginationAccountId: ").Append(OriginationAccountId).Append("\n");
            sb.Append("  GuaranteeDecision: ").Append(GuaranteeDecision).Append("\n");
            sb.Append("  GuaranteeDecisionRationale: ").Append(GuaranteeDecisionRationale).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
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
            return this.Equals(input as Transfer);
        }

        /// <summary>
        /// Returns true if Transfer instances are equal
        /// </summary>
        /// <param name="input">Instance of Transfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transfer input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.AchClass == input.AchClass ||
                    this.AchClass.Equals(input.AchClass)
                ) && base.Equals(input) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && base.Equals(input) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.SweepStatus == input.SweepStatus ||
                    this.SweepStatus.Equals(input.SweepStatus)
                ) && base.Equals(input) && 
                (
                    this.Network == input.Network ||
                    this.Network.Equals(input.Network)
                ) && base.Equals(input) && 
                (
                    this.Cancellable == input.Cancellable ||
                    this.Cancellable.Equals(input.Cancellable)
                ) && base.Equals(input) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && base.Equals(input) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && base.Equals(input) && 
                (
                    this.OriginationAccountId == input.OriginationAccountId ||
                    (this.OriginationAccountId != null &&
                    this.OriginationAccountId.Equals(input.OriginationAccountId))
                ) && base.Equals(input) && 
                (
                    this.GuaranteeDecision == input.GuaranteeDecision ||
                    this.GuaranteeDecision.Equals(input.GuaranteeDecision)
                ) && base.Equals(input) && 
                (
                    this.GuaranteeDecisionRationale == input.GuaranteeDecisionRationale ||
                    (this.GuaranteeDecisionRationale != null &&
                    this.GuaranteeDecisionRationale.Equals(input.GuaranteeDecisionRationale))
                ) && base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AchClass.GetHashCode();
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.SweepStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                hashCode = (hashCode * 59) + this.Cancellable.GetHashCode();
                if (this.FailureReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailureReason.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.OriginationAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginationAccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GuaranteeDecision.GetHashCode();
                if (this.GuaranteeDecisionRationale != null)
                {
                    hashCode = (hashCode * 59) + this.GuaranteeDecisionRationale.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
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
