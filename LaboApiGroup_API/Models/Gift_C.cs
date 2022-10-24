using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class Gift_C : IEntity<int>
    {
        public int Id { get; set; }
        public string Gift_Type { get; set; }
        public int Landing { get; set; }
        
    }
}
