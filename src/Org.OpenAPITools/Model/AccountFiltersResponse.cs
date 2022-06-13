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
    /// The &#x60;account_filters&#x60; specified in the original call to &#x60;/link/token/create&#x60;. 
    /// </summary>
    [DataContract(Name = "AccountFiltersResponse")]
    public partial class AccountFiltersResponse : Dictionary<String, Object>, IEquatable<AccountFiltersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountFiltersResponse" /> class.
        /// </summary>
        /// <param name="depository">depository.</param>
        /// <param name="credit">credit.</param>
        /// <param name="loan">loan.</param>
        /// <param name="investment">investment.</param>
        public AccountFiltersResponse(DepositoryFilter depository = default(DepositoryFilter), CreditFilter credit = default(CreditFilter), LoanFilter loan = default(LoanFilter), InvestmentFilter investment = default(InvestmentFilter)) : base()
        {
            this.Depository = depository;
            this.Credit = credit;
            this.Loan = loan;
            this.Investment = investment;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Depository
        /// </summary>
        [DataMember(Name = "depository", EmitDefaultValue = false)]
        public DepositoryFilter Depository { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public CreditFilter Credit { get; set; }

        /// <summary>
        /// Gets or Sets Loan
        /// </summary>
        [DataMember(Name = "loan", EmitDefaultValue = false)]
        public LoanFilter Loan { get; set; }

        /// <summary>
        /// Gets or Sets Investment
        /// </summary>
        [DataMember(Name = "investment", EmitDefaultValue = false)]
        public InvestmentFilter Investment { get; set; }

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
            sb.Append("class AccountFiltersResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Depository: ").Append(Depository).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Loan: ").Append(Loan).Append("\n");
            sb.Append("  Investment: ").Append(Investment).Append("\n");
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
            return this.Equals(input as AccountFiltersResponse);
        }

        /// <summary>
        /// Returns true if AccountFiltersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountFiltersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountFiltersResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Depository == input.Depository ||
                    (this.Depository != null &&
                    this.Depository.Equals(input.Depository))
                ) && base.Equals(input) && 
                (
                    this.Credit == input.Credit ||
                    (this.Credit != null &&
                    this.Credit.Equals(input.Credit))
                ) && base.Equals(input) && 
                (
                    this.Loan == input.Loan ||
                    (this.Loan != null &&
                    this.Loan.Equals(input.Loan))
                ) && base.Equals(input) && 
                (
                    this.Investment == input.Investment ||
                    (this.Investment != null &&
                    this.Investment.Equals(input.Investment))
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
                if (this.Depository != null)
                {
                    hashCode = (hashCode * 59) + this.Depository.GetHashCode();
                }
                if (this.Credit != null)
                {
                    hashCode = (hashCode * 59) + this.Credit.GetHashCode();
                }
                if (this.Loan != null)
                {
                    hashCode = (hashCode * 59) + this.Loan.GetHashCode();
                }
                if (this.Investment != null)
                {
                    hashCode = (hashCode * 59) + this.Investment.GetHashCode();
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
