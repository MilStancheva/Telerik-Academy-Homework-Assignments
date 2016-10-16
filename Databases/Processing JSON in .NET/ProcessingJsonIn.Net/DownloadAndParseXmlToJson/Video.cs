using System;
using System.Linq;
using Newtonsoft.Json;

namespace DownloadAndParseXmlToJson
{
    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }
    }
}
