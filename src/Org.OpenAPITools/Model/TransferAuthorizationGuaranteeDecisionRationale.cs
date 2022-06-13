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
    /// The rationale for Plaid&#39;s decision to not guarantee a transfer. Will be &#x60;null&#x60; unless &#x60;guarantee_decision&#x60; is &#x60;NOT_GUARANTEED&#x60;.
    /// </summary>
    [DataContract(Name = "TransferAuthorizationGuaranteeDecisionRationale")]
    public partial class TransferAuthorizationGuaranteeDecisionRationale : Dictionary<String, Object>, IEquatable<TransferAuthorizationGuaranteeDecisionRationale>, IValidatableObject
    {
        /// <summary>
        /// A code representing the reason Plaid declined to guarantee this transfer:  &#x60;RETURN_BANK&#x60;: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.  &#x60;RETURN_CUSTOMER&#x60;: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.  &#x60;GUARANTEE_LIMIT_REACHED&#x60;: This transfer is low-risk, but Guaranteed ACH has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.  &#x60;RISK_ESTIMATE_UNAVAILABLE&#x60;: A risk estimate is unavailable for this Item.
        /// </summary>
        /// <value>A code representing the reason Plaid declined to guarantee this transfer:  &#x60;RETURN_BANK&#x60;: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.  &#x60;RETURN_CUSTOMER&#x60;: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.  &#x60;GUARANTEE_LIMIT_REACHED&#x60;: This transfer is low-risk, but Guaranteed ACH has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.  &#x60;RISK_ESTIMATE_UNAVAILABLE&#x60;: A risk estimate is unavailable for this Item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum RETURNBANK for value: RETURN_BANK
            /// </summary>
            [EnumMember(Value = "RETURN_BANK")]
            RETURNBANK = 1,

            /// <summary>
            /// Enum RETURNCUSTOMER for value: RETURN_CUSTOMER
            /// </summary>
            [EnumMember(Value = "RETURN_CUSTOMER")]
            RETURNCUSTOMER = 2,

            /// <summary>
            /// Enum GUARANTEELIMITREACHED for value: GUARANTEE_LIMIT_REACHED
            /// </summary>
            [EnumMember(Value = "GUARANTEE_LIMIT_REACHED")]
            GUARANTEELIMITREACHED = 3,

            /// <summary>
            /// Enum RISKESTIMATEUNAVAILABLE for value: RISK_ESTIMATE_UNAVAILABLE
            /// </summary>
            [EnumMember(Value = "RISK_ESTIMATE_UNAVAILABLE")]
            RISKESTIMATEUNAVAILABLE = 4

        }


        /// <summary>
        /// A code representing the reason Plaid declined to guarantee this transfer:  &#x60;RETURN_BANK&#x60;: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.  &#x60;RETURN_CUSTOMER&#x60;: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.  &#x60;GUARANTEE_LIMIT_REACHED&#x60;: This transfer is low-risk, but Guaranteed ACH has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.  &#x60;RISK_ESTIMATE_UNAVAILABLE&#x60;: A risk estimate is unavailable for this Item.
        /// </summary>
        /// <value>A code representing the reason Plaid declined to guarantee this transfer:  &#x60;RETURN_BANK&#x60;: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.  &#x60;RETURN_CUSTOMER&#x60;: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.  &#x60;GUARANTEE_LIMIT_REACHED&#x60;: This transfer is low-risk, but Guaranteed ACH has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.  &#x60;RISK_ESTIMATE_UNAVAILABLE&#x60;: A risk estimate is unavailable for this Item.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAuthorizationGuaranteeDecisionRationale" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferAuthorizationGuaranteeDecisionRationale()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAuthorizationGuaranteeDecisionRationale" /> class.
        /// </summary>
        /// <param name="code">A code representing the reason Plaid declined to guarantee this transfer:  &#x60;RETURN_BANK&#x60;: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.  &#x60;RETURN_CUSTOMER&#x60;: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.  &#x60;GUARANTEE_LIMIT_REACHED&#x60;: This transfer is low-risk, but Guaranteed ACH has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.  &#x60;RISK_ESTIMATE_UNAVAILABLE&#x60;: A risk estimate is unavailable for this Item. (required).</param>
        /// <param name="description">A human-readable description of why the transfer cannot be guaranteed. (required).</param>
        public TransferAuthorizationGuaranteeDecisionRationale(CodeEnum code = default(CodeEnum), string description = default(string)) : base()
        {
            this.Code = code;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TransferAuthorizationGuaranteeDecisionRationale and cannot be null");
            }
            this.Description = description;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A human-readable description of why the transfer cannot be guaranteed.
        /// </summary>
        /// <value>A human-readable description of why the transfer cannot be guaranteed.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

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
            sb.Append("class TransferAuthorizationGuaranteeDecisionRationale {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as TransferAuthorizationGuaranteeDecisionRationale);
        }

        /// <summary>
        /// Returns true if TransferAuthorizationGuaranteeDecisionRationale instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferAuthorizationGuaranteeDecisionRationale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferAuthorizationGuaranteeDecisionRationale input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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