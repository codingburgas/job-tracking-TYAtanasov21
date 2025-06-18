namespace JobTracking.DataAccess.Data.Base;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; } // Use hashed passwords!
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<JobRecommendation> JobRecommendations { get; set; }
}
