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
    /// Describes a sweep of funds to / from the sweep account.  A sweep is associated with many sweep events (events of type &#x60;swept&#x60; or &#x60;reverse_swept&#x60;) which can be retrieved by invoking the &#x60;/transfer/event/list&#x60; endpoint with the corresponding &#x60;sweep_id&#x60;.  &#x60;swept&#x60; events occur when the transfer amount is credited or debited from your sweep account, depending on the &#x60;type&#x60; of the transfer. &#x60;reverse_swept&#x60; events occur when a transfer is reversed and Plaid undoes the credit or debit.  The total sum of the &#x60;swept&#x60; and &#x60;reverse_swept&#x60; events is equal to the &#x60;amount&#x60; of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.
    /// </summary>
    [DataContract(Name = "TransferSweep")]
    public partial class TransferSweep : Dictionary<String, Object>, IEquatable<TransferSweep>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferSweep" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferSweep()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferSweep" /> class.
        /// </summary>
        /// <param name="id">Identifier of the sweep. (required).</param>
        /// <param name="created">The datetime when the sweep occurred, in RFC 3339 format. (required).</param>
        /// <param name="amount">Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. \&quot;-10.00\&quot;)  If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced. (required).</param>
        /// <param name="isoCurrencyCode">The currency of the sweep, e.g. \&quot;USD\&quot;. (required).</param>
        public TransferSweep(string id = default(string), DateTime created = default(DateTime), string amount = default(string), string isoCurrencyCode = default(string)) : base()
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TransferSweep and cannot be null");
            }
            this.Id = id;
            this.Created = created;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TransferSweep and cannot be null");
            }
            this.Amount = amount;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for TransferSweep and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Identifier of the sweep.
        /// </summary>
        /// <value>Identifier of the sweep.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The datetime when the sweep occurred, in RFC 3339 format.
        /// </summary>
        /// <value>The datetime when the sweep occurred, in RFC 3339 format.</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. \&quot;-10.00\&quot;)  If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced.
        /// </summary>
        /// <value>Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. \&quot;-10.00\&quot;)  If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The currency of the sweep, e.g. \&quot;USD\&quot;.
        /// </summary>
        /// <value>The currency of the sweep, e.g. \&quot;USD\&quot;.</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = false)]
        public string IsoCurrencyCode { get; set; }

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
            sb.Append("class TransferSweep {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
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
            return this.Equals(input as TransferSweep);
        }

        /// <summary>
        /// Returns true if TransferSweep instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferSweep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferSweep input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
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