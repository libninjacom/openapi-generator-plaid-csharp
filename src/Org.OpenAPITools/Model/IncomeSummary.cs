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
    /// The verified fields from a paystub verification. All fields are provided as reported on the paystub.
    /// </summary>
    [DataContract(Name = "IncomeSummary")]
    public partial class IncomeSummary : Dictionary<String, Object>, IEquatable<IncomeSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncomeSummary()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeSummary" /> class.
        /// </summary>
        /// <param name="employerName">employerName (required).</param>
        /// <param name="employeeName">employeeName (required).</param>
        /// <param name="ytdGrossIncome">ytdGrossIncome (required).</param>
        /// <param name="ytdNetIncome">ytdNetIncome (required).</param>
        /// <param name="payFrequency">payFrequency (required).</param>
        /// <param name="projectedWage">projectedWage (required).</param>
        /// <param name="verifiedTransaction">verifiedTransaction (required).</param>
        public IncomeSummary(EmployerIncomeSummaryFieldString employerName = default(EmployerIncomeSummaryFieldString), EmployeeIncomeSummaryFieldString employeeName = default(EmployeeIncomeSummaryFieldString), YTDGrossIncomeSummaryFieldNumber ytdGrossIncome = default(YTDGrossIncomeSummaryFieldNumber), YTDNetIncomeSummaryFieldNumber ytdNetIncome = default(YTDNetIncomeSummaryFieldNumber), PayFrequency payFrequency = default(PayFrequency), ProjectedIncomeSummaryFieldNumber projectedWage = default(ProjectedIncomeSummaryFieldNumber), TransactionData verifiedTransaction = default(TransactionData)) : base()
        {
            // to ensure "employerName" is required (not null)
            if (employerName == null)
            {
                throw new ArgumentNullException("employerName is a required property for IncomeSummary and cannot be null");
            }
            this.EmployerName = employerName;
            // to ensure "employeeName" is required (not null)
            if (employeeName == null)
            {
                throw new ArgumentNullException("employeeName is a required property for IncomeSummary and cannot be null");
            }
            this.EmployeeName = employeeName;
            // to ensure "ytdGrossIncome" is required (not null)
            if (ytdGrossIncome == null)
            {
                throw new ArgumentNullException("ytdGrossIncome is a required property for IncomeSummary and cannot be null");
            }
            this.YtdGrossIncome = ytdGrossIncome;
            // to ensure "ytdNetIncome" is required (not null)
            if (ytdNetIncome == null)
            {
                throw new ArgumentNullException("ytdNetIncome is a required property for IncomeSummary and cannot be null");
            }
            this.YtdNetIncome = ytdNetIncome;
            // to ensure "payFrequency" is required (not null)
            if (payFrequency == null)
            {
                throw new ArgumentNullException("payFrequency is a required property for IncomeSummary and cannot be null");
            }
            this.PayFrequency = payFrequency;
            // to ensure "projectedWage" is required (not null)
            if (projectedWage == null)
            {
                throw new ArgumentNullException("projectedWage is a required property for IncomeSummary and cannot be null");
            }
            this.ProjectedWage = projectedWage;
            // to ensure "verifiedTransaction" is required (not null)
            if (verifiedTransaction == null)
            {
                throw new ArgumentNullException("verifiedTransaction is a required property for IncomeSummary and cannot be null");
            }
            this.VerifiedTransaction = verifiedTransaction;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets EmployerName
        /// </summary>
        [DataMember(Name = "employer_name", IsRequired = true, EmitDefaultValue = false)]
        public EmployerIncomeSummaryFieldString EmployerName { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeName
        /// </summary>
        [DataMember(Name = "employee_name", IsRequired = true, EmitDefaultValue = false)]
        public EmployeeIncomeSummaryFieldString EmployeeName { get; set; }

        /// <summary>
        /// Gets or Sets YtdGrossIncome
        /// </summary>
        [DataMember(Name = "ytd_gross_income", IsRequired = true, EmitDefaultValue = false)]
        public YTDGrossIncomeSummaryFieldNumber YtdGrossIncome { get; set; }

        /// <summary>
        /// Gets or Sets YtdNetIncome
        /// </summary>
        [DataMember(Name = "ytd_net_income", IsRequired = true, EmitDefaultValue = false)]
        public YTDNetIncomeSummaryFieldNumber YtdNetIncome { get; set; }

        /// <summary>
        /// Gets or Sets PayFrequency
        /// </summary>
        [DataMember(Name = "pay_frequency", IsRequired = true, EmitDefaultValue = true)]
        public PayFrequency PayFrequency { get; set; }

        /// <summary>
        /// Gets or Sets ProjectedWage
        /// </summary>
        [DataMember(Name = "projected_wage", IsRequired = true, EmitDefaultValue = false)]
        public ProjectedIncomeSummaryFieldNumber ProjectedWage { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedTransaction
        /// </summary>
        [DataMember(Name = "verified_transaction", IsRequired = true, EmitDefaultValue = true)]
        public TransactionData VerifiedTransaction { get; set; }

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
            sb.Append("class IncomeSummary {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmployerName: ").Append(EmployerName).Append("\n");
            sb.Append("  EmployeeName: ").Append(EmployeeName).Append("\n");
            sb.Append("  YtdGrossIncome: ").Append(YtdGrossIncome).Append("\n");
            sb.Append("  YtdNetIncome: ").Append(YtdNetIncome).Append("\n");
            sb.Append("  PayFrequency: ").Append(PayFrequency).Append("\n");
            sb.Append("  ProjectedWage: ").Append(ProjectedWage).Append("\n");
            sb.Append("  VerifiedTransaction: ").Append(VerifiedTransaction).Append("\n");
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
            return this.Equals(input as IncomeSummary);
        }

        /// <summary>
        /// Returns true if IncomeSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.EmployerName == input.EmployerName ||
                    (this.EmployerName != null &&
                    this.EmployerName.Equals(input.EmployerName))
                ) && base.Equals(input) && 
                (
                    this.EmployeeName == input.EmployeeName ||
                    (this.EmployeeName != null &&
                    this.EmployeeName.Equals(input.EmployeeName))
                ) && base.Equals(input) && 
                (
                    this.YtdGrossIncome == input.YtdGrossIncome ||
                    (this.YtdGrossIncome != null &&
                    this.YtdGrossIncome.Equals(input.YtdGrossIncome))
                ) && base.Equals(input) && 
                (
                    this.YtdNetIncome == input.YtdNetIncome ||
                    (this.YtdNetIncome != null &&
                    this.YtdNetIncome.Equals(input.YtdNetIncome))
                ) && base.Equals(input) && 
                (
                    this.PayFrequency == input.PayFrequency ||
                    (this.PayFrequency != null &&
                    this.PayFrequency.Equals(input.PayFrequency))
                ) && base.Equals(input) && 
                (
                    this.ProjectedWage == input.ProjectedWage ||
                    (this.ProjectedWage != null &&
                    this.ProjectedWage.Equals(input.ProjectedWage))
                ) && base.Equals(input) && 
                (
                    this.VerifiedTransaction == input.VerifiedTransaction ||
                    (this.VerifiedTransaction != null &&
                    this.VerifiedTransaction.Equals(input.VerifiedTransaction))
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
                if (this.EmployerName != null)
                {
                    hashCode = (hashCode * 59) + this.EmployerName.GetHashCode();
                }
                if (this.EmployeeName != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeName.GetHashCode();
                }
                if (this.YtdGrossIncome != null)
                {
                    hashCode = (hashCode * 59) + this.YtdGrossIncome.GetHashCode();
                }
                if (this.YtdNetIncome != null)
                {
                    hashCode = (hashCode * 59) + this.YtdNetIncome.GetHashCode();
                }
                if (this.PayFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.PayFrequency.GetHashCode();
                }
                if (this.ProjectedWage != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectedWage.GetHashCode();
                }
                if (this.VerifiedTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.VerifiedTransaction.GetHashCode();
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
