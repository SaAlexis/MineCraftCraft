

namespace Mine2Craft.Test.Entities
{
    public class ItemEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte isCombustible { get; set; }
        public byte isCooked { get; set; }

        public ICollection<WorkbenchEntity> Workbenches { get; set; }
    }
}
