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
    /// &#x60;investment:&#x60; Investment account.  &#x60;credit:&#x60; Credit card  &#x60;depository:&#x60; Depository account  &#x60;loan:&#x60; Loan account  &#x60;payroll:&#x60; Payroll account  &#x60;other:&#x60; Non-specified account type  See the [Account type schema](https://plaid.com/docs/api/accounts#account-type-schema) for a full listing of account types and corresponding subtypes.
    /// </summary>
    /// <value>&#x60;investment:&#x60; Investment account.  &#x60;credit:&#x60; Credit card  &#x60;depository:&#x60; Depository account  &#x60;loan:&#x60; Loan account  &#x60;payroll:&#x60; Payroll account  &#x60;other:&#x60; Non-specified account type  See the [Account type schema](https://plaid.com/docs/api/accounts#account-type-schema) for a full listing of account types and corresponding subtypes.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OverrideAccountType
    {
        /// <summary>
        /// Enum Investment for value: investment
        /// </summary>
        [EnumMember(Value = "investment")]
        Investment = 1,

        /// <summary>
        /// Enum Credit for value: credit
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit = 2,

        /// <summary>
        /// Enum Depository for value: depository
        /// </summary>
        [EnumMember(Value = "depository")]
        Depository = 3,

        /// <summary>
        /// Enum Loan for value: loan
        /// </summary>
        [EnumMember(Value = "loan")]
        Loan = 4,

        /// <summary>
        /// Enum Payroll for value: payroll
        /// </summary>
        [EnumMember(Value = "payroll")]
        Payroll = 5,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 6

    }

}
