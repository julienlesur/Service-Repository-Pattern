using Microsoft.AspNetCore.Mvc;
using Recruiting.Data.EfModels;
using Recruiting.Data.EfRepositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recruiting.Web.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly IEfApplicantRepository _applicantRepository;

        public ApplicantsController(IEfApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }
        public async Task<IActionResult> List()
        {
            IEnumerable<EfApplicant> applicants = await _applicantRepository.ListAsync();
            
            return View(applicants);
        }
    }
}
