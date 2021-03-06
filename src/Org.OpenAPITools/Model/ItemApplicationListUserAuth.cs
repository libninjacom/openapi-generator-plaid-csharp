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
    /// User authentication parameters, for clients making a request without an &#x60;access_token&#x60;. This is only allowed for select clients and will not be supported in the future. Most clients should call /item/import to obtain an access token before making a request.
    /// </summary>
    [DataContract(Name = "ItemApplicationListUserAuth")]
    public partial class ItemApplicationListUserAuth : IEquatable<ItemApplicationListUserAuth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApplicationListUserAuth" /> class.
        /// </summary>
        /// <param name="userId">Account username..</param>
        /// <param name="fiUsernameHash">Account username hashed by FI..</param>
        public ItemApplicationListUserAuth(string userId = default(string), string fiUsernameHash = default(string))
        {
            this.UserId = userId;
            this.FiUsernameHash = fiUsernameHash;
        }

        /// <summary>
        /// Account username.
        /// </summary>
        /// <value>Account username.</value>
        [DataMember(Name = "user_id", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Account username hashed by FI.
        /// </summary>
        /// <value>Account username hashed by FI.</value>
        [DataMember(Name = "fi_username_hash", EmitDefaultValue = true)]
        public string FiUsernameHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemApplicationListUserAuth {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  FiUsernameHash: ").Append(FiUsernameHash).Append("\n");
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
            return this.Equals(input as ItemApplicationListUserAuth);
        }

        /// <summary>
        /// Returns true if ItemApplicationListUserAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApplicationListUserAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApplicationListUserAuth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.FiUsernameHash == input.FiUsernameHash ||
                    (this.FiUsernameHash != null &&
                    this.FiUsernameHash.Equals(input.FiUsernameHash))
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
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.FiUsernameHash != null)
                {
                    hashCode = (hashCode * 59) + this.FiUsernameHash.GetHashCode();
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
