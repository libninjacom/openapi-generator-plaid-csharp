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
    /// TransactionsGetResponse defines the response schema for &#x60;/transactions/get&#x60;
    /// </summary>
    [DataContract(Name = "TransactionsGetResponse")]
    public partial class TransactionsGetResponse : Dictionary<String, Object>, IEquatable<TransactionsGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionsGetResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsGetResponse" /> class.
        /// </summary>
        /// <param name="accounts">An array containing the &#x60;accounts&#x60; associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the &#x60;account_id&#x60; field. (required).</param>
        /// <param name="transactions">An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the &#x60;count&#x60; parameter. (required).</param>
        /// <param name="totalTransactions">The total number of transactions available within the date range specified. If &#x60;total_transactions&#x60; is larger than the size of the &#x60;transactions&#x60; array, more transactions are available and can be fetched via manipulating the &#x60;offset&#x60; parameter. (required).</param>
        /// <param name="item">item (required).</param>
        /// <param name="requestId">A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. (required).</param>
        public TransactionsGetResponse(List<AccountBase> accounts = default(List<AccountBase>), List<Transaction> transactions = default(List<Transaction>), int totalTransactions = default(int), Item item = default(Item), string requestId = default(string)) : base()
        {
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new ArgumentNullException("accounts is a required property for TransactionsGetResponse and cannot be null");
            }
            this.Accounts = accounts;
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for TransactionsGetResponse and cannot be null");
            }
            this.Transactions = transactions;
            this.TotalTransactions = totalTransactions;
            // to ensure "item" is required (not null)
            if (item == null)
            {
                throw new ArgumentNullException("item is a required property for TransactionsGetResponse and cannot be null");
            }
            this.Item = item;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for TransactionsGetResponse and cannot be null");
            }
            this.RequestId = requestId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An array containing the &#x60;accounts&#x60; associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the &#x60;account_id&#x60; field.
        /// </summary>
        /// <value>An array containing the &#x60;accounts&#x60; associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the &#x60;account_id&#x60; field.</value>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = false)]
        public List<AccountBase> Accounts { get; set; }

        /// <summary>
        /// An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the &#x60;count&#x60; parameter.
        /// </summary>
        /// <value>An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the &#x60;count&#x60; parameter.</value>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = false)]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// The total number of transactions available within the date range specified. If &#x60;total_transactions&#x60; is larger than the size of the &#x60;transactions&#x60; array, more transactions are available and can be fetched via manipulating the &#x60;offset&#x60; parameter.
        /// </summary>
        /// <value>The total number of transactions available within the date range specified. If &#x60;total_transactions&#x60; is larger than the size of the &#x60;transactions&#x60; array, more transactions are available and can be fetched via manipulating the &#x60;offset&#x60; parameter.</value>
        [DataMember(Name = "total_transactions", IsRequired = true, EmitDefaultValue = false)]
        public int TotalTransactions { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public Item Item { get; set; }

        /// <summary>
        /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
        /// </summary>
        /// <value>A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.</value>
        [DataMember(Name = "request_id", IsRequired = true, EmitDefaultValue = false)]
        public string RequestId { get; set; }

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
            sb.Append("class TransactionsGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  TotalTransactions: ").Append(TotalTransactions).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as TransactionsGetResponse);
        }

        /// <summary>
        /// Returns true if TransactionsGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && base.Equals(input) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && base.Equals(input) && 
                (
                    this.TotalTransactions == input.TotalTransactions ||
                    this.TotalTransactions.Equals(input.TotalTransactions)
                ) && base.Equals(input) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && base.Equals(input) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalTransactions.GetHashCode();
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
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
