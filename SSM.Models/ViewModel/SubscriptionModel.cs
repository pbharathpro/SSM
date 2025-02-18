using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SSM.Models.ViewModel
{
    public class SubscriptionModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int DurationMonths { get; set; }
        public Guid UserId { get; set; }


    }
}
