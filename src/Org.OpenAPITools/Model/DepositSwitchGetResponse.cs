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
    /// DepositSwitchGetResponse defines the response schema for &#x60;/deposit_switch/get&#x60;
    /// </summary>
    [DataContract(Name = "DepositSwitchGetResponse")]
    public partial class DepositSwitchGetResponse : Dictionary<String, Object>, IEquatable<DepositSwitchGetResponse>, IValidatableObject
    {
        /// <summary>
        ///  The state, or status, of the deposit switch.  - &#x60;initialized&#x60; – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.  - &#x60;processing&#x60; – The deposit switch request has been submitted and is being processed.  - &#x60;completed&#x60; – The user&#39;s employer has fulfilled the deposit switch request.  - &#x60;error&#x60; – There was an error processing the deposit switch request.
        /// </summary>
        /// <value> The state, or status, of the deposit switch.  - &#x60;initialized&#x60; – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.  - &#x60;processing&#x60; – The deposit switch request has been submitted and is being processed.  - &#x60;completed&#x60; – The user&#39;s employer has fulfilled the deposit switch request.  - &#x60;error&#x60; – There was an error processing the deposit switch request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Initialized for value: initialized
            /// </summary>
            [EnumMember(Value = "initialized")]
            Initialized = 1,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 3,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4

        }


        /// <summary>
        ///  The state, or status, of the deposit switch.  - &#x60;initialized&#x60; – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.  - &#x60;processing&#x60; – The deposit switch request has been submitted and is being processed.  - &#x60;completed&#x60; – The user&#39;s employer has fulfilled the deposit switch request.  - &#x60;error&#x60; – There was an error processing the deposit switch request.
        /// </summary>
        /// <value> The state, or status, of the deposit switch.  - &#x60;initialized&#x60; – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.  - &#x60;processing&#x60; – The deposit switch request has been submitted and is being processed.  - &#x60;completed&#x60; – The user&#39;s employer has fulfilled the deposit switch request.  - &#x60;error&#x60; – There was an error processing the deposit switch request.</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// The method used to make the deposit switch.  - &#x60;instant&#x60; – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.  - &#x60;mail&#x60; – User requested that Plaid contact their employer by mail to make the direct deposit switch.  - &#x60;pdf&#x60; – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.&#39;
        /// </summary>
        /// <value>The method used to make the deposit switch.  - &#x60;instant&#x60; – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.  - &#x60;mail&#x60; – User requested that Plaid contact their employer by mail to make the direct deposit switch.  - &#x60;pdf&#x60; – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SwitchMethodEnum
        {
            /// <summary>
            /// Enum Instant for value: instant
            /// </summary>
            [EnumMember(Value = "instant")]
            Instant = 1,

            /// <summary>
            /// Enum Mail for value: mail
            /// </summary>
            [EnumMember(Value = "mail")]
            Mail = 2,

            /// <summary>
            /// Enum Pdf for value: pdf
            /// </summary>
            [EnumMember(Value = "pdf")]
            Pdf = 3,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 4

        }


        /// <summary>
        /// The method used to make the deposit switch.  - &#x60;instant&#x60; – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.  - &#x60;mail&#x60; – User requested that Plaid contact their employer by mail to make the direct deposit switch.  - &#x60;pdf&#x60; – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.&#39;
        /// </summary>
        /// <value>The method used to make the deposit switch.  - &#x60;instant&#x60; – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.  - &#x60;mail&#x60; – User requested that Plaid contact their employer by mail to make the direct deposit switch.  - &#x60;pdf&#x60; – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.&#39;</value>
        [DataMember(Name = "switch_method", EmitDefaultValue = true)]
        public SwitchMethodEnum? SwitchMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositSwitchGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepositSwitchGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositSwitchGetResponse" /> class.
        /// </summary>
        /// <param name="depositSwitchId">The ID of the deposit switch. (required).</param>
        /// <param name="targetAccountId">The ID of the bank account the direct deposit was switched to. (required).</param>
        /// <param name="targetItemId">The ID of the Item the direct deposit was switched to. (required).</param>
        /// <param name="state"> The state, or status, of the deposit switch.  - &#x60;initialized&#x60; – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.  - &#x60;processing&#x60; – The deposit switch request has been submitted and is being processed.  - &#x60;completed&#x60; – The user&#39;s employer has fulfilled the deposit switch request.  - &#x60;error&#x60; – There was an error processing the deposit switch request. (required).</param>
        /// <param name="switchMethod">The method used to make the deposit switch.  - &#x60;instant&#x60; – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.  - &#x60;mail&#x60; – User requested that Plaid contact their employer by mail to make the direct deposit switch.  - &#x60;pdf&#x60; – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.&#39;.</param>
        /// <param name="accountHasMultipleAllocations">When &#x60;true&#x60;, user’s direct deposit goes to multiple banks. When false, user’s direct deposit only goes to the target account. Always &#x60;null&#x60; if the deposit switch has not been completed. (required).</param>
        /// <param name="isAllocatedRemainder">When &#x60;true&#x60;, the target account is allocated the remainder of direct deposit after all other allocations have been deducted. When &#x60;false&#x60;, user’s direct deposit is allocated as a percent or amount. Always &#x60;null&#x60; if the deposit switch has not been completed. (required).</param>
        /// <param name="percentAllocated">The percentage of direct deposit allocated to the target account. Always &#x60;null&#x60; if the target account is not allocated a percentage or if the deposit switch has not been completed or if &#x60;is_allocated_remainder&#x60; is true. (required).</param>
        /// <param name="amountAllocated">The dollar amount of direct deposit allocated to the target account. Always &#x60;null&#x60; if the target account is not allocated an amount or if the deposit switch has not been completed. (required).</param>
        /// <param name="employerName">The name of the employer selected by the user. If the user did not select an employer, the value returned is &#x60;null&#x60;..</param>
        /// <param name="employerId">The ID of the employer selected by the user. If the user did not select an employer, the value returned is &#x60;null&#x60;..</param>
        /// <param name="institutionName">The name of the institution selected by the user. If the user did not select an institution, the value returned is &#x60;null&#x60;..</param>
        /// <param name="institutionId">The ID of the institution selected by the user. If the user did not select an institution, the value returned is &#x60;null&#x60;..</param>
        /// <param name="dateCreated">[ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was created.  (required).</param>
        /// <param name="dateCompleted">[ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was completed. Always &#x60;null&#x60; if the deposit switch has not been completed.  (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public DepositSwitchGetResponse(string depositSwitchId = default(string), string targetAccountId = default(string), string targetItemId = default(string), StateEnum state = default(StateEnum), SwitchMethodEnum? switchMethod = default(SwitchMethodEnum?), bool? accountHasMultipleAllocations = default(bool?), bool? isAllocatedRemainder = default(bool?), decimal? percentAllocated = default(decimal?), decimal? amountAllocated = default(decimal?), string employerName = default(string), string employerId = default(string), string institutionName = default(string), string institutionId = default(string), DateTime dateCreated = default(DateTime), DateTime? dateCompleted = default(DateTime?), string requestId = default(string)) : base()
        {
            // to ensure "depositSwitchId" is required (not null)
            if (depositSwitchId == null)
            {
                throw new ArgumentNullException("depositSwitchId is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.DepositSwitchId = depositSwitchId;
            // to ensure "targetAccountId" is required (not null)
            if (targetAccountId == null)
            {
                throw new ArgumentNullException("targetAccountId is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.TargetAccountId = targetAccountId;
            // to ensure "targetItemId" is required (not null)
            if (targetItemId == null)
            {
                throw new ArgumentNullException("targetItemId is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.TargetItemId = targetItemId;
            this.State = state;
            // to ensure "accountHasMultipleAllocations" is required (not null)
            if (accountHasMultipleAllocations == null)
            {
                throw new ArgumentNullException("accountHasMultipleAllocations is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.AccountHasMultipleAllocations = accountHasMultipleAllocations;
            // to ensure "isAllocatedRemainder" is required (not null)
            if (isAllocatedRemainder == null)
            {
                throw new ArgumentNullException("isAllocatedRemainder is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.IsAllocatedRemainder = isAllocatedRemainder;
            // to ensure "percentAllocated" is required (not null)
            if (percentAllocated == null)
            {
                throw new ArgumentNullException("percentAllocated is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.PercentAllocated = percentAllocated;
            // to ensure "amountAllocated" is required (not null)
            if (amountAllocated == null)
            {
                throw new ArgumentNullException("amountAllocated is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.AmountAllocated = amountAllocated;
            this.DateCreated = dateCreated;
            // to ensure "dateCompleted" is required (not null)
            if (dateCompleted == null)
            {
                throw new ArgumentNullException("dateCompleted is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.DateCompleted = dateCompleted;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for DepositSwitchGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.SwitchMethod = switchMethod;
            this.EmployerName = employerName;
            this.EmployerId = employerId;
            this.InstitutionName = institutionName;
            this.InstitutionId = institutionId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the deposit switch.
        /// </summary>
        /// <value>The ID of the deposit switch.</value>
        [DataMember(Name = "deposit_switch_id", IsRequired = true, EmitDefaultValue = false)]
        public string DepositSwitchId { get; set; }

        /// <summary>
        /// The ID of the bank account the direct deposit was switched to.
        /// </summary>
        /// <value>The ID of the bank account the direct deposit was switched to.</value>
        [DataMember(Name = "target_account_id", IsRequired = true, EmitDefaultValue = true)]
        public string TargetAccountId { get; set; }

        /// <summary>
        /// The ID of the Item the direct deposit was switched to.
        /// </summary>
        /// <value>The ID of the Item the direct deposit was switched to.</value>
        [DataMember(Name = "target_item_id", IsRequired = true, EmitDefaultValue = true)]
        public string TargetItemId { get; set; }

        /// <summary>
        /// When &#x60;true&#x60;, user’s direct deposit goes to multiple banks. When false, user’s direct deposit only goes to the target account. Always &#x60;null&#x60; if the deposit switch has not been completed.
        /// </summary>
        /// <value>When &#x60;true&#x60;, user’s direct deposit goes to multiple banks. When false, user’s direct deposit only goes to the target account. Always &#x60;null&#x60; if the deposit switch has not been completed.</value>
        [DataMember(Name = "account_has_multiple_allocations", IsRequired = true, EmitDefaultValue = true)]
        public bool? AccountHasMultipleAllocations { get; set; }

        /// <summary>
        /// When &#x60;true&#x60;, the target account is allocated the remainder of direct deposit after all other allocations have been deducted. When &#x60;false&#x60;, user’s direct deposit is allocated as a percent or amount. Always &#x60;null&#x60; if the deposit switch has not been completed.
        /// </summary>
        /// <value>When &#x60;true&#x60;, the target account is allocated the remainder of direct deposit after all other allocations have been deducted. When &#x60;false&#x60;, user’s direct deposit is allocated as a percent or amount. Always &#x60;null&#x60; if the deposit switch has not been completed.</value>
        [DataMember(Name = "is_allocated_remainder", IsRequired = true, EmitDefaultValue = true)]
        public bool? IsAllocatedRemainder { get; set; }

        /// <summary>
        /// The percentage of direct deposit allocated to the target account. Always &#x60;null&#x60; if the target account is not allocated a percentage or if the deposit switch has not been completed or if &#x60;is_allocated_remainder&#x60; is true.
        /// </summary>
        /// <value>The percentage of direct deposit allocated to the target account. Always &#x60;null&#x60; if the target account is not allocated a percentage or if the deposit switch has not been completed or if &#x60;is_allocated_remainder&#x60; is true.</value>
        [DataMember(Name = "percent_allocated", IsRequired = true, EmitDefaultValue = true)]
        public decimal? PercentAllocated { get; set; }

        /// <summary>
        /// The dollar amount of direct deposit allocated to the target account. Always &#x60;null&#x60; if the target account is not allocated an amount or if the deposit switch has not been completed.
        /// </summary>
        /// <value>The dollar amount of direct deposit allocated to the target account. Always &#x60;null&#x60; if the target account is not allocated an amount or if the deposit switch has not been completed.</value>
        [DataMember(Name = "amount_allocated", IsRequired = true, EmitDefaultValue = true)]
        public decimal? AmountAllocated { get; set; }

        /// <summary>
        /// The name of the employer selected by the user. If the user did not select an employer, the value returned is &#x60;null&#x60;.
        /// </summary>
        /// <value>The name of the employer selected by the user. If the user did not select an employer, the value returned is &#x60;null&#x60;.</value>
        [DataMember(Name = "employer_name", EmitDefaultValue = true)]
        public string EmployerName { get; set; }

        /// <summary>
        /// The ID of the employer selected by the user. If the user did not select an employer, the value returned is &#x60;null&#x60;.
        /// </summary>
        /// <value>The ID of the employer selected by the user. If the user did not select an employer, the value returned is &#x60;null&#x60;.</value>
        [DataMember(Name = "employer_id", EmitDefaultValue = true)]
        public string EmployerId { get; set; }

        /// <summary>
        /// The name of the institution selected by the user. If the user did not select an institution, the value returned is &#x60;null&#x60;.
        /// </summary>
        /// <value>The name of the institution selected by the user. If the user did not select an institution, the value returned is &#x60;null&#x60;.</value>
        [DataMember(Name = "institution_name", EmitDefaultValue = true)]
        public string InstitutionName { get; set; }

        /// <summary>
        /// The ID of the institution selected by the user. If the user did not select an institution, the value returned is &#x60;null&#x60;.
        /// </summary>
        /// <value>The ID of the institution selected by the user. If the user did not select an institution, the value returned is &#x60;null&#x60;.</value>
        [DataMember(Name = "institution_id", EmitDefaultValue = true)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// [ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was created. 
        /// </summary>
        /// <value>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was created. </value>
        [DataMember(Name = "date_created", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// [ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was completed. Always &#x60;null&#x60; if the deposit switch has not been completed. 
        /// </summary>
        /// <value>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was completed. Always &#x60;null&#x60; if the deposit switch has not been completed. </value>
        [DataMember(Name = "date_completed", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateCompleted { get; set; }

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
            sb.Append("class DepositSwitchGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DepositSwitchId: ").Append(DepositSwitchId).Append("\n");
            sb.Append("  TargetAccountId: ").Append(TargetAccountId).Append("\n");
            sb.Append("  TargetItemId: ").Append(TargetItemId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SwitchMethod: ").Append(SwitchMethod).Append("\n");
            sb.Append("  AccountHasMultipleAllocations: ").Append(AccountHasMultipleAllocations).Append("\n");
            sb.Append("  IsAllocatedRemainder: ").Append(IsAllocatedRemainder).Append("\n");
            sb.Append("  PercentAllocated: ").Append(PercentAllocated).Append("\n");
            sb.Append("  AmountAllocated: ").Append(AmountAllocated).Append("\n");
            sb.Append("  EmployerName: ").Append(EmployerName).Append("\n");
            sb.Append("  EmployerId: ").Append(EmployerId).Append("\n");
            sb.Append("  InstitutionName: ").Append(InstitutionName).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
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
            return this.Equals(input as DepositSwitchGetResponse);
        }

        /// <summary>
        /// Returns true if DepositSwitchGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositSwitchGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositSwitchGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.DepositSwitchId == input.DepositSwitchId ||
                    (this.DepositSwitchId != null &&
                    this.DepositSwitchId.Equals(input.DepositSwitchId))
                ) && base.Equals(input) && 
                (
                    this.TargetAccountId == input.TargetAccountId ||
                    (this.TargetAccountId != null &&
                    this.TargetAccountId.Equals(input.TargetAccountId))
                ) && base.Equals(input) && 
                (
                    this.TargetItemId == input.TargetItemId ||
                    (this.TargetItemId != null &&
                    this.TargetItemId.Equals(input.TargetItemId))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && base.Equals(input) && 
                (
                    this.SwitchMethod == input.SwitchMethod ||
                    this.SwitchMethod.Equals(input.SwitchMethod)
                ) && base.Equals(input) && 
                (
                    this.AccountHasMultipleAllocations == input.AccountHasMultipleAllocations ||
                    (this.AccountHasMultipleAllocations != null &&
                    this.AccountHasMultipleAllocations.Equals(input.AccountHasMultipleAllocations))
                ) && base.Equals(input) && 
                (
                    this.IsAllocatedRemainder == input.IsAllocatedRemainder ||
                    (this.IsAllocatedRemainder != null &&
                    this.IsAllocatedRemainder.Equals(input.IsAllocatedRemainder))
                ) && base.Equals(input) && 
                (
                    this.PercentAllocated == input.PercentAllocated ||
                    (this.PercentAllocated != null &&
                    this.PercentAllocated.Equals(input.PercentAllocated))
                ) && base.Equals(input) && 
                (
                    this.AmountAllocated == input.AmountAllocated ||
                    (this.AmountAllocated != null &&
                    this.AmountAllocated.Equals(input.AmountAllocated))
                ) && base.Equals(input) && 
                (
                    this.EmployerName == input.EmployerName ||
                    (this.EmployerName != null &&
                    this.EmployerName.Equals(input.EmployerName))
                ) && base.Equals(input) && 
                (
                    this.EmployerId == input.EmployerId ||
                    (this.EmployerId != null &&
                    this.EmployerId.Equals(input.EmployerId))
                ) && base.Equals(input) && 
                (
                    this.InstitutionName == input.InstitutionName ||
                    (this.InstitutionName != null &&
                    this.InstitutionName.Equals(input.InstitutionName))
                ) && base.Equals(input) && 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && base.Equals(input) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && base.Equals(input) && 
                (
                    this.DateCompleted == input.DateCompleted ||
                    (this.DateCompleted != null &&
                    this.DateCompleted.Equals(input.DateCompleted))
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
                if (this.DepositSwitchId != null)
                {
                    hashCode = (hashCode * 59) + this.DepositSwitchId.GetHashCode();
                }
                if (this.TargetAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAccountId.GetHashCode();
                }
                if (this.TargetItemId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetItemId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.SwitchMethod.GetHashCode();
                if (this.AccountHasMultipleAllocations != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHasMultipleAllocations.GetHashCode();
                }
                if (this.IsAllocatedRemainder != null)
                {
                    hashCode = (hashCode * 59) + this.IsAllocatedRemainder.GetHashCode();
                }
                if (this.PercentAllocated != null)
                {
                    hashCode = (hashCode * 59) + this.PercentAllocated.GetHashCode();
                }
                if (this.AmountAllocated != null)
                {
                    hashCode = (hashCode * 59) + this.AmountAllocated.GetHashCode();
                }
                if (this.EmployerName != null)
                {
                    hashCode = (hashCode * 59) + this.EmployerName.GetHashCode();
                }
                if (this.EmployerId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployerId.GetHashCode();
                }
                if (this.InstitutionName != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionName.GetHashCode();
                }
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateCompleted != null)
                {
                    hashCode = (hashCode * 59) + this.DateCompleted.GetHashCode();
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