/* 
 * Amber API Server
 *
 * Boon Logic Amber API Server
 *
 * OpenAPI spec version: 1.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = BoonAmber.Client.SwaggerDateConverter;

namespace BoonAmber.Model
{
    /// <summary>
    /// PutStreamFeature
    /// </summary>
    [DataContract]
        public partial class PutStreamFeature :  IEquatable<PutStreamFeature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutStreamFeature" /> class.
        /// </summary>
        /// <param name="label">label associated with feature (required).</param>
        /// <param name="value">new value for this feature in sensor fusion vector (required).</param>
        /// <param name="ts">ISO-format timestamp for this data value.</param>
        public PutStreamFeature(string label = default(string), float? value = default(float?), string ts = default(string))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new InvalidDataException("label is a required property for PutStreamFeature and cannot be null");
            }
            else
            {
                this.Label = label;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for PutStreamFeature and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            this.Ts = ts;
        }
        
        /// <summary>
        /// label associated with feature
        /// </summary>
        /// <value>label associated with feature</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// new value for this feature in sensor fusion vector
        /// </summary>
        /// <value>new value for this feature in sensor fusion vector</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float? Value { get; set; }

        /// <summary>
        /// ISO-format timestamp for this data value
        /// </summary>
        /// <value>ISO-format timestamp for this data value</value>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public string Ts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Ts != null)
                    hashCode = hashCode * 59 + this.Ts.GetHashCode();
                return hashCode;
            }
        }
    }
}
