using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class UploadResponse
    {
        /// <summary>
        /// Video ID
        /// </summary>
        [JsonProperty("video_id")]
        public int? VideoId { get; set; }

        /// <summary>
        /// Video size
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

    }
}