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
    /// Contains the authorization decision for a proposed transfer
    /// </summary>
    [DataContract(Name = "TransferAuthorization")]
    public partial class TransferAuthorization : Dictionary<String, Object>, IEquatable<TransferAuthorization>, IValidatableObject
    {
        /// <summary>
        ///  A decision regarding the proposed transfer.  &#x60;approved&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;permitted&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;declined&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details.
        /// </summary>
        /// <value> A decision regarding the proposed transfer.  &#x60;approved&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;permitted&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;declined&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DecisionEnum
        {
            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 1,

            /// <summary>
            /// Enum Permitted for value: permitted
            /// </summary>
            [EnumMember(Value = "permitted")]
            Permitted = 2,

            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 3

        }


        /// <summary>
        ///  A decision regarding the proposed transfer.  &#x60;approved&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;permitted&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;declined&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details.
        /// </summary>
        /// <value> A decision regarding the proposed transfer.  &#x60;approved&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;permitted&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;declined&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details.</value>
        [DataMember(Name = "decision", IsRequired = true, EmitDefaultValue = false)]
        public DecisionEnum Decision { get; set; }

        /// <summary>
        /// Gets or Sets GuaranteeDecision
        /// </summary>
        [DataMember(Name = "guarantee_decision", IsRequired = true, EmitDefaultValue = true)]
        public TransferAuthorizationGuaranteeDecision GuaranteeDecision { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAuthorization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferAuthorization()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAuthorization" /> class.
        /// </summary>
        /// <param name="id">Plaid’s unique identifier for a transfer authorization. (required).</param>
        /// <param name="created">The datetime representing when the authorization was created, in the format &#x60;2006-01-02T15:04:05Z&#x60;. (required).</param>
        /// <param name="decision"> A decision regarding the proposed transfer.  &#x60;approved&#x60; – The proposed transfer has received the end user&#39;s consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.   &#x60;permitted&#x60; – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.  &#x60;declined&#x60; – Plaid reviewed the proposed transfer and declined processing. Refer to the &#x60;code&#x60; field in the &#x60;decision_rationale&#x60; object for details. (required).</param>
        /// <param name="decisionRationale">decisionRationale (required).</param>
        /// <param name="guaranteeDecision">guaranteeDecision (required).</param>
        /// <param name="guaranteeDecisionRationale">guaranteeDecisionRationale (required).</param>
        /// <param name="proposedTransfer">proposedTransfer (required).</param>
        public TransferAuthorization(string id = default(string), DateTime created = default(DateTime), DecisionEnum decision = default(DecisionEnum), TransferAuthorizationDecisionRationale decisionRationale = default(TransferAuthorizationDecisionRationale), TransferAuthorizationGuaranteeDecision guaranteeDecision = default(TransferAuthorizationGuaranteeDecision), TransferAuthorizationGuaranteeDecisionRationale guaranteeDecisionRationale = default(TransferAuthorizationGuaranteeDecisionRationale), TransferAuthorizationProposedTransfer proposedTransfer = default(TransferAuthorizationProposedTransfer)) : base()
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TransferAuthorization and cannot be null");
            }
            this.Id = id;
            this.Created = created;
            this.Decision = decision;
            // to ensure "decisionRationale" is required (not null)
            if (decisionRationale == null)
            {
                throw new ArgumentNullException("decisionRationale is a required property for TransferAuthorization and cannot be null");
            }
            this.DecisionRationale = decisionRationale;
            this.GuaranteeDecision = guaranteeDecision;
            // to ensure "guaranteeDecisionRationale" is required (not null)
            if (guaranteeDecisionRationale == null)
            {
                throw new ArgumentNullException("guaranteeDecisionRationale is a required property for TransferAuthorization and cannot be null");
            }
            this.GuaranteeDecisionRationale = guaranteeDecisionRationale;
            // to ensure "proposedTransfer" is required (not null)
            if (proposedTransfer == null)
            {
                throw new ArgumentNullException("proposedTransfer is a required property for TransferAuthorization and cannot be null");
            }
            this.ProposedTransfer = proposedTransfer;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Plaid’s unique identifier for a transfer authorization.
        /// </summary>
        /// <value>Plaid’s unique identifier for a transfer authorization.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The datetime representing when the authorization was created, in the format &#x60;2006-01-02T15:04:05Z&#x60;.
        /// </summary>
        /// <value>The datetime representing when the authorization was created, in the format &#x60;2006-01-02T15:04:05Z&#x60;.</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets DecisionRationale
        /// </summary>
        [DataMember(Name = "decision_rationale", IsRequired = true, EmitDefaultValue = true)]
        public TransferAuthorizationDecisionRationale DecisionRationale { get; set; }

        /// <summary>
        /// Gets or Sets GuaranteeDecisionRationale
        /// </summary>
        [DataMember(Name = "guarantee_decision_rationale", IsRequired = true, EmitDefaultValue = true)]
        public TransferAuthorizationGuaranteeDecisionRationale GuaranteeDecisionRationale { get; set; }

        /// <summary>
        /// Gets or Sets ProposedTransfer
        /// </summary>
        [DataMember(Name = "proposed_transfer", IsRequired = true, EmitDefaultValue = false)]
        public TransferAuthorizationProposedTransfer ProposedTransfer { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferAuthorization {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Decision: ").Append(Decision).Append("\n");
            sb.Append("  DecisionRationale: ").Append(DecisionRationale).Append("\n");
            sb.Append("  GuaranteeDecision: ").Append(GuaranteeDecision).Append("\n");
            sb.Append("  GuaranteeDecisionRationale: ").Append(GuaranteeDecisionRationale).Append("\n");
            sb.Append("  ProposedTransfer: ").Append(ProposedTransfer).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as TransferAuthorization);
        }

        /// <summary>
        /// Returns true if TransferAuthorization instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferAuthorization input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && base.Equals(input) && 
                (
                    this.Decision == input.Decision ||
                    this.Decision.Equals(input.Decision)
                ) && base.Equals(input) && 
                (
                    this.DecisionRationale == input.DecisionRationale ||
                    (this.DecisionRationale != null &&
                    this.DecisionRationale.Equals(input.DecisionRationale))
                ) && base.Equals(input) && 
                (
                    this.GuaranteeDecision == input.GuaranteeDecision ||
                    this.GuaranteeDecision.Equals(input.GuaranteeDecision)
                ) && base.Equals(input) && 
                (
                    this.GuaranteeDecisionRationale == input.GuaranteeDecisionRationale ||
                    (this.GuaranteeDecisionRationale != null &&
                    this.GuaranteeDecisionRationale.Equals(input.GuaranteeDecisionRationale))
                ) && base.Equals(input) && 
                (
                    this.ProposedTransfer == input.ProposedTransfer ||
                    (this.ProposedTransfer != null &&
                    this.ProposedTransfer.Equals(input.ProposedTransfer))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Decision.GetHashCode();
                if (this.DecisionRationale != null)
                {
                    hashCode = (hashCode * 59) + this.DecisionRationale.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GuaranteeDecision.GetHashCode();
                if (this.GuaranteeDecisionRationale != null)
                {
                    hashCode = (hashCode * 59) + this.GuaranteeDecisionRationale.GetHashCode();
                }
                if (this.ProposedTransfer != null)
                {
                    hashCode = (hashCode * 59) + this.ProposedTransfer.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
