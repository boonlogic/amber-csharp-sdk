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
    /// Float32Array
    /// </summary>
    [DataContract]
        public partial class Float32Array : List<float?>,  IEquatable<Float32Array>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Float32Array" /> class.
        /// </summary>
        public Float32Array() : base()
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Float32Array {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Float32Array);
        }

        /// <summary>
        /// Returns true if Float32Array instances are equal
        /// </summary>
        /// <param name="input">Instance of Float32Array to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Float32Array input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }
    }
}
