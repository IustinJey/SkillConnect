namespace skillz_backend.DTOs
{
    // Represents data for user details.
    public class UserDto
    {
        public int Id { get; set; }
        // Gets or sets the username.
        public string Username { get; set; }

        // Gets or sets the email.
        public string Email { get; set; }

        // Gets or sets the phone number.
        public string PhoneNumber { get; set; }

        // Gets or sets the location.
        public string Location { get; set; }

        // Gets or sets the authentication token.
        public string Token { get; set; }
    }
}
