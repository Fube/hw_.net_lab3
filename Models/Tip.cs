using System.ComponentModel.DataAnnotations;

namespace hw_.net_lab3.Models
{
    public class Tip
    {
        [Required(ErrorMessage = "Cost of meal is required")]
        // double.Epsilon is the smallest positive number
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Cost of meal must be greater than 0")]
        public decimal Cost { get; set; }

        public decimal GetTip(decimal Percentage) => Cost * Percentage/100;
    }
}
