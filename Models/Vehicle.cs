using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTIWEBAPPDEMO.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string VehicleName { get; set; }
       
    }
}
