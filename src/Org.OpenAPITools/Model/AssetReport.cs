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
    /// An object representing an Asset Report
    /// </summary>
    [DataContract(Name = "AssetReport")]
    public partial class AssetReport : Dictionary<String, Object>, IEquatable<AssetReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetReport()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReport" /> class.
        /// </summary>
        /// <param name="assetReportId">A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive. (required).</param>
        /// <param name="clientReportId">An identifier you determine and submit for the Asset Report. (required).</param>
        /// <param name="dateGenerated">The date and time when the Asset Report was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (e.g. \&quot;2018-04-12T03:32:11Z\&quot;). (required).</param>
        /// <param name="daysRequested">The duration of transaction history you requested (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="items">Data returned by Plaid about each of the Items included in the Asset Report. (required).</param>
        public AssetReport(string assetReportId = default(string), string clientReportId = default(string), DateTime dateGenerated = default(DateTime), decimal daysRequested = default(decimal), AssetReportUser user = default(AssetReportUser), List<AssetReportItem> items = default(List<AssetReportItem>)) : base()
        {
            // to ensure "assetReportId" is required (not null)
            if (assetReportId == null)
            {
                throw new ArgumentNullException("assetReportId is a required property for AssetReport and cannot be null");
            }
            this.AssetReportId = assetReportId;
            // to ensure "clientReportId" is required (not null)
            if (clientReportId == null)
            {
                throw new ArgumentNullException("clientReportId is a required property for AssetReport and cannot be null");
            }
            this.ClientReportId = clientReportId;
            this.DateGenerated = dateGenerated;
            this.DaysRequested = daysRequested;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for AssetReport and cannot be null");
            }
            this.User = user;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for AssetReport and cannot be null");
            }
            this.Items = items;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.
        /// </summary>
        /// <value>A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.</value>
        [DataMember(Name = "asset_report_id", IsRequired = true, EmitDefaultValue = false)]
        public string AssetReportId { get; set; }

        /// <summary>
        /// An identifier you determine and submit for the Asset Report.
        /// </summary>
        /// <value>An identifier you determine and submit for the Asset Report.</value>
        [DataMember(Name = "client_report_id", IsRequired = true, EmitDefaultValue = true)]
        public string ClientReportId { get; set; }

        /// <summary>
        /// The date and time when the Asset Report was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (e.g. \&quot;2018-04-12T03:32:11Z\&quot;).
        /// </summary>
        /// <value>The date and time when the Asset Report was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (e.g. \&quot;2018-04-12T03:32:11Z\&quot;).</value>
        [DataMember(Name = "date_generated", IsRequired = true, EmitDefaultValue = false)]
        public DateTime DateGenerated { get; set; }

        /// <summary>
        /// The duration of transaction history you requested
        /// </summary>
        /// <value>The duration of transaction history you requested</value>
        [DataMember(Name = "days_requested", IsRequired = true, EmitDefaultValue = false)]
        public decimal DaysRequested { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public AssetReportUser User { get; set; }

        /// <summary>
        /// Data returned by Plaid about each of the Items included in the Asset Report.
        /// </summary>
        /// <value>Data returned by Plaid about each of the Items included in the Asset Report.</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = false)]
        public List<AssetReportItem> Items { get; set; }

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
            sb.Append("class AssetReport {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AssetReportId: ").Append(AssetReportId).Append("\n");
            sb.Append("  ClientReportId: ").Append(ClientReportId).Append("\n");
            sb.Append("  DateGenerated: ").Append(DateGenerated).Append("\n");
            sb.Append("  DaysRequested: ").Append(DaysRequested).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as AssetReport);
        }

        /// <summary>
        /// Returns true if AssetReport instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetReport input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AssetReportId == input.AssetReportId ||
                    (this.AssetReportId != null &&
                    this.AssetReportId.Equals(input.AssetReportId))
                ) && base.Equals(input) && 
                (
                    this.ClientReportId == input.ClientReportId ||
                    (this.ClientReportId != null &&
                    this.ClientReportId.Equals(input.ClientReportId))
                ) && base.Equals(input) && 
                (
                    this.DateGenerated == input.DateGenerated ||
                    (this.DateGenerated != null &&
                    this.DateGenerated.Equals(input.DateGenerated))
                ) && base.Equals(input) && 
                (
                    this.DaysRequested == input.DaysRequested ||
                    this.DaysRequested.Equals(input.DaysRequested)
                ) && base.Equals(input) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && base.Equals(input) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.AssetReportId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetReportId.GetHashCode();
                }
                if (this.ClientReportId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientReportId.GetHashCode();
                }
                if (this.DateGenerated != null)
                {
                    hashCode = (hashCode * 59) + this.DateGenerated.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DaysRequested.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
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
