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
    /// MBufferStats
    /// </summary>
    [DataContract(Name = "m_BufferStats")]
    public partial class MBufferStats : IEquatable<MBufferStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MBufferStats" /> class.
        /// </summary>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="totalBytesWritten">totalBytesWritten.</param>
        /// <param name="totalBytesProcessed">totalBytesProcessed.</param>
        /// <param name="loadBufferLength">loadBufferLength.</param>
        /// <param name="loadBufferCapacity">loadBufferCapacity.</param>
        public MBufferStats(int versionNumber = default(int), int totalBytesWritten = default(int), int totalBytesProcessed = default(int), int loadBufferLength = default(int), int loadBufferCapacity = default(int))
        {
            this.VersionNumber = versionNumber;
            this.TotalBytesWritten = totalBytesWritten;
            this.TotalBytesProcessed = totalBytesProcessed;
            this.LoadBufferLength = loadBufferLength;
            this.LoadBufferCapacity = loadBufferCapacity;
        }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name = "VersionNumber", EmitDefaultValue = false)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets TotalBytesWritten
        /// </summary>
        [DataMember(Name = "TotalBytesWritten", EmitDefaultValue = false)]
        public int TotalBytesWritten { get; set; }

        /// <summary>
        /// Gets or Sets TotalBytesProcessed
        /// </summary>
        [DataMember(Name = "TotalBytesProcessed", EmitDefaultValue = false)]
        public int TotalBytesProcessed { get; set; }

        /// <summary>
        /// Gets or Sets LoadBufferLength
        /// </summary>
        [DataMember(Name = "LoadBufferLength", EmitDefaultValue = false)]
        public int LoadBufferLength { get; set; }

        /// <summary>
        /// Gets or Sets LoadBufferCapacity
        /// </summary>
        [DataMember(Name = "LoadBufferCapacity", EmitDefaultValue = false)]
        public int LoadBufferCapacity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MBufferStats {\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  TotalBytesWritten: ").Append(TotalBytesWritten).Append("\n");
            sb.Append("  TotalBytesProcessed: ").Append(TotalBytesProcessed).Append("\n");
            sb.Append("  LoadBufferLength: ").Append(LoadBufferLength).Append("\n");
            sb.Append("  LoadBufferCapacity: ").Append(LoadBufferCapacity).Append("\n");
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
            return this.Equals(input as MBufferStats);
        }

        /// <summary>
        /// Returns true if MBufferStats instances are equal
        /// </summary>
        /// <param name="input">Instance of MBufferStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MBufferStats input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.VersionNumber == input.VersionNumber ||
                    this.VersionNumber.Equals(input.VersionNumber)
                ) &&
                (
                    this.TotalBytesWritten == input.TotalBytesWritten ||
                    this.TotalBytesWritten.Equals(input.TotalBytesWritten)
                ) &&
                (
                    this.TotalBytesProcessed == input.TotalBytesProcessed ||
                    this.TotalBytesProcessed.Equals(input.TotalBytesProcessed)
                ) &&
                (
                    this.LoadBufferLength == input.LoadBufferLength ||
                    this.LoadBufferLength.Equals(input.LoadBufferLength)
                ) &&
                (
                    this.LoadBufferCapacity == input.LoadBufferCapacity ||
                    this.LoadBufferCapacity.Equals(input.LoadBufferCapacity)
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
                hashCode = (hashCode * 59) + this.VersionNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalBytesWritten.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalBytesProcessed.GetHashCode();
                hashCode = (hashCode * 59) + this.LoadBufferLength.GetHashCode();
                hashCode = (hashCode * 59) + this.LoadBufferCapacity.GetHashCode();
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
