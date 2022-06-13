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
    /// Additional payment options
    /// </summary>
    [DataContract(Name = "ExternalPaymentOptions")]
    public partial class ExternalPaymentOptions : Dictionary<String, Object>, IEquatable<ExternalPaymentOptions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name = "scheme", EmitDefaultValue = true)]
        public PaymentScheme? Scheme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPaymentOptions" /> class.
        /// </summary>
        /// <param name="requestRefundDetails">When &#x60;true&#x60;, Plaid will attempt to request refund details from the payee&#39;s financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the &#x60;/payment_initiation/payment/get&#x60; response..</param>
        /// <param name="iban">The International Bank Account Number (IBAN) for the payer&#39;s account. If provided, the end user will be able to send payments only from the specified bank account..</param>
        /// <param name="bacs">bacs.</param>
        /// <param name="walletId">The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests..</param>
        /// <param name="scheme">scheme.</param>
        public ExternalPaymentOptions(bool? requestRefundDetails = default(bool?), string iban = default(string), PaymentInitiationOptionalRestrictionBacs bacs = default(PaymentInitiationOptionalRestrictionBacs), string walletId = default(string), PaymentScheme? scheme = default(PaymentScheme?)) : base()
        {
            this.RequestRefundDetails = requestRefundDetails;
            this.Iban = iban;
            this.Bacs = bacs;
            this.WalletId = walletId;
            this.Scheme = scheme;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// When &#x60;true&#x60;, Plaid will attempt to request refund details from the payee&#39;s financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the &#x60;/payment_initiation/payment/get&#x60; response.
        /// </summary>
        /// <value>When &#x60;true&#x60;, Plaid will attempt to request refund details from the payee&#39;s financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the &#x60;/payment_initiation/payment/get&#x60; response.</value>
        [DataMember(Name = "request_refund_details", EmitDefaultValue = true)]
        public bool? RequestRefundDetails { get; set; }

        /// <summary>
        /// The International Bank Account Number (IBAN) for the payer&#39;s account. If provided, the end user will be able to send payments only from the specified bank account.
        /// </summary>
        /// <value>The International Bank Account Number (IBAN) for the payer&#39;s account. If provided, the end user will be able to send payments only from the specified bank account.</value>
        [DataMember(Name = "iban", EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Bacs
        /// </summary>
        [DataMember(Name = "bacs", EmitDefaultValue = true)]
        public PaymentInitiationOptionalRestrictionBacs Bacs { get; set; }

        /// <summary>
        /// The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.
        /// </summary>
        /// <value>The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</value>
        [DataMember(Name = "wallet_id", EmitDefaultValue = true)]
        public string WalletId { get; set; }

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
            sb.Append("class ExternalPaymentOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RequestRefundDetails: ").Append(RequestRefundDetails).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Bacs: ").Append(Bacs).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
            return this.Equals(input as ExternalPaymentOptions);
        }

        /// <summary>
        /// Returns true if ExternalPaymentOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalPaymentOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalPaymentOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.RequestRefundDetails == input.RequestRefundDetails ||
                    (this.RequestRefundDetails != null &&
                    this.RequestRefundDetails.Equals(input.RequestRefundDetails))
                ) && base.Equals(input) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && base.Equals(input) && 
                (
                    this.Bacs == input.Bacs ||
                    (this.Bacs != null &&
                    this.Bacs.Equals(input.Bacs))
                ) && base.Equals(input) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && base.Equals(input) && 
                (
                    this.Scheme == input.Scheme ||
                    this.Scheme.Equals(input.Scheme)
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
                if (this.RequestRefundDetails != null)
                {
                    hashCode = (hashCode * 59) + this.RequestRefundDetails.GetHashCode();
                }
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.Bacs != null)
                {
                    hashCode = (hashCode * 59) + this.Bacs.GetHashCode();
                }
                if (this.WalletId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
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
            // Iban (string) maxLength
            if (this.Iban != null && this.Iban.Length > 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Iban, length must be less than 34.", new [] { "Iban" });
            }

            // Iban (string) minLength
            if (this.Iban != null && this.Iban.Length < 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Iban, length must be greater than 15.", new [] { "Iban" });
            }

            // WalletId (string) minLength
            if (this.WalletId != null && this.WalletId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WalletId, length must be greater than 1.", new [] { "WalletId" });
            }

            yield break;
        }
    }

}
