using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSP.Models
{
    //public class LogInModel
    //{
    //    public string LoginType { get; set; }
    //    public string UserID { get; set; }
    //    public string Password { get; set; }
    //    public string ReEnteredPassword { get; set; }
    //    public string Email { get; set; }
    //    public string DOB { get; set; }
    //    public string PhoneNumber { get; set; }
    //}
    public class LogInModel
    {
        public int ID { get; set; }
        public string LoginType { get; set; }
        [Required]
        public string UserID { get; set; }
        public string Password { get; set; }
        public string ReEnteredPassword { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        public string Name { get; set; }
    }
}