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
    /// The webhook of type &#x60;LIABILITIES&#x60; and code &#x60;DEFAULT_UPDATE&#x60; will be fired when new or updated liabilities have been detected on a liabilities item.
    /// </summary>
    [DataContract(Name = "LiabilitiesDefaultUpdateWebhook")]
    public partial class LiabilitiesDefaultUpdateWebhook : IEquatable<LiabilitiesDefaultUpdateWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiabilitiesDefaultUpdateWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LiabilitiesDefaultUpdateWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiabilitiesDefaultUpdateWebhook" /> class.
        /// </summary>
        /// <param name="webhookType">&#x60;LIABILITIES&#x60; (required).</param>
        /// <param name="webhookCode">&#x60;DEFAULT_UPDATE&#x60; (required).</param>
        /// <param name="itemId">The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error (required).</param>
        /// <param name="error">error (required).</param>
        /// <param name="accountIdsWithNewLiabilities">An array of &#x60;account_id&#x60;&#39;s for accounts that contain new liabilities.&#39; (required).</param>
        /// <param name="accountIdsWithUpdatedLiabilities">An object with keys of &#x60;account_id&#x60;&#39;s that are mapped to their respective liabilities fields that changed.  Example: &#x60;{ \&quot;XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58\&quot;: [\&quot;past_amount_due\&quot;] }&#x60;  (required).</param>
        public LiabilitiesDefaultUpdateWebhook(string webhookType = default(string), string webhookCode = default(string), string itemId = default(string), PlaidError error = default(PlaidError), List<string> accountIdsWithNewLiabilities = default(List<string>), Dictionary<string, List<string>> accountIdsWithUpdatedLiabilities = default(Dictionary<string, List<string>>))
        {
            // to ensure "webhookType" is required (not null)
            if (webhookType == null)
            {
                throw new ArgumentNullException("webhookType is a required property for LiabilitiesDefaultUpdateWebhook and cannot be null");
            }
            this.WebhookType = webhookType;
            // to ensure "webhookCode" is required (not null)
            if (webhookCode == null)
            {
                throw new ArgumentNullException("webhookCode is a required property for LiabilitiesDefaultUpdateWebhook and cannot be null");
            }
            this.WebhookCode = webhookCode;
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new ArgumentNullException("itemId is a required property for LiabilitiesDefaultUpdateWebhook and cannot be null");
            }
            this.ItemId = itemId;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for LiabilitiesDefaultUpdateWebhook and cannot be null");
            }
            this.Error = error;
            // to ensure "accountIdsWithNewLiabilities" is required (not null)
            if (accountIdsWithNewLiabilities == null)
            {
                throw new ArgumentNullException("accountIdsWithNewLiabilities is a required property for LiabilitiesDefaultUpdateWebhook and cannot be null");
            }
            this.AccountIdsWithNewLiabilities = accountIdsWithNewLiabilities;
            // to ensure "accountIdsWithUpdatedLiabilities" is required (not null)
            if (accountIdsWithUpdatedLiabilities == null)
            {
                throw new ArgumentNullException("accountIdsWithUpdatedLiabilities is a required property for LiabilitiesDefaultUpdateWebhook and cannot be null");
            }
            this.AccountIdsWithUpdatedLiabilities = accountIdsWithUpdatedLiabilities;
        }

        /// <summary>
        /// &#x60;LIABILITIES&#x60;
        /// </summary>
        /// <value>&#x60;LIABILITIES&#x60;</value>
        [DataMember(Name = "webhook_type", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookType { get; set; }

        /// <summary>
        /// &#x60;DEFAULT_UPDATE&#x60;
        /// </summary>
        /// <value>&#x60;DEFAULT_UPDATE&#x60;</value>
        [DataMember(Name = "webhook_code", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookCode { get; set; }

        /// <summary>
        /// The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error
        /// </summary>
        /// <value>The &#x60;item_id&#x60; of the Item associated with this webhook, warning, or error</value>
        [DataMember(Name = "item_id", IsRequired = true, EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = false)]
        public PlaidError Error { get; set; }

        /// <summary>
        /// An array of &#x60;account_id&#x60;&#39;s for accounts that contain new liabilities.&#39;
        /// </summary>
        /// <value>An array of &#x60;account_id&#x60;&#39;s for accounts that contain new liabilities.&#39;</value>
        [DataMember(Name = "account_ids_with_new_liabilities", IsRequired = true, EmitDefaultValue = false)]
        public List<string> AccountIdsWithNewLiabilities { get; set; }

        /// <summary>
        /// An object with keys of &#x60;account_id&#x60;&#39;s that are mapped to their respective liabilities fields that changed.  Example: &#x60;{ \&quot;XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58\&quot;: [\&quot;past_amount_due\&quot;] }&#x60; 
        /// </summary>
        /// <value>An object with keys of &#x60;account_id&#x60;&#39;s that are mapped to their respective liabilities fields that changed.  Example: &#x60;{ \&quot;XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58\&quot;: [\&quot;past_amount_due\&quot;] }&#x60; </value>
        [DataMember(Name = "account_ids_with_updated_liabilities", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, List<string>> AccountIdsWithUpdatedLiabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiabilitiesDefaultUpdateWebhook {\n");
            sb.Append("  WebhookType: ").Append(WebhookType).Append("\n");
            sb.Append("  WebhookCode: ").Append(WebhookCode).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  AccountIdsWithNewLiabilities: ").Append(AccountIdsWithNewLiabilities).Append("\n");
            sb.Append("  AccountIdsWithUpdatedLiabilities: ").Append(AccountIdsWithUpdatedLiabilities).Append("\n");
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
            return this.Equals(input as LiabilitiesDefaultUpdateWebhook);
        }

        /// <summary>
        /// Returns true if LiabilitiesDefaultUpdateWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of LiabilitiesDefaultUpdateWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiabilitiesDefaultUpdateWebhook input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WebhookType == input.WebhookType ||
                    (this.WebhookType != null &&
                    this.WebhookType.Equals(input.WebhookType))
                ) && 
                (
                    this.WebhookCode == input.WebhookCode ||
                    (this.WebhookCode != null &&
                    this.WebhookCode.Equals(input.WebhookCode))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.AccountIdsWithNewLiabilities == input.AccountIdsWithNewLiabilities ||
                    this.AccountIdsWithNewLiabilities != null &&
                    input.AccountIdsWithNewLiabilities != null &&
                    this.AccountIdsWithNewLiabilities.SequenceEqual(input.AccountIdsWithNewLiabilities)
                ) && 
                (
                    this.AccountIdsWithUpdatedLiabilities == input.AccountIdsWithUpdatedLiabilities ||
                    this.AccountIdsWithUpdatedLiabilities != null &&
                    input.AccountIdsWithUpdatedLiabilities != null &&
                    this.AccountIdsWithUpdatedLiabilities.SequenceEqual(input.AccountIdsWithUpdatedLiabilities)
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.AccountIdsWithNewLiabilities != null)
                {
                    hashCode = (hashCode * 59) + this.AccountIdsWithNewLiabilities.GetHashCode();
                }
                if (this.AccountIdsWithUpdatedLiabilities != null)
                {
                    hashCode = (hashCode * 59) + this.AccountIdsWithUpdatedLiabilities.GetHashCode();
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
