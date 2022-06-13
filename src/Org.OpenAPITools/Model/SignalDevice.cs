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
    /// Details about the end user&#39;s device
    /// </summary>
    [DataContract(Name = "SignalDevice")]
    public partial class SignalDevice : IEquatable<SignalDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalDevice" /> class.
        /// </summary>
        /// <param name="ipAddress">The IP address of the device that initiated the transaction.</param>
        /// <param name="userAgent">The user agent of the device that initiated the transaction (e.g. \&quot;Mozilla/5.0\&quot;).</param>
        public SignalDevice(string ipAddress = default(string), string userAgent = default(string))
        {
            this.IpAddress = ipAddress;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// The IP address of the device that initiated the transaction
        /// </summary>
        /// <value>The IP address of the device that initiated the transaction</value>
        [DataMember(Name = "ip_address", EmitDefaultValue = true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The user agent of the device that initiated the transaction (e.g. \&quot;Mozilla/5.0\&quot;)
        /// </summary>
        /// <value>The user agent of the device that initiated the transaction (e.g. \&quot;Mozilla/5.0\&quot;)</value>
        [DataMember(Name = "user_agent", EmitDefaultValue = true)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignalDevice {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SignalDevice);
        }

        /// <summary>
        /// Returns true if SignalDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalDevice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
                }
                if (this.UserAgent != null)
                {
                    hashCode = (hashCode * 59) + this.UserAgent.GetHashCode();
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