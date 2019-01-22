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
    /// SynthesizeSessionlessRequest
    /// </summary>
    [DataContract]
    public partial class SynthesizeSessionlessRequest :  IEquatable<SynthesizeSessionlessRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSessionlessRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SynthesizeSessionlessRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSessionlessRequest" /> class.
        /// </summary>
        /// <param name="Text">Text for synthesize to speech (required).</param>
        /// <param name="Credentials">Credentials (required).</param>
        /// <param name="VoiceName">Name of name (required).</param>
        /// <param name="Audio">Format of response audio (required).</param>
        public SynthesizeSessionlessRequest(SynthesizeText Text = default(SynthesizeText), Credentials Credentials = default(Credentials), string VoiceName = default(string), string Audio = default(string))
        {
            // to ensure "Text" is required (not null)
            if (Text == null)
            {
                throw new InvalidDataException("Text is a required property for SynthesizeSessionlessRequest and cannot be null");
            }
            else
            {
                this.Text = Text;
            }
            // to ensure "Credentials" is required (not null)
            if (Credentials == null)
            {
                throw new InvalidDataException("Credentials is a required property for SynthesizeSessionlessRequest and cannot be null");
            }
            else
            {
                this.Credentials = Credentials;
            }
            // to ensure "VoiceName" is required (not null)
            if (VoiceName == null)
            {
                throw new InvalidDataException("VoiceName is a required property for SynthesizeSessionlessRequest and cannot be null");
            }
            else
            {
                this.VoiceName = VoiceName;
            }
            // to ensure "Audio" is required (not null)
            if (Audio == null)
            {
                throw new InvalidDataException("Audio is a required property for SynthesizeSessionlessRequest and cannot be null");
            }
            else
            {
                this.Audio = Audio;
            }
        }
        
        /// <summary>
        /// Text for synthesize to speech
        /// </summary>
        /// <value>Text for synthesize to speech</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public SynthesizeText Text { get; set; }

        /// <summary>
        /// Credentials
        /// </summary>
        /// <value>Credentials</value>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Name of name
        /// </summary>
        /// <value>Name of name</value>
        [DataMember(Name="voice_name", EmitDefaultValue=false)]
        public string VoiceName { get; set; }

        /// <summary>
        /// Format of response audio
        /// </summary>
        /// <value>Format of response audio</value>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public string Audio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SynthesizeSessionlessRequest {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  VoiceName: ").Append(VoiceName).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
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
            return this.Equals(input as SynthesizeSessionlessRequest);
        }

        /// <summary>
        /// Returns true if SynthesizeSessionlessRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SynthesizeSessionlessRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SynthesizeSessionlessRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.VoiceName == input.VoiceName ||
                    (this.VoiceName != null &&
                    this.VoiceName.Equals(input.VoiceName))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.VoiceName != null)
                    hashCode = hashCode * 59 + this.VoiceName.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
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