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
    /// Fired when the status of an income verification instance has changed. It will typically take several minutes for this webhook to fire after the end user has uploaded their documents in the Document Income flow.
    /// </summary>
    [DataContract(Name = "IncomeVerificationStatusWebhook")]
    public partial class IncomeVerificationStatusWebhook : Dictionary<String, Object>, IEquatable<IncomeVerificationStatusWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeVerificationStatusWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncomeVerificationStatusWebhook()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeVerificationStatusWebhook" /> class.
        /// </summary>
        /// <param name="webhookType">&#x60;\&quot;INCOME\&quot;&#x60; (required).</param>
        /// <param name="webhookCode">&#x60;income_verification&#x60; (required).</param>
        /// <param name="incomeVerificationId">The &#x60;income_verification_id&#x60; of the verification instance whose status is being reported. (required).</param>
        /// <param name="itemId">The Item ID associated with the verification. (required).</param>
        /// <param name="verificationStatus">&#x60;VERIFICATION_STATUS_PROCESSING_COMPLETE&#x60;: The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the &#x60;/income/verification/paystubs/get&#x60; endpoint and check the document metadata to see which documents were successfully parsed.  &#x60;VERIFICATION_STATUS_PROCESSING_FAILED&#x60;: A failure occurred when attempting to process the verification documentation.  &#x60;VERIFICATION_STATUS_PENDING_APPROVAL&#x60;: The income verification has been sent to the user for review. (required).</param>
        public IncomeVerificationStatusWebhook(string webhookType = default(string), string webhookCode = default(string), string incomeVerificationId = default(string), string itemId = default(string), string verificationStatus = default(string)) : base()
        {
            // to ensure "webhookType" is required (not null)
            if (webhookType == null)
            {
                throw new ArgumentNullException("webhookType is a required property for IncomeVerificationStatusWebhook and cannot be null");
            }
            this.WebhookType = webhookType;
            // to ensure "webhookCode" is required (not null)
            if (webhookCode == null)
            {
                throw new ArgumentNullException("webhookCode is a required property for IncomeVerificationStatusWebhook and cannot be null");
            }
            this.WebhookCode = webhookCode;
            // to ensure "incomeVerificationId" is required (not null)
            if (incomeVerificationId == null)
            {
                throw new ArgumentNullException("incomeVerificationId is a required property for IncomeVerificationStatusWebhook and cannot be null");
            }
            this.IncomeVerificationId = incomeVerificationId;
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new ArgumentNullException("itemId is a required property for IncomeVerificationStatusWebhook and cannot be null");
            }
            this.ItemId = itemId;
            // to ensure "verificationStatus" is required (not null)
            if (verificationStatus == null)
            {
                throw new ArgumentNullException("verificationStatus is a required property for IncomeVerificationStatusWebhook and cannot be null");
            }
            this.VerificationStatus = verificationStatus;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// &#x60;\&quot;INCOME\&quot;&#x60;
        /// </summary>
        /// <value>&#x60;\&quot;INCOME\&quot;&#x60;</value>
        [DataMember(Name = "webhook_type", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookType { get; set; }

        /// <summary>
        /// &#x60;income_verification&#x60;
        /// </summary>
        /// <value>&#x60;income_verification&#x60;</value>
        [DataMember(Name = "webhook_code", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookCode { get; set; }

        /// <summary>
        /// The &#x60;income_verification_id&#x60; of the verification instance whose status is being reported.
        /// </summary>
        /// <value>The &#x60;income_verification_id&#x60; of the verification instance whose status is being reported.</value>
        [DataMember(Name = "income_verification_id", IsRequired = true, EmitDefaultValue = false)]
        public string IncomeVerificationId { get; set; }

        /// <summary>
        /// The Item ID associated with the verification.
        /// </summary>
        /// <value>The Item ID associated with the verification.</value>
        [DataMember(Name = "item_id", IsRequired = true, EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// &#x60;VERIFICATION_STATUS_PROCESSING_COMPLETE&#x60;: The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the &#x60;/income/verification/paystubs/get&#x60; endpoint and check the document metadata to see which documents were successfully parsed.  &#x60;VERIFICATION_STATUS_PROCESSING_FAILED&#x60;: A failure occurred when attempting to process the verification documentation.  &#x60;VERIFICATION_STATUS_PENDING_APPROVAL&#x60;: The income verification has been sent to the user for review.
        /// </summary>
        /// <value>&#x60;VERIFICATION_STATUS_PROCESSING_COMPLETE&#x60;: The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the &#x60;/income/verification/paystubs/get&#x60; endpoint and check the document metadata to see which documents were successfully parsed.  &#x60;VERIFICATION_STATUS_PROCESSING_FAILED&#x60;: A failure occurred when attempting to process the verification documentation.  &#x60;VERIFICATION_STATUS_PENDING_APPROVAL&#x60;: The income verification has been sent to the user for review.</value>
        [DataMember(Name = "verification_status", IsRequired = true, EmitDefaultValue = false)]
        public string VerificationStatus { get; set; }

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
            sb.Append("class IncomeVerificationStatusWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WebhookType: ").Append(WebhookType).Append("\n");
            sb.Append("  WebhookCode: ").Append(WebhookCode).Append("\n");
            sb.Append("  IncomeVerificationId: ").Append(IncomeVerificationId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(input as IncomeVerificationStatusWebhook);
        }

        /// <summary>
        /// Returns true if IncomeVerificationStatusWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeVerificationStatusWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeVerificationStatusWebhook input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.WebhookType == input.WebhookType ||
                    (this.WebhookType != null &&
                    this.WebhookType.Equals(input.WebhookType))
                ) && base.Equals(input) && 
                (
                    this.WebhookCode == input.WebhookCode ||
                    (this.WebhookCode != null &&
                    this.WebhookCode.Equals(input.WebhookCode))
                ) && base.Equals(input) && 
                (
                    this.IncomeVerificationId == input.IncomeVerificationId ||
                    (this.IncomeVerificationId != null &&
                    this.IncomeVerificationId.Equals(input.IncomeVerificationId))
                ) && base.Equals(input) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && base.Equals(input) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    (this.VerificationStatus != null &&
                    this.VerificationStatus.Equals(input.VerificationStatus))
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
                if (this.WebhookType != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookType.GetHashCode();
                }
                if (this.WebhookCode != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookCode.GetHashCode();
                }
                if (this.IncomeVerificationId != null)
                {
                    hashCode = (hashCode * 59) + this.IncomeVerificationId.GetHashCode();
                }
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.VerificationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
