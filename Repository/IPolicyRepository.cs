using PolicyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyService.Repository
{
    public interface IPolicyRepository
    {
        public IEnumerable<ProviderPolicy> GetChainOfProviders(int policyId);
        public string[] GetEligibleBenefits(int policyId, int memberId);
        public double GetEligibleClaimAmount(int policyId, int memberId);
        public List<Policy> GetPolicyList();
    }
}
