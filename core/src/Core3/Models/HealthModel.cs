using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Core3.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HealthModel :  IEquatable<HealthModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthModel" /> class.
        /// </summary>
        /// <param name="ServiceName">ServiceName (required).</param>
        /// <param name="IsOk">IsOk (required).</param>
        /// <param name="Version">Version (required).</param>
        /// <param name="Dependencies">Dependencies.</param>
        public HealthModel(string ServiceName = null, bool? IsOk = null, string Version = null, List<HealthModelDependencies> Dependencies = null)
        {
            // to ensure "ServiceName" is required (not null)
            if (ServiceName == null)
            {
                throw new InvalidDataException("ServiceName is a required property for HealthModel and cannot be null");
            }
            else
            {
                this.ServiceName = ServiceName;
            }
            // to ensure "IsOk" is required (not null)
            if (IsOk == null)
            {
                throw new InvalidDataException("IsOk is a required property for HealthModel and cannot be null");
            }
            else
            {
                this.IsOk = IsOk;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for HealthModel and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Dependencies = Dependencies;
            
        }

        
        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        public string ServiceName { get; set; }

        
        /// <summary>
        /// Gets or Sets IsOk
        /// </summary>
        public bool? IsOk { get; set; }

        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        public string Version { get; set; }

        
        /// <summary>
        /// Gets or Sets Dependencies
        /// </summary>
        public List<HealthModelDependencies> Dependencies { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthModel {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  IsOk: ").Append(IsOk).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((HealthModel)obj);
        }

        /// <summary>
        /// Returns true if HealthModel instances are equal
        /// </summary>
        /// <param name="other">Instance of HealthModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthModel other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) && 
                (
                    this.IsOk == other.IsOk ||
                    this.IsOk != null &&
                    this.IsOk.Equals(other.IsOk)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Dependencies == other.Dependencies ||
                    this.Dependencies != null &&
                    this.Dependencies.SequenceEqual(other.Dependencies)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                    if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                
                    if (this.IsOk != null)
                    hash = hash * 59 + this.IsOk.GetHashCode();
                
                    if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                    if (this.Dependencies != null)
                    hash = hash * 59 + this.Dependencies.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(HealthModel left, HealthModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HealthModel left, HealthModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
