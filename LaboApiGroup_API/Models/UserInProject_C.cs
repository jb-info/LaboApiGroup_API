namespace LaboApiGroup_API.Models
{
    public class UserInProject_C : IEntity<int>
    {
        public int Id { get; set; }
        public int Id_Project { get; set; }
        public int Id_User { get; set; }
    }
}
