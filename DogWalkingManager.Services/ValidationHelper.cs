namespace DogWalkingManager.Services
{
    /// <summary>
    /// Provides validation utilities for input data.
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Validates if a phone number is considered valid.
        /// </summary>
        /// <param name="phone">Phone number string.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        public static bool IsValidPhone(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) && phone.Length >= 8 && phone.All(char.IsDigit);
        }

        /// <summary>
        /// Validates if an age value is within a reasonable range for a dog.
        /// </summary>
        /// <param name="age">Dog's age.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        public static bool IsValidAge(int age)
        {
            return age > 0 && age <= 30;
        }
    }
}
