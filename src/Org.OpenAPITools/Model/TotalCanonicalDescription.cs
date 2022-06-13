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
    /// Commonly used term to describe the line item.
    /// </summary>
    /// <value>Commonly used term to describe the line item.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TotalCanonicalDescription
    {
        /// <summary>
        /// Enum BONUS for value: BONUS
        /// </summary>
        [EnumMember(Value = "BONUS")]
        BONUS = 1,

        /// <summary>
        /// Enum COMMISSION for value: COMMISSION
        /// </summary>
        [EnumMember(Value = "COMMISSION")]
        COMMISSION = 2,

        /// <summary>
        /// Enum OVERTIME for value: OVERTIME
        /// </summary>
        [EnumMember(Value = "OVERTIME")]
        OVERTIME = 3,

        /// <summary>
        /// Enum PAIDTIMEOFF for value: PAID TIME OFF
        /// </summary>
        [EnumMember(Value = "PAID TIME OFF")]
        PAIDTIMEOFF = 4,

        /// <summary>
        /// Enum REGULARPAY for value: REGULAR PAY
        /// </summary>
        [EnumMember(Value = "REGULAR PAY")]
        REGULARPAY = 5,

        /// <summary>
        /// Enum VACATION for value: VACATION
        /// </summary>
        [EnumMember(Value = "VACATION")]
        VACATION = 6,

        /// <summary>
        /// Enum EMPLOYEEMEDICARE for value: EMPLOYEE MEDICARE
        /// </summary>
        [EnumMember(Value = "EMPLOYEE MEDICARE")]
        EMPLOYEEMEDICARE = 7,

        /// <summary>
        /// Enum FICA for value: FICA
        /// </summary>
        [EnumMember(Value = "FICA")]
        FICA = 8,

        /// <summary>
        /// Enum SOCIALSECURITYEMPLOYEETAX for value: SOCIAL SECURITY EMPLOYEE TAX
        /// </summary>
        [EnumMember(Value = "SOCIAL SECURITY EMPLOYEE TAX")]
        SOCIALSECURITYEMPLOYEETAX = 9,

        /// <summary>
        /// Enum MEDICAL for value: MEDICAL
        /// </summary>
        [EnumMember(Value = "MEDICAL")]
        MEDICAL = 10,

        /// <summary>
        /// Enum VISION for value: VISION
        /// </summary>
        [EnumMember(Value = "VISION")]
        VISION = 11,

        /// <summary>
        /// Enum DENTAL for value: DENTAL
        /// </summary>
        [EnumMember(Value = "DENTAL")]
        DENTAL = 12,

        /// <summary>
        /// Enum NETPAY for value: NET PAY
        /// </summary>
        [EnumMember(Value = "NET PAY")]
        NETPAY = 13,

        /// <summary>
        /// Enum TAXES for value: TAXES
        /// </summary>
        [EnumMember(Value = "TAXES")]
        TAXES = 14,

        /// <summary>
        /// Enum NOTFOUND for value: NOT_FOUND
        /// </summary>
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND = 15,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 16,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 17

    }

}
