namespace DogWalkingManager.Services
{
    /// <summary>
    /// Provides a simple authentication mechanism.
    /// </summary>
    public class AuthenticationService
    {
        private const string DefaultUsername = "admin";
        private const string DefaultPassword = "password";

        /// <summary>
        /// Validates login credentials.
        /// </summary>
        /// <param name="username">The username entered.</param>
        /// <param name="password">The password entered.</param>
        /// <returns>True if credentials are valid; otherwise, false.</returns>
        public bool Login(string username, string password)
        {
            return username == DefaultUsername && password == DefaultPassword;
        }
    }
}
