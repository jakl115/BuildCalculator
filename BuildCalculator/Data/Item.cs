using System.ComponentModel.DataAnnotations;

namespace BuildCalculator.Data
{
    public class Item
    {
        [Key]
        public int itemId { get; set; }
        public int itemClassId { get; set; }

        public string nazwa { get; set; } = String.Empty;
        public int? sila { get; set; }
        public int? zreka { get; set; }
        public int? moc { get; set; }
        public int? wiedza { get; set; }
        public int? hp { get; set; }
        public int? mana { get; set; }
        public int? konda { get; set; }
        public int? sieczne { get; set; }
        public int? obuch { get; set; }
        public int? klute { get; set; }
        public int? ogien { get; set; }
        public int? energia { get; set; }
        public int? zimno { get; set; }
        public int? urok { get; set; }
        public int? dmg { get; set; }

        public ItemClass itemClass { get; set; }
    }
}
