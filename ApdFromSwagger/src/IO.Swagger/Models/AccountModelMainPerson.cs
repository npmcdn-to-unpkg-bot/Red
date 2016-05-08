using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AccountModelMainPerson :  IEquatable<AccountModelMainPerson>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountModelMainPerson" /> class.
        /// </summary>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="DateOfBirth">DateOfBirth (required).</param>
        public AccountModelMainPerson(string FirstName = null, string LastName = null, DateTime? DateOfBirth = null)
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for AccountModelMainPerson and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for AccountModelMainPerson and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "DateOfBirth" is required (not null)
            if (DateOfBirth == null)
            {
                throw new InvalidDataException("DateOfBirth is a required property for AccountModelMainPerson and cannot be null");
            }
            else
            {
                this.DateOfBirth = DateOfBirth;
            }
            
        }

        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        public string FirstName { get; set; }

        
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        public string LastName { get; set; }

        
        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountModelMainPerson {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            
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
            return Equals((AccountModelMainPerson)obj);
        }

        /// <summary>
        /// Returns true if AccountModelMainPerson instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountModelMainPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountModelMainPerson other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
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
                
                    if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                    if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                    if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(AccountModelMainPerson left, AccountModelMainPerson right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountModelMainPerson left, AccountModelMainPerson right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
