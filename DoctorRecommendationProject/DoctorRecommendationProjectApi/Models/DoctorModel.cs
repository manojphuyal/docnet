using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorRecommendationProject.Models
{
    public class DoctorModel
    {
        public int Doctor_ID { get; set; }
        public int Doctor_Specialty_ID { get; set; }
        public string Doctor_Name { get; set; }
        public string Doctor_Experience { get; set; }
        public int Hospital_ID { get; set; }
        public string Doctor_Education { get; set; }
        public string Doctor_Phone { get; set; }
        public string Doctor_Address { get; set; }
        public string Doctor_Email { get; set; }
        public string Doctor_Review { get; set; }
        public int Doctor_Comment_ID { get; set; }
    }
}