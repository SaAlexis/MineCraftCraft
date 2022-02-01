
namespace Mine2Craft.Test.Entities
{
    public class CompleteItemEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Durability { get; set; }

        public ICollection<WorkbenchEntity> Workbenches { get; set; }
    }
}
