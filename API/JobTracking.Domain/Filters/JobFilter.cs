using JobTracking.DataAccess.Data.Base;
using JobTracking.Domain.Filters.Base;

namespace JobTracking.Domain.Filters;

    public class JobFilter : BaseFilter<JobFilter>, IFilter<Job>
    {
        public string? Title { get; set; }

        public IQueryable<Job> Apply(IQueryable<Job> query)
        {
            if (!string.IsNullOrEmpty(Title))
                query = query.Where(j => j.Title.Contains(Title));

            if (PageNumber.HasValue && PageSize.HasValue)
                query = query.Skip((PageNumber.Value - 1) * PageSize.Value).Take(PageSize.Value);

            return query;
        }
    }