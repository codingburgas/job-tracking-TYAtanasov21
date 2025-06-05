namespace JobTracking.API.Controllers;
using JobTracking.Application.Interfaces;
using JobTracking.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet]
    public async Task<IActionResult> GetJobs() =>
        Ok(await _jobService.GetAllJobsAsync());

    [HttpPost]
    public async Task<IActionResult> AddJob([FromBody] JobDto dto)
    {
        await _jobService.AddJobAsync(dto);
        return Ok();
    }
}
