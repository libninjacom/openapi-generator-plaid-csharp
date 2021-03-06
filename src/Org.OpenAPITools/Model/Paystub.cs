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
    /// An object representing data extracted from the end user&#39;s paystub.
    /// </summary>
    [DataContract(Name = "Paystub")]
    public partial class Paystub : Dictionary<String, Object>, IEquatable<Paystub>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paystub" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Paystub()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Paystub" /> class.
        /// </summary>
        /// <param name="deductions">deductions (required).</param>
        /// <param name="docId">An identifier of the document referenced by the document metadata. (required).</param>
        /// <param name="earnings">earnings (required).</param>
        /// <param name="employee">employee (required).</param>
        /// <param name="employer">employer (required).</param>
        /// <param name="employmentDetails">employmentDetails.</param>
        /// <param name="netPay">netPay (required).</param>
        /// <param name="payPeriodDetails">payPeriodDetails (required).</param>
        /// <param name="paystubDetails">paystubDetails.</param>
        /// <param name="incomeBreakdown">incomeBreakdown.</param>
        /// <param name="ytdEarnings">ytdEarnings.</param>
        /// <param name="verification">verification (required).</param>
        public Paystub(Deductions deductions = default(Deductions), string docId = default(string), Earnings earnings = default(Earnings), Employee employee = default(Employee), PaystubEmployer employer = default(PaystubEmployer), EmploymentDetails employmentDetails = default(EmploymentDetails), NetPay netPay = default(NetPay), PayPeriodDetails payPeriodDetails = default(PayPeriodDetails), PaystubDetails paystubDetails = default(PaystubDetails), List<IncomeBreakdown> incomeBreakdown = default(List<IncomeBreakdown>), PaystubYTDDetails ytdEarnings = default(PaystubYTDDetails), PaystubVerification verification = default(PaystubVerification)) : base()
        {
            // to ensure "deductions" is required (not null)
            if (deductions == null)
            {
                throw new ArgumentNullException("deductions is a required property for Paystub and cannot be null");
            }
            this.Deductions = deductions;
            // to ensure "docId" is required (not null)
            if (docId == null)
            {
                throw new ArgumentNullException("docId is a required property for Paystub and cannot be null");
            }
            this.DocId = docId;
            // to ensure "earnings" is required (not null)
            if (earnings == null)
            {
                throw new ArgumentNullException("earnings is a required property for Paystub and cannot be null");
            }
            this.Earnings = earnings;
            // to ensure "employee" is required (not null)
            if (employee == null)
            {
                throw new ArgumentNullException("employee is a required property for Paystub and cannot be null");
            }
            this.Employee = employee;
            // to ensure "employer" is required (not null)
            if (employer == null)
            {
                throw new ArgumentNullException("employer is a required property for Paystub and cannot be null");
            }
            this.Employer = employer;
            // to ensure "netPay" is required (not null)
            if (netPay == null)
            {
                throw new ArgumentNullException("netPay is a required property for Paystub and cannot be null");
            }
            this.NetPay = netPay;
            // to ensure "payPeriodDetails" is required (not null)
            if (payPeriodDetails == null)
            {
                throw new ArgumentNullException("payPeriodDetails is a required property for Paystub and cannot be null");
            }
            this.PayPeriodDetails = payPeriodDetails;
            // to ensure "verification" is required (not null)
            if (verification == null)
            {
                throw new ArgumentNullException("verification is a required property for Paystub and cannot be null");
            }
            this.Verification = verification;
            this.EmploymentDetails = employmentDetails;
            this.PaystubDetails = paystubDetails;
            this.IncomeBreakdown = incomeBreakdown;
            this.YtdEarnings = ytdEarnings;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Deductions
        /// </summary>
        [DataMember(Name = "deductions", IsRequired = true, EmitDefaultValue = false)]
        public Deductions Deductions { get; set; }

        /// <summary>
        /// An identifier of the document referenced by the document metadata.
        /// </summary>
        /// <value>An identifier of the document referenced by the document metadata.</value>
        [DataMember(Name = "doc_id", IsRequired = true, EmitDefaultValue = false)]
        public string DocId { get; set; }

        /// <summary>
        /// Gets or Sets Earnings
        /// </summary>
        [DataMember(Name = "earnings", IsRequired = true, EmitDefaultValue = false)]
        public Earnings Earnings { get; set; }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", IsRequired = true, EmitDefaultValue = false)]
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or Sets Employer
        /// </summary>
        [DataMember(Name = "employer", IsRequired = true, EmitDefaultValue = false)]
        public PaystubEmployer Employer { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDetails
        /// </summary>
        [DataMember(Name = "employment_details", EmitDefaultValue = false)]
        [Obsolete]
        public EmploymentDetails EmploymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets NetPay
        /// </summary>
        [DataMember(Name = "net_pay", IsRequired = true, EmitDefaultValue = false)]
        public NetPay NetPay { get; set; }

        /// <summary>
        /// Gets or Sets PayPeriodDetails
        /// </summary>
        [DataMember(Name = "pay_period_details", IsRequired = true, EmitDefaultValue = false)]
        public PayPeriodDetails PayPeriodDetails { get; set; }

        /// <summary>
        /// Gets or Sets PaystubDetails
        /// </summary>
        [DataMember(Name = "paystub_details", EmitDefaultValue = false)]
        [Obsolete]
        public PaystubDetails PaystubDetails { get; set; }

        /// <summary>
        /// Gets or Sets IncomeBreakdown
        /// </summary>
        [DataMember(Name = "income_breakdown", EmitDefaultValue = false)]
        [Obsolete]
        public List<IncomeBreakdown> IncomeBreakdown { get; set; }

        /// <summary>
        /// Gets or Sets YtdEarnings
        /// </summary>
        [DataMember(Name = "ytd_earnings", EmitDefaultValue = false)]
        [Obsolete]
        public PaystubYTDDetails YtdEarnings { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name = "verification", IsRequired = true, EmitDefaultValue = true)]
        public PaystubVerification Verification { get; set; }

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
            sb.Append("class Paystub {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  DocId: ").Append(DocId).Append("\n");
            sb.Append("  Earnings: ").Append(Earnings).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Employer: ").Append(Employer).Append("\n");
            sb.Append("  EmploymentDetails: ").Append(EmploymentDetails).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  PayPeriodDetails: ").Append(PayPeriodDetails).Append("\n");
            sb.Append("  PaystubDetails: ").Append(PaystubDetails).Append("\n");
            sb.Append("  IncomeBreakdown: ").Append(IncomeBreakdown).Append("\n");
            sb.Append("  YtdEarnings: ").Append(YtdEarnings).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
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
            return this.Equals(input as Paystub);
        }

        /// <summary>
        /// Returns true if Paystub instances are equal
        /// </summary>
        /// <param name="input">Instance of Paystub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Paystub input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Deductions == input.Deductions ||
                    (this.Deductions != null &&
                    this.Deductions.Equals(input.Deductions))
                ) && base.Equals(input) && 
                (
                    this.DocId == input.DocId ||
                    (this.DocId != null &&
                    this.DocId.Equals(input.DocId))
                ) && base.Equals(input) && 
                (
                    this.Earnings == input.Earnings ||
                    (this.Earnings != null &&
                    this.Earnings.Equals(input.Earnings))
                ) && base.Equals(input) && 
                (
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && base.Equals(input) && 
                (
                    this.Employer == input.Employer ||
                    (this.Employer != null &&
                    this.Employer.Equals(input.Employer))
                ) && base.Equals(input) && 
                (
                    this.EmploymentDetails == input.EmploymentDetails ||
                    (this.EmploymentDetails != null &&
                    this.EmploymentDetails.Equals(input.EmploymentDetails))
                ) && base.Equals(input) && 
                (
                    this.NetPay == input.NetPay ||
                    (this.NetPay != null &&
                    this.NetPay.Equals(input.NetPay))
                ) && base.Equals(input) && 
                (
                    this.PayPeriodDetails == input.PayPeriodDetails ||
                    (this.PayPeriodDetails != null &&
                    this.PayPeriodDetails.Equals(input.PayPeriodDetails))
                ) && base.Equals(input) && 
                (
                    this.PaystubDetails == input.PaystubDetails ||
                    (this.PaystubDetails != null &&
                    this.PaystubDetails.Equals(input.PaystubDetails))
                ) && base.Equals(input) && 
                (
                    this.IncomeBreakdown == input.IncomeBreakdown ||
                    this.IncomeBreakdown != null &&
                    input.IncomeBreakdown != null &&
                    this.IncomeBreakdown.SequenceEqual(input.IncomeBreakdown)
                ) && base.Equals(input) && 
                (
                    this.YtdEarnings == input.YtdEarnings ||
                    (this.YtdEarnings != null &&
                    this.YtdEarnings.Equals(input.YtdEarnings))
                ) && base.Equals(input) && 
                (
                    this.Verification == input.Verification ||
                    (this.Verification != null &&
                    this.Verification.Equals(input.Verification))
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
                if (this.Deductions != null)
                {
                    hashCode = (hashCode * 59) + this.Deductions.GetHashCode();
                }
                if (this.DocId != null)
                {
                    hashCode = (hashCode * 59) + this.DocId.GetHashCode();
                }
                if (this.Earnings != null)
                {
                    hashCode = (hashCode * 59) + this.Earnings.GetHashCode();
                }
                if (this.Employee != null)
                {
                    hashCode = (hashCode * 59) + this.Employee.GetHashCode();
                }
                if (this.Employer != null)
                {
                    hashCode = (hashCode * 59) + this.Employer.GetHashCode();
                }
                if (this.EmploymentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.EmploymentDetails.GetHashCode();
                }
                if (this.NetPay != null)
                {
                    hashCode = (hashCode * 59) + this.NetPay.GetHashCode();
                }
                if (this.PayPeriodDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PayPeriodDetails.GetHashCode();
                }
                if (this.PaystubDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PaystubDetails.GetHashCode();
                }
                if (this.IncomeBreakdown != null)
                {
                    hashCode = (hashCode * 59) + this.IncomeBreakdown.GetHashCode();
                }
                if (this.YtdEarnings != null)
                {
                    hashCode = (hashCode * 59) + this.YtdEarnings.GetHashCode();
                }
                if (this.Verification != null)
                {
                    hashCode = (hashCode * 59) + this.Verification.GetHashCode();
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
