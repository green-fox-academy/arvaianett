using System.ComponentModel.DataAnnotations;

namespace PallidaExam.Models
{
    public class FilterOptions
    {
        [MaxLength(7)]
        public string Q { get; set; }
        public string Police { get; set; }
        public string Diplomat { get; set; }
    }
}
