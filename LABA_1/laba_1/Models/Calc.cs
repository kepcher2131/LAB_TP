using System.ComponentModel.DataAnnotations;

namespace laba_1.Models
{
    public class Calc
    {
        [Required(ErrorMessage = "Введите число")]
        public string? operand1 { get; set; }
        [Required(ErrorMessage = "Введите число")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Длина символа должна быть от 2 до 3")]
        public string? operand2 { get; set; }
        public string result { get; set; }
        public string calulate { get; set; }
        public string exception { get; set; }
    }
}
