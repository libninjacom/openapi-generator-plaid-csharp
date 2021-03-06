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
    /// A transaction within an investment account.
    /// </summary>
    [DataContract(Name = "InvestmentTransaction")]
    public partial class InvestmentTransaction : Dictionary<String, Object>, IEquatable<InvestmentTransaction>, IValidatableObject
    {
        /// <summary>
        /// Value is one of the following: &#x60;buy&#x60;: Buying an investment &#x60;sell&#x60;: Selling an investment &#x60;cancel&#x60;: A cancellation of a pending transaction &#x60;cash&#x60;: Activity that modifies a cash position &#x60;fee&#x60;: A fee on the account &#x60;transfer&#x60;: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer  For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).
        /// </summary>
        /// <value>Value is one of the following: &#x60;buy&#x60;: Buying an investment &#x60;sell&#x60;: Selling an investment &#x60;cancel&#x60;: A cancellation of a pending transaction &#x60;cash&#x60;: Activity that modifies a cash position &#x60;fee&#x60;: A fee on the account &#x60;transfer&#x60;: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer  For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 1,

            /// <summary>
            /// Enum Sell for value: sell
            /// </summary>
            [EnumMember(Value = "sell")]
            Sell = 2,

            /// <summary>
            /// Enum Cancel for value: cancel
            /// </summary>
            [EnumMember(Value = "cancel")]
            Cancel = 3,

            /// <summary>
            /// Enum Cash for value: cash
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash = 4,

            /// <summary>
            /// Enum Fee for value: fee
            /// </summary>
            [EnumMember(Value = "fee")]
            Fee = 5,

            /// <summary>
            /// Enum Transfer for value: transfer
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer = 6

        }


        /// <summary>
        /// Value is one of the following: &#x60;buy&#x60;: Buying an investment &#x60;sell&#x60;: Selling an investment &#x60;cancel&#x60;: A cancellation of a pending transaction &#x60;cash&#x60;: Activity that modifies a cash position &#x60;fee&#x60;: A fee on the account &#x60;transfer&#x60;: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer  For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).
        /// </summary>
        /// <value>Value is one of the following: &#x60;buy&#x60;: Buying an investment &#x60;sell&#x60;: Selling an investment &#x60;cancel&#x60;: A cancellation of a pending transaction &#x60;cash&#x60;: Activity that modifies a cash position &#x60;fee&#x60;: A fee on the account &#x60;transfer&#x60;: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer  For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).
        /// </summary>
        /// <value>For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubtypeEnum
        {
            /// <summary>
            /// Enum AccountFee for value: account fee
            /// </summary>
            [EnumMember(Value = "account fee")]
            AccountFee = 1,

            /// <summary>
            /// Enum Adjustment for value: adjustment
            /// </summary>
            [EnumMember(Value = "adjustment")]
            Adjustment = 2,

            /// <summary>
            /// Enum Assignment for value: assignment
            /// </summary>
            [EnumMember(Value = "assignment")]
            Assignment = 3,

            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 4,

            /// <summary>
            /// Enum BuyToCover for value: buy to cover
            /// </summary>
            [EnumMember(Value = "buy to cover")]
            BuyToCover = 5,

            /// <summary>
            /// Enum Contribution for value: contribution
            /// </summary>
            [EnumMember(Value = "contribution")]
            Contribution = 6,

            /// <summary>
            /// Enum Deposit for value: deposit
            /// </summary>
            [EnumMember(Value = "deposit")]
            Deposit = 7,

            /// <summary>
            /// Enum Distribution for value: distribution
            /// </summary>
            [EnumMember(Value = "distribution")]
            Distribution = 8,

            /// <summary>
            /// Enum Dividend for value: dividend
            /// </summary>
            [EnumMember(Value = "dividend")]
            Dividend = 9,

            /// <summary>
            /// Enum DividendReinvestment for value: dividend reinvestment
            /// </summary>
            [EnumMember(Value = "dividend reinvestment")]
            DividendReinvestment = 10,

            /// <summary>
            /// Enum Exercise for value: exercise
            /// </summary>
            [EnumMember(Value = "exercise")]
            Exercise = 11,

            /// <summary>
            /// Enum Expire for value: expire
            /// </summary>
            [EnumMember(Value = "expire")]
            Expire = 12,

            /// <summary>
            /// Enum FundFee for value: fund fee
            /// </summary>
            [EnumMember(Value = "fund fee")]
            FundFee = 13,

            /// <summary>
            /// Enum Interest for value: interest
            /// </summary>
            [EnumMember(Value = "interest")]
            Interest = 14,

            /// <summary>
            /// Enum InterestReceivable for value: interest receivable
            /// </summary>
            [EnumMember(Value = "interest receivable")]
            InterestReceivable = 15,

            /// <summary>
            /// Enum InterestReinvestment for value: interest reinvestment
            /// </summary>
            [EnumMember(Value = "interest reinvestment")]
            InterestReinvestment = 16,

            /// <summary>
            /// Enum LegalFee for value: legal fee
            /// </summary>
            [EnumMember(Value = "legal fee")]
            LegalFee = 17,

            /// <summary>
            /// Enum LoanPayment for value: loan payment
            /// </summary>
            [EnumMember(Value = "loan payment")]
            LoanPayment = 18,

            /// <summary>
            /// Enum LongTermCapitalGain for value: long-term capital gain
            /// </summary>
            [EnumMember(Value = "long-term capital gain")]
            LongTermCapitalGain = 19,

            /// <summary>
            /// Enum LongTermCapitalGainReinvestment for value: long-term capital gain reinvestment
            /// </summary>
            [EnumMember(Value = "long-term capital gain reinvestment")]
            LongTermCapitalGainReinvestment = 20,

            /// <summary>
            /// Enum ManagementFee for value: management fee
            /// </summary>
            [EnumMember(Value = "management fee")]
            ManagementFee = 21,

            /// <summary>
            /// Enum MarginExpense for value: margin expense
            /// </summary>
            [EnumMember(Value = "margin expense")]
            MarginExpense = 22,

            /// <summary>
            /// Enum Merger for value: merger
            /// </summary>
            [EnumMember(Value = "merger")]
            Merger = 23,

            /// <summary>
            /// Enum MiscellaneousFee for value: miscellaneous fee
            /// </summary>
            [EnumMember(Value = "miscellaneous fee")]
            MiscellaneousFee = 24,

            /// <summary>
            /// Enum NonQualifiedDividend for value: non-qualified dividend
            /// </summary>
            [EnumMember(Value = "non-qualified dividend")]
            NonQualifiedDividend = 25,

            /// <summary>
            /// Enum NonResidentTax for value: non-resident tax
            /// </summary>
            [EnumMember(Value = "non-resident tax")]
            NonResidentTax = 26,

            /// <summary>
            /// Enum PendingCredit for value: pending credit
            /// </summary>
            [EnumMember(Value = "pending credit")]
            PendingCredit = 27,

            /// <summary>
            /// Enum PendingDebit for value: pending debit
            /// </summary>
            [EnumMember(Value = "pending debit")]
            PendingDebit = 28,

            /// <summary>
            /// Enum QualifiedDividend for value: qualified dividend
            /// </summary>
            [EnumMember(Value = "qualified dividend")]
            QualifiedDividend = 29,

            /// <summary>
            /// Enum Rebalance for value: rebalance
            /// </summary>
            [EnumMember(Value = "rebalance")]
            Rebalance = 30,

            /// <summary>
            /// Enum ReturnOfPrincipal for value: return of principal
            /// </summary>
            [EnumMember(Value = "return of principal")]
            ReturnOfPrincipal = 31,

            /// <summary>
            /// Enum Sell for value: sell
            /// </summary>
            [EnumMember(Value = "sell")]
            Sell = 32,

            /// <summary>
            /// Enum SellShort for value: sell short
            /// </summary>
            [EnumMember(Value = "sell short")]
            SellShort = 33,

            /// <summary>
            /// Enum ShortTermCapitalGain for value: short-term capital gain
            /// </summary>
            [EnumMember(Value = "short-term capital gain")]
            ShortTermCapitalGain = 34,

            /// <summary>
            /// Enum ShortTermCapitalGainReinvestment for value: short-term capital gain reinvestment
            /// </summary>
            [EnumMember(Value = "short-term capital gain reinvestment")]
            ShortTermCapitalGainReinvestment = 35,

            /// <summary>
            /// Enum SpinOff for value: spin off
            /// </summary>
            [EnumMember(Value = "spin off")]
            SpinOff = 36,

            /// <summary>
            /// Enum Split for value: split
            /// </summary>
            [EnumMember(Value = "split")]
            Split = 37,

            /// <summary>
            /// Enum StockDistribution for value: stock distribution
            /// </summary>
            [EnumMember(Value = "stock distribution")]
            StockDistribution = 38,

            /// <summary>
            /// Enum Tax for value: tax
            /// </summary>
            [EnumMember(Value = "tax")]
            Tax = 39,

            /// <summary>
            /// Enum TaxWithheld for value: tax withheld
            /// </summary>
            [EnumMember(Value = "tax withheld")]
            TaxWithheld = 40,

            /// <summary>
            /// Enum Transfer for value: transfer
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer = 41,

            /// <summary>
            /// Enum TransferFee for value: transfer fee
            /// </summary>
            [EnumMember(Value = "transfer fee")]
            TransferFee = 42,

            /// <summary>
            /// Enum TrustFee for value: trust fee
            /// </summary>
            [EnumMember(Value = "trust fee")]
            TrustFee = 43,

            /// <summary>
            /// Enum UnqualifiedGain for value: unqualified gain
            /// </summary>
            [EnumMember(Value = "unqualified gain")]
            UnqualifiedGain = 44,

            /// <summary>
            /// Enum Withdrawal for value: withdrawal
            /// </summary>
            [EnumMember(Value = "withdrawal")]
            Withdrawal = 45

        }


        /// <summary>
        /// For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).
        /// </summary>
        /// <value>For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</value>
        [DataMember(Name = "subtype", IsRequired = true, EmitDefaultValue = false)]
        public SubtypeEnum Subtype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvestmentTransaction()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentTransaction" /> class.
        /// </summary>
        /// <param name="investmentTransactionId">The ID of the Investment transaction, unique across all Plaid transactions. Like all Plaid identifiers, the &#x60;investment_transaction_id&#x60; is case sensitive. (required).</param>
        /// <param name="cancelTransactionId">A legacy field formerly used internally by Plaid to identify certain canceled transactions..</param>
        /// <param name="accountId">The &#x60;account_id&#x60; of the account against which this transaction posted. (required).</param>
        /// <param name="securityId">The &#x60;security_id&#x60; to which this transaction is related. (required).</param>
        /// <param name="date">The [ISO 8601](https://wikipedia.org/wiki/ISO_8601) posting date for the transaction. (required).</param>
        /// <param name="name">The institution???s description of the transaction. (required).</param>
        /// <param name="quantity">The number of units of the security involved in this transaction. (required).</param>
        /// <param name="amount">The complete value of the transaction. Positive values when cash is debited, e.g. purchases of stock; negative values when cash is credited, e.g. sales of stock. Treatment remains the same for cash-only movements unassociated with securities. (required).</param>
        /// <param name="price">The price of the security at which this transaction occurred. (required).</param>
        /// <param name="fees">The combined value of all fees applied to this transaction (required).</param>
        /// <param name="type">Value is one of the following: &#x60;buy&#x60;: Buying an investment &#x60;sell&#x60;: Selling an investment &#x60;cancel&#x60;: A cancellation of a pending transaction &#x60;cash&#x60;: Activity that modifies a cash position &#x60;fee&#x60;: A fee on the account &#x60;transfer&#x60;: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer  For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema). (required).</param>
        /// <param name="subtype">For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema). (required).</param>
        /// <param name="isoCurrencyCode">The ISO-4217 currency code of the transaction. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-&#x60;null&#x60;. (required).</param>
        /// <param name="unofficialCurrencyCode">The unofficial currency code associated with the holding. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s. (required).</param>
        public InvestmentTransaction(string investmentTransactionId = default(string), string cancelTransactionId = default(string), string accountId = default(string), string securityId = default(string), DateTime date = default(DateTime), string name = default(string), decimal quantity = default(decimal), decimal amount = default(decimal), decimal price = default(decimal), decimal? fees = default(decimal?), TypeEnum type = default(TypeEnum), SubtypeEnum subtype = default(SubtypeEnum), string isoCurrencyCode = default(string), string unofficialCurrencyCode = default(string)) : base()
        {
            // to ensure "investmentTransactionId" is required (not null)
            if (investmentTransactionId == null)
            {
                throw new ArgumentNullException("investmentTransactionId is a required property for InvestmentTransaction and cannot be null");
            }
            this.InvestmentTransactionId = investmentTransactionId;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for InvestmentTransaction and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "securityId" is required (not null)
            if (securityId == null)
            {
                throw new ArgumentNullException("securityId is a required property for InvestmentTransaction and cannot be null");
            }
            this.SecurityId = securityId;
            this.Date = date;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for InvestmentTransaction and cannot be null");
            }
            this.Name = name;
            this.Quantity = quantity;
            this.Amount = amount;
            this.Price = price;
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new ArgumentNullException("fees is a required property for InvestmentTransaction and cannot be null");
            }
            this.Fees = fees;
            this.Type = type;
            this.Subtype = subtype;
            // to ensure "isoCurrencyCode" is required (not null)
            if (isoCurrencyCode == null)
            {
                throw new ArgumentNullException("isoCurrencyCode is a required property for InvestmentTransaction and cannot be null");
            }
            this.IsoCurrencyCode = isoCurrencyCode;
            // to ensure "unofficialCurrencyCode" is required (not null)
            if (unofficialCurrencyCode == null)
            {
                throw new ArgumentNullException("unofficialCurrencyCode is a required property for InvestmentTransaction and cannot be null");
            }
            this.UnofficialCurrencyCode = unofficialCurrencyCode;
            this.CancelTransactionId = cancelTransactionId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the Investment transaction, unique across all Plaid transactions. Like all Plaid identifiers, the &#x60;investment_transaction_id&#x60; is case sensitive.
        /// </summary>
        /// <value>The ID of the Investment transaction, unique across all Plaid transactions. Like all Plaid identifiers, the &#x60;investment_transaction_id&#x60; is case sensitive.</value>
        [DataMember(Name = "investment_transaction_id", IsRequired = true, EmitDefaultValue = false)]
        public string InvestmentTransactionId { get; set; }

        /// <summary>
        /// A legacy field formerly used internally by Plaid to identify certain canceled transactions.
        /// </summary>
        /// <value>A legacy field formerly used internally by Plaid to identify certain canceled transactions.</value>
        [DataMember(Name = "cancel_transaction_id", EmitDefaultValue = true)]
        [Obsolete]
        public string CancelTransactionId { get; set; }

        /// <summary>
        /// The &#x60;account_id&#x60; of the account against which this transaction posted.
        /// </summary>
        /// <value>The &#x60;account_id&#x60; of the account against which this transaction posted.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The &#x60;security_id&#x60; to which this transaction is related.
        /// </summary>
        /// <value>The &#x60;security_id&#x60; to which this transaction is related.</value>
        [DataMember(Name = "security_id", IsRequired = true, EmitDefaultValue = true)]
        public string SecurityId { get; set; }

        /// <summary>
        /// The [ISO 8601](https://wikipedia.org/wiki/ISO_8601) posting date for the transaction.
        /// </summary>
        /// <value>The [ISO 8601](https://wikipedia.org/wiki/ISO_8601) posting date for the transaction.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// The institution???s description of the transaction.
        /// </summary>
        /// <value>The institution???s description of the transaction.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of units of the security involved in this transaction.
        /// </summary>
        /// <value>The number of units of the security involved in this transaction.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The complete value of the transaction. Positive values when cash is debited, e.g. purchases of stock; negative values when cash is credited, e.g. sales of stock. Treatment remains the same for cash-only movements unassociated with securities.
        /// </summary>
        /// <value>The complete value of the transaction. Positive values when cash is debited, e.g. purchases of stock; negative values when cash is credited, e.g. sales of stock. Treatment remains the same for cash-only movements unassociated with securities.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The price of the security at which this transaction occurred.
        /// </summary>
        /// <value>The price of the security at which this transaction occurred.</value>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// The combined value of all fees applied to this transaction
        /// </summary>
        /// <value>The combined value of all fees applied to this transaction</value>
        [DataMember(Name = "fees", IsRequired = true, EmitDefaultValue = true)]
        public decimal? Fees { get; set; }

        /// <summary>
        /// The ISO-4217 currency code of the transaction. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-&#x60;null&#x60;.
        /// </summary>
        /// <value>The ISO-4217 currency code of the transaction. Always &#x60;null&#x60; if &#x60;unofficial_currency_code&#x60; is non-&#x60;null&#x60;.</value>
        [DataMember(Name = "iso_currency_code", IsRequired = true, EmitDefaultValue = true)]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// The unofficial currency code associated with the holding. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.
        /// </summary>
        /// <value>The unofficial currency code associated with the holding. Always &#x60;null&#x60; if &#x60;iso_currency_code&#x60; is non-&#x60;null&#x60;. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.  See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported &#x60;iso_currency_code&#x60;s.</value>
        [DataMember(Name = "unofficial_currency_code", IsRequired = true, EmitDefaultValue = true)]
        public string UnofficialCurrencyCode { get; set; }

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
            sb.Append("class InvestmentTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  InvestmentTransactionId: ").Append(InvestmentTransactionId).Append("\n");
            sb.Append("  CancelTransactionId: ").Append(CancelTransactionId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  SecurityId: ").Append(SecurityId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  IsoCurrencyCode: ").Append(IsoCurrencyCode).Append("\n");
            sb.Append("  UnofficialCurrencyCode: ").Append(UnofficialCurrencyCode).Append("\n");
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
            return this.Equals(input as InvestmentTransaction);
        }

        /// <summary>
        /// Returns true if InvestmentTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of InvestmentTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvestmentTransaction input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.InvestmentTransactionId == input.InvestmentTransactionId ||
                    (this.InvestmentTransactionId != null &&
                    this.InvestmentTransactionId.Equals(input.InvestmentTransactionId))
                ) && base.Equals(input) && 
                (
                    this.CancelTransactionId == input.CancelTransactionId ||
                    (this.CancelTransactionId != null &&
                    this.CancelTransactionId.Equals(input.CancelTransactionId))
                ) && base.Equals(input) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && base.Equals(input) && 
                (
                    this.SecurityId == input.SecurityId ||
                    (this.SecurityId != null &&
                    this.SecurityId.Equals(input.SecurityId))
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && base.Equals(input) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && base.Equals(input) && 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && base.Equals(input) && 
                (
                    this.Subtype == input.Subtype ||
                    this.Subtype.Equals(input.Subtype)
                ) && base.Equals(input) && 
                (
                    this.IsoCurrencyCode == input.IsoCurrencyCode ||
                    (this.IsoCurrencyCode != null &&
                    this.IsoCurrencyCode.Equals(input.IsoCurrencyCode))
                ) && base.Equals(input) && 
                (
                    this.UnofficialCurrencyCode == input.UnofficialCurrencyCode ||
                    (this.UnofficialCurrencyCode != null &&
                    this.UnofficialCurrencyCode.Equals(input.UnofficialCurrencyCode))
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
                if (this.InvestmentTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.InvestmentTransactionId.GetHashCode();
                }
                if (this.CancelTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.CancelTransactionId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.SecurityId != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityId.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                if (this.Fees != null)
                {
                    hashCode = (hashCode * 59) + this.Fees.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Subtype.GetHashCode();
                if (this.IsoCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCurrencyCode.GetHashCode();
                }
                if (this.UnofficialCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.UnofficialCurrencyCode.GetHashCode();
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
