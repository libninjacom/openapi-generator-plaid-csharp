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
    /// An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send &#x60;ENROLLMENT&#x60;. When scopes are updated in a post-enrollment view, the partner must send &#x60;PORTAL&#x60;.
    /// </summary>
    /// <value>An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send &#x60;ENROLLMENT&#x60;. When scopes are updated in a post-enrollment view, the partner must send &#x60;PORTAL&#x60;.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScopesContext
    {
        /// <summary>
        /// Enum ENROLLMENT for value: ENROLLMENT
        /// </summary>
        [EnumMember(Value = "ENROLLMENT")]
        ENROLLMENT = 1,

        /// <summary>
        /// Enum PORTAL for value: PORTAL
        /// </summary>
        [EnumMember(Value = "PORTAL")]
        PORTAL = 2

    }

}