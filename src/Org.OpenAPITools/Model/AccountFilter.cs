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
    /// Enumerates the account subtypes that the application wishes for the user to be able to select from. For more details refer to Plaid documentation on account filters.
    /// </summary>
    [DataContract(Name = "AccountFilter")]
    public partial class AccountFilter : IEquatable<AccountFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountFilter" /> class.
        /// </summary>
        /// <param name="depository">A list of account subtypes to be filtered..</param>
        /// <param name="credit">A list of account subtypes to be filtered..</param>
        /// <param name="loan">A list of account subtypes to be filtered..</param>
        /// <param name="investment">A list of account subtypes to be filtered..</param>
        public AccountFilter(List<string> depository = default(List<string>), List<string> credit = default(List<string>), List<string> loan = default(List<string>), List<string> investment = default(List<string>))
        {
            this.Depository = depository;
            this.Credit = credit;
            this.Loan = loan;
            this.Investment = investment;
        }

        /// <summary>
        /// A list of account subtypes to be filtered.
        /// </summary>
        /// <value>A list of account subtypes to be filtered.</value>
        [DataMember(Name = "depository", EmitDefaultValue = false)]
        public List<string> Depository { get; set; }

        /// <summary>
        /// A list of account subtypes to be filtered.
        /// </summary>
        /// <value>A list of account subtypes to be filtered.</value>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public List<string> Credit { get; set; }

        /// <summary>
        /// A list of account subtypes to be filtered.
        /// </summary>
        /// <value>A list of account subtypes to be filtered.</value>
        [DataMember(Name = "loan", EmitDefaultValue = false)]
        public List<string> Loan { get; set; }

        /// <summary>
        /// A list of account subtypes to be filtered.
        /// </summary>
        /// <value>A list of account subtypes to be filtered.</value>
        [DataMember(Name = "investment", EmitDefaultValue = false)]
        public List<string> Investment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountFilter {\n");
            sb.Append("  Depository: ").Append(Depository).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Loan: ").Append(Loan).Append("\n");
            sb.Append("  Investment: ").Append(Investment).Append("\n");
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
            return this.Equals(input as AccountFilter);
        }

        /// <summary>
        /// Returns true if AccountFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Depository == input.Depository ||
                    this.Depository != null &&
                    input.Depository != null &&
                    this.Depository.SequenceEqual(input.Depository)
                ) && 
                (
                    this.Credit == input.Credit ||
                    this.Credit != null &&
                    input.Credit != null &&
                    this.Credit.SequenceEqual(input.Credit)
                ) && 
                (
                    this.Loan == input.Loan ||
                    this.Loan != null &&
                    input.Loan != null &&
                    this.Loan.SequenceEqual(input.Loan)
                ) && 
                (
                    this.Investment == input.Investment ||
                    this.Investment != null &&
                    input.Investment != null &&
                    this.Investment.SequenceEqual(input.Investment)
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
