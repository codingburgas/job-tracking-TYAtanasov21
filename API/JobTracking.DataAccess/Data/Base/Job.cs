namespace JobTracking.DataAccess.Data.Base;
public class Job
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PostedOn { get; set; }
}