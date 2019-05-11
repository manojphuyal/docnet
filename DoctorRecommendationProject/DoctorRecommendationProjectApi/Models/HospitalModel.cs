using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorRecommendationProject.Models
{
    public class HospitalModel
    {
        public int Hospital_ID { get; set; }
        public string Hospital_Name { get; set; }
        public string Hospital_Address { get; set; }
        public string Hospital_Phone { get; set; }
    }
}