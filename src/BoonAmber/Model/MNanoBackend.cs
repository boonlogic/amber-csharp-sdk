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
    /// MNanoBackend
    /// </summary>
    [DataContract(Name = "m_NanoBackend")]
    public partial class MNanoBackend : IEquatable<MNanoBackend>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MNanoBackend" /> class.
        /// </summary>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="mPatternMemory">mPatternMemory.</param>
        /// <param name="mInitComplete">mInitComplete.</param>
        /// <param name="mPatternLength">mPatternLength.</param>
        /// <param name="mLearningIsOn">mLearningIsOn.</param>
        /// <param name="mNumOfPatternsClustered">mNumOfPatternsClustered.</param>
        public MNanoBackend(int versionNumber = default(int), MPatternMemory mPatternMemory = default(MPatternMemory), bool mInitComplete = default(bool), int mPatternLength = default(int), bool mLearningIsOn = default(bool), int mNumOfPatternsClustered = default(int))
        {
            this.VersionNumber = versionNumber;
            this.MPatternMemory = mPatternMemory;
            this.MInitComplete = mInitComplete;
            this.MPatternLength = mPatternLength;
            this.MLearningIsOn = mLearningIsOn;
            this.MNumOfPatternsClustered = mNumOfPatternsClustered;
        }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name = "VersionNumber", EmitDefaultValue = false)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets MPatternMemory
        /// </summary>
        [DataMember(Name = "m_PatternMemory", EmitDefaultValue = false)]
        public MPatternMemory MPatternMemory { get; set; }

        /// <summary>
        /// Gets or Sets MInitComplete
        /// </summary>
        [DataMember(Name = "m_InitComplete", EmitDefaultValue = true)]
        public bool MInitComplete { get; set; }

        /// <summary>
        /// Gets or Sets MPatternLength
        /// </summary>
        [DataMember(Name = "m_PatternLength", EmitDefaultValue = false)]
        public int MPatternLength { get; set; }

        /// <summary>
        /// Gets or Sets MLearningIsOn
        /// </summary>
        [DataMember(Name = "m_LearningIsOn", EmitDefaultValue = true)]
        public bool MLearningIsOn { get; set; }

        /// <summary>
        /// Gets or Sets MNumOfPatternsClustered
        /// </summary>
        [DataMember(Name = "m_NumOfPatternsClustered", EmitDefaultValue = false)]
        public int MNumOfPatternsClustered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MNanoBackend {\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  MPatternMemory: ").Append(MPatternMemory).Append("\n");
            sb.Append("  MInitComplete: ").Append(MInitComplete).Append("\n");
            sb.Append("  MPatternLength: ").Append(MPatternLength).Append("\n");
            sb.Append("  MLearningIsOn: ").Append(MLearningIsOn).Append("\n");
            sb.Append("  MNumOfPatternsClustered: ").Append(MNumOfPatternsClustered).Append("\n");
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
            return this.Equals(input as MNanoBackend);
        }

        /// <summary>
        /// Returns true if MNanoBackend instances are equal
        /// </summary>
        /// <param name="input">Instance of MNanoBackend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MNanoBackend input)
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
                    this.MPatternMemory == input.MPatternMemory ||
                    (this.MPatternMemory != null &&
                    this.MPatternMemory.Equals(input.MPatternMemory))
                ) &&
                (
                    this.MInitComplete == input.MInitComplete ||
                    this.MInitComplete.Equals(input.MInitComplete)
                ) &&
                (
                    this.MPatternLength == input.MPatternLength ||
                    this.MPatternLength.Equals(input.MPatternLength)
                ) &&
                (
                    this.MLearningIsOn == input.MLearningIsOn ||
                    this.MLearningIsOn.Equals(input.MLearningIsOn)
                ) &&
                (
                    this.MNumOfPatternsClustered == input.MNumOfPatternsClustered ||
                    this.MNumOfPatternsClustered.Equals(input.MNumOfPatternsClustered)
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
                if (this.MPatternMemory != null)
                {
                    hashCode = (hashCode * 59) + this.MPatternMemory.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MInitComplete.GetHashCode();
                hashCode = (hashCode * 59) + this.MPatternLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MLearningIsOn.GetHashCode();
                hashCode = (hashCode * 59) + this.MNumOfPatternsClustered.GetHashCode();
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
