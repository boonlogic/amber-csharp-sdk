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
    /// MNCP
    /// </summary>
    [DataContract]
        public partial class MNCP :  IEquatable<MNCP>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MNCP" /> class.
        /// </summary>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="numOfFeatures">numOfFeatures.</param>
        /// <param name="mNumericFormat">mNumericFormat.</param>
        /// <param name="mPercentVariation">mPercentVariation.</param>
        /// <param name="mAccuracy">mAccuracy.</param>
        /// <param name="mStreamingWindowSize">mStreamingWindowSize.</param>
        public MNCP(int? versionNumber = default(int?), int? numOfFeatures = default(int?), int? mNumericFormat = default(int?), float? mPercentVariation = default(float?), float? mAccuracy = default(float?), int? mStreamingWindowSize = default(int?))
        {
            this.VersionNumber = versionNumber;
            this.NumOfFeatures = numOfFeatures;
            this.MNumericFormat = mNumericFormat;
            this.MPercentVariation = mPercentVariation;
            this.MAccuracy = mAccuracy;
            this.MStreamingWindowSize = mStreamingWindowSize;
        }
        
        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name="VersionNumber", EmitDefaultValue=false)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets NumOfFeatures
        /// </summary>
        [DataMember(Name="NumOfFeatures", EmitDefaultValue=false)]
        public int? NumOfFeatures { get; set; }

        /// <summary>
        /// Gets or Sets MNumericFormat
        /// </summary>
        [DataMember(Name="m_NumericFormat", EmitDefaultValue=false)]
        public int? MNumericFormat { get; set; }

        /// <summary>
        /// Gets or Sets MPercentVariation
        /// </summary>
        [DataMember(Name="m_PercentVariation", EmitDefaultValue=false)]
        public float? MPercentVariation { get; set; }

        /// <summary>
        /// Gets or Sets MAccuracy
        /// </summary>
        [DataMember(Name="m_Accuracy", EmitDefaultValue=false)]
        public float? MAccuracy { get; set; }

        /// <summary>
        /// Gets or Sets MStreamingWindowSize
        /// </summary>
        [DataMember(Name="m_StreamingWindowSize", EmitDefaultValue=false)]
        public int? MStreamingWindowSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MNCP {\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  NumOfFeatures: ").Append(NumOfFeatures).Append("\n");
            sb.Append("  MNumericFormat: ").Append(MNumericFormat).Append("\n");
            sb.Append("  MPercentVariation: ").Append(MPercentVariation).Append("\n");
            sb.Append("  MAccuracy: ").Append(MAccuracy).Append("\n");
            sb.Append("  MStreamingWindowSize: ").Append(MStreamingWindowSize).Append("\n");
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
            return this.Equals(input as MNCP);
        }

        /// <summary>
        /// Returns true if MNCP instances are equal
        /// </summary>
        /// <param name="input">Instance of MNCP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MNCP input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.NumOfFeatures == input.NumOfFeatures ||
                    (this.NumOfFeatures != null &&
                    this.NumOfFeatures.Equals(input.NumOfFeatures))
                ) && 
                (
                    this.MNumericFormat == input.MNumericFormat ||
                    (this.MNumericFormat != null &&
                    this.MNumericFormat.Equals(input.MNumericFormat))
                ) && 
                (
                    this.MPercentVariation == input.MPercentVariation ||
                    (this.MPercentVariation != null &&
                    this.MPercentVariation.Equals(input.MPercentVariation))
                ) && 
                (
                    this.MAccuracy == input.MAccuracy ||
                    (this.MAccuracy != null &&
                    this.MAccuracy.Equals(input.MAccuracy))
                ) && 
                (
                    this.MStreamingWindowSize == input.MStreamingWindowSize ||
                    (this.MStreamingWindowSize != null &&
                    this.MStreamingWindowSize.Equals(input.MStreamingWindowSize))
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
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.NumOfFeatures != null)
                    hashCode = hashCode * 59 + this.NumOfFeatures.GetHashCode();
                if (this.MNumericFormat != null)
                    hashCode = hashCode * 59 + this.MNumericFormat.GetHashCode();
                if (this.MPercentVariation != null)
                    hashCode = hashCode * 59 + this.MPercentVariation.GetHashCode();
                if (this.MAccuracy != null)
                    hashCode = hashCode * 59 + this.MAccuracy.GetHashCode();
                if (this.MStreamingWindowSize != null)
                    hashCode = hashCode * 59 + this.MStreamingWindowSize.GetHashCode();
                return hashCode;
            }
        }
    }
}