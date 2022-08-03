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
    /// MTraining
    /// </summary>
    [DataContract(Name = "m_Training")]
    public partial class MTraining : IEquatable<MTraining>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MTraining" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MTraining() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MTraining" /> class.
        /// </summary>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="mGeometricPlotY">mGeometricPlotY (required).</param>
        /// <param name="mGeometricPlotX">mGeometricPlotX (required).</param>
        /// <param name="mClusterGrowth">mClusterGrowth (required).</param>
        /// <param name="mAnomalyIndexes">mAnomalyIndexes.</param>
        public MTraining(List<int> versionNumber = default(List<int>), List<float> mGeometricPlotY = default(List<float>), List<int> mGeometricPlotX = default(List<int>), List<int> mClusterGrowth = default(List<int>), List<int> mAnomalyIndexes = default(List<int>))
        {
            // to ensure "mGeometricPlotY" is required (not null)
            if (mGeometricPlotY == null)
            {
                throw new ArgumentNullException("mGeometricPlotY is a required property for MTraining and cannot be null");
            }
            this.MGeometricPlotY = mGeometricPlotY;
            // to ensure "mGeometricPlotX" is required (not null)
            if (mGeometricPlotX == null)
            {
                throw new ArgumentNullException("mGeometricPlotX is a required property for MTraining and cannot be null");
            }
            this.MGeometricPlotX = mGeometricPlotX;
            // to ensure "mClusterGrowth" is required (not null)
            if (mClusterGrowth == null)
            {
                throw new ArgumentNullException("mClusterGrowth is a required property for MTraining and cannot be null");
            }
            this.MClusterGrowth = mClusterGrowth;
            this.VersionNumber = versionNumber;
            this.MAnomalyIndexes = mAnomalyIndexes;
        }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name = "VersionNumber", EmitDefaultValue = false)]
        public List<int> VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets MGeometricPlotY
        /// </summary>
        [DataMember(Name = "m_GeometricPlotY", IsRequired = true, EmitDefaultValue = false)]
        public List<float> MGeometricPlotY { get; set; }

        /// <summary>
        /// Gets or Sets MGeometricPlotX
        /// </summary>
        [DataMember(Name = "m_GeometricPlotX", IsRequired = true, EmitDefaultValue = false)]
        public List<int> MGeometricPlotX { get; set; }

        /// <summary>
        /// Gets or Sets MClusterGrowth
        /// </summary>
        [DataMember(Name = "m_ClusterGrowth", IsRequired = true, EmitDefaultValue = false)]
        public List<int> MClusterGrowth { get; set; }

        /// <summary>
        /// Gets or Sets MAnomalyIndexes
        /// </summary>
        [DataMember(Name = "m_AnomalyIndexes", EmitDefaultValue = false)]
        public List<int> MAnomalyIndexes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MTraining {\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  MGeometricPlotY: ").Append(MGeometricPlotY).Append("\n");
            sb.Append("  MGeometricPlotX: ").Append(MGeometricPlotX).Append("\n");
            sb.Append("  MClusterGrowth: ").Append(MClusterGrowth).Append("\n");
            sb.Append("  MAnomalyIndexes: ").Append(MAnomalyIndexes).Append("\n");
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
            return this.Equals(input as MTraining);
        }

        /// <summary>
        /// Returns true if MTraining instances are equal
        /// </summary>
        /// <param name="input">Instance of MTraining to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MTraining input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VersionNumber == input.VersionNumber ||
                    this.VersionNumber != null &&
                    input.VersionNumber != null &&
                    this.VersionNumber.SequenceEqual(input.VersionNumber)
                ) && 
                (
                    this.MGeometricPlotY == input.MGeometricPlotY ||
                    this.MGeometricPlotY != null &&
                    input.MGeometricPlotY != null &&
                    this.MGeometricPlotY.SequenceEqual(input.MGeometricPlotY)
                ) && 
                (
                    this.MGeometricPlotX == input.MGeometricPlotX ||
                    this.MGeometricPlotX != null &&
                    input.MGeometricPlotX != null &&
                    this.MGeometricPlotX.SequenceEqual(input.MGeometricPlotX)
                ) && 
                (
                    this.MClusterGrowth == input.MClusterGrowth ||
                    this.MClusterGrowth != null &&
                    input.MClusterGrowth != null &&
                    this.MClusterGrowth.SequenceEqual(input.MClusterGrowth)
                ) && 
                (
                    this.MAnomalyIndexes == input.MAnomalyIndexes ||
                    this.MAnomalyIndexes != null &&
                    input.MAnomalyIndexes != null &&
                    this.MAnomalyIndexes.SequenceEqual(input.MAnomalyIndexes)
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
                if (this.VersionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VersionNumber.GetHashCode();
                }
                if (this.MGeometricPlotY != null)
                {
                    hashCode = (hashCode * 59) + this.MGeometricPlotY.GetHashCode();
                }
                if (this.MGeometricPlotX != null)
                {
                    hashCode = (hashCode * 59) + this.MGeometricPlotX.GetHashCode();
                }
                if (this.MClusterGrowth != null)
                {
                    hashCode = (hashCode * 59) + this.MClusterGrowth.GetHashCode();
                }
                if (this.MAnomalyIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.MAnomalyIndexes.GetHashCode();
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
