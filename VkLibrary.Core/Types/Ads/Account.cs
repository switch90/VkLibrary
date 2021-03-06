using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Account object.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("access_role")]
        public string AccessRole { get; set; }

        /// <summary>
        /// Account type
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// Information whether account is active
        /// </summary>
        [JsonProperty("account_status")]
        public int? AccountStatus { get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        [JsonProperty("account_id")]
        public int? AccountId { get; set; }
    }
}