using System.ComponentModel.DataAnnotations;

namespace PaymentMicroservice.Models
{
    public class PaymentDetails
    {
        [Required]
        [RegularExpression(@"^[0-9]*$")]
        [MinLength(12)]
        [MaxLength(12)]
        public string? CreditCardNumber { get; set; }


        [Required]
        [Range(2023, 2050, ErrorMessage = "ExpiryYear Field is Required Or ExpiryYear is invalid")]
        public int ExpiryYear { get; set; }


        [Required]
        [Range(100, 999, ErrorMessage = "Cvv Field is Required Or Cvv Number is invalid")]
        public int Cvv { get; set; }
    }
}
