/// <summary>
/// Represents the constants required for API configuration.
/// </summary>
namespace Gymany.Core.Constant
{
    /// <summary>
    /// Provides API endpoint constants for various resources.
    /// </summary>
    public static class ApiEndpoints
    {
        /// <summary>
        /// Endpoint for product-related operations.
        /// </summary>
        public const string PRODUCT = "Product";

        /// <summary>
        /// Endpoint for category-related operations.
        /// </summary>
        public const string CATEGORY = "Category";

        /// <summary>
        /// Endpoint for retrieving a product by its ID.
        /// /// </summary>
        public const string PRODUCT_BY_ID = "Product/id?id=";

        public const string NOTIFICATION = "Notification";
        public const string NOTIFICATION_BY_ID = "Notification/id?id=";
    }
}