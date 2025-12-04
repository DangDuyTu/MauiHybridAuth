using System.ComponentModel.DataAnnotations;

namespace MauiHybridAuth.Models
{
    public class LoginRequest
    {
        [Required]
        [Display(Name = "User name")]
        [EmailAddress]
        public string UserName { get; set; } = "admin@openworkshop.com";

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; } = "admin@openworkshop.com";

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "Admin@123";

        [Required]
        [Display(Name = "ClientId")]
        public string ClientId { get; set; } = "f02a5688-d993-46f9-beed-e557a52d578f";

        [Required]
        [Display(Name = "DbId")]
        public string DbId { get; set; } = "f1231b50-d928-42d9-acc8-116708e90be0";

        [Required]
        [Display(Name = "DbName")]
        public string DbName { get; set; } = "farm";
    }
}
