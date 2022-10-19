using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class GiftOfProject_C : IEntity<int>
    {
        public int Password { get; set; }
        public int Id_Project { get; set; }
        public int Id_Gift { get; set; }
    }
}
