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
    /// Represents an event in the Transfers API.
    /// </summary>
    [DataContract(Name = "TransferEvent")]
    public partial class TransferEvent : Dictionary<String, Object>, IEquatable<TransferEvent>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "event_type", IsRequired = true, EmitDefaultValue = false)]
        public TransferEventType EventType { get; set; }

        /// <summary>
        /// Gets or Sets TransferType
        /// </summary>
        [DataMember(Name = "transfer_type", IsRequired = true, EmitDefaultValue = false)]
        public TransferType TransferType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferEvent()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferEvent" /> class.
        /// </summary>
        /// <param name="eventId">Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers. (required).</param>
        /// <param name="timestamp">The datetime when this event occurred. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;. (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="accountId">The account ID associated with the transfer. (required).</param>
        /// <param name="transferId">Plaid’s unique identifier for a transfer. (required).</param>
        /// <param name="originationAccountId">The ID of the origination account that this balance belongs to. (required).</param>
        /// <param name="transferType">transferType (required).</param>
        /// <param name="transferAmount">The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;). (required).</param>
        /// <param name="failureReason">failureReason (required).</param>
        /// <param name="sweepId">Plaid’s unique identifier for a sweep. (required).</param>
        /// <param name="sweepAmount">A signed amount of how much was &#x60;swept&#x60; or &#x60;reverse_swept&#x60; (decimal string with two digits of precision e.g. \&quot;-5.50\&quot;). (required).</param>
        public TransferEvent(int eventId = default(int), DateTime timestamp = default(DateTime), TransferEventType eventType = default(TransferEventType), string accountId = default(string), string transferId = default(string), string originationAccountId = default(string), TransferType transferType = default(TransferType), string transferAmount = default(string), TransferFailure failureReason = default(TransferFailure), string sweepId = default(string), string sweepAmount = default(string)) : base()
        {
            this.EventId = eventId;
            this.Timestamp = timestamp;
            this.EventType = eventType;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for TransferEvent and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "transferId" is required (not null)
            if (transferId == null)
            {
                throw new ArgumentNullException("transferId is a required property for TransferEvent and cannot be null");
            }
            this.TransferId = transferId;
            // to ensure "originationAccountId" is required (not null)
            if (originationAccountId == null)
            {
                throw new ArgumentNullException("originationAccountId is a required property for TransferEvent and cannot be null");
            }
            this.OriginationAccountId = originationAccountId;
            this.TransferType = transferType;
            // to ensure "transferAmount" is required (not null)
            if (transferAmount == null)
            {
                throw new ArgumentNullException("transferAmount is a required property for TransferEvent and cannot be null");
            }
            this.TransferAmount = transferAmount;
            // to ensure "failureReason" is required (not null)
            if (failureReason == null)
            {
                throw new ArgumentNullException("failureReason is a required property for TransferEvent and cannot be null");
            }
            this.FailureReason = failureReason;
            // to ensure "sweepId" is required (not null)
            if (sweepId == null)
            {
                throw new ArgumentNullException("sweepId is a required property for TransferEvent and cannot be null");
            }
            this.SweepId = sweepId;
            // to ensure "sweepAmount" is required (not null)
            if (sweepAmount == null)
            {
                throw new ArgumentNullException("sweepAmount is a required property for TransferEvent and cannot be null");
            }
            this.SweepAmount = sweepAmount;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers.
        /// </summary>
        /// <value>Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers.</value>
        [DataMember(Name = "event_id", IsRequired = true, EmitDefaultValue = false)]
        public int EventId { get; set; }

        /// <summary>
        /// The datetime when this event occurred. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;.
        /// </summary>
        /// <value>The datetime when this event occurred. This will be of the form &#x60;2006-01-02T15:04:05Z&#x60;.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The account ID associated with the transfer.
        /// </summary>
        /// <value>The account ID associated with the transfer.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Plaid’s unique identifier for a transfer.
        /// </summary>
        /// <value>Plaid’s unique identifier for a transfer.</value>
        [DataMember(Name = "transfer_id", IsRequired = true, EmitDefaultValue = false)]
        public string TransferId { get; set; }

        /// <summary>
        /// The ID of the origination account that this balance belongs to.
        /// </summary>
        /// <value>The ID of the origination account that this balance belongs to.</value>
        [DataMember(Name = "origination_account_id", IsRequired = true, EmitDefaultValue = true)]
        public string OriginationAccountId { get; set; }

        /// <summary>
        /// The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).
        /// </summary>
        /// <value>The amount of the transfer (decimal string with two digits of precision e.g. \&quot;10.00\&quot;).</value>
        [DataMember(Name = "transfer_amount", IsRequired = true, EmitDefaultValue = false)]
        public string TransferAmount { get; set; }

        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failure_reason", IsRequired = true, EmitDefaultValue = true)]
        public TransferFailure FailureReason { get; set; }

        /// <summary>
        /// Plaid’s unique identifier for a sweep.
        /// </summary>
        /// <value>Plaid’s unique identifier for a sweep.</value>
        [DataMember(Name = "sweep_id", IsRequired = true, EmitDefaultValue = true)]
        public string SweepId { get; set; }

        /// <summary>
        /// A signed amount of how much was &#x60;swept&#x60; or &#x60;reverse_swept&#x60; (decimal string with two digits of precision e.g. \&quot;-5.50\&quot;).
        /// </summary>
        /// <value>A signed amount of how much was &#x60;swept&#x60; or &#x60;reverse_swept&#x60; (decimal string with two digits of precision e.g. \&quot;-5.50\&quot;).</value>
        [DataMember(Name = "sweep_amount", IsRequired = true, EmitDefaultValue = true)]
        public string SweepAmount { get; set; }

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
            sb.Append("class TransferEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  TransferId: ").Append(TransferId).Append("\n");
            sb.Append("  OriginationAccountId: ").Append(OriginationAccountId).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
            sb.Append("  TransferAmount: ").Append(TransferAmount).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  SweepId: ").Append(SweepId).Append("\n");
            sb.Append("  SweepAmount: ").Append(SweepAmount).Append("\n");
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
            return this.Equals(input as TransferEvent);
        }

        /// <summary>
        /// Returns true if TransferEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.EventId == input.EventId ||
                    this.EventId.Equals(input.EventId)
                ) && base.Equals(input) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && base.Equals(input) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && base.Equals(input) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && base.Equals(input) && 
                (
                    this.TransferId == input.TransferId ||
                    (this.TransferId != null &&
                    this.TransferId.Equals(input.TransferId))
                ) && base.Equals(input) && 
                (
                    this.OriginationAccountId == input.OriginationAccountId ||
                    (this.OriginationAccountId != null &&
                    this.OriginationAccountId.Equals(input.OriginationAccountId))
                ) && base.Equals(input) && 
                (
                    this.TransferType == input.TransferType ||
                    this.TransferType.Equals(input.TransferType)
                ) && base.Equals(input) && 
                (
                    this.TransferAmount == input.TransferAmount ||
                    (this.TransferAmount != null &&
                    this.TransferAmount.Equals(input.TransferAmount))
                ) && base.Equals(input) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && base.Equals(input) && 
                (
                    this.SweepId == input.SweepId ||
                    (this.SweepId != null &&
                    this.SweepId.Equals(input.SweepId))
                ) && base.Equals(input) && 
                (
                    this.SweepAmount == input.SweepAmount ||
                    (this.SweepAmount != null &&
                    this.SweepAmount.Equals(input.SweepAmount))
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
                hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.TransferId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferId.GetHashCode();
                }
                if (this.OriginationAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginationAccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransferType.GetHashCode();
                if (this.TransferAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TransferAmount.GetHashCode();
                }
                if (this.FailureReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailureReason.GetHashCode();
                }
                if (this.SweepId != null)
                {
                    hashCode = (hashCode * 59) + this.SweepId.GetHashCode();
                }
                if (this.SweepAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SweepAmount.GetHashCode();
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
            // EventId (int) minimum
            if (this.EventId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventId, must be a value greater than or equal to 0.", new [] { "EventId" });
            }

            yield break;
        }
    }

}
