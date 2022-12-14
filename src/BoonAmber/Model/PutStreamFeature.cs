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
    /// PutStreamFeature
    /// </summary>
    [DataContract(Name = "putStreamFeature")]
    public partial class PutStreamFeature : IEquatable<PutStreamFeature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutStreamFeature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PutStreamFeature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutStreamFeature" /> class.
        /// </summary>
        /// <param name="label">label associated with feature (required).</param>
        /// <param name="value">new value for this feature in sensor fusion vector (required).</param>
        /// <param name="ts">ISO-format timestamp for this data value.</param>
        public PutStreamFeature(string label = default(string), float value = default(float), string ts = default(string))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for PutStreamFeature and cannot be null");
            }
            this.Label = label;
            this.Value = value;
            this.Ts = ts;
        }

        /// <summary>
        /// label associated with feature
        /// </summary>
        /// <value>label associated with feature</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// new value for this feature in sensor fusion vector
        /// </summary>
        /// <value>new value for this feature in sensor fusion vector</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public float Value { get; set; }

        /// <summary>
        /// ISO-format timestamp for this data value
        /// </summary>
        /// <value>ISO-format timestamp for this data value</value>
        [DataMember(Name = "ts", EmitDefaultValue = false)]
        public string Ts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutStreamFeature {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
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
            return this.Equals(input as PutStreamFeature);
        }

        /// <summary>
        /// Returns true if PutStreamFeature instances are equal
        /// </summary>
        /// <param name="input">Instance of PutStreamFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutStreamFeature input)
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
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) &&
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.Ts != null)
                {
                    hashCode = (hashCode * 59) + this.Ts.GetHashCode();
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
