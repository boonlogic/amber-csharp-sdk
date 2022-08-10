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
    /// PostConfigResponse
    /// </summary>
    [DataContract(Name = "postConfigResponse")]
    public partial class PostConfigResponse : IEquatable<PostConfigResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostConfigResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostConfigResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostConfigResponse" /> class.
        /// </summary>
        /// <param name="anomalyHistoryWindow">the number of samples to use when calculating AH.</param>
        /// <param name="learningRateNumerator">enables graduation requirements for learning.</param>
        /// <param name="learningRateDenominator">enables graduation requirements for learning.</param>
        /// <param name="learningMaxClusters">learning graduation requirement for stopping learning upon reaching this cluster count.</param>
        /// <param name="learningMaxSamples">learning graduation requirement for stopping learning after acquiring this many samples.</param>
        /// <param name="featureCount">number of features per sample (required).</param>
        /// <param name="streamingWindowSize">streaming window size (required).</param>
        /// <param name="features">features.</param>
        /// <param name="samplesToBuffer">the number of samples to be applied before autotuning begins (required).</param>
        /// <param name="percentVariationOverride">override autotuned percent variation with this value.</param>
        public PostConfigResponse(int anomalyHistoryWindow = default(int), int learningRateNumerator = default(int), int learningRateDenominator = default(int), int learningMaxClusters = default(int), int learningMaxSamples = default(int), int featureCount = default(int), int streamingWindowSize = default(int), List<FeatureConfig> features = default(List<FeatureConfig>), int samplesToBuffer = default(int), float percentVariationOverride = default(float))
        {
            this.FeatureCount = featureCount;
            this.StreamingWindowSize = streamingWindowSize;
            this.SamplesToBuffer = samplesToBuffer;
            this.AnomalyHistoryWindow = anomalyHistoryWindow;
            this.LearningRateNumerator = learningRateNumerator;
            this.LearningRateDenominator = learningRateDenominator;
            this.LearningMaxClusters = learningMaxClusters;
            this.LearningMaxSamples = learningMaxSamples;
            this.Features = features;
            this.PercentVariationOverride = percentVariationOverride;
        }

        /// <summary>
        /// the number of samples to use when calculating AH
        /// </summary>
        /// <value>the number of samples to use when calculating AH</value>
        [DataMember(Name = "anomalyHistoryWindow", EmitDefaultValue = false)]
        public int AnomalyHistoryWindow { get; set; }

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
        /// number of features per sample
        /// </summary>
        /// <value>number of features per sample</value>
        [DataMember(Name = "featureCount", IsRequired = true, EmitDefaultValue = false)]
        public int FeatureCount { get; set; }

        /// <summary>
        /// streaming window size
        /// </summary>
        /// <value>streaming window size</value>
        [DataMember(Name = "streamingWindowSize", IsRequired = true, EmitDefaultValue = false)]
        public int StreamingWindowSize { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public List<FeatureConfig> Features { get; set; }

        /// <summary>
        /// the number of samples to be applied before autotuning begins
        /// </summary>
        /// <value>the number of samples to be applied before autotuning begins</value>
        [DataMember(Name = "samplesToBuffer", IsRequired = true, EmitDefaultValue = false)]
        public int SamplesToBuffer { get; set; }

        /// <summary>
        /// override autotuned percent variation with this value
        /// </summary>
        /// <value>override autotuned percent variation with this value</value>
        [DataMember(Name = "percentVariationOverride", EmitDefaultValue = false)]
        public float PercentVariationOverride { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostConfigResponse {\n");
            sb.Append("  AnomalyHistoryWindow: ").Append(AnomalyHistoryWindow).Append("\n");
            sb.Append("  LearningRateNumerator: ").Append(LearningRateNumerator).Append("\n");
            sb.Append("  LearningRateDenominator: ").Append(LearningRateDenominator).Append("\n");
            sb.Append("  LearningMaxClusters: ").Append(LearningMaxClusters).Append("\n");
            sb.Append("  LearningMaxSamples: ").Append(LearningMaxSamples).Append("\n");
            sb.Append("  FeatureCount: ").Append(FeatureCount).Append("\n");
            sb.Append("  StreamingWindowSize: ").Append(StreamingWindowSize).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  SamplesToBuffer: ").Append(SamplesToBuffer).Append("\n");
            sb.Append("  PercentVariationOverride: ").Append(PercentVariationOverride).Append("\n");
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
            return this.Equals(input as PostConfigResponse);
        }

        /// <summary>
        /// Returns true if PostConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PostConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostConfigResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AnomalyHistoryWindow == input.AnomalyHistoryWindow ||
                    this.AnomalyHistoryWindow.Equals(input.AnomalyHistoryWindow)
                ) &&
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
                ) &&
                (
                    this.FeatureCount == input.FeatureCount ||
                    this.FeatureCount.Equals(input.FeatureCount)
                ) &&
                (
                    this.StreamingWindowSize == input.StreamingWindowSize ||
                    this.StreamingWindowSize.Equals(input.StreamingWindowSize)
                ) &&
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) &&
                (
                    this.SamplesToBuffer == input.SamplesToBuffer ||
                    this.SamplesToBuffer.Equals(input.SamplesToBuffer)
                ) &&
                (
                    this.PercentVariationOverride == input.PercentVariationOverride ||
                    this.PercentVariationOverride.Equals(input.PercentVariationOverride)
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
                hashCode = (hashCode * 59) + this.AnomalyHistoryWindow.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningRateNumerator.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningRateDenominator.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningMaxClusters.GetHashCode();
                hashCode = (hashCode * 59) + this.LearningMaxSamples.GetHashCode();
                hashCode = (hashCode * 59) + this.FeatureCount.GetHashCode();
                hashCode = (hashCode * 59) + this.StreamingWindowSize.GetHashCode();
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SamplesToBuffer.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentVariationOverride.GetHashCode();
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
            // StreamingWindowSize (int) maximum
            if (this.StreamingWindowSize > (int)500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreamingWindowSize, must be a value less than or equal to 500.", new[] { "StreamingWindowSize" });
            }

            yield break;
        }
    }

}
