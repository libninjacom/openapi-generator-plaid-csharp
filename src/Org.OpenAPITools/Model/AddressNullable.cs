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
    /// A physical mailing address.
    /// </summary>
    [DataContract(Name = "AddressNullable")]
    public partial class AddressNullable : IEquatable<AddressNullable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressNullable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressNullable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressNullable" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="primary">When &#x60;true&#x60;, identifies the address as the primary address on an account..</param>
        public AddressNullable(AddressData data = default(AddressData), bool primary = default(bool))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AddressNullable and cannot be null");
            }
            this.Data = data;
            this.Primary = primary;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public AddressData Data { get; set; }

        /// <summary>
        /// When &#x60;true&#x60;, identifies the address as the primary address on an account.
        /// </summary>
        /// <value>When &#x60;true&#x60;, identifies the address as the primary address on an account.</value>
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public bool Primary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressNullable {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
            return this.Equals(input as AddressNullable);
        }

        /// <summary>
        /// Returns true if AddressNullable instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressNullable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressNullable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Primary == input.Primary ||
                    this.Primary.Equals(input.Primary)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Primary.GetHashCode();
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