using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Core3.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HealthModelDependencies :  IEquatable<HealthModelDependencies>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthModelDependencies" /> class.
        /// </summary>
        /// <param name="IsOK">IsOK (required).</param>
        /// <param name="ServiceName">ServiceName (required).</param>
        /// <param name="Url">Url (required).</param>
        public HealthModelDependencies(bool? IsOK = null, string ServiceName = null, string Url = null)
        {
            // to ensure "IsOK" is required (not null)
            if (IsOK == null)
            {
                throw new InvalidDataException("IsOK is a required property for HealthModelDependencies and cannot be null");
            }
            else
            {
                this.IsOK = IsOK;
            }
            // to ensure "ServiceName" is required (not null)
            if (ServiceName == null)
            {
                throw new InvalidDataException("ServiceName is a required property for HealthModelDependencies and cannot be null");
            }
            else
            {
                this.ServiceName = ServiceName;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for HealthModelDependencies and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            
        }

        
        /// <summary>
        /// Gets or Sets IsOK
        /// </summary>
        public bool? IsOK { get; set; }

        
        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        public string ServiceName { get; set; }

        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        public string Url { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthModelDependencies {\n");
            sb.Append("  IsOK: ").Append(IsOK).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            
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
            return Equals((HealthModelDependencies)obj);
        }

        /// <summary>
        /// Returns true if HealthModelDependencies instances are equal
        /// </summary>
        /// <param name="other">Instance of HealthModelDependencies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthModelDependencies other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.IsOK == other.IsOK ||
                    this.IsOK != null &&
                    this.IsOK.Equals(other.IsOK)
                ) && 
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                
                    if (this.IsOK != null)
                    hash = hash * 59 + this.IsOK.GetHashCode();
                
                    if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                
                    if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(HealthModelDependencies left, HealthModelDependencies right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HealthModelDependencies left, HealthModelDependencies right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
