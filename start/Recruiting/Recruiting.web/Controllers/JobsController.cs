using Microsoft.AspNetCore.Mvc;
using Recruiting.Data.EfModels;
using Recruiting.Data.EfRepositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recruiting.Web.Controllers
{
    public class JobsController : Controller
    {
        private readonly IEfJobRepository _jobRepository;

        public JobsController(IEfJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<IActionResult> List()
        {
            IEnumerable<EfJob> jobs = await _jobRepository.ListAsync();
            return View(jobs);
        }
    }
}
