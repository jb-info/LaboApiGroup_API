using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class RoleOfUser_C : IEntity<int>
    {
        public int Password { get; set; }
        public int Id_User { get; set; }
        public int Id_Role { get; set; }
    }
}
