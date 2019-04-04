using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSP.Models
{
    public class LogInModel
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Mobile { get; set; }
    }
}