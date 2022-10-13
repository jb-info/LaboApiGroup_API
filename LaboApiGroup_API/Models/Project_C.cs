using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class Project_C : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int Financial_Targets { get; set; }
        public int Earn_Money { get; set; }
    }
}
