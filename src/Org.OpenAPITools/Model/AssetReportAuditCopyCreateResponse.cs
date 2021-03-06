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
    /// AssetReportAuditCopyCreateResponse defines the response schema for &#x60;/asset_report/audit_copy/get&#x60;
    /// </summary>
    [DataContract(Name = "AssetReportAuditCopyCreateResponse")]
    public partial class AssetReportAuditCopyCreateResponse : Dictionary<String, Object>, IEquatable<AssetReportAuditCopyCreateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReportAuditCopyCreateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetReportAuditCopyCreateResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReportAuditCopyCreateResponse" /> class.
        /// </summary>
        /// <param name="auditCopyToken">A token that can be shared with a third party auditor to allow them to obtain access to the Asset Report. This token should be stored securely. (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public AssetReportAuditCopyCreateResponse(string auditCopyToken = default(string), string requestId = default(string)) : base()
        {
            // to ensure "auditCopyToken" is required (not null)
            if (auditCopyToken == null)
            {
                throw new ArgumentNullException("auditCopyToken is a required property for AssetReportAuditCopyCreateResponse and cannot be null");
            }
            this.AuditCopyToken = auditCopyToken;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for AssetReportAuditCopyCreateResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A token that can be shared with a third party auditor to allow them to obtain access to the Asset Report. This token should be stored securely.
        /// </summary>
        /// <value>A token that can be shared with a third party auditor to allow them to obtain access to the Asset Report. This token should be stored securely.</value>
        [DataMember(Name = "audit_copy_token", IsRequired = true, EmitDefaultValue = false)]
        public string AuditCopyToken { get; set; }

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
            sb.Append("class AssetReportAuditCopyCreateResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AuditCopyToken: ").Append(AuditCopyToken).Append("\n");
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
            return this.Equals(input as AssetReportAuditCopyCreateResponse);
        }

        /// <summary>
        /// Returns true if AssetReportAuditCopyCreateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetReportAuditCopyCreateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetReportAuditCopyCreateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AuditCopyToken == input.AuditCopyToken ||
                    (this.AuditCopyToken != null &&
                    this.AuditCopyToken.Equals(input.AuditCopyToken))
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
                if (this.AuditCopyToken != null)
                {
                    hashCode = (hashCode * 59) + this.AuditCopyToken.GetHashCode();
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
