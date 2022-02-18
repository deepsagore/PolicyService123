using PolicyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyService
{
    public class PolicyServiceData
    {
        public static List<Policy> policyList = new List<Policy>
        {
            new Policy
            {
                PolicyId=1,
                PolicyNo=101,
                Premium=50000.00,
                Tenure=3,
                Benefits = new string[]{"Medical Treatment","Accidental"} 
            },
            new Policy
            {
                PolicyId=2,
                PolicyNo=102,
                Premium=20000.00,
                Tenure=5,
                Benefits = new string[]{"Medical Treatment","Accidental"}
            },
            new Policy
            {
                PolicyId=3,
                PolicyNo=103,
                Premium=20000.00,
                Tenure=5,
                Benefits = new string[]{"Medical Treatment","Accidental"}
            }

        };
        public static List<MemberPolicy> memberPolicyList = new List<MemberPolicy>
        {
           new MemberPolicy
           {
               MemberId=1,
               PolicyId=1,
               PolicyNo=101,
               Benefits = new string[]{"Medical Treatment","Accidental"},
               Tenure=3,
               SubscriptionDate=new DateTime(2020, 03, 15),
               CapAmountBenefits=100000.00
           },
           new MemberPolicy
           {
               MemberId=2,
               PolicyId=2,
               PolicyNo=101,
               Benefits = new string[]{"Medical Treatment2","Accidental"},
               Tenure=3,SubscriptionDate=new DateTime(2019, 04, 18),
               CapAmountBenefits=120000.00
           },
           new MemberPolicy
           {
               MemberId=3,
               PolicyId=2,
               PolicyNo=102,
               Benefits = new string[]{"Medical Treatment3","Accidental"},
               Tenure=5,SubscriptionDate=new DateTime(2019, 05, 10),
               CapAmountBenefits=80000.00
           }
        };

        public static List<ProviderPolicy> providerPolicyList = new List<ProviderPolicy>
        {
            new ProviderPolicy
            {
                HospitalId=1,
                HospitalName="Choithram Hospital",
                HospitalAddress="Near Rajiv Gandhi Square",
                Location="Indore, Madhya Pradesh",
                PolicyId=1
            },
            new ProviderPolicy
            {
                HospitalId=2,
                HospitalName="Sai Hospital",
                HospitalAddress="Near Rajghat",
                Location="Barwani, Madhya Pradesh",
                PolicyId=1
            },
            new ProviderPolicy
            {
                HospitalId=3,
                HospitalName="Apollo Hospital",
                HospitalAddress="Near Bhawarkuwan",
                Location="Indore",
                PolicyId=2
            }
        };
       
    }
}
