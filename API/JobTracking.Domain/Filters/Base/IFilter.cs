namespace JobTracking.Domain.Filters.Base
{
    public interface IFilter<T>
    {
        IQueryable<T> Apply(IQueryable<T> query);
    }
}
