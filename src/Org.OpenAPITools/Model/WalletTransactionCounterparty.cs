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
    /// An object representing the e-wallet transaction&#39;s counterparty
    /// </summary>
    [DataContract(Name = "WalletTransactionCounterparty")]
    public partial class WalletTransactionCounterparty : Dictionary<String, Object>, IEquatable<WalletTransactionCounterparty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionCounterparty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletTransactionCounterparty()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionCounterparty" /> class.
        /// </summary>
        /// <param name="name">The name of the counterparty (required).</param>
        /// <param name="numbers">numbers (required).</param>
        public WalletTransactionCounterparty(string name = default(string), WalletTransactionCounterpartyNumbers numbers = default(WalletTransactionCounterpartyNumbers)) : base()
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WalletTransactionCounterparty and cannot be null");
            }
            this.Name = name;
            // to ensure "numbers" is required (not null)
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers is a required property for WalletTransactionCounterparty and cannot be null");
            }
            this.Numbers = numbers;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The name of the counterparty
        /// </summary>
        /// <value>The name of the counterparty</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Numbers
        /// </summary>
        [DataMember(Name = "numbers", IsRequired = true, EmitDefaultValue = false)]
        public WalletTransactionCounterpartyNumbers Numbers { get; set; }

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
            sb.Append("class WalletTransactionCounterparty {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
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
            return this.Equals(input as WalletTransactionCounterparty);
        }

        /// <summary>
        /// Returns true if WalletTransactionCounterparty instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletTransactionCounterparty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTransactionCounterparty input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Numbers == input.Numbers ||
                    (this.Numbers != null &&
                    this.Numbers.Equals(input.Numbers))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Numbers != null)
                {
                    hashCode = (hashCode * 59) + this.Numbers.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
