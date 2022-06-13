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
    /// AssetReportFilterResponse defines the response schema for &#x60;/asset_report/filter&#x60;
    /// </summary>
    [DataContract(Name = "AssetReportFilterResponse")]
    public partial class AssetReportFilterResponse : Dictionary<String, Object>, IEquatable<AssetReportFilterResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReportFilterResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetReportFilterResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReportFilterResponse" /> class.
        /// </summary>
        /// <param name="assetReportToken">A token that can be provided to endpoints such as &#x60;/asset_report/get&#x60; or &#x60;/asset_report/pdf/get&#x60; to fetch or update an Asset Report. (required).</param>
        /// <param name="assetReportId">A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive. (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public AssetReportFilterResponse(string assetReportToken = default(string), string assetReportId = default(string), string requestId = default(string)) : base()
        {
            // to ensure "assetReportToken" is required (not null)
            if (assetReportToken == null)
            {
                throw new ArgumentNullException("assetReportToken is a required property for AssetReportFilterResponse and cannot be null");
            }
            this.AssetReportToken = assetReportToken;
            // to ensure "assetReportId" is required (not null)
            if (assetReportId == null)
            {
                throw new ArgumentNullException("assetReportId is a required property for AssetReportFilterResponse and cannot be null");
            }
            this.AssetReportId = assetReportId;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for AssetReportFilterResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A token that can be provided to endpoints such as &#x60;/asset_report/get&#x60; or &#x60;/asset_report/pdf/get&#x60; to fetch or update an Asset Report.
        /// </summary>
        /// <value>A token that can be provided to endpoints such as &#x60;/asset_report/get&#x60; or &#x60;/asset_report/pdf/get&#x60; to fetch or update an Asset Report.</value>
        [DataMember(Name = "asset_report_token", IsRequired = true, EmitDefaultValue = false)]
        public string AssetReportToken { get; set; }

        /// <summary>
        /// A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.
        /// </summary>
        /// <value>A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.</value>
        [DataMember(Name = "asset_report_id", IsRequired = true, EmitDefaultValue = false)]
        public string AssetReportId { get; set; }

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
            sb.Append("class AssetReportFilterResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AssetReportToken: ").Append(AssetReportToken).Append("\n");
            sb.Append("  AssetReportId: ").Append(AssetReportId).Append("\n");
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
            return this.Equals(input as AssetReportFilterResponse);
        }

        /// <summary>
        /// Returns true if AssetReportFilterResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetReportFilterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetReportFilterResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AssetReportToken == input.AssetReportToken ||
                    (this.AssetReportToken != null &&
                    this.AssetReportToken.Equals(input.AssetReportToken))
                ) && base.Equals(input) && 
                (
                    this.AssetReportId == input.AssetReportId ||
                    (this.AssetReportId != null &&
                    this.AssetReportId.Equals(input.AssetReportId))
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
                if (this.AssetReportToken != null)
                {
                    hashCode = (hashCode * 59) + this.AssetReportToken.GetHashCode();
                }
                if (this.AssetReportId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetReportId.GetHashCode();
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
