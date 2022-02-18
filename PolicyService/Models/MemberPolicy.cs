using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyService.Models
{
    public class MemberPolicy
    {
        public int MemberId { get; set; }
        public int PolicyId { get; set; }
        public int PolicyNo { get; set; }
        public string[] Benefits { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public int Tenure { get; set; }
        public double CapAmountBenefits { get; set; }
    }
}
