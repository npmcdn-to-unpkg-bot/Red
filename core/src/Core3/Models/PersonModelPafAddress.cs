using System;
using System.Text;
using Newtonsoft.Json;

namespace Core3.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PersonModelPafAddress :  IEquatable<PersonModelPafAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonModelPafAddress" /> class.
        /// </summary>
        /// <param name="AdministrativeCounty">AdministrativeCounty.</param>
        /// <param name="DoubleDependentLocality">DoubleDependentLocality.</param>
        /// <param name="Town">Town.</param>
        /// <param name="TraditionalCounty">TraditionalCounty.</param>
        /// <param name="Dps">Dps.</param>
        /// <param name="SubBuilding">SubBuilding.</param>
        /// <param name="Postcode">Postcode.</param>
        /// <param name="PostalCounty">PostalCounty.</param>
        /// <param name="AbbreviatedPostalCounty">AbbreviatedPostalCounty.</param>
        /// <param name="DependentLocality">DependentLocality.</param>
        /// <param name="AbbreviatedOptionalCounty">AbbreviatedOptionalCounty.</param>
        /// <param name="Thoroughfare">Thoroughfare.</param>
        /// <param name="Building">Building.</param>
        /// <param name="OptionalCounty">OptionalCounty.</param>
        /// <param name="Number">Number.</param>
        /// <param name="PoBox">PoBox.</param>
        /// <param name="OrganisationName">OrganisationName.</param>
        /// <param name="DependentThoroughfare">DependentThoroughfare.</param>
        /// <param name="Department">Department.</param>
        public PersonModelPafAddress(string AdministrativeCounty = null, string DoubleDependentLocality = null, string Town = null, string TraditionalCounty = null, string Dps = null, string SubBuilding = null, string Postcode = null, string PostalCounty = null, string AbbreviatedPostalCounty = null, string DependentLocality = null, string AbbreviatedOptionalCounty = null, string Thoroughfare = null, string Building = null, string OptionalCounty = null, string Number = null, string PoBox = null, string OrganisationName = null, string DependentThoroughfare = null, string Department = null)
        {
            this.AdministrativeCounty = AdministrativeCounty;
            this.DoubleDependentLocality = DoubleDependentLocality;
            this.Town = Town;
            this.TraditionalCounty = TraditionalCounty;
            this.Dps = Dps;
            this.SubBuilding = SubBuilding;
            this.Postcode = Postcode;
            this.PostalCounty = PostalCounty;
            this.AbbreviatedPostalCounty = AbbreviatedPostalCounty;
            this.DependentLocality = DependentLocality;
            this.AbbreviatedOptionalCounty = AbbreviatedOptionalCounty;
            this.Thoroughfare = Thoroughfare;
            this.Building = Building;
            this.OptionalCounty = OptionalCounty;
            this.Number = Number;
            this.PoBox = PoBox;
            this.OrganisationName = OrganisationName;
            this.DependentThoroughfare = DependentThoroughfare;
            this.Department = Department;
            
        }

        
        /// <summary>
        /// Gets or Sets AdministrativeCounty
        /// </summary>
        public string AdministrativeCounty { get; set; }

        
        /// <summary>
        /// Gets or Sets DoubleDependentLocality
        /// </summary>
        public string DoubleDependentLocality { get; set; }

        
        /// <summary>
        /// Gets or Sets Town
        /// </summary>
        public string Town { get; set; }

        
        /// <summary>
        /// Gets or Sets TraditionalCounty
        /// </summary>
        public string TraditionalCounty { get; set; }

        
        /// <summary>
        /// Gets or Sets Dps
        /// </summary>
        public string Dps { get; set; }

        
        /// <summary>
        /// Gets or Sets SubBuilding
        /// </summary>
        public string SubBuilding { get; set; }

        
        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        public string Postcode { get; set; }

        
        /// <summary>
        /// Gets or Sets PostalCounty
        /// </summary>
        public string PostalCounty { get; set; }

        
        /// <summary>
        /// Gets or Sets AbbreviatedPostalCounty
        /// </summary>
        public string AbbreviatedPostalCounty { get; set; }

        
        /// <summary>
        /// Gets or Sets DependentLocality
        /// </summary>
        public string DependentLocality { get; set; }

        
        /// <summary>
        /// Gets or Sets AbbreviatedOptionalCounty
        /// </summary>
        public string AbbreviatedOptionalCounty { get; set; }

        
        /// <summary>
        /// Gets or Sets Thoroughfare
        /// </summary>
        public string Thoroughfare { get; set; }

        
        /// <summary>
        /// Gets or Sets Building
        /// </summary>
        public string Building { get; set; }

        
        /// <summary>
        /// Gets or Sets OptionalCounty
        /// </summary>
        public string OptionalCounty { get; set; }

        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        public string Number { get; set; }

        
        /// <summary>
        /// Gets or Sets PoBox
        /// </summary>
        public string PoBox { get; set; }

        
        /// <summary>
        /// Gets or Sets OrganisationName
        /// </summary>
        public string OrganisationName { get; set; }

        
        /// <summary>
        /// Gets or Sets DependentThoroughfare
        /// </summary>
        public string DependentThoroughfare { get; set; }

        
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        public string Department { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonModelPafAddress {\n");
            sb.Append("  AdministrativeCounty: ").Append(AdministrativeCounty).Append("\n");
            sb.Append("  DoubleDependentLocality: ").Append(DoubleDependentLocality).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  TraditionalCounty: ").Append(TraditionalCounty).Append("\n");
            sb.Append("  Dps: ").Append(Dps).Append("\n");
            sb.Append("  SubBuilding: ").Append(SubBuilding).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  PostalCounty: ").Append(PostalCounty).Append("\n");
            sb.Append("  AbbreviatedPostalCounty: ").Append(AbbreviatedPostalCounty).Append("\n");
            sb.Append("  DependentLocality: ").Append(DependentLocality).Append("\n");
            sb.Append("  AbbreviatedOptionalCounty: ").Append(AbbreviatedOptionalCounty).Append("\n");
            sb.Append("  Thoroughfare: ").Append(Thoroughfare).Append("\n");
            sb.Append("  Building: ").Append(Building).Append("\n");
            sb.Append("  OptionalCounty: ").Append(OptionalCounty).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PoBox: ").Append(PoBox).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  DependentThoroughfare: ").Append(DependentThoroughfare).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            
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
            return Equals((PersonModelPafAddress)obj);
        }

        /// <summary>
        /// Returns true if PersonModelPafAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonModelPafAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonModelPafAddress other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AdministrativeCounty == other.AdministrativeCounty ||
                    this.AdministrativeCounty != null &&
                    this.AdministrativeCounty.Equals(other.AdministrativeCounty)
                ) && 
                (
                    this.DoubleDependentLocality == other.DoubleDependentLocality ||
                    this.DoubleDependentLocality != null &&
                    this.DoubleDependentLocality.Equals(other.DoubleDependentLocality)
                ) && 
                (
                    this.Town == other.Town ||
                    this.Town != null &&
                    this.Town.Equals(other.Town)
                ) && 
                (
                    this.TraditionalCounty == other.TraditionalCounty ||
                    this.TraditionalCounty != null &&
                    this.TraditionalCounty.Equals(other.TraditionalCounty)
                ) && 
                (
                    this.Dps == other.Dps ||
                    this.Dps != null &&
                    this.Dps.Equals(other.Dps)
                ) && 
                (
                    this.SubBuilding == other.SubBuilding ||
                    this.SubBuilding != null &&
                    this.SubBuilding.Equals(other.SubBuilding)
                ) && 
                (
                    this.Postcode == other.Postcode ||
                    this.Postcode != null &&
                    this.Postcode.Equals(other.Postcode)
                ) && 
                (
                    this.PostalCounty == other.PostalCounty ||
                    this.PostalCounty != null &&
                    this.PostalCounty.Equals(other.PostalCounty)
                ) && 
                (
                    this.AbbreviatedPostalCounty == other.AbbreviatedPostalCounty ||
                    this.AbbreviatedPostalCounty != null &&
                    this.AbbreviatedPostalCounty.Equals(other.AbbreviatedPostalCounty)
                ) && 
                (
                    this.DependentLocality == other.DependentLocality ||
                    this.DependentLocality != null &&
                    this.DependentLocality.Equals(other.DependentLocality)
                ) && 
                (
                    this.AbbreviatedOptionalCounty == other.AbbreviatedOptionalCounty ||
                    this.AbbreviatedOptionalCounty != null &&
                    this.AbbreviatedOptionalCounty.Equals(other.AbbreviatedOptionalCounty)
                ) && 
                (
                    this.Thoroughfare == other.Thoroughfare ||
                    this.Thoroughfare != null &&
                    this.Thoroughfare.Equals(other.Thoroughfare)
                ) && 
                (
                    this.Building == other.Building ||
                    this.Building != null &&
                    this.Building.Equals(other.Building)
                ) && 
                (
                    this.OptionalCounty == other.OptionalCounty ||
                    this.OptionalCounty != null &&
                    this.OptionalCounty.Equals(other.OptionalCounty)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.PoBox == other.PoBox ||
                    this.PoBox != null &&
                    this.PoBox.Equals(other.PoBox)
                ) && 
                (
                    this.OrganisationName == other.OrganisationName ||
                    this.OrganisationName != null &&
                    this.OrganisationName.Equals(other.OrganisationName)
                ) && 
                (
                    this.DependentThoroughfare == other.DependentThoroughfare ||
                    this.DependentThoroughfare != null &&
                    this.DependentThoroughfare.Equals(other.DependentThoroughfare)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
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
                
                    if (this.AdministrativeCounty != null)
                    hash = hash * 59 + this.AdministrativeCounty.GetHashCode();
                
                    if (this.DoubleDependentLocality != null)
                    hash = hash * 59 + this.DoubleDependentLocality.GetHashCode();
                
                    if (this.Town != null)
                    hash = hash * 59 + this.Town.GetHashCode();
                
                    if (this.TraditionalCounty != null)
                    hash = hash * 59 + this.TraditionalCounty.GetHashCode();
                
                    if (this.Dps != null)
                    hash = hash * 59 + this.Dps.GetHashCode();
                
                    if (this.SubBuilding != null)
                    hash = hash * 59 + this.SubBuilding.GetHashCode();
                
                    if (this.Postcode != null)
                    hash = hash * 59 + this.Postcode.GetHashCode();
                
                    if (this.PostalCounty != null)
                    hash = hash * 59 + this.PostalCounty.GetHashCode();
                
                    if (this.AbbreviatedPostalCounty != null)
                    hash = hash * 59 + this.AbbreviatedPostalCounty.GetHashCode();
                
                    if (this.DependentLocality != null)
                    hash = hash * 59 + this.DependentLocality.GetHashCode();
                
                    if (this.AbbreviatedOptionalCounty != null)
                    hash = hash * 59 + this.AbbreviatedOptionalCounty.GetHashCode();
                
                    if (this.Thoroughfare != null)
                    hash = hash * 59 + this.Thoroughfare.GetHashCode();
                
                    if (this.Building != null)
                    hash = hash * 59 + this.Building.GetHashCode();
                
                    if (this.OptionalCounty != null)
                    hash = hash * 59 + this.OptionalCounty.GetHashCode();
                
                    if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                
                    if (this.PoBox != null)
                    hash = hash * 59 + this.PoBox.GetHashCode();
                
                    if (this.OrganisationName != null)
                    hash = hash * 59 + this.OrganisationName.GetHashCode();
                
                    if (this.DependentThoroughfare != null)
                    hash = hash * 59 + this.DependentThoroughfare.GetHashCode();
                
                    if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PersonModelPafAddress left, PersonModelPafAddress right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PersonModelPafAddress left, PersonModelPafAddress right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
