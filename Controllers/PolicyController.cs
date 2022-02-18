using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PolicyService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyRepository _policyRepository;
        public PolicyController(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }

        [HttpGet]

        [Route("PolicyList")]
        public IActionResult PolicyList()
        {
            try
            {
                var policyList = _policyRepository.GetPolicyList();
                return Ok(policyList);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        //[Route("{id:int}")]
        [Route("[action]/{id}")]
        public IActionResult GetChainOfProviders(int id)
        {
            try
            {

                if (id > 0)
                {
                    var providerlist = _policyRepository.GetChainOfProviders(id);
                    return Ok(providerlist);
                }
                else
                   return BadRequest();
            }
            catch (Exception)
            {
                return new NoContentResult();
            }
        }

        //https://localhost:44314/api/Policy/GetEligibleBenefits?PolicyId=1&MemberID=1
        [HttpGet]
        [Route("GetEligibleBenefits")]

        public IActionResult GetEligibleBenefit([FromQuery] int policyId, [FromQuery] int memberId)
        {
            try
            {
                if (policyId > 0 && memberId > 0)
                {
                    var benefitslist = _policyRepository.GetEligibleBenefits(policyId, memberId);
                    return new OkObjectResult(benefitslist);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {
                return new NoContentResult();
            }
        }

        //https://localhost:44314/api/Policy/GetEligibleClaimAmount?policyId=1&memberId=1
        [HttpGet]
        [Route("GetEligibleClaimAmount")]
        public IActionResult GetEligibleClaimAmount([FromQuery] int policyId, [FromQuery] int memberId)
        {
            try
            {
                if (policyId > 0 && memberId > 0)
                {
                    double amt = _policyRepository.GetEligibleClaimAmount(policyId, memberId);
                    if (amt != -1)
                        return new OkObjectResult(amt);
                    else
                        return BadRequest();
                }
                else
                    return BadRequest();

            }
            catch (Exception)
            {
                return new NoContentResult();
            }
        }
    }
}
