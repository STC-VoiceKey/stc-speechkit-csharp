/* 
 * TTS documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.1.73
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

namespace Cloud.Client.TTS.Model
{
    /// <summary>
    /// SynthesizeVoiceType
    /// </summary>
    [DataContract]
    public partial class SynthesizeVoiceType :  IEquatable<SynthesizeVoiceType>, IValidatableObject
    {
        /// <summary>
        /// Gender of voice
        /// </summary>
        /// <value>Gender of voice</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum UNDEFINED for value: UNDEFINED
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED = 1,
            
            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALE = 2,
            
            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALE = 3
        }

        /// <summary>
        /// Gender of voice
        /// </summary>
        /// <value>Gender of voice</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeVoiceType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SynthesizeVoiceType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeVoiceType" /> class.
        /// </summary>
        /// <param name="Id">Voice id (required).</param>
        /// <param name="Name">Name of voice (required).</param>
        /// <param name="Gender">Gender of voice (required).</param>
        public SynthesizeVoiceType(string Id = default(string), string Name = default(string), GenderEnum Gender = default(GenderEnum))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for SynthesizeVoiceType and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SynthesizeVoiceType and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Gender" is required (not null)
            if (Gender == null)
            {
                throw new InvalidDataException("Gender is a required property for SynthesizeVoiceType and cannot be null");
            }
            else
            {
                this.Gender = Gender;
            }
        }
        
        /// <summary>
        /// Voice id
        /// </summary>
        /// <value>Voice id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of voice
        /// </summary>
        /// <value>Name of voice</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SynthesizeVoiceType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
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
            return this.Equals(input as SynthesizeVoiceType);
        }

        /// <summary>
        /// Returns true if SynthesizeVoiceType instances are equal
        /// </summary>
        /// <param name="input">Instance of SynthesizeVoiceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SynthesizeVoiceType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
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
