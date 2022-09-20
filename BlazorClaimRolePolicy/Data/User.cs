using System.ComponentModel.DataAnnotations;

namespace BlazorClaimRolePolicy.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public String LoginName { get; set; } = String.Empty;
        [Required]
        public String UserRole { get; set; } = String.Empty;
    }
}
