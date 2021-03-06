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
    /// Fired when new transaction data is available for an Item. Plaid will typically check for new transaction data several times a day. 
    /// </summary>
    [DataContract(Name = "DefaultUpdateWebhook")]
    public partial class DefaultUpdateWebhook : Dictionary<String, Object>, IEquatable<DefaultUpdateWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultUpdateWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultUpdateWebhook()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultUpdateWebhook" /> class.
        /// </summary>
        /// <param name="webhookType">&#x60;TRANSACTIONS&#x60; (required).</param>
        /// <param name="webhookCode">&#x60;DEFAULT_UPDATE&#x60; (required).</param>
        /// <param name="error">error.</param>
        /// <param name="newTransactions">The number of new transactions detected since the last time this webhook was fired. (required).</param>
        /// <param name="itemId">The &#x60;item_id&#x60; of the Item the webhook relates to. (required).</param>
        public DefaultUpdateWebhook(string webhookType = default(string), string webhookCode = default(string), PlaidError error = default(PlaidError), decimal newTransactions = default(decimal), string itemId = default(string)) : base()
        {
            // to ensure "webhookType" is required (not null)
            if (webhookType == null)
            {
                throw new ArgumentNullException("webhookType is a required property for DefaultUpdateWebhook and cannot be null");
            }
            this.WebhookType = webhookType;
            // to ensure "webhookCode" is required (not null)
            if (webhookCode == null)
            {
                throw new ArgumentNullException("webhookCode is a required property for DefaultUpdateWebhook and cannot be null");
            }
            this.WebhookCode = webhookCode;
            this.NewTransactions = newTransactions;
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new ArgumentNullException("itemId is a required property for DefaultUpdateWebhook and cannot be null");
            }
            this.ItemId = itemId;
            this.Error = error;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// &#x60;TRANSACTIONS&#x60;
        /// </summary>
        /// <value>&#x60;TRANSACTIONS&#x60;</value>
        [DataMember(Name = "webhook_type", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookType { get; set; }

        /// <summary>
        /// &#x60;DEFAULT_UPDATE&#x60;
        /// </summary>
        /// <value>&#x60;DEFAULT_UPDATE&#x60;</value>
        [DataMember(Name = "webhook_code", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookCode { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public PlaidError Error { get; set; }

        /// <summary>
        /// The number of new transactions detected since the last time this webhook was fired.
        /// </summary>
        /// <value>The number of new transactions detected since the last time this webhook was fired.</value>
        [DataMember(Name = "new_transactions", IsRequired = true, EmitDefaultValue = false)]
        public decimal NewTransactions { get; set; }

        /// <summary>
        /// The &#x60;item_id&#x60; of the Item the webhook relates to.
        /// </summary>
        /// <value>The &#x60;item_id&#x60; of the Item the webhook relates to.</value>
        [DataMember(Name = "item_id", IsRequired = true, EmitDefaultValue = false)]
        public string ItemId { get; set; }

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
            sb.Append("class DefaultUpdateWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WebhookType: ").Append(WebhookType).Append("\n");
            sb.Append("  WebhookCode: ").Append(WebhookCode).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  NewTransactions: ").Append(NewTransactions).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as DefaultUpdateWebhook);
        }

        /// <summary>
        /// Returns true if DefaultUpdateWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of DefaultUpdateWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultUpdateWebhook input)
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
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && base.Equals(input) && 
                (
                    this.NewTransactions == input.NewTransactions ||
                    this.NewTransactions.Equals(input.NewTransactions)
                ) && base.Equals(input) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NewTransactions.GetHashCode();
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
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
