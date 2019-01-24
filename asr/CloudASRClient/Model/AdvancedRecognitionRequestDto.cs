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
    /// AdvancedRecognitionRequestDto
    /// </summary>
    [DataContract]
    public partial class AdvancedRecognitionRequestDto :  IEquatable<AdvancedRecognitionRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedRecognitionRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdvancedRecognitionRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedRecognitionRequestDto" /> class.
        /// </summary>
        /// <param name="PackageId">Recognize with package.</param>
        /// <param name="Channels">Specific channels to process.</param>
        /// <param name="Data">Binary audio file as Base64 string (required).</param>
        public AdvancedRecognitionRequestDto(string PackageId = default(string), List<int?> Channels = default(List<int?>), byte[] Data = default(byte[]))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for AdvancedRecognitionRequestDto and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            this.PackageId = PackageId;
            this.Channels = Channels;
        }
        
        /// <summary>
        /// Recognize with package
        /// </summary>
        /// <value>Recognize with package</value>
        [DataMember(Name="package_id", EmitDefaultValue=false)]
        public string PackageId { get; set; }

        /// <summary>
        /// Specific channels to process
        /// </summary>
        /// <value>Specific channels to process</value>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public List<int?> Channels { get; set; }

        /// <summary>
        /// Binary audio file as Base64 string
        /// </summary>
        /// <value>Binary audio file as Base64 string</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedRecognitionRequestDto {\n");
            sb.Append("  PackageId: ").Append(PackageId).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as AdvancedRecognitionRequestDto);
        }

        /// <summary>
        /// Returns true if AdvancedRecognitionRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedRecognitionRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedRecognitionRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageId == input.PackageId ||
                    (this.PackageId != null &&
                    this.PackageId.Equals(input.PackageId))
                ) && 
                (
                    this.Channels == input.Channels ||
                    this.Channels != null &&
                    this.Channels.SequenceEqual(input.Channels)
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
                if (this.PackageId != null)
                    hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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