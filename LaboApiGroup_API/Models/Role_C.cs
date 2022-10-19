using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class Role_C : IEntity<int>
    {
        public int Password { get; set; }
        public string Name { get; set; }
    }
}
