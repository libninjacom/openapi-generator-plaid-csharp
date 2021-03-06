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
    /// Indicates whether the transfer is guaranteed by Plaid (Guaranteed ACH customers only). This field will contain either &#x60;GUARANTEED&#x60; or &#x60;NOT_GUARANTEED&#x60; indicating whether Plaid will guarantee the transfer. If the transfer is not guaranteed, additional information will be provided in the &#x60;guarantee_decision_rationale&#x60; field. Refer to the &#x60;code&#x60; field in &#x60;guarantee_decision_rationale&#x60; for details.
    /// </summary>
    /// <value>Indicates whether the transfer is guaranteed by Plaid (Guaranteed ACH customers only). This field will contain either &#x60;GUARANTEED&#x60; or &#x60;NOT_GUARANTEED&#x60; indicating whether Plaid will guarantee the transfer. If the transfer is not guaranteed, additional information will be provided in the &#x60;guarantee_decision_rationale&#x60; field. Refer to the &#x60;code&#x60; field in &#x60;guarantee_decision_rationale&#x60; for details.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransferAuthorizationGuaranteeDecision
    {
        /// <summary>
        /// Enum GUARANTEED for value: GUARANTEED
        /// </summary>
        [EnumMember(Value = "GUARANTEED")]
        GUARANTEED = 1,

        /// <summary>
        /// Enum NOTGUARANTEED for value: NOT_GUARANTEED
        /// </summary>
        [EnumMember(Value = "NOT_GUARANTEED")]
        NOTGUARANTEED = 2,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 3

    }

}
