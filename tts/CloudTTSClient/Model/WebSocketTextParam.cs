/* 
 * TTS documentation
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
using SwaggerDateConverter = Cloud.TTS.Client.SwaggerDateConverter;

namespace Cloud.TTS.Model
{
    /// <summary>
    /// WebSocketTextParam
    /// </summary>
    [DataContract]
    public partial class WebSocketTextParam :  IEquatable<WebSocketTextParam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketTextParam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebSocketTextParam() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketTextParam" /> class.
        /// </summary>
        /// <param name="Mime">Type of content (required).</param>
        public WebSocketTextParam(string Mime = default(string))
        {
            // to ensure "Mime" is required (not null)
            if (Mime == null)
            {
                throw new InvalidDataException("Mime is a required property for WebSocketTextParam and cannot be null");
            }
            else
            {
                this.Mime = Mime;
            }
        }
        
        /// <summary>
        /// Type of content
        /// </summary>
        /// <value>Type of content</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebSocketTextParam {\n");
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
            return this.Equals(input as WebSocketTextParam);
        }

        /// <summary>
        /// Returns true if WebSocketTextParam instances are equal
        /// </summary>
        /// <param name="input">Instance of WebSocketTextParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebSocketTextParam input)
        {
            if (input == null)
                return false;

            return 
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
