using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyService.Models
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public int PolicyNo { get; set; }
        public string[] Benefits { get; set; }
        public double Premium { get; set; }
        public int Tenure { get; set; }
    }
}
