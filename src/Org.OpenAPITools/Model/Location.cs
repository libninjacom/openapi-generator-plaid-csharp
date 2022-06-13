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
    /// A representation of where a transaction took place
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : Dictionary<String, Object>, IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Location()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="address">The street address where the transaction occurred. (required).</param>
        /// <param name="city">The city where the transaction occurred. (required).</param>
        /// <param name="region">The region or state where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called &#x60;state&#x60;. (required).</param>
        /// <param name="postalCode">The postal code where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called &#x60;zip&#x60;. (required).</param>
        /// <param name="country">The ISO 3166-1 alpha-2 country code where the transaction occurred. (required).</param>
        /// <param name="lat">The latitude where the transaction occurred. (required).</param>
        /// <param name="lon">The longitude where the transaction occurred. (required).</param>
        /// <param name="storeNumber">The merchant defined store number where the transaction occurred. (required).</param>
        public Location(string address = default(string), string city = default(string), string region = default(string), string postalCode = default(string), string country = default(string), decimal? lat = default(decimal?), decimal? lon = default(decimal?), string storeNumber = default(string)) : base()
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Location and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Location and cannot be null");
            }
            this.City = city;
            // to ensure "region" is required (not null)
            if (region == null)
            {
                throw new ArgumentNullException("region is a required property for Location and cannot be null");
            }
            this.Region = region;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for Location and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for Location and cannot be null");
            }
            this.Country = country;
            // to ensure "lat" is required (not null)
            if (lat == null)
            {
                throw new ArgumentNullException("lat is a required property for Location and cannot be null");
            }
            this.Lat = lat;
            // to ensure "lon" is required (not null)
            if (lon == null)
            {
                throw new ArgumentNullException("lon is a required property for Location and cannot be null");
            }
            this.Lon = lon;
            // to ensure "storeNumber" is required (not null)
            if (storeNumber == null)
            {
                throw new ArgumentNullException("storeNumber is a required property for Location and cannot be null");
            }
            this.StoreNumber = storeNumber;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The street address where the transaction occurred.
        /// </summary>
        /// <value>The street address where the transaction occurred.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The city where the transaction occurred.
        /// </summary>
        /// <value>The city where the transaction occurred.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The region or state where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called &#x60;state&#x60;.
        /// </summary>
        /// <value>The region or state where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called &#x60;state&#x60;.</value>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// The postal code where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called &#x60;zip&#x60;.
        /// </summary>
        /// <value>The postal code where the transaction occurred. In API versions 2018-05-22 and earlier, this field is called &#x60;zip&#x60;.</value>
        [DataMember(Name = "postal_code", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code where the transaction occurred.
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 country code where the transaction occurred.</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The latitude where the transaction occurred.
        /// </summary>
        /// <value>The latitude where the transaction occurred.</value>
        [DataMember(Name = "lat", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Lat { get; set; }

        /// <summary>
        /// The longitude where the transaction occurred.
        /// </summary>
        /// <value>The longitude where the transaction occurred.</value>
        [DataMember(Name = "lon", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Lon { get; set; }

        /// <summary>
        /// The merchant defined store number where the transaction occurred.
        /// </summary>
        /// <value>The merchant defined store number where the transaction occurred.</value>
        [DataMember(Name = "store_number", IsRequired = true, EmitDefaultValue = true)]
        public string StoreNumber { get; set; }

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
            sb.Append("class Location {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
            sb.Append("  StoreNumber: ").Append(StoreNumber).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && base.Equals(input) && 
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
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && base.Equals(input) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && base.Equals(input) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && base.Equals(input) && 
                (
                    this.Lon == input.Lon ||
                    (this.Lon != null &&
                    this.Lon.Equals(input.Lon))
                ) && base.Equals(input) && 
                (
                    this.StoreNumber == input.StoreNumber ||
                    (this.StoreNumber != null &&
                    this.StoreNumber.Equals(input.StoreNumber))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Lat != null)
                {
                    hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                }
                if (this.Lon != null)
                {
                    hashCode = (hashCode * 59) + this.Lon.GetHashCode();
                }
                if (this.StoreNumber != null)
                {
                    hashCode = (hashCode * 59) + this.StoreNumber.GetHashCode();
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