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
    /// ProcessorIdentityGetRequest defines the request schema for &#x60;/processor/identity/get&#x60;
    /// </summary>
    [DataContract(Name = "ProcessorIdentityGetRequest")]
    public partial class ProcessorIdentityGetRequest : IEquatable<ProcessorIdentityGetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorIdentityGetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessorIdentityGetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorIdentityGetRequest" /> class.
        /// </summary>
        /// <param name="clientId">Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body..</param>
        /// <param name="secret">Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body..</param>
        /// <param name="processorToken">The processor token obtained from the Plaid integration partner. Processor tokens are in the format: &#x60;processor-&lt;environment&gt;-&lt;identifier&gt;&#x60; (required).</param>
        public ProcessorIdentityGetRequest(string clientId = default(string), string secret = default(string), string processorToken = default(string))
        {
            // to ensure "processorToken" is required (not null)
            if (processorToken == null)
            {
                throw new ArgumentNullException("processorToken is a required property for ProcessorIdentityGetRequest and cannot be null");
            }
            this.ProcessorToken = processorToken;
            this.ClientId = clientId;
            this.Secret = secret;
        }

        /// <summary>
        /// Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;client_id&#x60;. The &#x60;client_id&#x60; is required and may be provided either in the &#x60;PLAID-CLIENT-ID&#x60; header or as part of a request body.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.
        /// </summary>
        /// <value>Your Plaid API &#x60;secret&#x60;. The &#x60;secret&#x60; is required and may be provided either in the &#x60;PLAID-SECRET&#x60; header or as part of a request body.</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// The processor token obtained from the Plaid integration partner. Processor tokens are in the format: &#x60;processor-&lt;environment&gt;-&lt;identifier&gt;&#x60;
        /// </summary>
        /// <value>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: &#x60;processor-&lt;environment&gt;-&lt;identifier&gt;&#x60;</value>
        [DataMember(Name = "processor_token", IsRequired = true, EmitDefaultValue = false)]
        public string ProcessorToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessorIdentityGetRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  ProcessorToken: ").Append(ProcessorToken).Append("\n");
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
            return this.Equals(input as ProcessorIdentityGetRequest);
        }

        /// <summary>
        /// Returns true if ProcessorIdentityGetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessorIdentityGetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessorIdentityGetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.ProcessorToken == input.ProcessorToken ||
                    (this.ProcessorToken != null &&
                    this.ProcessorToken.Equals(input.ProcessorToken))
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                if (this.ProcessorToken != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessorToken.GetHashCode();
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
