using Microsoft.AspNetCore.Http;
using PolicyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace PolicyService.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        public IEnumerable<ProviderPolicy> GetChainOfProviders(int policyId)
        {
            try
            {

                var providerList = PolicyServiceData.providerPolicyList.Where(p => p.PolicyId == policyId).ToList();
                if (providerList != null)
                {
                    return providerList;
                }
                else
                    return null;
            }
            catch(Exception e)
            {
                return (IEnumerable<ProviderPolicy>)e.ToString().ToList();
            }
           
        }

        public string[] GetEligibleBenefits(int policyId, int memberId)
        {
            try
            {
                //string[] benefits = PolicyServiceData.memberPolicyList.Find(x => x.MemberId == memberId && x.PolicyId == policyId).Benefits;
                string[] benefits = PolicyServiceData.memberPolicyList.First(x => x.MemberId == memberId && x.PolicyId == policyId).Benefits.ToArray();
                
                if(benefits == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                else
                {
                    return benefits;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public double GetEligibleClaimAmount(int policyId, int memberId)
        {
            try
            {
                if (PolicyServiceData.memberPolicyList.FirstOrDefault(p => p.PolicyId == policyId && p.MemberId == memberId) == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                else
                {
                    double claimAmt = PolicyServiceData.memberPolicyList.FirstOrDefault(p => p.PolicyId == policyId && p.MemberId == memberId).CapAmountBenefits;
                    return claimAmt;
                }
            }
            catch (Exception)
            {
                double errorValue = -1;
                return errorValue;

            }
        }
        public List<Policy> GetPolicyList()
        {
            return PolicyServiceData.policyList;
        }
    }
}
