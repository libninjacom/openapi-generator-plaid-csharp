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
    /// The request was flagged by Plaid&#39;s fraud system, and requires additional verification to ensure they are not a bot.
    /// </summary>
    [DataContract(Name = "Recaptcha_RequiredError")]
    public partial class RecaptchaRequiredError : Dictionary<String, Object>, IEquatable<RecaptchaRequiredError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecaptchaRequiredError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecaptchaRequiredError()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecaptchaRequiredError" /> class.
        /// </summary>
        /// <param name="errorType">RECAPTCHA_ERROR (required).</param>
        /// <param name="errorCode">RECAPTCHA_REQUIRED (required).</param>
        /// <param name="displayMessage">displayMessage (required).</param>
        /// <param name="httpCode">400 (required).</param>
        /// <param name="linkUserExperience">Your user will be prompted to solve a Google reCAPTCHA challenge in the Link Recaptcha pane. If they solve the challenge successfully, the user&#39;s request is resubmitted and they are directed to the next Item creation step. (required).</param>
        /// <param name="commonCauses">Plaid&#39;s fraud system detects abusive traffic and considers a variety of parameters throughout Item creation requests. When a request is considered risky or possibly fraudulent, Link presents a reCAPTCHA for the user to solve. (required).</param>
        /// <param name="troubleshootingSteps">Link will automatically guide your user through reCAPTCHA verification. As a general rule, we recommend instrumenting basic fraud monitoring to detect and protect your website from spam and abuse.  If your user cannot verify their session, please submit a Support ticket with the following identifiers: &#x60;link_session_id&#x60; or &#x60;request_id&#x60; (required).</param>
        public RecaptchaRequiredError(string errorType = default(string), string errorCode = default(string), string displayMessage = default(string), string httpCode = default(string), string linkUserExperience = default(string), string commonCauses = default(string), string troubleshootingSteps = default(string)) : base()
        {
            // to ensure "errorType" is required (not null)
            if (errorType == null)
            {
                throw new ArgumentNullException("errorType is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.ErrorType = errorType;
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new ArgumentNullException("errorCode is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.ErrorCode = errorCode;
            // to ensure "displayMessage" is required (not null)
            if (displayMessage == null)
            {
                throw new ArgumentNullException("displayMessage is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.DisplayMessage = displayMessage;
            // to ensure "httpCode" is required (not null)
            if (httpCode == null)
            {
                throw new ArgumentNullException("httpCode is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.HttpCode = httpCode;
            // to ensure "linkUserExperience" is required (not null)
            if (linkUserExperience == null)
            {
                throw new ArgumentNullException("linkUserExperience is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.LinkUserExperience = linkUserExperience;
            // to ensure "commonCauses" is required (not null)
            if (commonCauses == null)
            {
                throw new ArgumentNullException("commonCauses is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.CommonCauses = commonCauses;
            // to ensure "troubleshootingSteps" is required (not null)
            if (troubleshootingSteps == null)
            {
                throw new ArgumentNullException("troubleshootingSteps is a required property for RecaptchaRequiredError and cannot be null");
            }
            this.TroubleshootingSteps = troubleshootingSteps;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// RECAPTCHA_ERROR
        /// </summary>
        /// <value>RECAPTCHA_ERROR</value>
        [DataMember(Name = "error_type", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// RECAPTCHA_REQUIRED
        /// </summary>
        /// <value>RECAPTCHA_REQUIRED</value>
        [DataMember(Name = "error_code", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets DisplayMessage
        /// </summary>
        [DataMember(Name = "display_message", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayMessage { get; set; }

        /// <summary>
        /// 400
        /// </summary>
        /// <value>400</value>
        [DataMember(Name = "http_code", IsRequired = true, EmitDefaultValue = false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// Your user will be prompted to solve a Google reCAPTCHA challenge in the Link Recaptcha pane. If they solve the challenge successfully, the user&#39;s request is resubmitted and they are directed to the next Item creation step.
        /// </summary>
        /// <value>Your user will be prompted to solve a Google reCAPTCHA challenge in the Link Recaptcha pane. If they solve the challenge successfully, the user&#39;s request is resubmitted and they are directed to the next Item creation step.</value>
        [DataMember(Name = "link_user_experience", IsRequired = true, EmitDefaultValue = false)]
        public string LinkUserExperience { get; set; }

        /// <summary>
        /// Plaid&#39;s fraud system detects abusive traffic and considers a variety of parameters throughout Item creation requests. When a request is considered risky or possibly fraudulent, Link presents a reCAPTCHA for the user to solve.
        /// </summary>
        /// <value>Plaid&#39;s fraud system detects abusive traffic and considers a variety of parameters throughout Item creation requests. When a request is considered risky or possibly fraudulent, Link presents a reCAPTCHA for the user to solve.</value>
        [DataMember(Name = "common_causes", IsRequired = true, EmitDefaultValue = false)]
        public string CommonCauses { get; set; }

        /// <summary>
        /// Link will automatically guide your user through reCAPTCHA verification. As a general rule, we recommend instrumenting basic fraud monitoring to detect and protect your website from spam and abuse.  If your user cannot verify their session, please submit a Support ticket with the following identifiers: &#x60;link_session_id&#x60; or &#x60;request_id&#x60;
        /// </summary>
        /// <value>Link will automatically guide your user through reCAPTCHA verification. As a general rule, we recommend instrumenting basic fraud monitoring to detect and protect your website from spam and abuse.  If your user cannot verify their session, please submit a Support ticket with the following identifiers: &#x60;link_session_id&#x60; or &#x60;request_id&#x60;</value>
        [DataMember(Name = "troubleshooting_steps", IsRequired = true, EmitDefaultValue = false)]
        public string TroubleshootingSteps { get; set; }

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
            sb.Append("class RecaptchaRequiredError {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  DisplayMessage: ").Append(DisplayMessage).Append("\n");
            sb.Append("  HttpCode: ").Append(HttpCode).Append("\n");
            sb.Append("  LinkUserExperience: ").Append(LinkUserExperience).Append("\n");
            sb.Append("  CommonCauses: ").Append(CommonCauses).Append("\n");
            sb.Append("  TroubleshootingSteps: ").Append(TroubleshootingSteps).Append("\n");
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
            return this.Equals(input as RecaptchaRequiredError);
        }

        /// <summary>
        /// Returns true if RecaptchaRequiredError instances are equal
        /// </summary>
        /// <param name="input">Instance of RecaptchaRequiredError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecaptchaRequiredError input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ErrorType == input.ErrorType ||
                    (this.ErrorType != null &&
                    this.ErrorType.Equals(input.ErrorType))
                ) && base.Equals(input) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && base.Equals(input) && 
                (
                    this.DisplayMessage == input.DisplayMessage ||
                    (this.DisplayMessage != null &&
                    this.DisplayMessage.Equals(input.DisplayMessage))
                ) && base.Equals(input) && 
                (
                    this.HttpCode == input.HttpCode ||
                    (this.HttpCode != null &&
                    this.HttpCode.Equals(input.HttpCode))
                ) && base.Equals(input) && 
                (
                    this.LinkUserExperience == input.LinkUserExperience ||
                    (this.LinkUserExperience != null &&
                    this.LinkUserExperience.Equals(input.LinkUserExperience))
                ) && base.Equals(input) && 
                (
                    this.CommonCauses == input.CommonCauses ||
                    (this.CommonCauses != null &&
                    this.CommonCauses.Equals(input.CommonCauses))
                ) && base.Equals(input) && 
                (
                    this.TroubleshootingSteps == input.TroubleshootingSteps ||
                    (this.TroubleshootingSteps != null &&
                    this.TroubleshootingSteps.Equals(input.TroubleshootingSteps))
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
                if (this.ErrorType != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorType.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.DisplayMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayMessage.GetHashCode();
                }
                if (this.HttpCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpCode.GetHashCode();
                }
                if (this.LinkUserExperience != null)
                {
                    hashCode = (hashCode * 59) + this.LinkUserExperience.GetHashCode();
                }
                if (this.CommonCauses != null)
                {
                    hashCode = (hashCode * 59) + this.CommonCauses.GetHashCode();
                }
                if (this.TroubleshootingSteps != null)
                {
                    hashCode = (hashCode * 59) + this.TroubleshootingSteps.GetHashCode();
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