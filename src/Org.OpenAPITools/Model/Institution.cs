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
    /// Details relating to a specific financial institution
    /// </summary>
    [DataContract(Name = "Institution")]
    public partial class Institution : Dictionary<String, Object>, IEquatable<Institution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Institution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Institution()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Institution" /> class.
        /// </summary>
        /// <param name="institutionId">Unique identifier for the institution (required).</param>
        /// <param name="name">The official name of the institution (required).</param>
        /// <param name="products">A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return &#x60;auth&#x60; in the product array; institutions that do not list &#x60;auth&#x60; may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. To identify institutions that support those methods, use the &#x60;auth_metadata&#x60; object. For more details, see [Full Auth coverage](https://plaid.com/docs/auth/coverage/). (required).</param>
        /// <param name="countryCodes">A list of the country codes supported by the institution. (required).</param>
        /// <param name="url">The URL for the institution&#39;s website.</param>
        /// <param name="primaryColor">Hexadecimal representation of the primary color used by the institution.</param>
        /// <param name="logo">Base64 encoded representation of the institution&#39;s logo.</param>
        /// <param name="routingNumbers">A partial list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution. (required).</param>
        /// <param name="oauth">Indicates that the institution has an OAuth login flow. (required).</param>
        /// <param name="status">status.</param>
        /// <param name="paymentInitiationMetadata">paymentInitiationMetadata.</param>
        /// <param name="authMetadata">authMetadata.</param>
        public Institution(string institutionId = default(string), string name = default(string), List<Products> products = default(List<Products>), List<CountryCode> countryCodes = default(List<CountryCode>), string url = default(string), string primaryColor = default(string), string logo = default(string), List<string> routingNumbers = default(List<string>), bool oauth = default(bool), InstitutionStatus status = default(InstitutionStatus), PaymentInitiationMetadata paymentInitiationMetadata = default(PaymentInitiationMetadata), AuthMetadata authMetadata = default(AuthMetadata)) : base()
        {
            // to ensure "institutionId" is required (not null)
            if (institutionId == null)
            {
                throw new ArgumentNullException("institutionId is a required property for Institution and cannot be null");
            }
            this.InstitutionId = institutionId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Institution and cannot be null");
            }
            this.Name = name;
            // to ensure "products" is required (not null)
            if (products == null)
            {
                throw new ArgumentNullException("products is a required property for Institution and cannot be null");
            }
            this.Products = products;
            // to ensure "countryCodes" is required (not null)
            if (countryCodes == null)
            {
                throw new ArgumentNullException("countryCodes is a required property for Institution and cannot be null");
            }
            this.CountryCodes = countryCodes;
            // to ensure "routingNumbers" is required (not null)
            if (routingNumbers == null)
            {
                throw new ArgumentNullException("routingNumbers is a required property for Institution and cannot be null");
            }
            this.RoutingNumbers = routingNumbers;
            this.Oauth = oauth;
            this.Url = url;
            this.PrimaryColor = primaryColor;
            this.Logo = logo;
            this.Status = status;
            this.PaymentInitiationMetadata = paymentInitiationMetadata;
            this.AuthMetadata = authMetadata;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Unique identifier for the institution
        /// </summary>
        /// <value>Unique identifier for the institution</value>
        [DataMember(Name = "institution_id", IsRequired = true, EmitDefaultValue = false)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// The official name of the institution
        /// </summary>
        /// <value>The official name of the institution</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return &#x60;auth&#x60; in the product array; institutions that do not list &#x60;auth&#x60; may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. To identify institutions that support those methods, use the &#x60;auth_metadata&#x60; object. For more details, see [Full Auth coverage](https://plaid.com/docs/auth/coverage/).
        /// </summary>
        /// <value>A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return &#x60;auth&#x60; in the product array; institutions that do not list &#x60;auth&#x60; may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. To identify institutions that support those methods, use the &#x60;auth_metadata&#x60; object. For more details, see [Full Auth coverage](https://plaid.com/docs/auth/coverage/).</value>
        [DataMember(Name = "products", IsRequired = true, EmitDefaultValue = false)]
        public List<Products> Products { get; set; }

        /// <summary>
        /// A list of the country codes supported by the institution.
        /// </summary>
        /// <value>A list of the country codes supported by the institution.</value>
        [DataMember(Name = "country_codes", IsRequired = true, EmitDefaultValue = false)]
        public List<CountryCode> CountryCodes { get; set; }

        /// <summary>
        /// The URL for the institution&#39;s website
        /// </summary>
        /// <value>The URL for the institution&#39;s website</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Hexadecimal representation of the primary color used by the institution
        /// </summary>
        /// <value>Hexadecimal representation of the primary color used by the institution</value>
        [DataMember(Name = "primary_color", EmitDefaultValue = true)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// Base64 encoded representation of the institution&#39;s logo
        /// </summary>
        /// <value>Base64 encoded representation of the institution&#39;s logo</value>
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public string Logo { get; set; }

        /// <summary>
        /// A partial list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution.
        /// </summary>
        /// <value>A partial list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution.</value>
        [DataMember(Name = "routing_numbers", IsRequired = true, EmitDefaultValue = false)]
        public List<string> RoutingNumbers { get; set; }

        /// <summary>
        /// Indicates that the institution has an OAuth login flow.
        /// </summary>
        /// <value>Indicates that the institution has an OAuth login flow.</value>
        [DataMember(Name = "oauth", IsRequired = true, EmitDefaultValue = true)]
        public bool Oauth { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public InstitutionStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInitiationMetadata
        /// </summary>
        [DataMember(Name = "payment_initiation_metadata", EmitDefaultValue = true)]
        public PaymentInitiationMetadata PaymentInitiationMetadata { get; set; }

        /// <summary>
        /// Gets or Sets AuthMetadata
        /// </summary>
        [DataMember(Name = "auth_metadata", EmitDefaultValue = true)]
        public AuthMetadata AuthMetadata { get; set; }

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
            sb.Append("class Institution {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  CountryCodes: ").Append(CountryCodes).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  RoutingNumbers: ").Append(RoutingNumbers).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentInitiationMetadata: ").Append(PaymentInitiationMetadata).Append("\n");
            sb.Append("  AuthMetadata: ").Append(AuthMetadata).Append("\n");
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
            return this.Equals(input as Institution);
        }

        /// <summary>
        /// Returns true if Institution instances are equal
        /// </summary>
        /// <param name="input">Instance of Institution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Institution input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && base.Equals(input) && 
                (
                    this.CountryCodes == input.CountryCodes ||
                    this.CountryCodes != null &&
                    input.CountryCodes != null &&
                    this.CountryCodes.SequenceEqual(input.CountryCodes)
                ) && base.Equals(input) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && base.Equals(input) && 
                (
                    this.PrimaryColor == input.PrimaryColor ||
                    (this.PrimaryColor != null &&
                    this.PrimaryColor.Equals(input.PrimaryColor))
                ) && base.Equals(input) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && base.Equals(input) && 
                (
                    this.RoutingNumbers == input.RoutingNumbers ||
                    this.RoutingNumbers != null &&
                    input.RoutingNumbers != null &&
                    this.RoutingNumbers.SequenceEqual(input.RoutingNumbers)
                ) && base.Equals(input) && 
                (
                    this.Oauth == input.Oauth ||
                    this.Oauth.Equals(input.Oauth)
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.PaymentInitiationMetadata == input.PaymentInitiationMetadata ||
                    (this.PaymentInitiationMetadata != null &&
                    this.PaymentInitiationMetadata.Equals(input.PaymentInitiationMetadata))
                ) && base.Equals(input) && 
                (
                    this.AuthMetadata == input.AuthMetadata ||
                    (this.AuthMetadata != null &&
                    this.AuthMetadata.Equals(input.AuthMetadata))
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
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Products != null)
                {
                    hashCode = (hashCode * 59) + this.Products.GetHashCode();
                }
                if (this.CountryCodes != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCodes.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.PrimaryColor != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryColor.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.RoutingNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumbers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Oauth.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.PaymentInitiationMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInitiationMetadata.GetHashCode();
                }
                if (this.AuthMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.AuthMetadata.GetHashCode();
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
