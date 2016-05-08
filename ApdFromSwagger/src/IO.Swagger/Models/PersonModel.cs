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
    public partial class PersonModel :  IEquatable<PersonModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonModel" /> class.
        /// </summary>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="DateOfBirth">DateOfBirth (required).</param>
        /// <param name="Title">Title.</param>
        /// <param name="MaritalStataus">MaritalStataus.</param>
        /// <param name="TelephoneNumber">TelephoneNumber.</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="EmploymentStatus">EmploymentStatus.</param>
        /// <param name="Occupation">Occupation.</param>
        /// <param name="BusinessType">BusinessType.</param>
        /// <param name="PartTimeWork">PartTimeWork.</param>
        /// <param name="SecondOccupation">SecondOccupation.</param>
        /// <param name="SecondBusinessType">SecondBusinessType.</param>
        /// <param name="HomeOwnership">HomeOwnership.</param>
        /// <param name="ChildrenUnderSixteen">ChildrenUnderSixteen.</param>
        /// <param name="ChildrenUnderEighteen">ChildrenUnderEighteen.</param>
        /// <param name="Smoker">Smoker.</param>
        /// <param name="UkResidentSinceBirth">UkResidentSinceBirth.</param>
        /// <param name="UkResidentSinceDate">UkResidentSinceDate.</param>
        /// <param name="DrivingLicenceType">DrivingLicenceType.</param>
        /// <param name="DrivingLicenceNumber">DrivingLicenceNumber.</param>
        /// <param name="DrivingLicenceYears">DrivingLicenceYears.</param>
        /// <param name="AdditionalDrivingQualifications">AdditionalDrivingQualifications.</param>
        /// <param name="DvlaMedicalConditions">DvlaMedicalConditions.</param>
        public PersonModel(string FirstName = null, string LastName = null, DateTime? DateOfBirth = null, string Title = null, string MaritalStataus = null, string TelephoneNumber = null, List<PersonModelAddresses> Addresses = null, string EmploymentStatus = null, string Occupation = null, string BusinessType = null, bool? PartTimeWork = null, string SecondOccupation = null, string SecondBusinessType = null, string HomeOwnership = null, bool? ChildrenUnderSixteen = null, bool? ChildrenUnderEighteen = null, bool? Smoker = null, bool? UkResidentSinceBirth = null, DateTime? UkResidentSinceDate = null, string DrivingLicenceType = null, string DrivingLicenceNumber = null, int? DrivingLicenceYears = null, string AdditionalDrivingQualifications = null, string DvlaMedicalConditions = null)
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for PersonModel and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for PersonModel and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "DateOfBirth" is required (not null)
            if (DateOfBirth == null)
            {
                throw new InvalidDataException("DateOfBirth is a required property for PersonModel and cannot be null");
            }
            else
            {
                this.DateOfBirth = DateOfBirth;
            }
            this.Title = Title;
            this.MaritalStataus = MaritalStataus;
            this.TelephoneNumber = TelephoneNumber;
            this.Addresses = Addresses;
            this.EmploymentStatus = EmploymentStatus;
            this.Occupation = Occupation;
            this.BusinessType = BusinessType;
            this.PartTimeWork = PartTimeWork;
            this.SecondOccupation = SecondOccupation;
            this.SecondBusinessType = SecondBusinessType;
            this.HomeOwnership = HomeOwnership;
            this.ChildrenUnderSixteen = ChildrenUnderSixteen;
            this.ChildrenUnderEighteen = ChildrenUnderEighteen;
            this.Smoker = Smoker;
            this.UkResidentSinceBirth = UkResidentSinceBirth;
            this.UkResidentSinceDate = UkResidentSinceDate;
            this.DrivingLicenceType = DrivingLicenceType;
            this.DrivingLicenceNumber = DrivingLicenceNumber;
            this.DrivingLicenceYears = DrivingLicenceYears;
            this.AdditionalDrivingQualifications = AdditionalDrivingQualifications;
            this.DvlaMedicalConditions = DvlaMedicalConditions;
            
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
        /// Gets or Sets Title
        /// </summary>
        public string Title { get; set; }

        
        /// <summary>
        /// Gets or Sets MaritalStataus
        /// </summary>
        public string MaritalStataus { get; set; }

        
        /// <summary>
        /// Gets or Sets TelephoneNumber
        /// </summary>
        public string TelephoneNumber { get; set; }

        
        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        public List<PersonModelAddresses> Addresses { get; set; }

        
        /// <summary>
        /// Gets or Sets EmploymentStatus
        /// </summary>
        public string EmploymentStatus { get; set; }

        
        /// <summary>
        /// Gets or Sets Occupation
        /// </summary>
        public string Occupation { get; set; }

        
        /// <summary>
        /// Gets or Sets BusinessType
        /// </summary>
        public string BusinessType { get; set; }

        
        /// <summary>
        /// Gets or Sets PartTimeWork
        /// </summary>
        public bool? PartTimeWork { get; set; }

        
        /// <summary>
        /// Gets or Sets SecondOccupation
        /// </summary>
        public string SecondOccupation { get; set; }

        
        /// <summary>
        /// Gets or Sets SecondBusinessType
        /// </summary>
        public string SecondBusinessType { get; set; }

        
        /// <summary>
        /// Gets or Sets HomeOwnership
        /// </summary>
        public string HomeOwnership { get; set; }

        
        /// <summary>
        /// Gets or Sets ChildrenUnderSixteen
        /// </summary>
        public bool? ChildrenUnderSixteen { get; set; }

        
        /// <summary>
        /// Gets or Sets ChildrenUnderEighteen
        /// </summary>
        public bool? ChildrenUnderEighteen { get; set; }

        
        /// <summary>
        /// Gets or Sets Smoker
        /// </summary>
        public bool? Smoker { get; set; }

        
        /// <summary>
        /// Gets or Sets UkResidentSinceBirth
        /// </summary>
        public bool? UkResidentSinceBirth { get; set; }

        
        /// <summary>
        /// Gets or Sets UkResidentSinceDate
        /// </summary>
        public DateTime? UkResidentSinceDate { get; set; }

        
        /// <summary>
        /// Gets or Sets DrivingLicenceType
        /// </summary>
        public string DrivingLicenceType { get; set; }

        
        /// <summary>
        /// Gets or Sets DrivingLicenceNumber
        /// </summary>
        public string DrivingLicenceNumber { get; set; }

        
        /// <summary>
        /// Gets or Sets DrivingLicenceYears
        /// </summary>
        public int? DrivingLicenceYears { get; set; }

        
        /// <summary>
        /// Gets or Sets AdditionalDrivingQualifications
        /// </summary>
        public string AdditionalDrivingQualifications { get; set; }

        
        /// <summary>
        /// Gets or Sets DvlaMedicalConditions
        /// </summary>
        public string DvlaMedicalConditions { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonModel {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MaritalStataus: ").Append(MaritalStataus).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  EmploymentStatus: ").Append(EmploymentStatus).Append("\n");
            sb.Append("  Occupation: ").Append(Occupation).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("  PartTimeWork: ").Append(PartTimeWork).Append("\n");
            sb.Append("  SecondOccupation: ").Append(SecondOccupation).Append("\n");
            sb.Append("  SecondBusinessType: ").Append(SecondBusinessType).Append("\n");
            sb.Append("  HomeOwnership: ").Append(HomeOwnership).Append("\n");
            sb.Append("  ChildrenUnderSixteen: ").Append(ChildrenUnderSixteen).Append("\n");
            sb.Append("  ChildrenUnderEighteen: ").Append(ChildrenUnderEighteen).Append("\n");
            sb.Append("  Smoker: ").Append(Smoker).Append("\n");
            sb.Append("  UkResidentSinceBirth: ").Append(UkResidentSinceBirth).Append("\n");
            sb.Append("  UkResidentSinceDate: ").Append(UkResidentSinceDate).Append("\n");
            sb.Append("  DrivingLicenceType: ").Append(DrivingLicenceType).Append("\n");
            sb.Append("  DrivingLicenceNumber: ").Append(DrivingLicenceNumber).Append("\n");
            sb.Append("  DrivingLicenceYears: ").Append(DrivingLicenceYears).Append("\n");
            sb.Append("  AdditionalDrivingQualifications: ").Append(AdditionalDrivingQualifications).Append("\n");
            sb.Append("  DvlaMedicalConditions: ").Append(DvlaMedicalConditions).Append("\n");
            
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
            return Equals((PersonModel)obj);
        }

        /// <summary>
        /// Returns true if PersonModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonModel other)
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
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.MaritalStataus == other.MaritalStataus ||
                    this.MaritalStataus != null &&
                    this.MaritalStataus.Equals(other.MaritalStataus)
                ) && 
                (
                    this.TelephoneNumber == other.TelephoneNumber ||
                    this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(other.TelephoneNumber)
                ) && 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.EmploymentStatus == other.EmploymentStatus ||
                    this.EmploymentStatus != null &&
                    this.EmploymentStatus.Equals(other.EmploymentStatus)
                ) && 
                (
                    this.Occupation == other.Occupation ||
                    this.Occupation != null &&
                    this.Occupation.Equals(other.Occupation)
                ) && 
                (
                    this.BusinessType == other.BusinessType ||
                    this.BusinessType != null &&
                    this.BusinessType.Equals(other.BusinessType)
                ) && 
                (
                    this.PartTimeWork == other.PartTimeWork ||
                    this.PartTimeWork != null &&
                    this.PartTimeWork.Equals(other.PartTimeWork)
                ) && 
                (
                    this.SecondOccupation == other.SecondOccupation ||
                    this.SecondOccupation != null &&
                    this.SecondOccupation.Equals(other.SecondOccupation)
                ) && 
                (
                    this.SecondBusinessType == other.SecondBusinessType ||
                    this.SecondBusinessType != null &&
                    this.SecondBusinessType.Equals(other.SecondBusinessType)
                ) && 
                (
                    this.HomeOwnership == other.HomeOwnership ||
                    this.HomeOwnership != null &&
                    this.HomeOwnership.Equals(other.HomeOwnership)
                ) && 
                (
                    this.ChildrenUnderSixteen == other.ChildrenUnderSixteen ||
                    this.ChildrenUnderSixteen != null &&
                    this.ChildrenUnderSixteen.Equals(other.ChildrenUnderSixteen)
                ) && 
                (
                    this.ChildrenUnderEighteen == other.ChildrenUnderEighteen ||
                    this.ChildrenUnderEighteen != null &&
                    this.ChildrenUnderEighteen.Equals(other.ChildrenUnderEighteen)
                ) && 
                (
                    this.Smoker == other.Smoker ||
                    this.Smoker != null &&
                    this.Smoker.Equals(other.Smoker)
                ) && 
                (
                    this.UkResidentSinceBirth == other.UkResidentSinceBirth ||
                    this.UkResidentSinceBirth != null &&
                    this.UkResidentSinceBirth.Equals(other.UkResidentSinceBirth)
                ) && 
                (
                    this.UkResidentSinceDate == other.UkResidentSinceDate ||
                    this.UkResidentSinceDate != null &&
                    this.UkResidentSinceDate.Equals(other.UkResidentSinceDate)
                ) && 
                (
                    this.DrivingLicenceType == other.DrivingLicenceType ||
                    this.DrivingLicenceType != null &&
                    this.DrivingLicenceType.Equals(other.DrivingLicenceType)
                ) && 
                (
                    this.DrivingLicenceNumber == other.DrivingLicenceNumber ||
                    this.DrivingLicenceNumber != null &&
                    this.DrivingLicenceNumber.Equals(other.DrivingLicenceNumber)
                ) && 
                (
                    this.DrivingLicenceYears == other.DrivingLicenceYears ||
                    this.DrivingLicenceYears != null &&
                    this.DrivingLicenceYears.Equals(other.DrivingLicenceYears)
                ) && 
                (
                    this.AdditionalDrivingQualifications == other.AdditionalDrivingQualifications ||
                    this.AdditionalDrivingQualifications != null &&
                    this.AdditionalDrivingQualifications.Equals(other.AdditionalDrivingQualifications)
                ) && 
                (
                    this.DvlaMedicalConditions == other.DvlaMedicalConditions ||
                    this.DvlaMedicalConditions != null &&
                    this.DvlaMedicalConditions.Equals(other.DvlaMedicalConditions)
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
                
                    if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                    if (this.MaritalStataus != null)
                    hash = hash * 59 + this.MaritalStataus.GetHashCode();
                
                    if (this.TelephoneNumber != null)
                    hash = hash * 59 + this.TelephoneNumber.GetHashCode();
                
                    if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                
                    if (this.EmploymentStatus != null)
                    hash = hash * 59 + this.EmploymentStatus.GetHashCode();
                
                    if (this.Occupation != null)
                    hash = hash * 59 + this.Occupation.GetHashCode();
                
                    if (this.BusinessType != null)
                    hash = hash * 59 + this.BusinessType.GetHashCode();
                
                    if (this.PartTimeWork != null)
                    hash = hash * 59 + this.PartTimeWork.GetHashCode();
                
                    if (this.SecondOccupation != null)
                    hash = hash * 59 + this.SecondOccupation.GetHashCode();
                
                    if (this.SecondBusinessType != null)
                    hash = hash * 59 + this.SecondBusinessType.GetHashCode();
                
                    if (this.HomeOwnership != null)
                    hash = hash * 59 + this.HomeOwnership.GetHashCode();
                
                    if (this.ChildrenUnderSixteen != null)
                    hash = hash * 59 + this.ChildrenUnderSixteen.GetHashCode();
                
                    if (this.ChildrenUnderEighteen != null)
                    hash = hash * 59 + this.ChildrenUnderEighteen.GetHashCode();
                
                    if (this.Smoker != null)
                    hash = hash * 59 + this.Smoker.GetHashCode();
                
                    if (this.UkResidentSinceBirth != null)
                    hash = hash * 59 + this.UkResidentSinceBirth.GetHashCode();
                
                    if (this.UkResidentSinceDate != null)
                    hash = hash * 59 + this.UkResidentSinceDate.GetHashCode();
                
                    if (this.DrivingLicenceType != null)
                    hash = hash * 59 + this.DrivingLicenceType.GetHashCode();
                
                    if (this.DrivingLicenceNumber != null)
                    hash = hash * 59 + this.DrivingLicenceNumber.GetHashCode();
                
                    if (this.DrivingLicenceYears != null)
                    hash = hash * 59 + this.DrivingLicenceYears.GetHashCode();
                
                    if (this.AdditionalDrivingQualifications != null)
                    hash = hash * 59 + this.AdditionalDrivingQualifications.GetHashCode();
                
                    if (this.DvlaMedicalConditions != null)
                    hash = hash * 59 + this.DvlaMedicalConditions.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PersonModel left, PersonModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PersonModel left, PersonModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
