using JobTracking.Domain.Enums;

namespace JobTracking.Domain.Filters.Base;
    public class BaseFilter<T> where T : class
    {
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public string? SortBy { get; set; }
        public SortOrderEnum? SortDirection { get; set; }
    }
    
