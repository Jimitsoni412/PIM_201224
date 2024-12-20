namespace PIM.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
