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
    /// An object representing data from a paystub.
    /// </summary>
    [DataContract(Name = "PaystubOverride")]
    public partial class PaystubOverride : IEquatable<PaystubOverride>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaystubOverride" /> class.
        /// </summary>
        /// <param name="employer">employer.</param>
        /// <param name="employee">employee.</param>
        /// <param name="incomeBreakdown">incomeBreakdown.</param>
        /// <param name="payPeriodDetails">payPeriodDetails.</param>
        public PaystubOverride(PaystubOverrideEmployer employer = default(PaystubOverrideEmployer), PaystubOverrideEmployee employee = default(PaystubOverrideEmployee), List<IncomeBreakdown> incomeBreakdown = default(List<IncomeBreakdown>), PayPeriodDetails payPeriodDetails = default(PayPeriodDetails))
        {
            this.Employer = employer;
            this.Employee = employee;
            this.IncomeBreakdown = incomeBreakdown;
            this.PayPeriodDetails = payPeriodDetails;
        }

        /// <summary>
        /// Gets or Sets Employer
        /// </summary>
        [DataMember(Name = "employer", EmitDefaultValue = false)]
        public PaystubOverrideEmployer Employer { get; set; }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public PaystubOverrideEmployee Employee { get; set; }

        /// <summary>
        /// Gets or Sets IncomeBreakdown
        /// </summary>
        [DataMember(Name = "income_breakdown", EmitDefaultValue = false)]
        public List<IncomeBreakdown> IncomeBreakdown { get; set; }

        /// <summary>
        /// Gets or Sets PayPeriodDetails
        /// </summary>
        [DataMember(Name = "pay_period_details", EmitDefaultValue = false)]
        public PayPeriodDetails PayPeriodDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaystubOverride {\n");
            sb.Append("  Employer: ").Append(Employer).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  IncomeBreakdown: ").Append(IncomeBreakdown).Append("\n");
            sb.Append("  PayPeriodDetails: ").Append(PayPeriodDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as PaystubOverride);
        }

        /// <summary>
        /// Returns true if PaystubOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of PaystubOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaystubOverride input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Employer == input.Employer ||
                    (this.Employer != null &&
                    this.Employer.Equals(input.Employer))
                ) && 
                (
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && 
                (
                    this.IncomeBreakdown == input.IncomeBreakdown ||
                    this.IncomeBreakdown != null &&
                    input.IncomeBreakdown != null &&
                    this.IncomeBreakdown.SequenceEqual(input.IncomeBreakdown)
                ) && 
                (
                    this.PayPeriodDetails == input.PayPeriodDetails ||
                    (this.PayPeriodDetails != null &&
                    this.PayPeriodDetails.Equals(input.PayPeriodDetails))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Employer != null)
                {
                    hashCode = (hashCode * 59) + this.Employer.GetHashCode();
                }
                if (this.Employee != null)
                {
                    hashCode = (hashCode * 59) + this.Employee.GetHashCode();
                }
                if (this.IncomeBreakdown != null)
                {
                    hashCode = (hashCode * 59) + this.IncomeBreakdown.GetHashCode();
                }
                if (this.PayPeriodDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PayPeriodDetails.GetHashCode();
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
