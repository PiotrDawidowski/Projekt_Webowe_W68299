using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektKrypto2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal BalanceUsd { get; set; } = 0; // Domyœlnie 0 USD
    }

}
