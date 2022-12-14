/*
 * Amber API Server
 *
 * Boon Logic Amber API Server
 *
 * The version of the OpenAPI document: 1.0.3
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
using OpenAPIDateConverter = BoonAmber.Client.OpenAPIDateConverter;

namespace BoonAmber.Model
{
    /// <summary>
    /// FusionConfig
    /// </summary>
    [DataContract(Name = "fusionConfig")]
    public partial class FusionConfig : IEquatable<FusionConfig>, IValidatableObject
    {
        /// <summary>
        /// policy for submitting sensor fusion vector when this feature is updated. One of \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;submit\&quot;)
        /// </summary>
        /// <value>policy for submitting sensor fusion vector when this feature is updated. One of \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;submit\&quot;)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubmitRuleEnum
        {
            /// <summary>
            /// Enum Submit for value: submit
            /// </summary>
            [EnumMember(Value = "submit")]
            Submit = 1,

            /// <summary>
            /// Enum Nosubmit for value: nosubmit
            /// </summary>
            [EnumMember(Value = "nosubmit")]
            Nosubmit = 2

        }


        /// <summary>
        /// policy for submitting sensor fusion vector when this feature is updated. One of \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;submit\&quot;)
        /// </summary>
        /// <value>policy for submitting sensor fusion vector when this feature is updated. One of \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;submit\&quot;)</value>
        [DataMember(Name = "submitRule", EmitDefaultValue = false)]
        public SubmitRuleEnum? SubmitRule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FusionConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FusionConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FusionConfig" /> class.
        /// </summary>
        /// <param name="label">label associated with feature (required).</param>
        /// <param name="submitRule">policy for submitting sensor fusion vector when this feature is updated. One of \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;submit\&quot;).</param>
        public FusionConfig(string label = default(string), SubmitRuleEnum? submitRule = default(SubmitRuleEnum?))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for FusionConfig and cannot be null");
            }
            this.Label = label;
            this.SubmitRule = submitRule;
        }

        /// <summary>
        /// label associated with feature
        /// </summary>
        /// <value>label associated with feature</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FusionConfig {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  SubmitRule: ").Append(SubmitRule).Append("\n");
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
            return this.Equals(input as FusionConfig);
        }

        /// <summary>
        /// Returns true if FusionConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of FusionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FusionConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) &&
                (
                    this.SubmitRule == input.SubmitRule ||
                    this.SubmitRule.Equals(input.SubmitRule)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SubmitRule.GetHashCode();
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
