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
    /// Information about the balance of a bank transfer
    /// </summary>
    [DataContract(Name = "BankTransferBalance")]
    public partial class BankTransferBalance : Dictionary<String, Object>, IEquatable<BankTransferBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BankTransferBalance()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferBalance" /> class.
        /// </summary>
        /// <param name="available">The total available balance - the sum of all successful debit transfer amounts minus all credit transfer amounts. (required).</param>
        /// <param name="transactable">The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance. (required).</param>
        public BankTransferBalance(string available = default(string), string transactable = default(string)) : base()
        {
            // to ensure "available" is required (not null)
            if (available == null)
            {
                throw new ArgumentNullException("available is a required property for BankTransferBalance and cannot be null");
            }
            this.Available = available;
            // to ensure "transactable" is required (not null)
            if (transactable == null)
            {
                throw new ArgumentNullException("transactable is a required property for BankTransferBalance and cannot be null");
            }
            this.Transactable = transactable;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The total available balance - the sum of all successful debit transfer amounts minus all credit transfer amounts.
        /// </summary>
        /// <value>The total available balance - the sum of all successful debit transfer amounts minus all credit transfer amounts.</value>
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = false)]
        public string Available { get; set; }

        /// <summary>
        /// The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.
        /// </summary>
        /// <value>The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.</value>
        [DataMember(Name = "transactable", IsRequired = true, EmitDefaultValue = false)]
        public string Transactable { get; set; }

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
            sb.Append("class BankTransferBalance {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Transactable: ").Append(Transactable).Append("\n");
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
            return this.Equals(input as BankTransferBalance);
        }

        /// <summary>
        /// Returns true if BankTransferBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of BankTransferBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankTransferBalance input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && base.Equals(input) && 
                (
                    this.Transactable == input.Transactable ||
                    (this.Transactable != null &&
                    this.Transactable.Equals(input.Transactable))
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
                if (this.Available != null)
                {
                    hashCode = (hashCode * 59) + this.Available.GetHashCode();
                }
                if (this.Transactable != null)
                {
                    hashCode = (hashCode * 59) + this.Transactable.GetHashCode();
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