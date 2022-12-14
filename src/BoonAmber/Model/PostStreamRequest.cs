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
    /// PostStreamRequest
    /// </summary>
    [DataContract(Name = "postStreamRequest")]
    public partial class PostStreamRequest : IEquatable<PostStreamRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostStreamRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostStreamRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostStreamRequest" /> class.
        /// </summary>
        /// <param name="saveImage">save the sensor after calculation (default to true).</param>
        /// <param name="data">data (required).</param>
        public PostStreamRequest(bool saveImage = true, string data = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for PostStreamRequest and cannot be null");
            }
            this.Data = data;
            this.SaveImage = saveImage;
        }

        /// <summary>
        /// save the sensor after calculation
        /// </summary>
        /// <value>save the sensor after calculation</value>
        [DataMember(Name = "saveImage", EmitDefaultValue = true)]
        public bool SaveImage { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostStreamRequest {\n");
            sb.Append("  SaveImage: ").Append(SaveImage).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as PostStreamRequest);
        }

        /// <summary>
        /// Returns true if PostStreamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostStreamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostStreamRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SaveImage == input.SaveImage ||
                    this.SaveImage.Equals(input.SaveImage)
                ) &&
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                hashCode = (hashCode * 59) + this.SaveImage.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
