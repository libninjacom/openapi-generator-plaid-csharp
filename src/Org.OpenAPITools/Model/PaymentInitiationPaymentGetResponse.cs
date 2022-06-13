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
    /// PaymentInitiationPaymentGetResponse defines the response schema for &#x60;/payment_initation/payment/get&#x60;
    /// </summary>
    [DataContract(Name = "PaymentInitiationPaymentGetResponse")]
    public partial class PaymentInitiationPaymentGetResponse : Dictionary<String, Object>, IEquatable<PaymentInitiationPaymentGetResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public PaymentInitiationPaymentStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name = "scheme", EmitDefaultValue = true)]
        public PaymentScheme? Scheme { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedScheme
        /// </summary>
        [DataMember(Name = "adjusted_scheme", EmitDefaultValue = true)]
        public PaymentScheme? AdjustedScheme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationPaymentGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInitiationPaymentGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationPaymentGetResponse" /> class.
        /// </summary>
        /// <param name="paymentId">The ID of the payment. Like all Plaid identifiers, the &#x60;payment_id&#x60; is case sensitive. (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="recipientId">The ID of the recipient (required).</param>
        /// <param name="reference">A reference for the payment. (required).</param>
        /// <param name="adjustedReference">The value of the reference sent to the bank after adjustment to pass bank validation rules..</param>
        /// <param name="lastStatusUpdate">The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format (required).</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="refundDetails">refundDetails.</param>
        /// <param name="bacs">bacs (required).</param>
        /// <param name="iban">The International Bank Account Number (IBAN) for the sender, if specified in the &#x60;/payment_initiation/payment/create&#x60; call. (required).</param>
        /// <param name="initiatedRefunds">Initiated refunds associated with the payment..</param>
        /// <param name="walletId">The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests..</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="adjustedScheme">adjustedScheme.</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public PaymentInitiationPaymentGetResponse(string paymentId = default(string), PaymentAmount amount = default(PaymentAmount), PaymentInitiationPaymentStatus status = default(PaymentInitiationPaymentStatus), string recipientId = default(string), string reference = default(string), string adjustedReference = default(string), DateTime lastStatusUpdate = default(DateTime), ExternalPaymentScheduleGet schedule = default(ExternalPaymentScheduleGet), ExternalPaymentRefundDetails refundDetails = default(ExternalPaymentRefundDetails), SenderBACSNullable bacs = default(SenderBACSNullable), string iban = default(string), List<PaymentInitiationRefund> initiatedRefunds = default(List<PaymentInitiationRefund>), string walletId = default(string), PaymentScheme? scheme = default(PaymentScheme?), PaymentScheme? adjustedScheme = default(PaymentScheme?), string requestId = default(string)) : base()
        {
            // to ensure "paymentId" is required (not null)
            if (paymentId == null)
            {
                throw new ArgumentNullException("paymentId is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.PaymentId = paymentId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.Amount = amount;
            this.Status = status;
            // to ensure "recipientId" is required (not null)
            if (recipientId == null)
            {
                throw new ArgumentNullException("recipientId is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.RecipientId = recipientId;
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new ArgumentNullException("reference is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.Reference = reference;
            this.LastStatusUpdate = lastStatusUpdate;
            // to ensure "bacs" is required (not null)
            if (bacs == null)
            {
                throw new ArgumentNullException("bacs is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.Bacs = bacs;
            // to ensure "iban" is required (not null)
            if (iban == null)
            {
                throw new ArgumentNullException("iban is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.Iban = iban;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for PaymentInitiationPaymentGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdjustedReference = adjustedReference;
            this.Schedule = schedule;
            this.RefundDetails = refundDetails;
            this.InitiatedRefunds = initiatedRefunds;
            this.WalletId = walletId;
            this.Scheme = scheme;
            this.AdjustedScheme = adjustedScheme;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the payment. Like all Plaid identifiers, the &#x60;payment_id&#x60; is case sensitive.
        /// </summary>
        /// <value>The ID of the payment. Like all Plaid identifiers, the &#x60;payment_id&#x60; is case sensitive.</value>
        [DataMember(Name = "payment_id", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public PaymentAmount Amount { get; set; }

        /// <summary>
        /// The ID of the recipient
        /// </summary>
        /// <value>The ID of the recipient</value>
        [DataMember(Name = "recipient_id", IsRequired = true, EmitDefaultValue = false)]
        public string RecipientId { get; set; }

        /// <summary>
        /// A reference for the payment.
        /// </summary>
        /// <value>A reference for the payment.</value>
        [DataMember(Name = "reference", IsRequired = true, EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The value of the reference sent to the bank after adjustment to pass bank validation rules.
        /// </summary>
        /// <value>The value of the reference sent to the bank after adjustment to pass bank validation rules.</value>
        [DataMember(Name = "adjusted_reference", EmitDefaultValue = true)]
        public string AdjustedReference { get; set; }

        /// <summary>
        /// The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format
        /// </summary>
        /// <value>The date and time of the last time the &#x60;status&#x60; was updated, in IS0 8601 format</value>
        [DataMember(Name = "last_status_update", IsRequired = true, EmitDefaultValue = false)]
        public DateTime LastStatusUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = true)]
        public ExternalPaymentScheduleGet Schedule { get; set; }

        /// <summary>
        /// Gets or Sets RefundDetails
        /// </summary>
        [DataMember(Name = "refund_details", EmitDefaultValue = true)]
        public ExternalPaymentRefundDetails RefundDetails { get; set; }

        /// <summary>
        /// Gets or Sets Bacs
        /// </summary>
        [DataMember(Name = "bacs", IsRequired = true, EmitDefaultValue = true)]
        public SenderBACSNullable Bacs { get; set; }

        /// <summary>
        /// The International Bank Account Number (IBAN) for the sender, if specified in the &#x60;/payment_initiation/payment/create&#x60; call.
        /// </summary>
        /// <value>The International Bank Account Number (IBAN) for the sender, if specified in the &#x60;/payment_initiation/payment/create&#x60; call.</value>
        [DataMember(Name = "iban", IsRequired = true, EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// Initiated refunds associated with the payment.
        /// </summary>
        /// <value>Initiated refunds associated with the payment.</value>
        [DataMember(Name = "initiated_refunds", EmitDefaultValue = false)]
        public List<PaymentInitiationRefund> InitiatedRefunds { get; set; }

        /// <summary>
        /// The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.
        /// </summary>
        /// <value>The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</value>
        [DataMember(Name = "wallet_id", EmitDefaultValue = true)]
        public string WalletId { get; set; }

        /// <summary>
        /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
        /// </summary>
        /// <value>A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.</value>
        [DataMember(Name = "request_id", IsRequired = true, EmitDefaultValue = false)]
        public string RequestId { get; set; }

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
            sb.Append("class PaymentInitiationPaymentGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  AdjustedReference: ").Append(AdjustedReference).Append("\n");
            sb.Append("  LastStatusUpdate: ").Append(LastStatusUpdate).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  RefundDetails: ").Append(RefundDetails).Append("\n");
            sb.Append("  Bacs: ").Append(Bacs).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  InitiatedRefunds: ").Append(InitiatedRefunds).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  AdjustedScheme: ").Append(AdjustedScheme).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as PaymentInitiationPaymentGetResponse);
        }

        /// <summary>
        /// Returns true if PaymentInitiationPaymentGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInitiationPaymentGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInitiationPaymentGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.RecipientId == input.RecipientId ||
                    (this.RecipientId != null &&
                    this.RecipientId.Equals(input.RecipientId))
                ) && base.Equals(input) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && base.Equals(input) && 
                (
                    this.AdjustedReference == input.AdjustedReference ||
                    (this.AdjustedReference != null &&
                    this.AdjustedReference.Equals(input.AdjustedReference))
                ) && base.Equals(input) && 
                (
                    this.LastStatusUpdate == input.LastStatusUpdate ||
                    (this.LastStatusUpdate != null &&
                    this.LastStatusUpdate.Equals(input.LastStatusUpdate))
                ) && base.Equals(input) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && base.Equals(input) && 
                (
                    this.RefundDetails == input.RefundDetails ||
                    (this.RefundDetails != null &&
                    this.RefundDetails.Equals(input.RefundDetails))
                ) && base.Equals(input) && 
                (
                    this.Bacs == input.Bacs ||
                    (this.Bacs != null &&
                    this.Bacs.Equals(input.Bacs))
                ) && base.Equals(input) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && base.Equals(input) && 
                (
                    this.InitiatedRefunds == input.InitiatedRefunds ||
                    this.InitiatedRefunds != null &&
                    input.InitiatedRefunds != null &&
                    this.InitiatedRefunds.SequenceEqual(input.InitiatedRefunds)
                ) && base.Equals(input) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && base.Equals(input) && 
                (
                    this.Scheme == input.Scheme ||
                    this.Scheme.Equals(input.Scheme)
                ) && base.Equals(input) && 
                (
                    this.AdjustedScheme == input.AdjustedScheme ||
                    this.AdjustedScheme.Equals(input.AdjustedScheme)
                ) && base.Equals(input) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.PaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.RecipientId != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.AdjustedReference != null)
                {
                    hashCode = (hashCode * 59) + this.AdjustedReference.GetHashCode();
                }
                if (this.LastStatusUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastStatusUpdate.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.RefundDetails != null)
                {
                    hashCode = (hashCode * 59) + this.RefundDetails.GetHashCode();
                }
                if (this.Bacs != null)
                {
                    hashCode = (hashCode * 59) + this.Bacs.GetHashCode();
                }
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.InitiatedRefunds != null)
                {
                    hashCode = (hashCode * 59) + this.InitiatedRefunds.GetHashCode();
                }
                if (this.WalletId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
                hashCode = (hashCode * 59) + this.AdjustedScheme.GetHashCode();
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
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