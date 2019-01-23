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
    /// ASRAdvancedResultDto
    /// </summary>
    [DataContract]
    public partial class ASRAdvancedResultDto :  IEquatable<ASRAdvancedResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASRAdvancedResultDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ASRAdvancedResultDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ASRAdvancedResultDto" /> class.
        /// </summary>
        /// <param name="ChannelId">Channel id (required).</param>
        /// <param name="Result">Recognition result (required).</param>
        public ASRAdvancedResultDto(int? ChannelId = default(int?), List<WordDto> Result = default(List<WordDto>))
        {
            // to ensure "ChannelId" is required (not null)
            if (ChannelId == null)
            {
                throw new InvalidDataException("ChannelId is a required property for ASRAdvancedResultDto and cannot be null");
            }
            else
            {
                this.ChannelId = ChannelId;
            }
            // to ensure "Result" is required (not null)
            if (Result == null)
            {
                throw new InvalidDataException("Result is a required property for ASRAdvancedResultDto and cannot be null");
            }
            else
            {
                this.Result = Result;
            }
        }
        
        /// <summary>
        /// Channel id
        /// </summary>
        /// <value>Channel id</value>
        [DataMember(Name="channel_id", EmitDefaultValue=false)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// Recognition result
        /// </summary>
        /// <value>Recognition result</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public List<WordDto> Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ASRAdvancedResultDto {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as ASRAdvancedResultDto);
        }

        /// <summary>
        /// Returns true if ASRAdvancedResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ASRAdvancedResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ASRAdvancedResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
