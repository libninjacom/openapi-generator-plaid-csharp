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
    /// Indicates the direction of the transfer: &#x60;outbound&#x60; for API-initiated transfers, or &#x60;inbound&#x60; for payments received by the FBO account.
    /// </summary>
    /// <value>Indicates the direction of the transfer: &#x60;outbound&#x60; for API-initiated transfers, or &#x60;inbound&#x60; for payments received by the FBO account.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankTransferDirection
    {
        /// <summary>
        /// Enum Outbound for value: outbound
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound = 1,

        /// <summary>
        /// Enum Inbound for value: inbound
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound = 2,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 3

    }

}
