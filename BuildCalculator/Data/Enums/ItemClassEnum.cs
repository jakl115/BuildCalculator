using System.ComponentModel.DataAnnotations;

namespace BuildCalculator.Data.Enums
{
    public enum ItemClassEnum
    {
        [Display(Name = "Zbroja")]
        zbroja = 1,
        [Display(Name = "Hełm")]
        helm = 2,
        [Display(Name = "Naszyjnik")]
        naszyjnik = 3,
        [Display(Name = "Rękawice")]
        rekawice = 4,
        [Display(Name = "Broń")]
        bron = 5,
        [Display(Name = "Tarcza")]
        tarcza = 6,
        [Display(Name = "Pas")]
        pas = 7,
        [Display(Name = "Buty")]
        buty = 8,
        [Display(Name = "Pierścień")]
        pierscien = 9,
        [Display(Name = "Spodnie")]
        spodnie = 10,
        [Display(Name = "Peleryna")]
        peleryna = 11
    }
}
