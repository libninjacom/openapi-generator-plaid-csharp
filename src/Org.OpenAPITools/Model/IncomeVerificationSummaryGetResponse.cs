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
    /// IncomeVerificationSummaryGetResponse defines the response schema for &#x60;/income/verification/summary/get&#x60;.
    /// </summary>
    [DataContract(Name = "IncomeVerificationSummaryGetResponse")]
    public partial class IncomeVerificationSummaryGetResponse : Dictionary<String, Object>, IEquatable<IncomeVerificationSummaryGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeVerificationSummaryGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncomeVerificationSummaryGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeVerificationSummaryGetResponse" /> class.
        /// </summary>
        /// <param name="incomeSummaries">A list of income summaries. (required).</param>
        /// <param name="error">error.</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public IncomeVerificationSummaryGetResponse(List<IncomeSummary> incomeSummaries = default(List<IncomeSummary>), PlaidError error = default(PlaidError), string requestId = default(string)) : base()
        {
            // to ensure "incomeSummaries" is required (not null)
            if (incomeSummaries == null)
            {
                throw new ArgumentNullException("incomeSummaries is a required property for IncomeVerificationSummaryGetResponse and cannot be null");
            }
            this.IncomeSummaries = incomeSummaries;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for IncomeVerificationSummaryGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.Error = error;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A list of income summaries.
        /// </summary>
        /// <value>A list of income summaries.</value>
        [DataMember(Name = "income_summaries", IsRequired = true, EmitDefaultValue = false)]
        public List<IncomeSummary> IncomeSummaries { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public PlaidError Error { get; set; }

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
            sb.Append("class IncomeVerificationSummaryGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IncomeSummaries: ").Append(IncomeSummaries).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as IncomeVerificationSummaryGetResponse);
        }

        /// <summary>
        /// Returns true if IncomeVerificationSummaryGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeVerificationSummaryGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeVerificationSummaryGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.IncomeSummaries == input.IncomeSummaries ||
                    this.IncomeSummaries != null &&
                    input.IncomeSummaries != null &&
                    this.IncomeSummaries.SequenceEqual(input.IncomeSummaries)
                ) && base.Equals(input) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.IncomeSummaries != null)
                {
                    hashCode = (hashCode * 59) + this.IncomeSummaries.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
