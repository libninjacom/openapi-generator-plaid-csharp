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
    /// Fired when Asset Report generation has failed. The resulting &#x60;error&#x60; will have an &#x60;error_type&#x60; of &#x60;ASSET_REPORT_ERROR&#x60;.
    /// </summary>
    [DataContract(Name = "AssetsErrorWebhook")]
    public partial class AssetsErrorWebhook : Dictionary<String, Object>, IEquatable<AssetsErrorWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsErrorWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetsErrorWebhook()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsErrorWebhook" /> class.
        /// </summary>
        /// <param name="webhookType">&#x60;ASSETS&#x60; (required).</param>
        /// <param name="webhookCode">&#x60;ERROR&#x60; (required).</param>
        /// <param name="error">error (required).</param>
        /// <param name="assetReportId">The ID associated with the Asset Report. (required).</param>
        public AssetsErrorWebhook(string webhookType = default(string), string webhookCode = default(string), PlaidError error = default(PlaidError), string assetReportId = default(string)) : base()
        {
            // to ensure "webhookType" is required (not null)
            if (webhookType == null)
            {
                throw new ArgumentNullException("webhookType is a required property for AssetsErrorWebhook and cannot be null");
            }
            this.WebhookType = webhookType;
            // to ensure "webhookCode" is required (not null)
            if (webhookCode == null)
            {
                throw new ArgumentNullException("webhookCode is a required property for AssetsErrorWebhook and cannot be null");
            }
            this.WebhookCode = webhookCode;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for AssetsErrorWebhook and cannot be null");
            }
            this.Error = error;
            // to ensure "assetReportId" is required (not null)
            if (assetReportId == null)
            {
                throw new ArgumentNullException("assetReportId is a required property for AssetsErrorWebhook and cannot be null");
            }
            this.AssetReportId = assetReportId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// &#x60;ASSETS&#x60;
        /// </summary>
        /// <value>&#x60;ASSETS&#x60;</value>
        [DataMember(Name = "webhook_type", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookType { get; set; }

        /// <summary>
        /// &#x60;ERROR&#x60;
        /// </summary>
        /// <value>&#x60;ERROR&#x60;</value>
        [DataMember(Name = "webhook_code", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookCode { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = false)]
        public PlaidError Error { get; set; }

        /// <summary>
        /// The ID associated with the Asset Report.
        /// </summary>
        /// <value>The ID associated with the Asset Report.</value>
        [DataMember(Name = "asset_report_id", IsRequired = true, EmitDefaultValue = false)]
        public string AssetReportId { get; set; }

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
            sb.Append("class AssetsErrorWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WebhookType: ").Append(WebhookType).Append("\n");
            sb.Append("  WebhookCode: ").Append(WebhookCode).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  AssetReportId: ").Append(AssetReportId).Append("\n");
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
            return this.Equals(input as AssetsErrorWebhook);
        }

        /// <summary>
        /// Returns true if AssetsErrorWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetsErrorWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetsErrorWebhook input)
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
                    this.AssetReportId == input.AssetReportId ||
                    (this.AssetReportId != null &&
                    this.AssetReportId.Equals(input.AssetReportId))
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
                if (this.AssetReportId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetReportId.GetHashCode();
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
