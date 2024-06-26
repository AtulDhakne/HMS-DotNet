﻿using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Enter your email")]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Enter a valid email id")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Enter your Name")]
        //[RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Name should have alphabets only")]
        public string Name { get; set; }


        //[Required(ErrorMessage = "Enter your phone number")]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter valid phone number")]
        public string Phone { get; set; }
        public string Diseases { get; set; }




        //[Required]
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }


        //[DataType(DataType.Date)]
        //[Display(Name = "Date Of Booking")]
        //[NotFutureDate(ErrorMessage = "Booking Date of cannot be a past date.")]
        public DateTime BookingDate { get; set; }

        //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
        //public class NotFutureDateAttribute : ValidationAttribute
        //{
        //    public override bool IsValid(object value)
        //    {
        //        if (value is DateTime date)
        //        {
        //            return date >= DateTime.Now;
        //        }

        //        // Return false for non-DateTime values (you can modify this behavior based on your requirements)
        //        return false;
        //    }
        //}
    }

}
