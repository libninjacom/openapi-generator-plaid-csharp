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
    /// A grouping of related transactions
    /// </summary>
    [DataContract(Name = "TransactionStream")]
    public partial class TransactionStream : Dictionary<String, Object>, IEquatable<TransactionStream>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = false)]
        public RecurringTransactionFrequency Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStream" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionStream()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStream" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the account to which the stream belongs (required).</param>
        /// <param name="streamId">A unique id for the stream (required).</param>
        /// <param name="categoryId">The ID of the category to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview). (required).</param>
        /// <param name="category">A hierarchical array of the categories to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview). (required).</param>
        /// <param name="description">A description of the transaction stream. (required).</param>
        /// <param name="firstDate">The posted date of the earliest transaction in the stream. (required).</param>
        /// <param name="lastDate">The posted date of the latest transaction in the stream. (required).</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="transactionIds">An array of Plaid transaction IDs belonging to the stream, sorted by posted date. (required).</param>
        /// <param name="averageAmount">averageAmount (required).</param>
        /// <param name="isActive">indicates whether the transaction stream is still live. (required).</param>
        public TransactionStream(string accountId = default(string), string streamId = default(string), string categoryId = default(string), List<string> category = default(List<string>), string description = default(string), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), RecurringTransactionFrequency frequency = default(RecurringTransactionFrequency), List<string> transactionIds = default(List<string>), TransactionStreamAmount averageAmount = default(TransactionStreamAmount), bool isActive = default(bool)) : base()
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for TransactionStream and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "streamId" is required (not null)
            if (streamId == null)
            {
                throw new ArgumentNullException("streamId is a required property for TransactionStream and cannot be null");
            }
            this.StreamId = streamId;
            // to ensure "categoryId" is required (not null)
            if (categoryId == null)
            {
                throw new ArgumentNullException("categoryId is a required property for TransactionStream and cannot be null");
            }
            this.CategoryId = categoryId;
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for TransactionStream and cannot be null");
            }
            this.Category = category;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TransactionStream and cannot be null");
            }
            this.Description = description;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.Frequency = frequency;
            // to ensure "transactionIds" is required (not null)
            if (transactionIds == null)
            {
                throw new ArgumentNullException("transactionIds is a required property for TransactionStream and cannot be null");
            }
            this.TransactionIds = transactionIds;
            // to ensure "averageAmount" is required (not null)
            if (averageAmount == null)
            {
                throw new ArgumentNullException("averageAmount is a required property for TransactionStream and cannot be null");
            }
            this.AverageAmount = averageAmount;
            this.IsActive = isActive;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the account to which the stream belongs
        /// </summary>
        /// <value>The ID of the account to which the stream belongs</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// A unique id for the stream
        /// </summary>
        /// <value>A unique id for the stream</value>
        [DataMember(Name = "stream_id", IsRequired = true, EmitDefaultValue = false)]
        public string StreamId { get; set; }

        /// <summary>
        /// The ID of the category to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).
        /// </summary>
        /// <value>The ID of the category to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).</value>
        [DataMember(Name = "category_id", IsRequired = true, EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// A hierarchical array of the categories to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).
        /// </summary>
        /// <value>A hierarchical array of the categories to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).</value>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Category { get; set; }

        /// <summary>
        /// A description of the transaction stream.
        /// </summary>
        /// <value>A description of the transaction stream.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The posted date of the earliest transaction in the stream.
        /// </summary>
        /// <value>The posted date of the earliest transaction in the stream.</value>
        [DataMember(Name = "first_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime FirstDate { get; set; }

        /// <summary>
        /// The posted date of the latest transaction in the stream.
        /// </summary>
        /// <value>The posted date of the latest transaction in the stream.</value>
        [DataMember(Name = "last_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastDate { get; set; }

        /// <summary>
        /// An array of Plaid transaction IDs belonging to the stream, sorted by posted date.
        /// </summary>
        /// <value>An array of Plaid transaction IDs belonging to the stream, sorted by posted date.</value>
        [DataMember(Name = "transaction_ids", IsRequired = true, EmitDefaultValue = false)]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// Gets or Sets AverageAmount
        /// </summary>
        [DataMember(Name = "average_amount", IsRequired = true, EmitDefaultValue = false)]
        public TransactionStreamAmount AverageAmount { get; set; }

        /// <summary>
        /// indicates whether the transaction stream is still live.
        /// </summary>
        /// <value>indicates whether the transaction stream is still live.</value>
        [DataMember(Name = "is_active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

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
            sb.Append("class TransactionStream {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  StreamId: ").Append(StreamId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FirstDate: ").Append(FirstDate).Append("\n");
            sb.Append("  LastDate: ").Append(LastDate).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
            sb.Append("  AverageAmount: ").Append(AverageAmount).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as TransactionStream);
        }

        /// <summary>
        /// Returns true if TransactionStream instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionStream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionStream input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && base.Equals(input) && 
                (
                    this.StreamId == input.StreamId ||
                    (this.StreamId != null &&
                    this.StreamId.Equals(input.StreamId))
                ) && base.Equals(input) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && base.Equals(input) && 
                (
                    this.Category == input.Category ||
                    this.Category != null &&
                    input.Category != null &&
                    this.Category.SequenceEqual(input.Category)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.FirstDate == input.FirstDate ||
                    (this.FirstDate != null &&
                    this.FirstDate.Equals(input.FirstDate))
                ) && base.Equals(input) && 
                (
                    this.LastDate == input.LastDate ||
                    (this.LastDate != null &&
                    this.LastDate.Equals(input.LastDate))
                ) && base.Equals(input) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && base.Equals(input) && 
                (
                    this.TransactionIds == input.TransactionIds ||
                    this.TransactionIds != null &&
                    input.TransactionIds != null &&
                    this.TransactionIds.SequenceEqual(input.TransactionIds)
                ) && base.Equals(input) && 
                (
                    this.AverageAmount == input.AverageAmount ||
                    (this.AverageAmount != null &&
                    this.AverageAmount.Equals(input.AverageAmount))
                ) && base.Equals(input) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.StreamId != null)
                {
                    hashCode = (hashCode * 59) + this.StreamId.GetHashCode();
                }
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FirstDate != null)
                {
                    hashCode = (hashCode * 59) + this.FirstDate.GetHashCode();
                }
                if (this.LastDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                if (this.TransactionIds != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIds.GetHashCode();
                }
                if (this.AverageAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AverageAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
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
