using DogWalkingManager.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DogWalkingManager.Tests
{
    /// <summary>
    /// Contains unit tests for AuthenticationService.
    /// </summary>
    [TestClass]
    public class AuthenticationServiceTests
    {
        private AuthenticationService _authenticationService;

        [TestInitialize]
        public void Setup()
        {
            _authenticationService = new AuthenticationService();
        }

        [TestMethod]
        public void Login_ShouldReturnTrue_WhenCredentialsAreValid()
        {
            // Arrange
            string username = "admin";
            string password = "password";

            // Act
            bool result = _authenticationService.Login(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_ShouldReturnFalse_WhenUsernameIsInvalid()
        {
            // Arrange
            string username = "wronguser";
            string password = "password";

            // Act
            bool result = _authenticationService.Login(username, password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_ShouldReturnFalse_WhenPasswordIsInvalid()
        {
            // Arrange
            string username = "admin";
            string password = "wrongpassword";

            // Act
            bool result = _authenticationService.Login(username, password);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
