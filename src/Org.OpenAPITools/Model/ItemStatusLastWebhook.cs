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
    /// Information about the last webhook fired for the Item.
    /// </summary>
    [DataContract(Name = "ItemStatusLastWebhook")]
    public partial class ItemStatusLastWebhook : Dictionary<String, Object>, IEquatable<ItemStatusLastWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStatusLastWebhook" /> class.
        /// </summary>
        /// <param name="sentAt">[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of when the webhook was fired. .</param>
        /// <param name="codeSent">The last webhook code sent..</param>
        public ItemStatusLastWebhook(DateTime? sentAt = default(DateTime?), string codeSent = default(string)) : base()
        {
            this.SentAt = sentAt;
            this.CodeSent = codeSent;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// [ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of when the webhook was fired. 
        /// </summary>
        /// <value>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of when the webhook was fired. </value>
        [DataMember(Name = "sent_at", EmitDefaultValue = true)]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// The last webhook code sent.
        /// </summary>
        /// <value>The last webhook code sent.</value>
        [DataMember(Name = "code_sent", EmitDefaultValue = true)]
        public string CodeSent { get; set; }

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
            sb.Append("class ItemStatusLastWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  CodeSent: ").Append(CodeSent).Append("\n");
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
            return this.Equals(input as ItemStatusLastWebhook);
        }

        /// <summary>
        /// Returns true if ItemStatusLastWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemStatusLastWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemStatusLastWebhook input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.SentAt == input.SentAt ||
                    (this.SentAt != null &&
                    this.SentAt.Equals(input.SentAt))
                ) && base.Equals(input) && 
                (
                    this.CodeSent == input.CodeSent ||
                    (this.CodeSent != null &&
                    this.CodeSent.Equals(input.CodeSent))
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
                if (this.SentAt != null)
                {
                    hashCode = (hashCode * 59) + this.SentAt.GetHashCode();
                }
                if (this.CodeSent != null)
                {
                    hashCode = (hashCode * 59) + this.CodeSent.GetHashCode();
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
