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
    /// The verification refresh status. One of the following:  &#x60;\&quot;VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED\&quot;&#x60; User presence is required to refresh an income verification. &#x60;\&quot;VERIFICATION_REFRESH_SUCCESSFUL\&quot;&#x60; The income verification refresh was successful. &#x60;\&quot;VERIFICATION_REFRESH_NOT_FOUND\&quot;&#x60; No new data was found after the income verification refresh.
    /// </summary>
    /// <value>The verification refresh status. One of the following:  &#x60;\&quot;VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED\&quot;&#x60; User presence is required to refresh an income verification. &#x60;\&quot;VERIFICATION_REFRESH_SUCCESSFUL\&quot;&#x60; The income verification refresh was successful. &#x60;\&quot;VERIFICATION_REFRESH_NOT_FOUND\&quot;&#x60; No new data was found after the income verification refresh.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerificationRefreshStatus
    {
        /// <summary>
        /// Enum STATUSUSERPRESENCEREQUIRED for value: VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED
        /// </summary>
        [EnumMember(Value = "VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED")]
        STATUSUSERPRESENCEREQUIRED = 1,

        /// <summary>
        /// Enum SUCCESSFUL for value: VERIFICATION_REFRESH_SUCCESSFUL
        /// </summary>
        [EnumMember(Value = "VERIFICATION_REFRESH_SUCCESSFUL")]
        SUCCESSFUL = 2,

        /// <summary>
        /// Enum NOTFOUND for value: VERIFICATION_REFRESH_NOT_FOUND
        /// </summary>
        [EnumMember(Value = "VERIFICATION_REFRESH_NOT_FOUND")]
        NOTFOUND = 3

    }

}