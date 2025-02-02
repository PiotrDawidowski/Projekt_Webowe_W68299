using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjektKrypto2.Data;

namespace ProjektKrypto2.Components.Models
{
    public class CryptoWallet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        public string CryptoSymbol { get; set; } = string.Empty;

        [Required]
        public string CryptoName { get; set; } = string.Empty;

        [Required]
        public decimal Quantity { get; set; } // Ilość zakupionej kryptowaluty

        [Required]
        public decimal PriceUsd { get; set; } // Cena zakupu

        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }
    }
}
