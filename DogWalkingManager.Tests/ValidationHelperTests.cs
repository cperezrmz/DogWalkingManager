using DogWalkingManager.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DogWalkingManager.Tests
{
    /// <summary>
    /// Contains unit tests for ValidationHelper methods.
    /// </summary>
    [TestClass]
    public class ValidationHelperTests
    {
        [TestMethod]
        public void IsValidPhone_ShouldReturnTrue_ForValidPhoneNumber()
        {
            // Arrange
            string validPhone = "12345678";

            // Act
            bool result = ValidationHelper.IsValidPhone(validPhone);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidPhone_ShouldReturnFalse_ForInvalidPhoneNumber()
        {
            // Arrange
            string invalidPhone = "abc123";

            // Act
            bool result = ValidationHelper.IsValidPhone(invalidPhone);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidAge_ShouldReturnTrue_ForValidAge()
        {
            // Arrange
            int validAge = 5;

            // Act
            bool result = ValidationHelper.IsValidAge(validAge);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidAge_ShouldReturnFalse_ForInvalidAge()
        {
            // Arrange
            int invalidAge = 50;

            // Act
            bool result = ValidationHelper.IsValidAge(invalidAge);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
