namespace JobTracking.Domain.DTOs
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; } // "seeker" or "lister"
    }
}
