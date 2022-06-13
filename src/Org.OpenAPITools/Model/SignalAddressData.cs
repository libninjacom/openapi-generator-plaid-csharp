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
    /// Data about the components comprising an address.
    /// </summary>
    [DataContract(Name = "SignalAddressData")]
    public partial class SignalAddressData : Dictionary<String, Object>, IEquatable<SignalAddressData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalAddressData" /> class.
        /// </summary>
        /// <param name="city">The full city name.</param>
        /// <param name="region">The region or state Example: &#x60;\&quot;NC\&quot;&#x60;.</param>
        /// <param name="street">The full street address Example: &#x60;\&quot;564 Main Street, APT 15\&quot;&#x60;.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="country">The ISO 3166-1 alpha-2 country code.</param>
        public SignalAddressData(string city = default(string), string region = default(string), string street = default(string), string postalCode = default(string), string country = default(string)) : base()
        {
            this.City = city;
            this.Region = region;
            this.Street = street;
            this.PostalCode = postalCode;
            this.Country = country;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The full city name
        /// </summary>
        /// <value>The full city name</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The region or state Example: &#x60;\&quot;NC\&quot;&#x60;
        /// </summary>
        /// <value>The region or state Example: &#x60;\&quot;NC\&quot;&#x60;</value>
        [DataMember(Name = "region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// The full street address Example: &#x60;\&quot;564 Main Street, APT 15\&quot;&#x60;
        /// </summary>
        /// <value>The full street address Example: &#x60;\&quot;564 Main Street, APT 15\&quot;&#x60;</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        /// <value>The postal code</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 country code</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

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
            sb.Append("class SignalAddressData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as SignalAddressData);
        }

        /// <summary>
        /// Returns true if SignalAddressData instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalAddressData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalAddressData input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && base.Equals(input) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && base.Equals(input) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && base.Equals(input) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && base.Equals(input) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
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
