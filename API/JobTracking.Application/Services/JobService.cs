using JobTracking.DataAccess.Data.Base;
namespace JobTracking.Application.Services;
using JobTracking.Application.Interfaces;
using JobTracking.DataAccess;
using JobTracking.Domain.DTOs;
using Microsoft.EntityFrameworkCore;

public class JobService : IJobService
{
    private readonly AppDbContext _context;

    public JobService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<JobDto>> GetAllJobsAsync()
    {
        return await _context.Jobs
            .Select(j => new JobDto
            {
                Title = j.Title,
                Description = j.Description
            }).ToListAsync();
    }

    public async Task<JobDto> GetJobByIdAsync(int id)
    {
        var job = await _context.Jobs.FindAsync(id);
        return job == null ? null : new JobDto
        {
            Title = job.Title,
            Description = job.Description
        };
    }

    public async Task AddJobAsync(JobDto dto)
    {
        var job = new Job
        {
            Title = dto.Title,
            Description = dto.Description,
            PostedOn = DateTime.UtcNow
        };
        _context.Jobs.Add(job);
        await _context.SaveChangesAsync();
    }
}
