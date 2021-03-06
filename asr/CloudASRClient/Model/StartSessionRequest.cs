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
    /// StartSessionRequest
    /// </summary>
    [DataContract]
    public partial class StartSessionRequest :  IEquatable<StartSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartSessionRequest" /> class.
        /// </summary>
        /// <param name="Username">User login (required).</param>
        /// <param name="Password">User password (required).</param>
        /// <param name="DomainId">User domain identifier (required).</param>
        public StartSessionRequest(string Username = default(string), string Password = default(string), long? DomainId = default(long?))
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for StartSessionRequest and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for StartSessionRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "DomainId" is required (not null)
            if (DomainId == null)
            {
                throw new InvalidDataException("DomainId is a required property for StartSessionRequest and cannot be null");
            }
            else
            {
                this.DomainId = DomainId;
            }
        }
        
        /// <summary>
        /// User login
        /// </summary>
        /// <value>User login</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        /// <value>User password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// User domain identifier
        /// </summary>
        /// <value>User domain identifier</value>
        [DataMember(Name="domain_id", EmitDefaultValue=false)]
        public long? DomainId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartSessionRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
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
            return this.Equals(input as StartSessionRequest);
        }

        /// <summary>
        /// Returns true if StartSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartSessionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
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
