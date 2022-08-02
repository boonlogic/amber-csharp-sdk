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
    /// MNano
    /// </summary>
    [DataContract]
        public partial class MNano :  IEquatable<MNano>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MNano" /> class.
        /// </summary>
        /// <param name="mNanoConfig">mNanoConfig (required).</param>
        /// <param name="magicNumber">magicNumber.</param>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="backendVersion">backendVersion.</param>
        /// <param name="mErrorMsg">mErrorMsg.</param>
        /// <param name="mNanoBackend">mNanoBackend.</param>
        public MNano(MNanoConfig mNanoConfig = default(MNanoConfig), int? magicNumber = default(int?), int? versionNumber = default(int?), int? backendVersion = default(int?), string mErrorMsg = default(string), MNanoBackend mNanoBackend = default(MNanoBackend))
        {
            // to ensure "mNanoConfig" is required (not null)
            if (mNanoConfig == null)
            {
                throw new InvalidDataException("mNanoConfig is a required property for MNano and cannot be null");
            }
            else
            {
                this.MNanoConfig = mNanoConfig;
            }
            this.MagicNumber = magicNumber;
            this.VersionNumber = versionNumber;
            this.BackendVersion = backendVersion;
            this.MErrorMsg = mErrorMsg;
            this.MNanoBackend = mNanoBackend;
        }
        
        /// <summary>
        /// Gets or Sets MNanoConfig
        /// </summary>
        [DataMember(Name="m_NanoConfig", EmitDefaultValue=false)]
        public MNanoConfig MNanoConfig { get; set; }

        /// <summary>
        /// Gets or Sets MagicNumber
        /// </summary>
        [DataMember(Name="MagicNumber", EmitDefaultValue=false)]
        public int? MagicNumber { get; set; }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name="VersionNumber", EmitDefaultValue=false)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets BackendVersion
        /// </summary>
        [DataMember(Name="BackendVersion", EmitDefaultValue=false)]
        public int? BackendVersion { get; set; }

        /// <summary>
        /// Gets or Sets MErrorMsg
        /// </summary>
        [DataMember(Name="m_ErrorMsg", EmitDefaultValue=false)]
        public string MErrorMsg { get; set; }

        /// <summary>
        /// Gets or Sets MNanoBackend
        /// </summary>
        [DataMember(Name="m_NanoBackend", EmitDefaultValue=false)]
        public MNanoBackend MNanoBackend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MNano {\n");
            sb.Append("  MNanoConfig: ").Append(MNanoConfig).Append("\n");
            sb.Append("  MagicNumber: ").Append(MagicNumber).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  BackendVersion: ").Append(BackendVersion).Append("\n");
            sb.Append("  MErrorMsg: ").Append(MErrorMsg).Append("\n");
            sb.Append("  MNanoBackend: ").Append(MNanoBackend).Append("\n");
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
            return this.Equals(input as MNano);
        }

        /// <summary>
        /// Returns true if MNano instances are equal
        /// </summary>
        /// <param name="input">Instance of MNano to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MNano input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MNanoConfig == input.MNanoConfig ||
                    (this.MNanoConfig != null &&
                    this.MNanoConfig.Equals(input.MNanoConfig))
                ) && 
                (
                    this.MagicNumber == input.MagicNumber ||
                    (this.MagicNumber != null &&
                    this.MagicNumber.Equals(input.MagicNumber))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.BackendVersion == input.BackendVersion ||
                    (this.BackendVersion != null &&
                    this.BackendVersion.Equals(input.BackendVersion))
                ) && 
                (
                    this.MErrorMsg == input.MErrorMsg ||
                    (this.MErrorMsg != null &&
                    this.MErrorMsg.Equals(input.MErrorMsg))
                ) && 
                (
                    this.MNanoBackend == input.MNanoBackend ||
                    (this.MNanoBackend != null &&
                    this.MNanoBackend.Equals(input.MNanoBackend))
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
                if (this.MNanoConfig != null)
                    hashCode = hashCode * 59 + this.MNanoConfig.GetHashCode();
                if (this.MagicNumber != null)
                    hashCode = hashCode * 59 + this.MagicNumber.GetHashCode();
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.BackendVersion != null)
                    hashCode = hashCode * 59 + this.BackendVersion.GetHashCode();
                if (this.MErrorMsg != null)
                    hashCode = hashCode * 59 + this.MErrorMsg.GetHashCode();
                if (this.MNanoBackend != null)
                    hashCode = hashCode * 59 + this.MNanoBackend.GetHashCode();
                return hashCode;
            }
        }
    }
}
