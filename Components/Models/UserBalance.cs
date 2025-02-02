using ProjektKrypto2.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektKrypto2.Components.Models
{
    public class UserBalance
    {
        [Key]
        public string UserId { get; set; } = null!;

        public decimal Balance { get; set; } = 0;

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; } = null!;
    }
}