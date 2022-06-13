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
    /// Derived verification status.
    /// </summary>
    /// <value>Derived verification status.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaystubVerificationStatus
    {
        /// <summary>
        /// Enum PAYSTUBVERIFICATIONSTATUSUNKNOWN for value: PAYSTUB_VERIFICATION_STATUS_UNKNOWN
        /// </summary>
        [EnumMember(Value = "PAYSTUB_VERIFICATION_STATUS_UNKNOWN")]
        PAYSTUBVERIFICATIONSTATUSUNKNOWN = 1,

        /// <summary>
        /// Enum PAYSTUBVERIFICATIONSTATUSVERIFIED for value: PAYSTUB_VERIFICATION_STATUS_VERIFIED
        /// </summary>
        [EnumMember(Value = "PAYSTUB_VERIFICATION_STATUS_VERIFIED")]
        PAYSTUBVERIFICATIONSTATUSVERIFIED = 2,

        /// <summary>
        /// Enum PAYSTUBVERIFICATIONSTATUSFRAUDULENT for value: PAYSTUB_VERIFICATION_STATUS_FRAUDULENT
        /// </summary>
        [EnumMember(Value = "PAYSTUB_VERIFICATION_STATUS_FRAUDULENT")]
        PAYSTUBVERIFICATIONSTATUSFRAUDULENT = 3,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 4

    }

}
