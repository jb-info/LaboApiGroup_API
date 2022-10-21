using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class Users_C : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }

    public class Login_User
    {
        public int Email { get; set; }
        public int Password { get; set; }
    }
   public class UserWithToken
    {
        public string NickName { get; set; }
        public bool IsAdmin { get; set; }
        public Role_C Role { get; set; }
        public string Token { get; set; }
    }
}
