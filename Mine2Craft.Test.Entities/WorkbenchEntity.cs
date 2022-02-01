
namespace Mine2Craft.Test.Entities
{
    public class WorkbenchEntity
    {
        public Guid Id { get; set; }
        public int Position { get; set; }

        public Guid CurrentItemId { get; set; }
        public ItemEntity CurrentItem { get; set; }

        public Guid CurrentCompleteItemId { get; set; }
        public CompleteItemEntity CurrentCompleteItem { get; set; }

    }
}
