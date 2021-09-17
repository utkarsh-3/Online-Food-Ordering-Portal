using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [MaxLength(10)]
        [MinLength(3)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [MaxLength(10)]
        [MinLength(3)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please enter your Address")]
        [MaxLength(10)]
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        
        [Required(ErrorMessage = "Please enter correct Pincode")]
        [StringLength(6)]
        [MinLength(6)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Pin code")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Please enter correct Pincode")]
        public string Pincode { get; set; }
        
        [Required(ErrorMessage = "Please enter your City")]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter your State")]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your Country")]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]

        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter your Phone number")]
        [StringLength(10)]
        [MinLength(10)]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter your Email ")]
        [StringLength(25)]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

    }
}
