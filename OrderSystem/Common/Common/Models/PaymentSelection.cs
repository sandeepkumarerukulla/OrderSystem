using System.ComponentModel.DataAnnotations;

namespace Common.Models
{
    public class PaymentSelection
    {
        [Required]
        public string Type { get; set; }
    }
}
