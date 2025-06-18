namespace JobTracking.DataAccess.Data.Base;

public class JobRecommendation
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int JobId { get; set; }
    public Job Job { get; set; }

    public double Score { get; set; }
}
