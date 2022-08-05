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
    /// SensorInstance
    /// </summary>
    [DataContract(Name = "sensorInstance")]
    public partial class SensorInstance : IEquatable<SensorInstance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInstance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SensorInstance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInstance" /> class.
        /// </summary>
        /// <param name="label">Additional label to be assigned for sensor (required).</param>
        /// <param name="sensorId">Unique identifier for sensor (required).</param>
        public SensorInstance(string label = default(string), string sensorId = default(string))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for SensorInstance and cannot be null");
            }
            this.Label = label;
            // to ensure "sensorId" is required (not null)
            if (sensorId == null)
            {
                throw new ArgumentNullException("sensorId is a required property for SensorInstance and cannot be null");
            }
            this.SensorId = sensorId;
        }

        /// <summary>
        /// Additional label to be assigned for sensor
        /// </summary>
        /// <value>Additional label to be assigned for sensor</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Unique identifier for sensor
        /// </summary>
        /// <value>Unique identifier for sensor</value>
        [DataMember(Name = "sensorId", IsRequired = true, EmitDefaultValue = false)]
        public string SensorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SensorInstance {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  SensorId: ").Append(SensorId).Append("\n");
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
            return this.Equals(input as SensorInstance);
        }

        /// <summary>
        /// Returns true if SensorInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of SensorInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensorInstance input)
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
                    this.SensorId == input.SensorId ||
                    (this.SensorId != null &&
                    this.SensorId.Equals(input.SensorId))
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
                if (this.SensorId != null)
                {
                    hashCode = (hashCode * 59) + this.SensorId.GetHashCode();
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