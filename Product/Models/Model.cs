using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Models
{
    public enum Billin
    {
        Phonepe,
        Googlepay,
        Cash,
    }
    public class Model
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name should not be empty")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "PhoneNumber should not be empty")]
        [StringLength(10, ErrorMessage = "PhoneNumber should not exceed 10 digits")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "CityName should not be empty")]
        public string City { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "RegionName should not be empty")]
        public string Region { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "PostalCode should not be empty")]
        public string PostalCode { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "CountryName should not be empty")]
        public string Country { get; set; }
        public Billin Billing { get; set; }
    }


}
