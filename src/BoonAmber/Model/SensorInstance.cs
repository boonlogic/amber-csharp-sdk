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
    /// SensorInstance
    /// </summary>
    [DataContract]
        public partial class SensorInstance :  IEquatable<SensorInstance>
    {
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
                throw new InvalidDataException("label is a required property for SensorInstance and cannot be null");
            }
            else
            {
                this.Label = label;
            }
            // to ensure "sensorId" is required (not null)
            if (sensorId == null)
            {
                throw new InvalidDataException("sensorId is a required property for SensorInstance and cannot be null");
            }
            else
            {
                this.SensorId = sensorId;
            }
        }
        
        /// <summary>
        /// Additional label to be assigned for sensor
        /// </summary>
        /// <value>Additional label to be assigned for sensor</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Unique identifier for sensor
        /// </summary>
        /// <value>Unique identifier for sensor</value>
        [DataMember(Name="sensorId", EmitDefaultValue=false)]
        public string SensorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.SensorId != null)
                    hashCode = hashCode * 59 + this.SensorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
