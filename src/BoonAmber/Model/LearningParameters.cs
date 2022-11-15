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
    /// LearningParameters
    /// </summary>
    [DataContract(Name = "learningParameters")]
    public partial class LearningParameters : IEquatable<LearningParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningParameters" /> class.
        /// </summary>
        /// <param name="learningRateNumerator">enables graduation requirements for learning.</param>
        /// <param name="learningRateDenominator">enables graduation requirements for learning.</param>
        /// <param name="learningMaxClusters">learning graduation requirement for stopping learning upon reaching this cluster count.</param>
        /// <param name="learningMaxSamples">learning graduation requirement for stopping learning after acquiring this many samples.</param>
        public LearningParameters(int learningRateNumerator = default(int), int learningRateDenominator = default(int), int learningMaxClusters = default(int), int learningMaxSamples = default(int))
        {
            this.LearningRateNumerator = learningRateNumerator;
            this.LearningRateDenominator = learningRateDenominator;
            this.LearningMaxClusters = learningMaxClusters;
            this.LearningMaxSamples = learningMaxSamples;
        }

        /// <summary>
        /// enables graduation requirements for learning
        /// </summary>
        /// <value>enables graduation requirements for learning</value>
        [DataMember(Name = "learningRateNumerator", EmitDefaultValue = false)]
        public int LearningRateNumerator { get; set; }

        /// <summary>
        /// enables graduation requirements for learning
        /// </summary>
        /// <value>enables graduation requirements for learning</value>
        [DataMember(Name = "learningRateDenominator", EmitDefaultValue = false)]
        public int LearningRateDenominator { get; set; }

        /// <summary>
        /// learning graduation requirement for stopping learning upon reaching this cluster count
        /// </summary>
        /// <value>learning graduation requirement for stopping learning upon reaching this cluster count</value>
        [DataMember(Name = "learningMaxClusters", EmitDefaultValue = false)]
        public int LearningMaxClusters { get; set; }

        /// <summary>
        /// learning graduation requirement for stopping learning after acquiring this many samples
        /// </summary>
        /// <value>learning graduation requirement for stopping learning after acquiring this many samples</value>
        [DataMember(Name = "learningMaxSamples", EmitDefaultValue = false)]
        public int LearningMaxSamples { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LearningParameters {\n");
            sb.Append("  LearningRateNumerator: ").Append(LearningRateNumerator).Append("\n");
            sb.Append("  LearningRateDenominator: ").Append(LearningRateDenominator).Append("\n");
            sb.Append("  LearningMaxClusters: ").Append(LearningMaxClusters).Append("\n");
            sb.Append("  LearningMaxSamples: ").Append(LearningMaxSamples).Append("\n");
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
            return this.Equals(input as LearningParameters);
        }

        /// <summary>
        /// Returns true if LearningParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of LearningParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningParameters input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.LearningRateNumerator == input.LearningRateNumerator ||
                    this.LearningRateNumerator.Equals(input.LearningRateNumerator)
                ) &&
                (
                    this.LearningRateDenominator == input.LearningRateDenominator ||
                    this.LearningRateDenominator.Equals(input.LearningRateDenominator)
                ) &&
                (
                    this.LearningMaxClusters == input.LearningMaxClusters ||
                    this.LearningMaxClusters.Equals(input.LearningMaxClusters)
                ) &&
                (
                    this.LearningMaxSamples == input.LearningMaxSamples ||
                    this.LearningMaxSamples.Equals(input.LearningMaxSamples)
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
                hashCode = (hashCode * 59) + this.LearningRateNumerator.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningRateDenominator.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningMaxClusters.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningMaxSamples.GetHashCode();
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