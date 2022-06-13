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
    /// The counterparty&#39;s bank account numbers
    /// </summary>
    [DataContract(Name = "WalletTransactionCounterpartyNumbers")]
    public partial class WalletTransactionCounterpartyNumbers : IEquatable<WalletTransactionCounterpartyNumbers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionCounterpartyNumbers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletTransactionCounterpartyNumbers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionCounterpartyNumbers" /> class.
        /// </summary>
        /// <param name="bacs">bacs (required).</param>
        public WalletTransactionCounterpartyNumbers(WalletTransactionCounterpartyBACS bacs = default(WalletTransactionCounterpartyBACS))
        {
            // to ensure "bacs" is required (not null)
            if (bacs == null)
            {
                throw new ArgumentNullException("bacs is a required property for WalletTransactionCounterpartyNumbers and cannot be null");
            }
            this.Bacs = bacs;
        }

        /// <summary>
        /// Gets or Sets Bacs
        /// </summary>
        [DataMember(Name = "bacs", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionCounterpartyBACS Bacs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletTransactionCounterpartyNumbers {\n");
            sb.Append("  Bacs: ").Append(Bacs).Append("\n");
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
            return this.Equals(input as WalletTransactionCounterpartyNumbers);
        }

        /// <summary>
        /// Returns true if WalletTransactionCounterpartyNumbers instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletTransactionCounterpartyNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTransactionCounterpartyNumbers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bacs == input.Bacs ||
                    (this.Bacs != null &&
                    this.Bacs.Equals(input.Bacs))
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
                if (this.Bacs != null)
                {
                    hashCode = (hashCode * 59) + this.Bacs.GetHashCode();
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
