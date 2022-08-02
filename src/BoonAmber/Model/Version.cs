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
    /// Version
    /// </summary>
    [DataContract]
        public partial class Version :  IEquatable<Version>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="release">release (required).</param>
        /// <param name="apiVersion">apiVersion (required).</param>
        /// <param name="builder">builder (required).</param>
        /// <param name="expertApi">expertApi (required).</param>
        /// <param name="expertCommon">expertCommon (required).</param>
        /// <param name="nanoSecure">nanoSecure (required).</param>
        /// <param name="swaggerUi">swaggerUi (required).</param>
        public Version(string release = default(string), string apiVersion = default(string), string builder = default(string), string expertApi = default(string), string expertCommon = default(string), string nanoSecure = default(string), string swaggerUi = default(string))
        {
            // to ensure "release" is required (not null)
            if (release == null)
            {
                throw new InvalidDataException("release is a required property for Version and cannot be null");
            }
            else
            {
                this.Release = release;
            }
            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null)
            {
                throw new InvalidDataException("apiVersion is a required property for Version and cannot be null");
            }
            else
            {
                this.ApiVersion = apiVersion;
            }
            // to ensure "builder" is required (not null)
            if (builder == null)
            {
                throw new InvalidDataException("builder is a required property for Version and cannot be null");
            }
            else
            {
                this.Builder = builder;
            }
            // to ensure "expertApi" is required (not null)
            if (expertApi == null)
            {
                throw new InvalidDataException("expertApi is a required property for Version and cannot be null");
            }
            else
            {
                this.ExpertApi = expertApi;
            }
            // to ensure "expertCommon" is required (not null)
            if (expertCommon == null)
            {
                throw new InvalidDataException("expertCommon is a required property for Version and cannot be null");
            }
            else
            {
                this.ExpertCommon = expertCommon;
            }
            // to ensure "nanoSecure" is required (not null)
            if (nanoSecure == null)
            {
                throw new InvalidDataException("nanoSecure is a required property for Version and cannot be null");
            }
            else
            {
                this.NanoSecure = nanoSecure;
            }
            // to ensure "swaggerUi" is required (not null)
            if (swaggerUi == null)
            {
                throw new InvalidDataException("swaggerUi is a required property for Version and cannot be null");
            }
            else
            {
                this.SwaggerUi = swaggerUi;
            }
        }
        
        /// <summary>
        /// Gets or Sets Release
        /// </summary>
        [DataMember(Name="release", EmitDefaultValue=false)]
        public string Release { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="api-version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets Builder
        /// </summary>
        [DataMember(Name="builder", EmitDefaultValue=false)]
        public string Builder { get; set; }

        /// <summary>
        /// Gets or Sets ExpertApi
        /// </summary>
        [DataMember(Name="expert-api", EmitDefaultValue=false)]
        public string ExpertApi { get; set; }

        /// <summary>
        /// Gets or Sets ExpertCommon
        /// </summary>
        [DataMember(Name="expert-common", EmitDefaultValue=false)]
        public string ExpertCommon { get; set; }

        /// <summary>
        /// Gets or Sets NanoSecure
        /// </summary>
        [DataMember(Name="nano-secure", EmitDefaultValue=false)]
        public string NanoSecure { get; set; }

        /// <summary>
        /// Gets or Sets SwaggerUi
        /// </summary>
        [DataMember(Name="swagger-ui", EmitDefaultValue=false)]
        public string SwaggerUi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Builder: ").Append(Builder).Append("\n");
            sb.Append("  ExpertApi: ").Append(ExpertApi).Append("\n");
            sb.Append("  ExpertCommon: ").Append(ExpertCommon).Append("\n");
            sb.Append("  NanoSecure: ").Append(NanoSecure).Append("\n");
            sb.Append("  SwaggerUi: ").Append(SwaggerUi).Append("\n");
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
            return this.Equals(input as Version);
        }

        /// <summary>
        /// Returns true if Version instances are equal
        /// </summary>
        /// <param name="input">Instance of Version to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Release == input.Release ||
                    (this.Release != null &&
                    this.Release.Equals(input.Release))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Builder == input.Builder ||
                    (this.Builder != null &&
                    this.Builder.Equals(input.Builder))
                ) && 
                (
                    this.ExpertApi == input.ExpertApi ||
                    (this.ExpertApi != null &&
                    this.ExpertApi.Equals(input.ExpertApi))
                ) && 
                (
                    this.ExpertCommon == input.ExpertCommon ||
                    (this.ExpertCommon != null &&
                    this.ExpertCommon.Equals(input.ExpertCommon))
                ) && 
                (
                    this.NanoSecure == input.NanoSecure ||
                    (this.NanoSecure != null &&
                    this.NanoSecure.Equals(input.NanoSecure))
                ) && 
                (
                    this.SwaggerUi == input.SwaggerUi ||
                    (this.SwaggerUi != null &&
                    this.SwaggerUi.Equals(input.SwaggerUi))
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
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Builder != null)
                    hashCode = hashCode * 59 + this.Builder.GetHashCode();
                if (this.ExpertApi != null)
                    hashCode = hashCode * 59 + this.ExpertApi.GetHashCode();
                if (this.ExpertCommon != null)
                    hashCode = hashCode * 59 + this.ExpertCommon.GetHashCode();
                if (this.NanoSecure != null)
                    hashCode = hashCode * 59 + this.NanoSecure.GetHashCode();
                if (this.SwaggerUi != null)
                    hashCode = hashCode * 59 + this.SwaggerUi.GetHashCode();
                return hashCode;
            }
        }
    }
}
