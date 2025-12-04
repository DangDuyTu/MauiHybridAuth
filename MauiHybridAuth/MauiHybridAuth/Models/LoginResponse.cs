using System.Text.Json.Serialization;

namespace MauiHybridAuth.Models
{
    /// <summary>
    /// This class is used to store the token information received from the server.
    /// </summary>
    public class LoginResponse
    {
        const int ACCESS_TOKEN_EXPIRY_SECONDS = 900;
        public LoginResponse()
        {
            ExpiresIn = ACCESS_TOKEN_EXPIRY_SECONDS;
        }

        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public int ExpiresIn { get; set; }
        public DateTime ExpiresTime { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string? UserName { get; set; } = string.Empty;
        public string ClientId { get; set; }
        public string? Email { get; set; } = string.Empty;
        public bool Success { get; set; }
        public string Message { get; set; }
        public string? DbName { get; set; }
        public string? DbId { get; set; }
        public bool Is2FAToken { get; set; }
        public string TokenType { get; set; } = "Bearer";

    }
}
