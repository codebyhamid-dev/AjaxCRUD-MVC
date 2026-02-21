using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxCRUD_MVC.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Account Number")]
        [Required(ErrorMessage = "Account Number is required.")]
        [Column(TypeName = "nvarchar(20)")]
        public string AccountNumber { get; set; }
        [Display(Name = "Beneficiary Name")]
        [Required(ErrorMessage = "Beneficiary Name is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [Display(Name = "Bank Name")]
        [Required(ErrorMessage = "Bank Name is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }
        [Display(Name = "SWIFT Code")]
        [Required(ErrorMessage = "SWIFT Code is required.")]
        [Column(TypeName = "nvarchar(20)")]
        public string SwiftCode { get; set; }
        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
