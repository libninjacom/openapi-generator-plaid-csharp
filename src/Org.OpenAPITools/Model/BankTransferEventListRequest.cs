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
    /// Defines the request schema for &#x60;/bank_transfer/event/list&#x60;
    /// </summary>
    [DataContract(Name = "BankTransferEventListRequest")]
    public partial class BankTransferEventListRequest : IEquatable<BankTransferEventListRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of bank transfer. This will be either &#x60;debit&#x60; or &#x60;credit&#x60;.  A &#x60;debit&#x60; indicates a transfer of money into your origination account; a &#x60;credit&#x60; indicates a transfer of money out of your origination account.
        /// </summary>
        /// <value>The type of bank transfer. This will be either &#x60;debit&#x60; or &#x60;credit&#x60;.  A &#x60;debit&#x60; indicates a transfer of money into your origination account; a &#x60;credit&#x60; indicates a transfer of money out of your origination account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BankTransferTypeEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 1,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 2,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 3

        }


        /// <summary>
        /// The type of bank transfer. This will be either &#x60;debit&#x60; or &#x60;credit&#x60;.  A &#x60;debit&#x60; indicates a transfer of money into your origination account; a &#x60;credit&#x60; indicates a transfer of money out of your origination account.
        /// </summary>
        /// <value>The type of bank transfer. This will be either &#x60;debit&#x60; or &#x60;credit&#x60;.  A &#x60;debit&#x60; indicates a transfer of money into your origination account; a &#x60;credit&#x60; indicates a transfer of money out of your origination account.</value>
        [DataMember(Name = "bank_transfer_type", EmitDefaultValue = true)]
        public BankTransferTypeEnum? BankTransferType { get; set; }
        /// <summary>
        /// Indicates the direction of the transfer: &#x60;outbound&#x60;: for API-initiated transfers &#x60;inbound&#x60;: for payments received by the FBO account.
        /// </summary>
        /// <value>Indicates the direction of the transfer: &#x60;outbound&#x60;: for API-initiated transfers &#x60;inbound&#x60;: for payments received by the FBO account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Inbound for value: inbound
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound = 1,

            /// <summary>
            /// Enum Outbound for value: outbound
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound = 2,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 3

        }


        /// <summary>
        /// Indicates the direction of the transfer: &#x60;outbound&#x60;: for API-initiated transfers &#x60;inbound&#x60;: for payments received by the FBO account.
        /// </summary>
        /// <value>Indicates the direction of the transfer: &#x60;outbound&#x60;: for API-initiated transfers &#x60;inbound&#x60;: for payments received by the FBO account.</value>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferEventListRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="startDate">The start datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;).</param>
        /// <param name="endDate">The end datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;).</param>
        /// <param name="bankTransferId">Plaid’s unique identifier for a bank transfer..</param>
        /// <param name="accountId">The account ID to get events for all transactions to/from an account..</param>
        /// <param name="bankTransferType">The type of bank transfer. This will be either &#x60;debit&#x60; or &#x60;credit&#x60;.  A &#x60;debit&#x60; indicates a transfer of money into your origination account; a &#x60;credit&#x60; indicates a transfer of money out of your origination account..</param>
        /// <param name="eventTypes">Filter events by event type..</param>
        /// <param name="count">The maximum number of bank transfer events to return. If the number of events matching the above parameters is greater than &#x60;count&#x60;, the most recent events will be returned. (default to 25).</param>
        /// <param name="offset">The offset into the list of bank transfer events. When &#x60;count&#x60;&#x3D;25 and &#x60;offset&#x60;&#x3D;0, the first 25 events will be returned. When &#x60;count&#x60;&#x3D;25 and &#x60;offset&#x60;&#x3D;25, the next 25 bank transfer events will be returned. (default to 0).</param>
        /// <param name="originationAccountId">The origination account ID to get events for transfers from a specific origination account..</param>
        /// <param name="direction">Indicates the direction of the transfer: &#x60;outbound&#x60;: for API-initiated transfers &#x60;inbound&#x60;: for payments received by the FBO account..</param>
        public BankTransferEventListRequest(string clientId = default(string), string secret = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string bankTransferId = default(string), string accountId = default(string), BankTransferTypeEnum? bankTransferType = default(BankTransferTypeEnum?), List<BankTransferEventType> eventTypes = default(List<BankTransferEventType>), int? count = 25, int? offset = 0, string originationAccountId = default(string), DirectionEnum? direction = default(DirectionEnum?))
        {
            this.ClientId = clientId;
            this.Secret = secret;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.BankTransferId = bankTransferId;
            this.AccountId = accountId;
            this.BankTransferType = bankTransferType;
            this.EventTypes = eventTypes;
            // use default value if no "count" provided
            this.Count = count ?? 25;
            // use default value if no "offset" provided
            this.Offset = offset ?? 0;
            this.OriginationAccountId = originationAccountId;
            this.Direction = direction;
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
        /// The start datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;)
        /// </summary>
        /// <value>The start datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;)</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;)
        /// </summary>
        /// <value>The end datetime of bank transfers to list. This should be in RFC 3339 format (i.e. &#x60;2019-12-06T22:35:49Z&#x60;)</value>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Plaid’s unique identifier for a bank transfer.
        /// </summary>
        /// <value>Plaid’s unique identifier for a bank transfer.</value>
        [DataMember(Name = "bank_transfer_id", EmitDefaultValue = true)]
        public string BankTransferId { get; set; }

        /// <summary>
        /// The account ID to get events for all transactions to/from an account.
        /// </summary>
        /// <value>The account ID to get events for all transactions to/from an account.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Filter events by event type.
        /// </summary>
        /// <value>Filter events by event type.</value>
        [DataMember(Name = "event_types", EmitDefaultValue = false)]
        public List<BankTransferEventType> EventTypes { get; set; }

        /// <summary>
        /// The maximum number of bank transfer events to return. If the number of events matching the above parameters is greater than &#x60;count&#x60;, the most recent events will be returned.
        /// </summary>
        /// <value>The maximum number of bank transfer events to return. If the number of events matching the above parameters is greater than &#x60;count&#x60;, the most recent events will be returned.</value>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public int? Count { get; set; }

        /// <summary>
        /// The offset into the list of bank transfer events. When &#x60;count&#x60;&#x3D;25 and &#x60;offset&#x60;&#x3D;0, the first 25 events will be returned. When &#x60;count&#x60;&#x3D;25 and &#x60;offset&#x60;&#x3D;25, the next 25 bank transfer events will be returned.
        /// </summary>
        /// <value>The offset into the list of bank transfer events. When &#x60;count&#x60;&#x3D;25 and &#x60;offset&#x60;&#x3D;0, the first 25 events will be returned. When &#x60;count&#x60;&#x3D;25 and &#x60;offset&#x60;&#x3D;25, the next 25 bank transfer events will be returned.</value>
        [DataMember(Name = "offset", EmitDefaultValue = true)]
        public int? Offset { get; set; }

        /// <summary>
        /// The origination account ID to get events for transfers from a specific origination account.
        /// </summary>
        /// <value>The origination account ID to get events for transfers from a specific origination account.</value>
        [DataMember(Name = "origination_account_id", EmitDefaultValue = true)]
        public string OriginationAccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankTransferEventListRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  BankTransferId: ").Append(BankTransferId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  BankTransferType: ").Append(BankTransferType).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  OriginationAccountId: ").Append(OriginationAccountId).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as BankTransferEventListRequest);
        }

        /// <summary>
        /// Returns true if BankTransferEventListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BankTransferEventListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankTransferEventListRequest input)
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.BankTransferId == input.BankTransferId ||
                    (this.BankTransferId != null &&
                    this.BankTransferId.Equals(input.BankTransferId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.BankTransferType == input.BankTransferType ||
                    this.BankTransferType.Equals(input.BankTransferType)
                ) && 
                (
                    this.EventTypes == input.EventTypes ||
                    this.EventTypes != null &&
                    input.EventTypes != null &&
                    this.EventTypes.SequenceEqual(input.EventTypes)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.OriginationAccountId == input.OriginationAccountId ||
                    (this.OriginationAccountId != null &&
                    this.OriginationAccountId.Equals(input.OriginationAccountId))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.BankTransferId != null)
                {
                    hashCode = (hashCode * 59) + this.BankTransferId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BankTransferType.GetHashCode();
                if (this.EventTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EventTypes.GetHashCode();
                }
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
                }
                if (this.Offset != null)
                {
                    hashCode = (hashCode * 59) + this.Offset.GetHashCode();
                }
                if (this.OriginationAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginationAccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
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
            // Count (int?) maximum
            if (this.Count > (int?)25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value less than or equal to 25.", new [] { "Count" });
            }

            // Count (int?) minimum
            if (this.Count < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to 1.", new [] { "Count" });
            }

            // Offset (int?) minimum
            if (this.Offset < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new [] { "Offset" });
            }

            yield break;
        }
    }

}
