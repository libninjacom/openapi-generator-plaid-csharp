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
    /// An optional object to filter &#x60;/liabilities/get&#x60; results. If provided, &#x60;options&#x60; cannot be null.
    /// </summary>
    [DataContract(Name = "LiabilitiesGetRequestOptions")]
    public partial class LiabilitiesGetRequestOptions : IEquatable<LiabilitiesGetRequestOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiabilitiesGetRequestOptions" /> class.
        /// </summary>
        /// <param name="accountIds">A list of accounts to retrieve for the Item.  An error will be returned if a provided &#x60;account_id&#x60; is not associated with the Item.</param>
        public LiabilitiesGetRequestOptions(List<string> accountIds = default(List<string>))
        {
            this.AccountIds = accountIds;
        }

        /// <summary>
        /// A list of accounts to retrieve for the Item.  An error will be returned if a provided &#x60;account_id&#x60; is not associated with the Item
        /// </summary>
        /// <value>A list of accounts to retrieve for the Item.  An error will be returned if a provided &#x60;account_id&#x60; is not associated with the Item</value>
        [DataMember(Name = "account_ids", EmitDefaultValue = false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiabilitiesGetRequestOptions {\n");
            sb.Append("  AccountIds: ").Append(AccountIds).Append("\n");
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
            return this.Equals(input as LiabilitiesGetRequestOptions);
        }

        /// <summary>
        /// Returns true if LiabilitiesGetRequestOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of LiabilitiesGetRequestOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiabilitiesGetRequestOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountIds == input.AccountIds ||
                    this.AccountIds != null &&
                    input.AccountIds != null &&
                    this.AccountIds.SequenceEqual(input.AccountIds)
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
                if (this.AccountIds != null)
                {
                    hashCode = (hashCode * 59) + this.AccountIds.GetHashCode();
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
