using System.ComponentModel.DataAnnotations;

namespace BuildCalculator.Data
{
    public class ItemClass
    {
        [Key]
        public int itemClassId { get; set; }
        public string name { get; set; } = string.Empty;

        public ICollection<Item> items { get; set; }
    }
}
