/* 
 * ASR documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloud.ASR.Client.SwaggerDateConverter;

namespace Cloud.ASR.Model
{
    /// <summary>
    /// AudioFileDto
    /// </summary>
    [DataContract]
    public partial class AudioFileDto :  IEquatable<AudioFileDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFileDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudioFileDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFileDto" /> class.
        /// </summary>
        /// <param name="Data">Binary audio file as Base64 string (required).</param>
        /// <param name="Mime">Audio file mime type.</param>
        public AudioFileDto(byte[] Data = default(byte[]), string Mime = default(string))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for AudioFileDto and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            this.Mime = Mime;
        }
        
        /// <summary>
        /// Binary audio file as Base64 string
        /// </summary>
        /// <value>Binary audio file as Base64 string</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// Audio file mime type
        /// </summary>
        /// <value>Audio file mime type</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioFileDto {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
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
            return this.Equals(input as AudioFileDto);
        }

        /// <summary>
        /// Returns true if AudioFileDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AudioFileDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudioFileDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Mime == input.Mime ||
                    (this.Mime != null &&
                    this.Mime.Equals(input.Mime))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Mime != null)
                    hashCode = hashCode * 59 + this.Mime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
