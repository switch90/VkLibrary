using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;
using VkLibrary.Core.Types.Photos;

namespace VkLibrary.Core.Types.Market
{
    /// <summary>
    /// API MarketItemFull object.
    /// </summary>
    public class MarketItemFull : MarketItem
    {
        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views_count")]
        public int? ViewsCount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        /// <summary>
        /// Information whether current use can comment the item
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Information whether current use can repost the item
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos")]
        public IEnumerable<Photo> Photos { get; set; }
    }
}