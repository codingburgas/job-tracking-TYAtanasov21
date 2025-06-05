namespace JobTracking.Application.Interfaces;
using JobTracking.Domain.DTOs;
public interface IJobService
{
    Task<IEnumerable<JobDto>> GetAllJobsAsync();
    Task<JobDto> GetJobByIdAsync(int id);
    Task AddJobAsync(JobDto jobDto);
}