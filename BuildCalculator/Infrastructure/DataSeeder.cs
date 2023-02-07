using BuildCalculator.Data.Enums;
using BuildCalculator.Data;

namespace BuildCalculator.Infrastructure
{
    public static class DataSeeder
    {
        public static ICollection<ItemClass> getItemClasses()
        {
            var itemClasses = new List<ItemClass>();
            foreach (var enumValue in Enum.GetValues(typeof(ItemClassEnum)))
            {
                itemClasses.Add(new ItemClass()
                {
                    itemClassId = (int)enumValue,
                    name = ((ItemClassEnum)enumValue).ToString()
                });
            }
            return itemClasses;
        }
    }
}
