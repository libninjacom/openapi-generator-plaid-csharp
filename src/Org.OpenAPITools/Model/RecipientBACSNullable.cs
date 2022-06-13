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
    /// An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.
    /// </summary>
    [DataContract(Name = "RecipientBACSNullable")]
    public partial class RecipientBACSNullable : IEquatable<RecipientBACSNullable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientBACSNullable" /> class.
        /// </summary>
        /// <param name="account">The account number of the account. Maximum of 10 characters..</param>
        /// <param name="sortCode">The 6-character sort code of the account..</param>
        public RecipientBACSNullable(string account = default(string), string sortCode = default(string))
        {
            this.Account = account;
            this.SortCode = sortCode;
        }

        /// <summary>
        /// The account number of the account. Maximum of 10 characters.
        /// </summary>
        /// <value>The account number of the account. Maximum of 10 characters.</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// The 6-character sort code of the account.
        /// </summary>
        /// <value>The 6-character sort code of the account.</value>
        [DataMember(Name = "sort_code", EmitDefaultValue = false)]
        public string SortCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecipientBACSNullable {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  SortCode: ").Append(SortCode).Append("\n");
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
            return this.Equals(input as RecipientBACSNullable);
        }

        /// <summary>
        /// Returns true if RecipientBACSNullable instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipientBACSNullable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientBACSNullable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.SortCode == input.SortCode ||
                    (this.SortCode != null &&
                    this.SortCode.Equals(input.SortCode))
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.SortCode != null)
                {
                    hashCode = (hashCode * 59) + this.SortCode.GetHashCode();
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
            // Account (string) maxLength
            if (this.Account != null && this.Account.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be less than 10.", new [] { "Account" });
            }

            // Account (string) minLength
            if (this.Account != null && this.Account.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be greater than 1.", new [] { "Account" });
            }

            // SortCode (string) maxLength
            if (this.SortCode != null && this.SortCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortCode, length must be less than 6.", new [] { "SortCode" });
            }

            // SortCode (string) minLength
            if (this.SortCode != null && this.SortCode.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortCode, length must be greater than 6.", new [] { "SortCode" });
            }

            yield break;
        }
    }

}
