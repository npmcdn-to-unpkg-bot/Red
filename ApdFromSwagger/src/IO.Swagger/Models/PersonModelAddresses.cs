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
    public partial class PersonModelAddresses :  IEquatable<PersonModelAddresses>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonModelAddresses" /> class.
        /// </summary>
        /// <param name="LineTwo">LineTwo.</param>
        /// <param name="LineFive">LineFive.</param>
        /// <param name="LineSix">LineSix.</param>
        /// <param name="Postcode">Postcode (required).</param>
        /// <param name="PafAddress">PafAddress.</param>
        /// <param name="LineOne">LineOne (required).</param>
        /// <param name="LineFour">LineFour.</param>
        /// <param name="LineThree">LineThree.</param>
        /// <param name="LineSeven">LineSeven.</param>
        public PersonModelAddresses(string LineTwo = null, string LineFive = null, string LineSix = null, string Postcode = null, PersonModelPafAddress PafAddress = null, string LineOne = null, string LineFour = null, string LineThree = null, string LineSeven = null)
        {
            // to ensure "Postcode" is required (not null)
            if (Postcode == null)
            {
                throw new InvalidDataException("Postcode is a required property for PersonModelAddresses and cannot be null");
            }
            else
            {
                this.Postcode = Postcode;
            }
            // to ensure "LineOne" is required (not null)
            if (LineOne == null)
            {
                throw new InvalidDataException("LineOne is a required property for PersonModelAddresses and cannot be null");
            }
            else
            {
                this.LineOne = LineOne;
            }
            this.LineTwo = LineTwo;
            this.LineFive = LineFive;
            this.LineSix = LineSix;
            this.PafAddress = PafAddress;
            this.LineFour = LineFour;
            this.LineThree = LineThree;
            this.LineSeven = LineSeven;
            
        }

        
        /// <summary>
        /// Gets or Sets LineTwo
        /// </summary>
        public string LineTwo { get; set; }

        
        /// <summary>
        /// Gets or Sets LineFive
        /// </summary>
        public string LineFive { get; set; }

        
        /// <summary>
        /// Gets or Sets LineSix
        /// </summary>
        public string LineSix { get; set; }

        
        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        public string Postcode { get; set; }

        
        /// <summary>
        /// Gets or Sets PafAddress
        /// </summary>
        public PersonModelPafAddress PafAddress { get; set; }

        
        /// <summary>
        /// Gets or Sets LineOne
        /// </summary>
        public string LineOne { get; set; }

        
        /// <summary>
        /// Gets or Sets LineFour
        /// </summary>
        public string LineFour { get; set; }

        
        /// <summary>
        /// Gets or Sets LineThree
        /// </summary>
        public string LineThree { get; set; }

        
        /// <summary>
        /// Gets or Sets LineSeven
        /// </summary>
        public string LineSeven { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonModelAddresses {\n");
            sb.Append("  LineTwo: ").Append(LineTwo).Append("\n");
            sb.Append("  LineFive: ").Append(LineFive).Append("\n");
            sb.Append("  LineSix: ").Append(LineSix).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  PafAddress: ").Append(PafAddress).Append("\n");
            sb.Append("  LineOne: ").Append(LineOne).Append("\n");
            sb.Append("  LineFour: ").Append(LineFour).Append("\n");
            sb.Append("  LineThree: ").Append(LineThree).Append("\n");
            sb.Append("  LineSeven: ").Append(LineSeven).Append("\n");
            
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
            return Equals((PersonModelAddresses)obj);
        }

        /// <summary>
        /// Returns true if PersonModelAddresses instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonModelAddresses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonModelAddresses other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.LineTwo == other.LineTwo ||
                    this.LineTwo != null &&
                    this.LineTwo.Equals(other.LineTwo)
                ) && 
                (
                    this.LineFive == other.LineFive ||
                    this.LineFive != null &&
                    this.LineFive.Equals(other.LineFive)
                ) && 
                (
                    this.LineSix == other.LineSix ||
                    this.LineSix != null &&
                    this.LineSix.Equals(other.LineSix)
                ) && 
                (
                    this.Postcode == other.Postcode ||
                    this.Postcode != null &&
                    this.Postcode.Equals(other.Postcode)
                ) && 
                (
                    this.PafAddress == other.PafAddress ||
                    this.PafAddress != null &&
                    this.PafAddress.Equals(other.PafAddress)
                ) && 
                (
                    this.LineOne == other.LineOne ||
                    this.LineOne != null &&
                    this.LineOne.Equals(other.LineOne)
                ) && 
                (
                    this.LineFour == other.LineFour ||
                    this.LineFour != null &&
                    this.LineFour.Equals(other.LineFour)
                ) && 
                (
                    this.LineThree == other.LineThree ||
                    this.LineThree != null &&
                    this.LineThree.Equals(other.LineThree)
                ) && 
                (
                    this.LineSeven == other.LineSeven ||
                    this.LineSeven != null &&
                    this.LineSeven.Equals(other.LineSeven)
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
                
                    if (this.LineTwo != null)
                    hash = hash * 59 + this.LineTwo.GetHashCode();
                
                    if (this.LineFive != null)
                    hash = hash * 59 + this.LineFive.GetHashCode();
                
                    if (this.LineSix != null)
                    hash = hash * 59 + this.LineSix.GetHashCode();
                
                    if (this.Postcode != null)
                    hash = hash * 59 + this.Postcode.GetHashCode();
                
                    if (this.PafAddress != null)
                    hash = hash * 59 + this.PafAddress.GetHashCode();
                
                    if (this.LineOne != null)
                    hash = hash * 59 + this.LineOne.GetHashCode();
                
                    if (this.LineFour != null)
                    hash = hash * 59 + this.LineFour.GetHashCode();
                
                    if (this.LineThree != null)
                    hash = hash * 59 + this.LineThree.GetHashCode();
                
                    if (this.LineSeven != null)
                    hash = hash * 59 + this.LineSeven.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PersonModelAddresses left, PersonModelAddresses right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PersonModelAddresses left, PersonModelAddresses right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
