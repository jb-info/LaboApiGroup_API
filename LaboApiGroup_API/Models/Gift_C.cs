namespace LaboApiGroup_API.Models
{
    public class Gift_C : IEntity<int>
    {
        public int Id { get; set; }
        public string Gift_Type { get; set; }
        public int landing { get; set; }
    }
}
