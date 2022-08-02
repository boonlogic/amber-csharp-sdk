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
    /// PutConfigResponse
    /// </summary>
    [DataContract]
        public partial class PutConfigResponse :  IEquatable<PutConfigResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutConfigResponse" /> class.
        /// </summary>
        /// <param name="features">features.</param>
        /// <param name="streaming">streaming.</param>
        public PutConfigResponse(List<FusionConfig> features = default(List<FusionConfig>), StreamingParameters streaming = default(StreamingParameters))
        {
            this.Features = features;
            this.Streaming = streaming;
        }
        
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<FusionConfig> Features { get; set; }

        /// <summary>
        /// Gets or Sets Streaming
        /// </summary>
        [DataMember(Name="streaming", EmitDefaultValue=false)]
        public StreamingParameters Streaming { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutConfigResponse {\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Streaming: ").Append(Streaming).Append("\n");
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
            return this.Equals(input as PutConfigResponse);
        }

        /// <summary>
        /// Returns true if PutConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PutConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.Streaming == input.Streaming ||
                    (this.Streaming != null &&
                    this.Streaming.Equals(input.Streaming))
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
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.Streaming != null)
                    hashCode = hashCode * 59 + this.Streaming.GetHashCode();
                return hashCode;
            }
        }
    }
}