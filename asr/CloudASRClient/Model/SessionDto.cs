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
    /// SessionDto
    /// </summary>
    [DataContract]
    public partial class SessionDto :  IEquatable<SessionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDto" /> class.
        /// </summary>
        /// <param name="SessionId">SessionId (required).</param>
        public SessionDto(Guid? SessionId = default(Guid?))
        {
            // to ensure "SessionId" is required (not null)
            if (SessionId == null)
            {
                throw new InvalidDataException("SessionId is a required property for SessionDto and cannot be null");
            }
            else
            {
                this.SessionId = SessionId;
            }
        }
        
        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="session_id", EmitDefaultValue=false)]
        public Guid? SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionDto {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(input as SessionDto);
        }

        /// <summary>
        /// Returns true if SessionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
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
