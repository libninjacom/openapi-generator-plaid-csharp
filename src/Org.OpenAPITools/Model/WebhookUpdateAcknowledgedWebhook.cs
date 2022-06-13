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
    /// Fired when an Item&#39;s webhook is updated. This will be sent to the newly specified webhook.
    /// </summary>
    [DataContract(Name = "WebhookUpdateAcknowledgedWebhook")]
    public partial class WebhookUpdateAcknowledgedWebhook : Dictionary<String, Object>, IEquatable<WebhookUpdateAcknowledgedWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateAcknowledgedWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookUpdateAcknowledgedWebhook()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateAcknowledgedWebhook" /> class.
        /// </summary>
        /// <param name="webhookType">&#x60;ITEM&#x60; (required).</param>
        /// <param name="webhookCode">&#x60;WEBHOOK_UPDATE_ACKNOWLEDGED&#x60; (required).</param>
        /// <param name="itemId">The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error (required).</param>
        /// <param name="newWebhookUrl">The new webhook URL (required).</param>
        /// <param name="error">error.</param>
        public WebhookUpdateAcknowledgedWebhook(string webhookType = default(string), string webhookCode = default(string), string itemId = default(string), string newWebhookUrl = default(string), PlaidError error = default(PlaidError)) : base()
        {
            // to ensure "webhookType" is required (not null)
            if (webhookType == null)
            {
                throw new ArgumentNullException("webhookType is a required property for WebhookUpdateAcknowledgedWebhook and cannot be null");
            }
            this.WebhookType = webhookType;
            // to ensure "webhookCode" is required (not null)
            if (webhookCode == null)
            {
                throw new ArgumentNullException("webhookCode is a required property for WebhookUpdateAcknowledgedWebhook and cannot be null");
            }
            this.WebhookCode = webhookCode;
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new ArgumentNullException("itemId is a required property for WebhookUpdateAcknowledgedWebhook and cannot be null");
            }
            this.ItemId = itemId;
            // to ensure "newWebhookUrl" is required (not null)
            if (newWebhookUrl == null)
            {
                throw new ArgumentNullException("newWebhookUrl is a required property for WebhookUpdateAcknowledgedWebhook and cannot be null");
            }
            this.NewWebhookUrl = newWebhookUrl;
            this.Error = error;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// &#x60;ITEM&#x60;
        /// </summary>
        /// <value>&#x60;ITEM&#x60;</value>
        [DataMember(Name = "webhook_type", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookType { get; set; }

        /// <summary>
        /// &#x60;WEBHOOK_UPDATE_ACKNOWLEDGED&#x60;
        /// </summary>
        /// <value>&#x60;WEBHOOK_UPDATE_ACKNOWLEDGED&#x60;</value>
        [DataMember(Name = "webhook_code", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookCode { get; set; }

        /// <summary>
        /// The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error
        /// </summary>
        /// <value>The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error</value>
        [DataMember(Name = "item_id", IsRequired = true, EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// The new webhook URL
        /// </summary>
        /// <value>The new webhook URL</value>
        [DataMember(Name = "new_webhook_url", IsRequired = true, EmitDefaultValue = false)]
        public string NewWebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public PlaidError Error { get; set; }

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
            sb.Append("class WebhookUpdateAcknowledgedWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WebhookType: ").Append(WebhookType).Append("\n");
            sb.Append("  WebhookCode: ").Append(WebhookCode).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  NewWebhookUrl: ").Append(NewWebhookUrl).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as WebhookUpdateAcknowledgedWebhook);
        }

        /// <summary>
        /// Returns true if WebhookUpdateAcknowledgedWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUpdateAcknowledgedWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUpdateAcknowledgedWebhook input)
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
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && base.Equals(input) && 
                (
                    this.NewWebhookUrl == input.NewWebhookUrl ||
                    (this.NewWebhookUrl != null &&
                    this.NewWebhookUrl.Equals(input.NewWebhookUrl))
                ) && base.Equals(input) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.NewWebhookUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NewWebhookUrl.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
