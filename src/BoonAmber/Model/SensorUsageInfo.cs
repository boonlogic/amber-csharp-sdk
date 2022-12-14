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
    /// SensorUsageInfo
    /// </summary>
    [DataContract(Name = "sensorUsageInfo")]
    public partial class SensorUsageInfo : IEquatable<SensorUsageInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorUsageInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SensorUsageInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorUsageInfo" /> class.
        /// </summary>
        /// <param name="postConfig">postConfig (required).</param>
        /// <param name="postOutage">postOutage (required).</param>
        /// <param name="postStream">postStream (required).</param>
        /// <param name="putSensor">putSensor (required).</param>
        /// <param name="getSensor">getSensor (required).</param>
        /// <param name="getConfig">getConfig (required).</param>
        /// <param name="getStatus">getStatus (required).</param>
        /// <param name="getRootCause">getRootCause (required).</param>
        /// <param name="getAmberSummary">getAmberSummary (required).</param>
        /// <param name="postPretrain">postPretrain (required).</param>
        /// <param name="getPretrain">getPretrain (required).</param>
        public SensorUsageInfo(EndpointUsageInfo postConfig = default(EndpointUsageInfo), EndpointUsageInfo postOutage = default(EndpointUsageInfo), StreamingEndpointUsageInfo postStream = default(StreamingEndpointUsageInfo), EndpointUsageInfo putSensor = default(EndpointUsageInfo), EndpointUsageInfo getSensor = default(EndpointUsageInfo), EndpointUsageInfo getConfig = default(EndpointUsageInfo), EndpointUsageInfo getStatus = default(EndpointUsageInfo), EndpointUsageInfo getRootCause = default(EndpointUsageInfo), EndpointUsageInfo getAmberSummary = default(EndpointUsageInfo), EndpointUsageInfo postPretrain = default(EndpointUsageInfo), EndpointUsageInfo getPretrain = default(EndpointUsageInfo))
        {
            // to ensure "postConfig" is required (not null)
            if (postConfig == null)
            {
                throw new ArgumentNullException("postConfig is a required property for SensorUsageInfo and cannot be null");
            }
            this.PostConfig = postConfig;
            // to ensure "postOutage" is required (not null)
            if (postOutage == null)
            {
                throw new ArgumentNullException("postOutage is a required property for SensorUsageInfo and cannot be null");
            }
            this.PostOutage = postOutage;
            // to ensure "postStream" is required (not null)
            if (postStream == null)
            {
                throw new ArgumentNullException("postStream is a required property for SensorUsageInfo and cannot be null");
            }
            this.PostStream = postStream;
            // to ensure "putSensor" is required (not null)
            if (putSensor == null)
            {
                throw new ArgumentNullException("putSensor is a required property for SensorUsageInfo and cannot be null");
            }
            this.PutSensor = putSensor;
            // to ensure "getSensor" is required (not null)
            if (getSensor == null)
            {
                throw new ArgumentNullException("getSensor is a required property for SensorUsageInfo and cannot be null");
            }
            this.GetSensor = getSensor;
            // to ensure "getConfig" is required (not null)
            if (getConfig == null)
            {
                throw new ArgumentNullException("getConfig is a required property for SensorUsageInfo and cannot be null");
            }
            this.GetConfig = getConfig;
            // to ensure "getStatus" is required (not null)
            if (getStatus == null)
            {
                throw new ArgumentNullException("getStatus is a required property for SensorUsageInfo and cannot be null");
            }
            this.GetStatus = getStatus;
            // to ensure "getRootCause" is required (not null)
            if (getRootCause == null)
            {
                throw new ArgumentNullException("getRootCause is a required property for SensorUsageInfo and cannot be null");
            }
            this.GetRootCause = getRootCause;
            // to ensure "getAmberSummary" is required (not null)
            if (getAmberSummary == null)
            {
                throw new ArgumentNullException("getAmberSummary is a required property for SensorUsageInfo and cannot be null");
            }
            this.GetAmberSummary = getAmberSummary;
            // to ensure "postPretrain" is required (not null)
            if (postPretrain == null)
            {
                throw new ArgumentNullException("postPretrain is a required property for SensorUsageInfo and cannot be null");
            }
            this.PostPretrain = postPretrain;
            // to ensure "getPretrain" is required (not null)
            if (getPretrain == null)
            {
                throw new ArgumentNullException("getPretrain is a required property for SensorUsageInfo and cannot be null");
            }
            this.GetPretrain = getPretrain;
        }

        /// <summary>
        /// Gets or Sets PostConfig
        /// </summary>
        [DataMember(Name = "postConfig", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo PostConfig { get; set; }

        /// <summary>
        /// Gets or Sets PostOutage
        /// </summary>
        [DataMember(Name = "postOutage", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo PostOutage { get; set; }

        /// <summary>
        /// Gets or Sets PostStream
        /// </summary>
        [DataMember(Name = "postStream", IsRequired = true, EmitDefaultValue = false)]
        public StreamingEndpointUsageInfo PostStream { get; set; }

        /// <summary>
        /// Gets or Sets PutSensor
        /// </summary>
        [DataMember(Name = "putSensor", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo PutSensor { get; set; }

        /// <summary>
        /// Gets or Sets GetSensor
        /// </summary>
        [DataMember(Name = "getSensor", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo GetSensor { get; set; }

        /// <summary>
        /// Gets or Sets GetConfig
        /// </summary>
        [DataMember(Name = "getConfig", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo GetConfig { get; set; }

        /// <summary>
        /// Gets or Sets GetStatus
        /// </summary>
        [DataMember(Name = "getStatus", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo GetStatus { get; set; }

        /// <summary>
        /// Gets or Sets GetRootCause
        /// </summary>
        [DataMember(Name = "getRootCause", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo GetRootCause { get; set; }

        /// <summary>
        /// Gets or Sets GetAmberSummary
        /// </summary>
        [DataMember(Name = "getAmberSummary", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo GetAmberSummary { get; set; }

        /// <summary>
        /// Gets or Sets PostPretrain
        /// </summary>
        [DataMember(Name = "postPretrain", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo PostPretrain { get; set; }

        /// <summary>
        /// Gets or Sets GetPretrain
        /// </summary>
        [DataMember(Name = "getPretrain", IsRequired = true, EmitDefaultValue = false)]
        public EndpointUsageInfo GetPretrain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SensorUsageInfo {\n");
            sb.Append("  PostConfig: ").Append(PostConfig).Append("\n");
            sb.Append("  PostOutage: ").Append(PostOutage).Append("\n");
            sb.Append("  PostStream: ").Append(PostStream).Append("\n");
            sb.Append("  PutSensor: ").Append(PutSensor).Append("\n");
            sb.Append("  GetSensor: ").Append(GetSensor).Append("\n");
            sb.Append("  GetConfig: ").Append(GetConfig).Append("\n");
            sb.Append("  GetStatus: ").Append(GetStatus).Append("\n");
            sb.Append("  GetRootCause: ").Append(GetRootCause).Append("\n");
            sb.Append("  GetAmberSummary: ").Append(GetAmberSummary).Append("\n");
            sb.Append("  PostPretrain: ").Append(PostPretrain).Append("\n");
            sb.Append("  GetPretrain: ").Append(GetPretrain).Append("\n");
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
            return this.Equals(input as SensorUsageInfo);
        }

        /// <summary>
        /// Returns true if SensorUsageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SensorUsageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensorUsageInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.PostConfig == input.PostConfig ||
                    (this.PostConfig != null &&
                    this.PostConfig.Equals(input.PostConfig))
                ) &&
                (
                    this.PostOutage == input.PostOutage ||
                    (this.PostOutage != null &&
                    this.PostOutage.Equals(input.PostOutage))
                ) &&
                (
                    this.PostStream == input.PostStream ||
                    (this.PostStream != null &&
                    this.PostStream.Equals(input.PostStream))
                ) &&
                (
                    this.PutSensor == input.PutSensor ||
                    (this.PutSensor != null &&
                    this.PutSensor.Equals(input.PutSensor))
                ) &&
                (
                    this.GetSensor == input.GetSensor ||
                    (this.GetSensor != null &&
                    this.GetSensor.Equals(input.GetSensor))
                ) &&
                (
                    this.GetConfig == input.GetConfig ||
                    (this.GetConfig != null &&
                    this.GetConfig.Equals(input.GetConfig))
                ) &&
                (
                    this.GetStatus == input.GetStatus ||
                    (this.GetStatus != null &&
                    this.GetStatus.Equals(input.GetStatus))
                ) &&
                (
                    this.GetRootCause == input.GetRootCause ||
                    (this.GetRootCause != null &&
                    this.GetRootCause.Equals(input.GetRootCause))
                ) &&
                (
                    this.GetAmberSummary == input.GetAmberSummary ||
                    (this.GetAmberSummary != null &&
                    this.GetAmberSummary.Equals(input.GetAmberSummary))
                ) &&
                (
                    this.PostPretrain == input.PostPretrain ||
                    (this.PostPretrain != null &&
                    this.PostPretrain.Equals(input.PostPretrain))
                ) &&
                (
                    this.GetPretrain == input.GetPretrain ||
                    (this.GetPretrain != null &&
                    this.GetPretrain.Equals(input.GetPretrain))
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
                if (this.PostConfig != null)
                {
                    hashCode = (hashCode * 59) + this.PostConfig.GetHashCode();
                }
                if (this.PostOutage != null)
                {
                    hashCode = (hashCode * 59) + this.PostOutage.GetHashCode();
                }
                if (this.PostStream != null)
                {
                    hashCode = (hashCode * 59) + this.PostStream.GetHashCode();
                }
                if (this.PutSensor != null)
                {
                    hashCode = (hashCode * 59) + this.PutSensor.GetHashCode();
                }
                if (this.GetSensor != null)
                {
                    hashCode = (hashCode * 59) + this.GetSensor.GetHashCode();
                }
                if (this.GetConfig != null)
                {
                    hashCode = (hashCode * 59) + this.GetConfig.GetHashCode();
                }
                if (this.GetStatus != null)
                {
                    hashCode = (hashCode * 59) + this.GetStatus.GetHashCode();
                }
                if (this.GetRootCause != null)
                {
                    hashCode = (hashCode * 59) + this.GetRootCause.GetHashCode();
                }
                if (this.GetAmberSummary != null)
                {
                    hashCode = (hashCode * 59) + this.GetAmberSummary.GetHashCode();
                }
                if (this.PostPretrain != null)
                {
                    hashCode = (hashCode * 59) + this.PostPretrain.GetHashCode();
                }
                if (this.GetPretrain != null)
                {
                    hashCode = (hashCode * 59) + this.GetPretrain.GetHashCode();
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
