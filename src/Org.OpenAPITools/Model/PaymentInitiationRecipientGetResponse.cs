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
    /// PaymentInitiationRecipientGetResponse defines the response schema for &#x60;/payment_initiation/recipient/get&#x60;
    /// </summary>
    [DataContract(Name = "PaymentInitiationRecipientGetResponse")]
    public partial class PaymentInitiationRecipientGetResponse : Dictionary<String, Object>, IEquatable<PaymentInitiationRecipientGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationRecipientGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInitiationRecipientGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationRecipientGetResponse" /> class.
        /// </summary>
        /// <param name="recipientId">The ID of the recipient. (required).</param>
        /// <param name="name">The name of the recipient. (required).</param>
        /// <param name="address">address.</param>
        /// <param name="iban">The International Bank Account Number (IBAN) for the recipient..</param>
        /// <param name="bacs">bacs.</param>
        /// <param name="emiRecipientId">The EMI (E-Money Institution) recipient that this recipient is associated with, if any. This EMI recipient is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests..</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public PaymentInitiationRecipientGetResponse(string recipientId = default(string), string name = default(string), PaymentInitiationAddress address = default(PaymentInitiationAddress), string iban = default(string), RecipientBACSNullable bacs = default(RecipientBACSNullable), string emiRecipientId = default(string), string requestId = default(string)) : base()
        {
            // to ensure "recipientId" is required (not null)
            if (recipientId == null)
            {
                throw new ArgumentNullException("recipientId is a required property for PaymentInitiationRecipientGetResponse and cannot be null");
            }
            this.RecipientId = recipientId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PaymentInitiationRecipientGetResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for PaymentInitiationRecipientGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.Address = address;
            this.Iban = iban;
            this.Bacs = bacs;
            this.EmiRecipientId = emiRecipientId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the recipient.
        /// </summary>
        /// <value>The ID of the recipient.</value>
        [DataMember(Name = "recipient_id", IsRequired = true, EmitDefaultValue = false)]
        public string RecipientId { get; set; }

        /// <summary>
        /// The name of the recipient.
        /// </summary>
        /// <value>The name of the recipient.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public PaymentInitiationAddress Address { get; set; }

        /// <summary>
        /// The International Bank Account Number (IBAN) for the recipient.
        /// </summary>
        /// <value>The International Bank Account Number (IBAN) for the recipient.</value>
        [DataMember(Name = "iban", EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Bacs
        /// </summary>
        [DataMember(Name = "bacs", EmitDefaultValue = true)]
        public RecipientBACSNullable Bacs { get; set; }

        /// <summary>
        /// The EMI (E-Money Institution) recipient that this recipient is associated with, if any. This EMI recipient is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.
        /// </summary>
        /// <value>The EMI (E-Money Institution) recipient that this recipient is associated with, if any. This EMI recipient is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</value>
        [DataMember(Name = "emi_recipient_id", EmitDefaultValue = true)]
        public string EmiRecipientId { get; set; }

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
            sb.Append("class PaymentInitiationRecipientGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Bacs: ").Append(Bacs).Append("\n");
            sb.Append("  EmiRecipientId: ").Append(EmiRecipientId).Append("\n");
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
            return this.Equals(input as PaymentInitiationRecipientGetResponse);
        }

        /// <summary>
        /// Returns true if PaymentInitiationRecipientGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInitiationRecipientGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInitiationRecipientGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.RecipientId == input.RecipientId ||
                    (this.RecipientId != null &&
                    this.RecipientId.Equals(input.RecipientId))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                    this.EmiRecipientId == input.EmiRecipientId ||
                    (this.EmiRecipientId != null &&
                    this.EmiRecipientId.Equals(input.EmiRecipientId))
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
                if (this.RecipientId != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.Bacs != null)
                {
                    hashCode = (hashCode * 59) + this.Bacs.GetHashCode();
                }
                if (this.EmiRecipientId != null)
                {
                    hashCode = (hashCode * 59) + this.EmiRecipientId.GetHashCode();
                }
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
