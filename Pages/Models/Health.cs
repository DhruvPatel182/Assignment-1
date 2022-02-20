using System;
using System.ComponentModel.DataAnnotations;

namespace HealthRazor.Models
{
    public class Health
    {
        public int ID { get; set; }
        public string DiseaseName { get; set; }
        public string Cause { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        public string Precaution { get; set; }
        public decimal HealthIndex { get; set; }
    }
}