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
    /// InstitutionsSearchRequest defines the request schema for &#x60;/institutions/search&#x60;
    /// </summary>
    [DataContract(Name = "InstitutionsSearchRequest")]
    public partial class InstitutionsSearchRequest : IEquatable<InstitutionsSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstitutionsSearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsSearchRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="query">The search query. Institutions with names matching the query are returned (required).</param>
        /// <param name="products">Filter the Institutions based on whether they support all products listed in &#x60;products&#x60;. Provide &#x60;null&#x60; to get institutions regardless of supported products. Note that when &#x60;auth&#x60; is specified as a product, if you are enabled for Instant Match or Automated Micro-deposits, institutions that support those products will be returned even if &#x60;auth&#x60; is not present in their product array. (required).</param>
        /// <param name="countryCodes">Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard. In API versions 2019-05-29 and earlier, the &#x60;country_codes&#x60; parameter is an optional parameter within the &#x60;options&#x60; object and will default to &#x60;[US]&#x60; if it is not supplied.  (required).</param>
        /// <param name="options">options.</param>
        public InstitutionsSearchRequest(string clientId = default(string), string secret = default(string), string query = default(string), List<Products> products = default(List<Products>), List<CountryCode> countryCodes = default(List<CountryCode>), InstitutionsSearchRequestOptions options = default(InstitutionsSearchRequestOptions))
        {
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new ArgumentNullException("query is a required property for InstitutionsSearchRequest and cannot be null");
            }
            this.Query = query;
            // to ensure "products" is required (not null)
            if (products == null)
            {
                throw new ArgumentNullException("products is a required property for InstitutionsSearchRequest and cannot be null");
            }
            this.Products = products;
            // to ensure "countryCodes" is required (not null)
            if (countryCodes == null)
            {
                throw new ArgumentNullException("countryCodes is a required property for InstitutionsSearchRequest and cannot be null");
            }
            this.CountryCodes = countryCodes;
            this.ClientId = clientId;
            this.Secret = secret;
            this.Options = options;
        }

        /// <summary>
        /// Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// The search query. Institutions with names matching the query are returned
        /// </summary>
        /// <value>The search query. Institutions with names matching the query are returned</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Filter the Institutions based on whether they support all products listed in &#x60;products&#x60;. Provide &#x60;null&#x60; to get institutions regardless of supported products. Note that when &#x60;auth&#x60; is specified as a product, if you are enabled for Instant Match or Automated Micro-deposits, institutions that support those products will be returned even if &#x60;auth&#x60; is not present in their product array.
        /// </summary>
        /// <value>Filter the Institutions based on whether they support all products listed in &#x60;products&#x60;. Provide &#x60;null&#x60; to get institutions regardless of supported products. Note that when &#x60;auth&#x60; is specified as a product, if you are enabled for Instant Match or Automated Micro-deposits, institutions that support those products will be returned even if &#x60;auth&#x60; is not present in their product array.</value>
        [DataMember(Name = "products", IsRequired = true, EmitDefaultValue = true)]
        public List<Products> Products { get; set; }

        /// <summary>
        /// Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard. In API versions 2019-05-29 and earlier, the &#x60;country_codes&#x60; parameter is an optional parameter within the &#x60;options&#x60; object and will default to &#x60;[US]&#x60; if it is not supplied. 
        /// </summary>
        /// <value>Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard. In API versions 2019-05-29 and earlier, the &#x60;country_codes&#x60; parameter is an optional parameter within the &#x60;options&#x60; object and will default to &#x60;[US]&#x60; if it is not supplied. </value>
        [DataMember(Name = "country_codes", IsRequired = true, EmitDefaultValue = false)]
        public List<CountryCode> CountryCodes { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public InstitutionsSearchRequestOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstitutionsSearchRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  CountryCodes: ").Append(CountryCodes).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as InstitutionsSearchRequest);
        }

        /// <summary>
        /// Returns true if InstitutionsSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionsSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionsSearchRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && 
                (
                    this.CountryCodes == input.CountryCodes ||
                    this.CountryCodes != null &&
                    input.CountryCodes != null &&
                    this.CountryCodes.SequenceEqual(input.CountryCodes)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
                }
                if (this.Products != null)
                {
                    hashCode = (hashCode * 59) + this.Products.GetHashCode();
                }
                if (this.CountryCodes != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCodes.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
            // Query (string) minLength
            if (this.Query != null && this.Query.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Query, length must be greater than 1.", new [] { "Query" });
            }

            yield break;
        }
    }

}
