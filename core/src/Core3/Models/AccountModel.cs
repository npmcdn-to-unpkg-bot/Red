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
    public partial class AccountModel :  IEquatable<AccountModel>
    {
        public AccountModel()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountModel" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId (required).</param>
        /// <param name="MainPerson">MainPerson.</param>
        /// <param name="People">People (required).</param>
        public AccountModel(string AccountId = null, AccountModelMainPerson MainPerson = null, List<PersonModel> People = null)
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for AccountModel and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "People" is required (not null)
            if (People == null)
            {
                throw new InvalidDataException("People is a required property for AccountModel and cannot be null");
            }
            else
            {
                this.People = People;
            }
            this.MainPerson = MainPerson;
            
        }

        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        public string AccountId { get; set; }

        
        /// <summary>
        /// Gets or Sets MainPerson
        /// </summary>
        public AccountModelMainPerson MainPerson { get; set; }

        
        /// <summary>
        /// Gets or Sets People
        /// </summary>
        public List<PersonModel> People { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  MainPerson: ").Append(MainPerson).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            
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
            return Equals((AccountModel)obj);
        }

        /// <summary>
        /// Returns true if AccountModel instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountModel other)
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
                    this.MainPerson == other.MainPerson ||
                    this.MainPerson != null &&
                    this.MainPerson.Equals(other.MainPerson)
                ) && 
                (
                    this.People == other.People ||
                    this.People != null &&
                    this.People.SequenceEqual(other.People)
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
                
                    if (this.MainPerson != null)
                    hash = hash * 59 + this.MainPerson.GetHashCode();
                
                    if (this.People != null)
                    hash = hash * 59 + this.People.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(AccountModel left, AccountModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountModel left, AccountModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
