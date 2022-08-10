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
    /// PutStreamRequest
    /// </summary>
    [DataContract(Name = "putStreamRequest")]
    public partial class PutStreamRequest : IEquatable<PutStreamRequest>, IValidatableObject
    {
        /// <summary>
        /// Policy for submitting sensor fusion vector on this request, overriding per-feature submit rules in fusion configuration. One of \&quot;default\&quot;, \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;default\&quot;). Under \&quot;default\&quot; policy, the per-feature settings of \&quot;submit\&quot; or \&quot;nosubmit\&quot; are used to determine whether this update to the fusion vector triggers an inference.
        /// </summary>
        /// <value>Policy for submitting sensor fusion vector on this request, overriding per-feature submit rules in fusion configuration. One of \&quot;default\&quot;, \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;default\&quot;). Under \&quot;default\&quot; policy, the per-feature settings of \&quot;submit\&quot; or \&quot;nosubmit\&quot; are used to determine whether this update to the fusion vector triggers an inference.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubmitRuleEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Submit for value: submit
            /// </summary>
            [EnumMember(Value = "submit")]
            Submit = 2,

            /// <summary>
            /// Enum Nosubmit for value: nosubmit
            /// </summary>
            [EnumMember(Value = "nosubmit")]
            Nosubmit = 3

        }


        /// <summary>
        /// Policy for submitting sensor fusion vector on this request, overriding per-feature submit rules in fusion configuration. One of \&quot;default\&quot;, \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;default\&quot;). Under \&quot;default\&quot; policy, the per-feature settings of \&quot;submit\&quot; or \&quot;nosubmit\&quot; are used to determine whether this update to the fusion vector triggers an inference.
        /// </summary>
        /// <value>Policy for submitting sensor fusion vector on this request, overriding per-feature submit rules in fusion configuration. One of \&quot;default\&quot;, \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;default\&quot;). Under \&quot;default\&quot; policy, the per-feature settings of \&quot;submit\&quot; or \&quot;nosubmit\&quot; are used to determine whether this update to the fusion vector triggers an inference.</value>
        [DataMember(Name = "submitRule", EmitDefaultValue = false)]
        public SubmitRuleEnum? SubmitRule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutStreamRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PutStreamRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutStreamRequest" /> class.
        /// </summary>
        /// <param name="vector">vector (required).</param>
        /// <param name="submitRule">Policy for submitting sensor fusion vector on this request, overriding per-feature submit rules in fusion configuration. One of \&quot;default\&quot;, \&quot;submit\&quot;, \&quot;nosubmit\&quot; (defaults to \&quot;default\&quot;). Under \&quot;default\&quot; policy, the per-feature settings of \&quot;submit\&quot; or \&quot;nosubmit\&quot; are used to determine whether this update to the fusion vector triggers an inference..</param>
        public PutStreamRequest(List<PutStreamFeature> vector = default(List<PutStreamFeature>), SubmitRuleEnum? submitRule = default(SubmitRuleEnum?))
        {
            // to ensure "vector" is required (not null)
            if (vector == null)
            {
                throw new ArgumentNullException("vector is a required property for PutStreamRequest and cannot be null");
            }
            this.Vector = vector;
            this.SubmitRule = submitRule;
        }

        /// <summary>
        /// Gets or Sets Vector
        /// </summary>
        [DataMember(Name = "vector", IsRequired = true, EmitDefaultValue = false)]
        public List<PutStreamFeature> Vector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutStreamRequest {\n");
            sb.Append("  Vector: ").Append(Vector).Append("\n");
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
            return this.Equals(input as PutStreamRequest);
        }

        /// <summary>
        /// Returns true if PutStreamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PutStreamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutStreamRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Vector == input.Vector ||
                    this.Vector != null &&
                    input.Vector != null &&
                    this.Vector.SequenceEqual(input.Vector)
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
                if (this.Vector != null)
                {
                    hashCode = (hashCode * 59) + this.Vector.GetHashCode();
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
