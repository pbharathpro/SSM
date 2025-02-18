using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSM.Models.ViewModel
{
    public class SubscriberDetailsModel
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Cost { get; set; }

        public int DurationMonths { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime RenewalDate { get; set; }
        public Guid UserId { get; set; }

    }
}
