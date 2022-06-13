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
    /// TransactionAllOf
    /// </summary>
    [DataContract(Name = "Transaction_allOf")]
    public partial class TransactionAllOf : IEquatable<TransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// The channel used to make a payment. &#x60;online:&#x60; transactions that took place online.  &#x60;in store:&#x60; transactions that were made at a physical location.  &#x60;other:&#x60; transactions that relate to banks, e.g. fees or deposits.  This field replaces the &#x60;transaction_type&#x60; field. 
        /// </summary>
        /// <value>The channel used to make a payment. &#x60;online:&#x60; transactions that took place online.  &#x60;in store:&#x60; transactions that were made at a physical location.  &#x60;other:&#x60; transactions that relate to banks, e.g. fees or deposits.  This field replaces the &#x60;transaction_type&#x60; field. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentChannelEnum
        {
            /// <summary>
            /// Enum Online for value: online
            /// </summary>
            [EnumMember(Value = "online")]
            Online = 1,

            /// <summary>
            /// Enum InStore for value: in store
            /// </summary>
            [EnumMember(Value = "in store")]
            InStore = 2,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3

        }


        /// <summary>
        /// The channel used to make a payment. &#x60;online:&#x60; transactions that took place online.  &#x60;in store:&#x60; transactions that were made at a physical location.  &#x60;other:&#x60; transactions that relate to banks, e.g. fees or deposits.  This field replaces the &#x60;transaction_type&#x60; field. 
        /// </summary>
        /// <value>The channel used to make a payment. &#x60;online:&#x60; transactions that took place online.  &#x60;in store:&#x60; transactions that were made at a physical location.  &#x60;other:&#x60; transactions that relate to banks, e.g. fees or deposits.  This field replaces the &#x60;transaction_type&#x60; field. </value>
        [DataMember(Name = "payment_channel", IsRequired = true, EmitDefaultValue = false)]
        public PaymentChannelEnum PaymentChannel { get; set; }

        /// <summary>
        /// Gets or Sets TransactionCode
        /// </summary>
        [DataMember(Name = "transaction_code", IsRequired = true, EmitDefaultValue = true)]
        public TransactionCode TransactionCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAllOf" /> class.
        /// </summary>
        /// <param name="paymentChannel">The channel used to make a payment. &#x60;online:&#x60; transactions that took place online.  &#x60;in store:&#x60; transactions that were made at a physical location.  &#x60;other:&#x60; transactions that relate to banks, e.g. fees or deposits.  This field replaces the &#x60;transaction_type&#x60; field.  (required).</param>
        /// <param name="authorizedDate">The date that the transaction was authorized. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DD&#x60; ). The &#x60;authorized_date&#x60; field uses machine learning to determine a transaction date for transactions where the &#x60;date_transacted&#x60; is not available. If the &#x60;date_transacted&#x60; field is present and not &#x60;null&#x60;, the &#x60;authorized_date&#x60; field will have the same value as the &#x60;date_transacted&#x60; field. (required).</param>
        /// <param name="authorizedDatetime">Date and time when a transaction was authorized in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DDTHH:mm:ssZ&#x60; ).  This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00). (required).</param>
        /// <param name="datetime">Date and time when a transaction was posted in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DDTHH:mm:ssZ&#x60; ).  This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00). (required).</param>
        /// <param name="transactionCode">transactionCode (required).</param>
        /// <param name="personalFinanceCategory">personalFinanceCategory.</param>
        public TransactionAllOf(PaymentChannelEnum paymentChannel = default(PaymentChannelEnum), DateTime? authorizedDate = default(DateTime?), DateTime? authorizedDatetime = default(DateTime?), DateTime? datetime = default(DateTime?), TransactionCode transactionCode = default(TransactionCode), PersonalFinanceCategory personalFinanceCategory = default(PersonalFinanceCategory))
        {
            this.PaymentChannel = paymentChannel;
            // to ensure "authorizedDate" is required (not null)
            if (authorizedDate == null)
            {
                throw new ArgumentNullException("authorizedDate is a required property for TransactionAllOf and cannot be null");
            }
            this.AuthorizedDate = authorizedDate;
            // to ensure "authorizedDatetime" is required (not null)
            if (authorizedDatetime == null)
            {
                throw new ArgumentNullException("authorizedDatetime is a required property for TransactionAllOf and cannot be null");
            }
            this.AuthorizedDatetime = authorizedDatetime;
            // to ensure "datetime" is required (not null)
            if (datetime == null)
            {
                throw new ArgumentNullException("datetime is a required property for TransactionAllOf and cannot be null");
            }
            this.Datetime = datetime;
            this.TransactionCode = transactionCode;
            this.PersonalFinanceCategory = personalFinanceCategory;
        }

        /// <summary>
        /// The date that the transaction was authorized. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DD&#x60; ). The &#x60;authorized_date&#x60; field uses machine learning to determine a transaction date for transactions where the &#x60;date_transacted&#x60; is not available. If the &#x60;date_transacted&#x60; field is present and not &#x60;null&#x60;, the &#x60;authorized_date&#x60; field will have the same value as the &#x60;date_transacted&#x60; field.
        /// </summary>
        /// <value>The date that the transaction was authorized. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DD&#x60; ). The &#x60;authorized_date&#x60; field uses machine learning to determine a transaction date for transactions where the &#x60;date_transacted&#x60; is not available. If the &#x60;date_transacted&#x60; field is present and not &#x60;null&#x60;, the &#x60;authorized_date&#x60; field will have the same value as the &#x60;date_transacted&#x60; field.</value>
        [DataMember(Name = "authorized_date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? AuthorizedDate { get; set; }

        /// <summary>
        /// Date and time when a transaction was authorized in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DDTHH:mm:ssZ&#x60; ).  This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).
        /// </summary>
        /// <value>Date and time when a transaction was authorized in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DDTHH:mm:ssZ&#x60; ).  This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).</value>
        [DataMember(Name = "authorized_datetime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? AuthorizedDatetime { get; set; }

        /// <summary>
        /// Date and time when a transaction was posted in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DDTHH:mm:ssZ&#x60; ).  This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).
        /// </summary>
        /// <value>Date and time when a transaction was posted in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( &#x60;YYYY-MM-DDTHH:mm:ssZ&#x60; ).  This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).</value>
        [DataMember(Name = "datetime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? Datetime { get; set; }

        /// <summary>
        /// Gets or Sets PersonalFinanceCategory
        /// </summary>
        [DataMember(Name = "personal_finance_category", EmitDefaultValue = true)]
        public PersonalFinanceCategory PersonalFinanceCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionAllOf {\n");
            sb.Append("  PaymentChannel: ").Append(PaymentChannel).Append("\n");
            sb.Append("  AuthorizedDate: ").Append(AuthorizedDate).Append("\n");
            sb.Append("  AuthorizedDatetime: ").Append(AuthorizedDatetime).Append("\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  TransactionCode: ").Append(TransactionCode).Append("\n");
            sb.Append("  PersonalFinanceCategory: ").Append(PersonalFinanceCategory).Append("\n");
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
            return this.Equals(input as TransactionAllOf);
        }

        /// <summary>
        /// Returns true if TransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentChannel == input.PaymentChannel ||
                    this.PaymentChannel.Equals(input.PaymentChannel)
                ) && 
                (
                    this.AuthorizedDate == input.AuthorizedDate ||
                    (this.AuthorizedDate != null &&
                    this.AuthorizedDate.Equals(input.AuthorizedDate))
                ) && 
                (
                    this.AuthorizedDatetime == input.AuthorizedDatetime ||
                    (this.AuthorizedDatetime != null &&
                    this.AuthorizedDatetime.Equals(input.AuthorizedDatetime))
                ) && 
                (
                    this.Datetime == input.Datetime ||
                    (this.Datetime != null &&
                    this.Datetime.Equals(input.Datetime))
                ) && 
                (
                    this.TransactionCode == input.TransactionCode ||
                    this.TransactionCode.Equals(input.TransactionCode)
                ) && 
                (
                    this.PersonalFinanceCategory == input.PersonalFinanceCategory ||
                    (this.PersonalFinanceCategory != null &&
                    this.PersonalFinanceCategory.Equals(input.PersonalFinanceCategory))
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
                hashCode = (hashCode * 59) + this.PaymentChannel.GetHashCode();
                if (this.AuthorizedDate != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizedDate.GetHashCode();
                }
                if (this.AuthorizedDatetime != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizedDatetime.GetHashCode();
                }
                if (this.Datetime != null)
                {
                    hashCode = (hashCode * 59) + this.Datetime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionCode.GetHashCode();
                if (this.PersonalFinanceCategory != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalFinanceCategory.GetHashCode();
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