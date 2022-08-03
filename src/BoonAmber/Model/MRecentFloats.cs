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
    /// MRecentFloats
    /// </summary>
    [DataContract(Name = "m_RecentFloats")]
    public partial class MRecentFloats : IEquatable<MRecentFloats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MRecentFloats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MRecentFloats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MRecentFloats" /> class.
        /// </summary>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="mValues">mValues (required).</param>
        public MRecentFloats(int versionNumber = default(int), List<float> mValues = default(List<float>))
        {
            // to ensure "mValues" is required (not null)
            if (mValues == null)
            {
                throw new ArgumentNullException("mValues is a required property for MRecentFloats and cannot be null");
            }
            this.MValues = mValues;
            this.VersionNumber = versionNumber;
        }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name = "VersionNumber", EmitDefaultValue = false)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets MValues
        /// </summary>
        [DataMember(Name = "m_Values", IsRequired = true, EmitDefaultValue = false)]
        public List<float> MValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MRecentFloats {\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  MValues: ").Append(MValues).Append("\n");
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
            return this.Equals(input as MRecentFloats);
        }

        /// <summary>
        /// Returns true if MRecentFloats instances are equal
        /// </summary>
        /// <param name="input">Instance of MRecentFloats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MRecentFloats input)
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
                    this.MValues == input.MValues ||
                    this.MValues != null &&
                    input.MValues != null &&
                    this.MValues.SequenceEqual(input.MValues)
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
                if (this.MValues != null)
                {
                    hashCode = (hashCode * 59) + this.MValues.GetHashCode();
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
