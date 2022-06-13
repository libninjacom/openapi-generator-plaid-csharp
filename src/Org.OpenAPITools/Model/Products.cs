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
    /// A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.
    /// </summary>
    /// <value>A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Products
    {
        /// <summary>
        /// Enum Assets for value: assets
        /// </summary>
        [EnumMember(Value = "assets")]
        Assets = 1,

        /// <summary>
        /// Enum Auth for value: auth
        /// </summary>
        [EnumMember(Value = "auth")]
        Auth = 2,

        /// <summary>
        /// Enum Balance for value: balance
        /// </summary>
        [EnumMember(Value = "balance")]
        Balance = 3,

        /// <summary>
        /// Enum Identity for value: identity
        /// </summary>
        [EnumMember(Value = "identity")]
        Identity = 4,

        /// <summary>
        /// Enum Investments for value: investments
        /// </summary>
        [EnumMember(Value = "investments")]
        Investments = 5,

        /// <summary>
        /// Enum Liabilities for value: liabilities
        /// </summary>
        [EnumMember(Value = "liabilities")]
        Liabilities = 6,

        /// <summary>
        /// Enum PaymentInitiation for value: payment_initiation
        /// </summary>
        [EnumMember(Value = "payment_initiation")]
        PaymentInitiation = 7,

        /// <summary>
        /// Enum Transactions for value: transactions
        /// </summary>
        [EnumMember(Value = "transactions")]
        Transactions = 8,

        /// <summary>
        /// Enum CreditDetails for value: credit_details
        /// </summary>
        [EnumMember(Value = "credit_details")]
        CreditDetails = 9,

        /// <summary>
        /// Enum Income for value: income
        /// </summary>
        [EnumMember(Value = "income")]
        Income = 10,

        /// <summary>
        /// Enum IncomeVerification for value: income_verification
        /// </summary>
        [EnumMember(Value = "income_verification")]
        IncomeVerification = 11,

        /// <summary>
        /// Enum DepositSwitch for value: deposit_switch
        /// </summary>
        [EnumMember(Value = "deposit_switch")]
        DepositSwitch = 12,

        /// <summary>
        /// Enum StandingOrders for value: standing_orders
        /// </summary>
        [EnumMember(Value = "standing_orders")]
        StandingOrders = 13,

        /// <summary>
        /// Enum Transfer for value: transfer
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer = 14,

        /// <summary>
        /// Enum Employment for value: employment
        /// </summary>
        [EnumMember(Value = "employment")]
        Employment = 15

    }

}