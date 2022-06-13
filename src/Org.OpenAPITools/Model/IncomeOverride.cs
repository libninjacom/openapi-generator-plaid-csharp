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
    /// Specify payroll data on the account.
    /// </summary>
    [DataContract(Name = "IncomeOverride")]
    public partial class IncomeOverride : IEquatable<IncomeOverride>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeOverride" /> class.
        /// </summary>
        /// <param name="paystubs">A list of paystubs associated with the account..</param>
        public IncomeOverride(List<PaystubOverride> paystubs = default(List<PaystubOverride>))
        {
            this.Paystubs = paystubs;
        }

        /// <summary>
        /// A list of paystubs associated with the account.
        /// </summary>
        /// <value>A list of paystubs associated with the account.</value>
        [DataMember(Name = "paystubs", EmitDefaultValue = false)]
        public List<PaystubOverride> Paystubs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IncomeOverride {\n");
            sb.Append("  Paystubs: ").Append(Paystubs).Append("\n");
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
            return this.Equals(input as IncomeOverride);
        }

        /// <summary>
        /// Returns true if IncomeOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeOverride input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Paystubs == input.Paystubs ||
                    this.Paystubs != null &&
                    input.Paystubs != null &&
                    this.Paystubs.SequenceEqual(input.Paystubs)
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
                if (this.Paystubs != null)
                {
                    hashCode = (hashCode * 59) + this.Paystubs.GetHashCode();
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
