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
    /// Specifies the multi-factor authentication settings to use with this test account
    /// </summary>
    [DataContract(Name = "MFA")]
    public partial class MFA : Dictionary<String, Object>, IEquatable<MFA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MFA" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MFA()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MFA" /> class.
        /// </summary>
        /// <param name="type">Possible values are &#x60;device&#x60;, &#x60;selections&#x60;, or &#x60;questions&#x60;.  If value is &#x60;device&#x60;, the MFA answer is &#x60;1234&#x60;.  If value is &#x60;selections&#x60;, the MFA answer is always the first option.  If value is &#x60;questions&#x60;, the MFA answer is  &#x60;answer_&lt;i&gt;_&lt;j&gt;&#x60; for the j-th question in the i-th round, starting from 0. For example, the answer to the first question in the second round is &#x60;answer_1_0&#x60;. (required).</param>
        /// <param name="questionRounds">Number of rounds of questions. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;.  (required).</param>
        /// <param name="questionsPerRound">Number of questions per round. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;. If value of type is &#x60;selections&#x60;, default value is 2. (required).</param>
        /// <param name="selectionRounds">Number of rounds of selections, used if &#x60;type&#x60; is &#x60;selections&#x60;. Defaults to 1. (required).</param>
        /// <param name="selectionsPerQuestion">Number of available answers per question, used if &#x60;type&#x60; is &#x60;selection&#x60;. Defaults to 2.  (required).</param>
        public MFA(string type = default(string), decimal questionRounds = default(decimal), decimal questionsPerRound = default(decimal), decimal selectionRounds = default(decimal), decimal selectionsPerQuestion = default(decimal)) : base()
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for MFA and cannot be null");
            }
            this.Type = type;
            this.QuestionRounds = questionRounds;
            this.QuestionsPerRound = questionsPerRound;
            this.SelectionRounds = selectionRounds;
            this.SelectionsPerQuestion = selectionsPerQuestion;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Possible values are &#x60;device&#x60;, &#x60;selections&#x60;, or &#x60;questions&#x60;.  If value is &#x60;device&#x60;, the MFA answer is &#x60;1234&#x60;.  If value is &#x60;selections&#x60;, the MFA answer is always the first option.  If value is &#x60;questions&#x60;, the MFA answer is  &#x60;answer_&lt;i&gt;_&lt;j&gt;&#x60; for the j-th question in the i-th round, starting from 0. For example, the answer to the first question in the second round is &#x60;answer_1_0&#x60;.
        /// </summary>
        /// <value>Possible values are &#x60;device&#x60;, &#x60;selections&#x60;, or &#x60;questions&#x60;.  If value is &#x60;device&#x60;, the MFA answer is &#x60;1234&#x60;.  If value is &#x60;selections&#x60;, the MFA answer is always the first option.  If value is &#x60;questions&#x60;, the MFA answer is  &#x60;answer_&lt;i&gt;_&lt;j&gt;&#x60; for the j-th question in the i-th round, starting from 0. For example, the answer to the first question in the second round is &#x60;answer_1_0&#x60;.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Number of rounds of questions. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;. 
        /// </summary>
        /// <value>Number of rounds of questions. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;. </value>
        [DataMember(Name = "question_rounds", IsRequired = true, EmitDefaultValue = false)]
        public decimal QuestionRounds { get; set; }

        /// <summary>
        /// Number of questions per round. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;. If value of type is &#x60;selections&#x60;, default value is 2.
        /// </summary>
        /// <value>Number of questions per round. Required if value of &#x60;type&#x60; is &#x60;questions&#x60;. If value of type is &#x60;selections&#x60;, default value is 2.</value>
        [DataMember(Name = "questions_per_round", IsRequired = true, EmitDefaultValue = false)]
        public decimal QuestionsPerRound { get; set; }

        /// <summary>
        /// Number of rounds of selections, used if &#x60;type&#x60; is &#x60;selections&#x60;. Defaults to 1.
        /// </summary>
        /// <value>Number of rounds of selections, used if &#x60;type&#x60; is &#x60;selections&#x60;. Defaults to 1.</value>
        [DataMember(Name = "selection_rounds", IsRequired = true, EmitDefaultValue = false)]
        public decimal SelectionRounds { get; set; }

        /// <summary>
        /// Number of available answers per question, used if &#x60;type&#x60; is &#x60;selection&#x60;. Defaults to 2. 
        /// </summary>
        /// <value>Number of available answers per question, used if &#x60;type&#x60; is &#x60;selection&#x60;. Defaults to 2. </value>
        [DataMember(Name = "selections_per_question", IsRequired = true, EmitDefaultValue = false)]
        public decimal SelectionsPerQuestion { get; set; }

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
            sb.Append("class MFA {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  QuestionRounds: ").Append(QuestionRounds).Append("\n");
            sb.Append("  QuestionsPerRound: ").Append(QuestionsPerRound).Append("\n");
            sb.Append("  SelectionRounds: ").Append(SelectionRounds).Append("\n");
            sb.Append("  SelectionsPerQuestion: ").Append(SelectionsPerQuestion).Append("\n");
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
            return this.Equals(input as MFA);
        }

        /// <summary>
        /// Returns true if MFA instances are equal
        /// </summary>
        /// <param name="input">Instance of MFA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MFA input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.QuestionRounds == input.QuestionRounds ||
                    this.QuestionRounds.Equals(input.QuestionRounds)
                ) && base.Equals(input) && 
                (
                    this.QuestionsPerRound == input.QuestionsPerRound ||
                    this.QuestionsPerRound.Equals(input.QuestionsPerRound)
                ) && base.Equals(input) && 
                (
                    this.SelectionRounds == input.SelectionRounds ||
                    this.SelectionRounds.Equals(input.SelectionRounds)
                ) && base.Equals(input) && 
                (
                    this.SelectionsPerQuestion == input.SelectionsPerQuestion ||
                    this.SelectionsPerQuestion.Equals(input.SelectionsPerQuestion)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.QuestionRounds.GetHashCode();
                hashCode = (hashCode * 59) + this.QuestionsPerRound.GetHashCode();
                hashCode = (hashCode * 59) + this.SelectionRounds.GetHashCode();
                hashCode = (hashCode * 59) + this.SelectionsPerQuestion.GetHashCode();
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
