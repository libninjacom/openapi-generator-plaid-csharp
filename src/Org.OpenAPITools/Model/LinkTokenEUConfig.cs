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
    /// Configuration parameters for EU flows
    /// </summary>
    [DataContract(Name = "LinkTokenEUConfig")]
    public partial class LinkTokenEUConfig : IEquatable<LinkTokenEUConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkTokenEUConfig" /> class.
        /// </summary>
        /// <param name="headless">If &#x60;true&#x60;, open Link without an initial UI. Defaults to &#x60;false&#x60;..</param>
        public LinkTokenEUConfig(bool headless = default(bool))
        {
            this.Headless = headless;
        }

        /// <summary>
        /// If &#x60;true&#x60;, open Link without an initial UI. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>If &#x60;true&#x60;, open Link without an initial UI. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "headless", EmitDefaultValue = true)]
        public bool Headless { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkTokenEUConfig {\n");
            sb.Append("  Headless: ").Append(Headless).Append("\n");
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
            return this.Equals(input as LinkTokenEUConfig);
        }

        /// <summary>
        /// Returns true if LinkTokenEUConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkTokenEUConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkTokenEUConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Headless == input.Headless ||
                    this.Headless.Equals(input.Headless)
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
                hashCode = (hashCode * 59) + this.Headless.GetHashCode();
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
