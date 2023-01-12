using BlissQuestions.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net;
using System.Threading.Tasks;

namespace BlissQuestions.API.Controllers
{
    [Route("api/health")]
    public class HealthController : Controller
    {
        private readonly HealthCheckService _healthCheckService;
        public HealthController(HealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        /// <summary>
        /// Get Health
        /// </summary>
        /// <remarks>Provides an indication about the health of the API</remarks>
        /// <response code="200">API is healthy</response>
        /// <response code="503">API is unhealthy or in degraded state</response>
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var report = await _healthCheckService.CheckHealthAsync();
            var healthResponse = new HealthDto();
            if (report.Status == HealthStatus.Healthy)
            {
                healthResponse.Status = "OK";
                return Ok(healthResponse);
            }
            healthResponse.Status = "Service Unavailable. Please try again later.";
            return StatusCode((int)HttpStatusCode.ServiceUnavailable, healthResponse);
        }
    }
}
