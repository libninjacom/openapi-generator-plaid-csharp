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
    /// Specifies the use case of the transfer.  Required for transfers on an ACH network. In Sandbox, only &#x60;ccd&#x60;, &#x60;ppd&#x60;, or &#x60;web&#x60; can be used.  &#x60;\&quot;arc\&quot;&#x60; - Accounts Receivable Entry  &#x60;\&quot;cbr&#x60;\&quot; - Cross Border Entry  &#x60;\&quot;ccd\&quot;&#x60; - Corporate Credit or Debit - fund transfer between two corporate bank accounts  &#x60;\&quot;cie\&quot;&#x60; - Customer Initiated Entry  &#x60;\&quot;cor\&quot;&#x60; - Automated Notification of Change  &#x60;\&quot;ctx\&quot;&#x60; - Corporate Trade Exchange  &#x60;\&quot;iat\&quot;&#x60; - International  &#x60;\&quot;mte\&quot;&#x60; - Machine Transfer Entry  &#x60;\&quot;pbr\&quot;&#x60; - Cross Border Entry  &#x60;\&quot;pop\&quot;&#x60; - Point-of-Purchase Entry  &#x60;\&quot;pos\&quot;&#x60; - Point-of-Sale Entry  &#x60;\&quot;ppd\&quot;&#x60; - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment  &#x60;\&quot;rck\&quot;&#x60; - Re-presented Check Entry  &#x60;\&quot;tel\&quot;&#x60; - Telephone-Initiated Entry  &#x60;\&quot;web\&quot;&#x60; - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet
    /// </summary>
    /// <value>Specifies the use case of the transfer.  Required for transfers on an ACH network. In Sandbox, only &#x60;ccd&#x60;, &#x60;ppd&#x60;, or &#x60;web&#x60; can be used.  &#x60;\&quot;arc\&quot;&#x60; - Accounts Receivable Entry  &#x60;\&quot;cbr&#x60;\&quot; - Cross Border Entry  &#x60;\&quot;ccd\&quot;&#x60; - Corporate Credit or Debit - fund transfer between two corporate bank accounts  &#x60;\&quot;cie\&quot;&#x60; - Customer Initiated Entry  &#x60;\&quot;cor\&quot;&#x60; - Automated Notification of Change  &#x60;\&quot;ctx\&quot;&#x60; - Corporate Trade Exchange  &#x60;\&quot;iat\&quot;&#x60; - International  &#x60;\&quot;mte\&quot;&#x60; - Machine Transfer Entry  &#x60;\&quot;pbr\&quot;&#x60; - Cross Border Entry  &#x60;\&quot;pop\&quot;&#x60; - Point-of-Purchase Entry  &#x60;\&quot;pos\&quot;&#x60; - Point-of-Sale Entry  &#x60;\&quot;ppd\&quot;&#x60; - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment  &#x60;\&quot;rck\&quot;&#x60; - Re-presented Check Entry  &#x60;\&quot;tel\&quot;&#x60; - Telephone-Initiated Entry  &#x60;\&quot;web\&quot;&#x60; - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ACHClass
    {
        /// <summary>
        /// Enum Arc for value: arc
        /// </summary>
        [EnumMember(Value = "arc")]
        Arc = 1,

        /// <summary>
        /// Enum Cbr for value: cbr
        /// </summary>
        [EnumMember(Value = "cbr")]
        Cbr = 2,

        /// <summary>
        /// Enum Ccd for value: ccd
        /// </summary>
        [EnumMember(Value = "ccd")]
        Ccd = 3,

        /// <summary>
        /// Enum Cie for value: cie
        /// </summary>
        [EnumMember(Value = "cie")]
        Cie = 4,

        /// <summary>
        /// Enum Cor for value: cor
        /// </summary>
        [EnumMember(Value = "cor")]
        Cor = 5,

        /// <summary>
        /// Enum Ctx for value: ctx
        /// </summary>
        [EnumMember(Value = "ctx")]
        Ctx = 6,

        /// <summary>
        /// Enum Iat for value: iat
        /// </summary>
        [EnumMember(Value = "iat")]
        Iat = 7,

        /// <summary>
        /// Enum Mte for value: mte
        /// </summary>
        [EnumMember(Value = "mte")]
        Mte = 8,

        /// <summary>
        /// Enum Pbr for value: pbr
        /// </summary>
        [EnumMember(Value = "pbr")]
        Pbr = 9,

        /// <summary>
        /// Enum Pop for value: pop
        /// </summary>
        [EnumMember(Value = "pop")]
        Pop = 10,

        /// <summary>
        /// Enum Pos for value: pos
        /// </summary>
        [EnumMember(Value = "pos")]
        Pos = 11,

        /// <summary>
        /// Enum Ppd for value: ppd
        /// </summary>
        [EnumMember(Value = "ppd")]
        Ppd = 12,

        /// <summary>
        /// Enum Rck for value: rck
        /// </summary>
        [EnumMember(Value = "rck")]
        Rck = 13,

        /// <summary>
        /// Enum Tel for value: tel
        /// </summary>
        [EnumMember(Value = "tel")]
        Tel = 14,

        /// <summary>
        /// Enum Web for value: web
        /// </summary>
        [EnumMember(Value = "web")]
        Web = 15

    }

}
