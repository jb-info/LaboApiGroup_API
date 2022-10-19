using LaboApiGroup_Repo.Interfaces;

namespace LaboApiGroup_API.Models
{
    public class Transactions_C : IEntity<int>
    {
        public int Id { get; set; }
        public int Id_Project { get; set; }
        public Guid Id_User { get; set; }
        public int Amount { get; set; }
        public DateTime Date_Transaction { get; set; }
    }
}
