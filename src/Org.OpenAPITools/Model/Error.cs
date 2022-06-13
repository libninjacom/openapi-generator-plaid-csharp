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
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by &#x60;error_type&#x60;. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be &#x60;null&#x60; if no error has occurred.
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : Dictionary<String, Object>, IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// A broad categorization of the error. Safe for programmatic use.
        /// </summary>
        /// <value>A broad categorization of the error. Safe for programmatic use.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorTypeEnum
        {
            /// <summary>
            /// Enum INVALIDREQUEST for value: INVALID_REQUEST
            /// </summary>
            [EnumMember(Value = "INVALID_REQUEST")]
            INVALIDREQUEST = 1,

            /// <summary>
            /// Enum INVALIDRESULT for value: INVALID_RESULT
            /// </summary>
            [EnumMember(Value = "INVALID_RESULT")]
            INVALIDRESULT = 2,

            /// <summary>
            /// Enum INVALIDINPUT for value: INVALID_INPUT
            /// </summary>
            [EnumMember(Value = "INVALID_INPUT")]
            INVALIDINPUT = 3,

            /// <summary>
            /// Enum INSTITUTIONERROR for value: INSTITUTION_ERROR
            /// </summary>
            [EnumMember(Value = "INSTITUTION_ERROR")]
            INSTITUTIONERROR = 4,

            /// <summary>
            /// Enum RATELIMITEXCEEDED for value: RATE_LIMIT_EXCEEDED
            /// </summary>
            [EnumMember(Value = "RATE_LIMIT_EXCEEDED")]
            RATELIMITEXCEEDED = 5,

            /// <summary>
            /// Enum APIERROR for value: API_ERROR
            /// </summary>
            [EnumMember(Value = "API_ERROR")]
            APIERROR = 6,

            /// <summary>
            /// Enum ITEMERROR for value: ITEM_ERROR
            /// </summary>
            [EnumMember(Value = "ITEM_ERROR")]
            ITEMERROR = 7,

            /// <summary>
            /// Enum ASSETREPORTERROR for value: ASSET_REPORT_ERROR
            /// </summary>
            [EnumMember(Value = "ASSET_REPORT_ERROR")]
            ASSETREPORTERROR = 8,

            /// <summary>
            /// Enum RECAPTCHAERROR for value: RECAPTCHA_ERROR
            /// </summary>
            [EnumMember(Value = "RECAPTCHA_ERROR")]
            RECAPTCHAERROR = 9,

            /// <summary>
            /// Enum OAUTHERROR for value: OAUTH_ERROR
            /// </summary>
            [EnumMember(Value = "OAUTH_ERROR")]
            OAUTHERROR = 10,

            /// <summary>
            /// Enum PAYMENTERROR for value: PAYMENT_ERROR
            /// </summary>
            [EnumMember(Value = "PAYMENT_ERROR")]
            PAYMENTERROR = 11,

            /// <summary>
            /// Enum BANKTRANSFERERROR for value: BANK_TRANSFER_ERROR
            /// </summary>
            [EnumMember(Value = "BANK_TRANSFER_ERROR")]
            BANKTRANSFERERROR = 12,

            /// <summary>
            /// Enum INCOMEVERIFICATIONERROR for value: INCOME_VERIFICATION_ERROR
            /// </summary>
            [EnumMember(Value = "INCOME_VERIFICATION_ERROR")]
            INCOMEVERIFICATIONERROR = 13

        }


        /// <summary>
        /// A broad categorization of the error. Safe for programmatic use.
        /// </summary>
        /// <value>A broad categorization of the error. Safe for programmatic use.</value>
        [DataMember(Name = "error_type", IsRequired = true, EmitDefaultValue = false)]
        public ErrorTypeEnum ErrorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="errorType">A broad categorization of the error. Safe for programmatic use. (required).</param>
        /// <param name="errorCode">The particular error code. Safe for programmatic use. (required).</param>
        /// <param name="errorMessage">A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use. (required).</param>
        /// <param name="displayMessage">A user-friendly representation of the error code. &#x60;null&#x60; if the error is not related to user action.  This may change over time and is not safe for programmatic use. (required).</param>
        /// <param name="requestId">A unique ID identifying the request, to be used for troubleshooting purposes. This field will be omitted in errors provided by webhooks..</param>
        /// <param name="causes">In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, &#x60;causes&#x60; will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.  &#x60;causes&#x60; will only be provided for the &#x60;error_type&#x60; &#x60;ASSET_REPORT_ERROR&#x60;. &#x60;causes&#x60; will also not be populated inside an error nested within a &#x60;warning&#x60; object..</param>
        /// <param name="status">The HTTP status code associated with the error. This will only be returned in the response body when the error information is provided via a webhook..</param>
        /// <param name="documentationUrl">The URL of a Plaid documentation page with more information about the error.</param>
        /// <param name="suggestedAction">Suggested steps for resolving the error.</param>
        public Error(ErrorTypeEnum errorType = default(ErrorTypeEnum), string errorCode = default(string), string errorMessage = default(string), string displayMessage = default(string), string requestId = default(string), List<Object> causes = default(List<Object>), decimal? status = default(decimal?), string documentationUrl = default(string), string suggestedAction = default(string)) : base()
        {
            this.ErrorType = errorType;
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new ArgumentNullException("errorCode is a required property for Error and cannot be null");
            }
            this.ErrorCode = errorCode;
            // to ensure "errorMessage" is required (not null)
            if (errorMessage == null)
            {
                throw new ArgumentNullException("errorMessage is a required property for Error and cannot be null");
            }
            this.ErrorMessage = errorMessage;
            // to ensure "displayMessage" is required (not null)
            if (displayMessage == null)
            {
                throw new ArgumentNullException("displayMessage is a required property for Error and cannot be null");
            }
            this.DisplayMessage = displayMessage;
            this.RequestId = requestId;
            this.Causes = causes;
            this.Status = status;
            this.DocumentationUrl = documentationUrl;
            this.SuggestedAction = suggestedAction;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The particular error code. Safe for programmatic use.
        /// </summary>
        /// <value>The particular error code. Safe for programmatic use.</value>
        [DataMember(Name = "error_code", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.
        /// </summary>
        /// <value>A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.</value>
        [DataMember(Name = "error_message", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// A user-friendly representation of the error code. &#x60;null&#x60; if the error is not related to user action.  This may change over time and is not safe for programmatic use.
        /// </summary>
        /// <value>A user-friendly representation of the error code. &#x60;null&#x60; if the error is not related to user action.  This may change over time and is not safe for programmatic use.</value>
        [DataMember(Name = "display_message", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayMessage { get; set; }

        /// <summary>
        /// A unique ID identifying the request, to be used for troubleshooting purposes. This field will be omitted in errors provided by webhooks.
        /// </summary>
        /// <value>A unique ID identifying the request, to be used for troubleshooting purposes. This field will be omitted in errors provided by webhooks.</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, &#x60;causes&#x60; will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.  &#x60;causes&#x60; will only be provided for the &#x60;error_type&#x60; &#x60;ASSET_REPORT_ERROR&#x60;. &#x60;causes&#x60; will also not be populated inside an error nested within a &#x60;warning&#x60; object.
        /// </summary>
        /// <value>In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, &#x60;causes&#x60; will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.  &#x60;causes&#x60; will only be provided for the &#x60;error_type&#x60; &#x60;ASSET_REPORT_ERROR&#x60;. &#x60;causes&#x60; will also not be populated inside an error nested within a &#x60;warning&#x60; object.</value>
        [DataMember(Name = "causes", EmitDefaultValue = false)]
        public List<Object> Causes { get; set; }

        /// <summary>
        /// The HTTP status code associated with the error. This will only be returned in the response body when the error information is provided via a webhook.
        /// </summary>
        /// <value>The HTTP status code associated with the error. This will only be returned in the response body when the error information is provided via a webhook.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public decimal? Status { get; set; }

        /// <summary>
        /// The URL of a Plaid documentation page with more information about the error
        /// </summary>
        /// <value>The URL of a Plaid documentation page with more information about the error</value>
        [DataMember(Name = "documentation_url", EmitDefaultValue = false)]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// Suggested steps for resolving the error
        /// </summary>
        /// <value>Suggested steps for resolving the error</value>
        [DataMember(Name = "suggested_action", EmitDefaultValue = false)]
        public string SuggestedAction { get; set; }

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
            sb.Append("class Error {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  DisplayMessage: ").Append(DisplayMessage).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Causes: ").Append(Causes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  SuggestedAction: ").Append(SuggestedAction).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ErrorType == input.ErrorType ||
                    this.ErrorType.Equals(input.ErrorType)
                ) && base.Equals(input) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && base.Equals(input) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && base.Equals(input) && 
                (
                    this.DisplayMessage == input.DisplayMessage ||
                    (this.DisplayMessage != null &&
                    this.DisplayMessage.Equals(input.DisplayMessage))
                ) && base.Equals(input) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && base.Equals(input) && 
                (
                    this.Causes == input.Causes ||
                    this.Causes != null &&
                    input.Causes != null &&
                    this.Causes.SequenceEqual(input.Causes)
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.DocumentationUrl == input.DocumentationUrl ||
                    (this.DocumentationUrl != null &&
                    this.DocumentationUrl.Equals(input.DocumentationUrl))
                ) && base.Equals(input) && 
                (
                    this.SuggestedAction == input.SuggestedAction ||
                    (this.SuggestedAction != null &&
                    this.SuggestedAction.Equals(input.SuggestedAction))
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
                hashCode = (hashCode * 59) + this.ErrorType.GetHashCode();
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.DisplayMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayMessage.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.Causes != null)
                {
                    hashCode = (hashCode * 59) + this.Causes.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.DocumentationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentationUrl.GetHashCode();
                }
                if (this.SuggestedAction != null)
                {
                    hashCode = (hashCode * 59) + this.SuggestedAction.GetHashCode();
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