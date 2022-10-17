using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class Users_C : IEntity<int>
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
