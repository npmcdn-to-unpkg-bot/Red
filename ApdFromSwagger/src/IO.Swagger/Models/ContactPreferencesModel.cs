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
    public partial class ContactPreferencesModel :  IEquatable<ContactPreferencesModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPreferencesModel" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId (required).</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="Post">Post (required).</param>
        /// <param name="Sms">Sms (required).</param>
        /// <param name="Telephone">Telephone (required).</param>
        public ContactPreferencesModel(string AccountId = null, bool? Email = null, bool? Post = null, bool? Sms = null, bool? Telephone = null)
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for ContactPreferencesModel and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for ContactPreferencesModel and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Post" is required (not null)
            if (Post == null)
            {
                throw new InvalidDataException("Post is a required property for ContactPreferencesModel and cannot be null");
            }
            else
            {
                this.Post = Post;
            }
            // to ensure "Sms" is required (not null)
            if (Sms == null)
            {
                throw new InvalidDataException("Sms is a required property for ContactPreferencesModel and cannot be null");
            }
            else
            {
                this.Sms = Sms;
            }
            // to ensure "Telephone" is required (not null)
            if (Telephone == null)
            {
                throw new InvalidDataException("Telephone is a required property for ContactPreferencesModel and cannot be null");
            }
            else
            {
                this.Telephone = Telephone;
            }
            
        }

        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        public string AccountId { get; set; }

        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        public bool? Email { get; set; }

        
        /// <summary>
        /// Gets or Sets Post
        /// </summary>
        public bool? Post { get; set; }

        
        /// <summary>
        /// Gets or Sets Sms
        /// </summary>
        public bool? Sms { get; set; }

        
        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        public bool? Telephone { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactPreferencesModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            
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
            return Equals((ContactPreferencesModel)obj);
        }

        /// <summary>
        /// Returns true if ContactPreferencesModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactPreferencesModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactPreferencesModel other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Post == other.Post ||
                    this.Post != null &&
                    this.Post.Equals(other.Post)
                ) && 
                (
                    this.Sms == other.Sms ||
                    this.Sms != null &&
                    this.Sms.Equals(other.Sms)
                ) && 
                (
                    this.Telephone == other.Telephone ||
                    this.Telephone != null &&
                    this.Telephone.Equals(other.Telephone)
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
                
                    if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                
                    if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                    if (this.Post != null)
                    hash = hash * 59 + this.Post.GetHashCode();
                
                    if (this.Sms != null)
                    hash = hash * 59 + this.Sms.GetHashCode();
                
                    if (this.Telephone != null)
                    hash = hash * 59 + this.Telephone.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ContactPreferencesModel left, ContactPreferencesModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContactPreferencesModel left, ContactPreferencesModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
