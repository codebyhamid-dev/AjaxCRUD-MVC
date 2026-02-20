using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxCRUD_MVC.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Account Number is required.")]
        [Column(TypeName = "nvarchar(20)")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string SwiftCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
    }
}
