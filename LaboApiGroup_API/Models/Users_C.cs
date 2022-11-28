using LaboApiGroup_Repo.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LaboApiGroup_API.Models
{
    public class Users_C : IEntity<Guid>
    {
        public Guid Id { get; set; }
        [Required]
        public string NickName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
    public class Login_User
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
   public class UserWithToken
    {
        public Guid Guid { get; set; }
        public string NickName { get; set; }
        public bool IsAdmin { get; set; }
        public Role_C Role { get; set; }
        public string Token { get; set; }
    }
    public class SwitchUser
    {
        [Required]
        public Guid Id_User { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
