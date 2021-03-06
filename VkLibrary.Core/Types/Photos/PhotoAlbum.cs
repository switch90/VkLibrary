using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Photos
{
    /// <summary>
    /// API PhotoAlbum object.
    /// </summary>
    public class PhotoAlbum
    {
        /// <summary>
        /// Photos number
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Photo album ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Album owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Photo album description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        [JsonProperty("updated")]
        public int? Updated { get; set; }

        /// <summary>
        /// Date when the album has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Photo album title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("thumb")]
        public Photo Thumb { get; set; }
    }
}