using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SSM.Models.ViewModel
{
    public class SubscriptionModel
    {
        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Category can only contain letters and spaces.")]
        public string Category { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Duration must be between 1 and 12 months.")]
        public int DurationMonths { get; set; }

        [Required]
        public Guid UserId { get; set; }


    }
}
