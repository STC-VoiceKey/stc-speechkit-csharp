/* 
 * ASR documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.1.58
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
using SwaggerDateConverter = Cloud.Client.SwaggerDateConverter;

namespace Cloud.Client.ASR.Model
{
    /// <summary>
    /// PackageDto
    /// </summary>
    [DataContract]
    public partial class PackageDto :  IEquatable<PackageDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageDto" /> class.
        /// </summary>
        /// <param name="PackageId">Package ID (required).</param>
        /// <param name="Name">Package name (required).</param>
        /// <param name="Language">Package language (required).</param>
        /// <param name="SampleRate">Required sample rate of data (required).</param>
        /// <param name="Loaded">Is package loaded to the cache (required).</param>
        public PackageDto(string PackageId = default(string), string Name = default(string), string Language = default(string), int? SampleRate = default(int?), bool? Loaded = default(bool?))
        {
            // to ensure "PackageId" is required (not null)
            if (PackageId == null)
            {
                throw new InvalidDataException("PackageId is a required property for PackageDto and cannot be null");
            }
            else
            {
                this.PackageId = PackageId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PackageDto and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Language" is required (not null)
            if (Language == null)
            {
                throw new InvalidDataException("Language is a required property for PackageDto and cannot be null");
            }
            else
            {
                this.Language = Language;
            }
            // to ensure "SampleRate" is required (not null)
            if (SampleRate == null)
            {
                throw new InvalidDataException("SampleRate is a required property for PackageDto and cannot be null");
            }
            else
            {
                this.SampleRate = SampleRate;
            }
            // to ensure "Loaded" is required (not null)
            if (Loaded == null)
            {
                throw new InvalidDataException("Loaded is a required property for PackageDto and cannot be null");
            }
            else
            {
                this.Loaded = Loaded;
            }
        }
        
        /// <summary>
        /// Package ID
        /// </summary>
        /// <value>Package ID</value>
        [DataMember(Name="package_id", EmitDefaultValue=false)]
        public string PackageId { get; set; }

        /// <summary>
        /// Package name
        /// </summary>
        /// <value>Package name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Package language
        /// </summary>
        /// <value>Package language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Required sample rate of data
        /// </summary>
        /// <value>Required sample rate of data</value>
        [DataMember(Name="sample_rate", EmitDefaultValue=false)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Is package loaded to the cache
        /// </summary>
        /// <value>Is package loaded to the cache</value>
        [DataMember(Name="loaded", EmitDefaultValue=false)]
        public bool? Loaded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageDto {\n");
            sb.Append("  PackageId: ").Append(PackageId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  Loaded: ").Append(Loaded).Append("\n");
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
            return this.Equals(input as PackageDto);
        }

        /// <summary>
        /// Returns true if PackageDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.SampleRate == input.SampleRate ||
                    (this.SampleRate != null &&
                    this.SampleRate.Equals(input.SampleRate))
                ) && 
                (
                    this.Loaded == input.Loaded ||
                    (this.Loaded != null &&
                    this.Loaded.Equals(input.Loaded))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SampleRate != null)
                    hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.Loaded != null)
                    hashCode = hashCode * 59 + this.Loaded.GetHashCode();
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